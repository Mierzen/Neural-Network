Imports System
Imports System.IO
Imports System.Text
Imports NeuralNetwork.Activation
Imports NeuralNetwork.BackpropagationNetwork

Module TrainingMode
    Public inputData(,) As Double
    Public numInputs As Integer
    Public numInputLines As Integer
    Public numHiddenLayers As Integer
    Public numNodesInLayer() As Integer 'index = layer number: 0 = input layer, last = last hidden layer.  value = number of neurons in layer
    Public numOutputs As Integer
    Public numOutputLines As Integer
    Public layerSums() As Double
    Public expectedOutputsPerLine As Integer
    Public expectedOutputs(,) As Double
    Public actualOutputs() As Double
    Public E As Double 'error (e.g. MSE, RMSE)
    Public deltak() As Double

    Public Sub Training_Start()
        numHiddenLayers = form_main.DataGridView1.RowCount
        ReDim numNodesInLayer(0 To numHiddenLayers + 1)
        ReDim layerSums(0 To numHiddenLayers + 1)
        ReDim deltak(0 To numOutputs - 1)
        ReDim actualOutputs(numOutputs - 1)

        Application.UseWaitCursor = True

        If expectedOutputsPerLine <> numOutputs Then
            MsgBox("The number of outputs as set up in the network do not agree with the number of outputs in the training data.", vbOKOnly Or MsgBoxStyle.Critical, "Incorrect output size")
            Exit Sub
        End If

        Dim network As New BackpropagationNetwork
        network.AddLayer(New Layer(numInputs, ActivationFunction.Linear, ILayer.LayerType_.Input))
        For Each row As DataGridViewRow In form_main.DataGridView1.Rows
            If Not row.IsNewRow Then
                network.AddLayer(New Layer(CInt(row.Cells("HiddenLayerNeuronCount").Value), _
                                           [Enum].Parse(GetType(ActivationFunction), row.Cells("HiddenLayerActivationFunction").Value), ILayer.LayerType_.Hidden))
            End If
        Next
        network.AddLayer(New Layer(numOutputs, [Enum].Parse(GetType(ActivationFunction), form_main.combo_outputLayerAF.SelectedItem), ILayer.LayerType_.Output))
        'TODO: check if this^ is right

        Dim i As Integer = 0
        For Each layer As Layer In network.Layers
            If layer.LayerType = ILayer.LayerType_.Output Then
                Exit For
            End If
            layer.GenerateWeights(network, i)
            i += 1
        Next

        For Each layer As Layer In network.Layers
            layer.GenerateBias(network)
        Next

        i = 0
        For Each layer As Layer In network.Layers
            layer.InitialiseDeltas(network, i)
            i += 1
        Next

        'load training data into memory
        NetworkOperation.loadTrainingData() 'TODO: Split data into training, validation and testing sets

        form_main.panel_stats.Visible = True
        form_main.panel_stats.Update()
        If form_main.chk_showGraph.Checked Then
            form_main.chart_errorSecondary.Titles(0).Text = "Network error (RMSE)" & vbNewLine & "Last " & form_main.tb_graphSecondaryPoints.Text & " iterations"

            form_main.panel_charts.Visible = True

            form_main.panel_charts.Update()
        End If

        'center form on screen
        form_main.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (form_main.Height \ 2)
        form_main.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (form_main.Width \ 2)

        Dim err As Double = 0
        i = 1
        Do
            form_main.lb_iterationNum.Text = i
            err = NetworkOperation.trainNetwork(network, CDbl(form_main.tb_learningRate.Text), CDbl(form_main.tb_momentum.Text))
            i += 1
            form_main.lb_currentError.Text = err
            form_main.lb_currentError.Update()

            'update charts
            form_main.chart_error.Series(0).Points.Add(err)
            form_main.chart_error.Update()
            form_main.lb_iterationNum.Update()

            Dim chart200_pointCount As Integer = form_main.chart_errorSecondary.Series(0).Points.Count
            If chart200_pointCount <= form_main.tb_graphSecondaryPoints.Text Then
                form_main.chart_errorSecondary.Series(0).Points.Add(err)
            Else
                form_main.chart_errorSecondary.Series(0).Points.RemoveAt(0)
                form_main.chart_errorSecondary.Series(0).Points.Add(err)
            End If
            form_main.chart_errorSecondary.Update()
        Loop While (err > CDbl(form_main.tb_maxError.Text)) AndAlso (i <= CInt(form_main.tb_maxEpochs.Text))
        'TODO: normaliseData()

        Beep()

        If MsgBox("Save the neural network?", vbYesNo Or MsgBoxStyle.Question, "Save?") = MsgBoxResult.Yes Then
            Dim path As String

            If form_main.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                path = form_main.SaveFileDialog1.FileName.ToString

                If (path IsNot Nothing) Then
                    NetworkOperation.Save(network, path)

                    Dim openTargetDir As MsgBoxResult
                    openTargetDir = MsgBox("Done!" & vbNewLine & vbNewLine & "Open Windows Explorer to view the neural network file?", _
                                           MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.MsgBoxSetForeground)
                    If openTargetDir = MsgBoxResult.Yes Then
                        Diagnostics.Process.Start("Explorer.exe", System.IO.Path.GetDirectoryName(path))
                    End If
                End If
            End If
        End If
    End Sub

    Public Function validateCSV(filePath As String, ByRef numLines As Integer, ByRef numFields As Integer) As String

        If filePath = "" OrElse filePath = Nothing OrElse Strings.LCase(Strings.Right(filePath, 4)) <> ".csv" OrElse System.IO.File.Exists(filePath) = False Then
            Return "FileNotExist"
        End If

        If Util.File.CSV.HasConsistentFields(filePath) = False Then
            Return "NotConsistentFields"
        End If

        Dim tempLineCount As Integer = Util.File.GetLineCount(filePath)
        If tempLineCount <= 0 Then
            Return "FileEmpty"
        Else
            numLines = tempLineCount
        End If

        numFields = Util.File.CSV.GetFieldCount(filePath)

        Return "Success"
    End Function
End Module
