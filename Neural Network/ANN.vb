Imports System
Imports System.IO
Imports System.Text
Imports NeuralNetwork.Activation
Imports NeuralNetwork.BackpropagationNetwork

Module ANN
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

    Public Sub ANN_Start()
        numHiddenLayers = Form1.DataGridView1.RowCount
        ReDim numNodesInLayer(0 To numHiddenLayers + 1)
        numOutputs = Form1.tb_numOutputs.Text
        ReDim layerSums(0 To numHiddenLayers + 1)
        ReDim deltak(0 To numOutputs - 1)

        ReDim actualOutputs(numOutputs - 1)

        validateCSV("input") 'TODO: just check this again after everything is done
        If Form1.chk_learningMode.Checked Then
            validateCSV("output")
        End If

        If expectedOutputsPerLine <> numOutputs Then
            MsgBox("The number of outputs as set up in the network do not agree with the number of outputs in the training data.")
            Exit Sub
        End If

        Dim network As New BackpropagationNetwork
        network.AddLayer(New Layer(numInputs, ActivationFunction.Linear, ILayer.LayerType_.Input))
        For Each row As DataGridViewRow In Form1.DataGridView1.Rows
            If Not row.IsNewRow Then
                network.AddLayer(New Layer(CInt(row.Cells("HiddenLayerNeuronCount").Value), _
                                           [Enum].Parse(GetType(ActivationFunction), row.Cells("HiddenLayerActivationFunction").Value), ILayer.LayerType_.Hidden))
            End If
        Next
        network.AddLayer(New Layer(numOutputs, [Enum].Parse(GetType(ActivationFunction), Form1.combo_outputLayerAF.SelectedItem), ILayer.LayerType_.Output))
        'TODO: check if this^ is right

        Dim i As Integer = 0
        For Each layer As Layer In network.Layers
            If layer.LayerType = ILayer.LayerType_.Output Then
                Exit For
            End If
            layer.GenerateWeights(network, i)
            i += 1
        Next

        i = 0
        For Each layer As Layer In network.Layers
            layer.InitialiseDeltas(network, i)
            i += 1
        Next


        'TODO: add training mode and calculation mode ↴
        'load training data into memory
        NetworkOperation.loadTrainingData() 'TODO: Split data into training, validation and testing sets
        For i = 0 To 1000
            Form1.lb_iterationNum.Text = i
            NetworkOperation.trainNetwork(network, 0.1, 0.15)
        Next
        'NetworkOperation.networkCalculate(network)
        'TODO: normaliseData()

    End Sub

    Private Sub validateCSV(csvType As String)
        csvType = Strings.LCase(csvType)

        If csvType <> "input" Then
            If csvType <> "output" Then
                Throw New ArgumentException("Please specify ONLY ""input"" or ""output"".", csvType)
            End If
        End If

        Dim csvPath As String
        If csvType = "input" Then
            csvPath = Form1.tb_input.Text
        Else 'output
            csvPath = Form1.tb_output.Text
        End If

        Dim numParameters As Integer
        Dim numLines As Integer

        'check if each line of the csv is the same lenght (same number of parameters)
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(csvPath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            numParameters = MyReader.ReadFields().Length
            numLines = 1

            While Not MyReader.EndOfData
                Try
                    If numParameters <> MyReader.ReadFields().Length Then
                        MsgBox("All lines in the csv file are not the same lenght." & vbNewLine & "Please fix the line(s).")
                        Exit Sub
                    Else
                        numLines += 1
                    End If
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

        'save the number of inputs per line and number of lines (NUMBER OF INPUTS)
        If csvType = "input" Then
            numInputs = numParameters
            numInputLines = numLines
        Else
            numOutputLines = numLines
            expectedOutputsPerLine = numParameters
        End If
    End Sub

    Sub csvCreate(filePath As String, contents As String)
        Dim fs As FileStream = File.Create(filePath)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(contents)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
End Module
