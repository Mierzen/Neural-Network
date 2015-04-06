Imports System
Imports System.IO
Imports System.Text
Imports ANNForBeginners.Activation
Imports ANNForBeginners.BackpropagationNetwork

Module ANN
    Public inputData(,) As Double
    Public numInputs As Integer
    Public numInputLines As Integer
    Public numHiddenLayers As Integer
    Public numNodesInLayer() As Integer 'index = layer number: 0 = input layer, last = last hidden layer.  value = number of neurons in layer
    Public numOutputs As Integer
    Public layerSums() As Double
    Public expectedOutputsPerLine As Integer
    Public expectedOutputs() As Double
    Public actualOutputs() As Double
    Public E As Double 'error (e.g. MSE, RMSE)
    Public deltak() As Double

    Public Sub ANN_Start()
        numHiddenLayers = Form1.DataGridView1.RowCount
        ReDim numNodesInLayer(0 To numHiddenLayers + 1)
        numOutputs = Form1.tb_numOutputs.Text
        ReDim layerSums(0 To numHiddenLayers + 1)
        ReDim deltak(0 To numOutputs - 1)

        ReDim expectedOutputs(numOutputs - 1)
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
        network.AddLayer(New Layer(numOutputs, ActivationFunction.Linear, ILayer.LayerType_.Output))
        'TODO: check if this^ is right

        Dim i As Integer = 0
        For Each layer As Layer In network.Layers
            If layer.LayerType = ILayer.LayerType_.Output Then
                Exit For
            End If
            layer.GenerateWeights(network, i)
            i += 1
        Next

        'TODO: add training mode and calculation mode ↴
        'load training data into memory
        NetworkOperation.loadTrainingData() 'TODO: Split data into training, validation and testing sets

        NetworkOperation.trainNetwork(network)

        'hack neuronCalcAll()
        NetworkOperation.networkCalculate(network)
        'TODO: normaliseData()

        calcE("MSE")
        calcDeltas()
    End Sub

    Sub calcE(Optional type As String = "mse")
        type = Strings.LCase(type)

        Select Case type
            Case "mse", "rmse"
                Dim sumSquared As Double = 0
                Dim tempE As Double = 0

                For i = 0 To numOutputs - 1
                    sumSquared += (expectedOutputs(i) - actualOutputs(i)) ^ 2
                Next
                tempE = sumSquared / numOutputs

                If type = "mse" Then
                    E = tempE
                ElseIf type = "rmse" Then
                    E = Math.Sqrt(tempE)
                End If
            Case "arctan", "atan"
                Dim sumSquaredAtan As Double = 0

                For i = 0 To numOutputs - 1
                    sumSquaredAtan += Math.Atan(expectedOutputs(i) - actualOutputs(i)) ^ 2
                Next
                E = sumSquaredAtan / numOutputs
        End Select
    End Sub

    Sub calcDeltas()
        For i = 0 To numOutputs - 1 'for each output neuron
            deltak(i) = (actualOutputs(i) - expectedOutputs(i)) * ActivationFunctions.EvaluateDerivative(ActivationFunction.Sigmoid, 0.5)
        Next
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
            expectedOutputsPerLine = numParameters
        End If
    End Sub

    Sub csvCreate(filePath As String, contents As String)
        Dim fs As FileStream = File.Create(filePath)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(contents)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Function random() As Double 'TODO: move to util class if needed
        Dim upperbound1 As Integer = -1
        Dim lowerbound1 As Integer = 4
        Dim upperbound2 As Integer = -2
        Dim lowerbound2 As Integer = 3

        Dim randomVal1 As Integer = 0
        Dim randomVal2 As Integer = 0

        Do Until randomVal1 <> 0
            randomVal1 = CInt(Math.Floor((upperbound1 - lowerbound1 + 1) * Rnd())) + lowerbound1
        Loop
        Do Until randomVal2 <> 0
            randomVal2 = CInt(Math.Floor((upperbound2 - lowerbound2 + 1) * Rnd())) + lowerbound2
        Loop

        Return randomVal1 / randomVal2
    End Function
End Module
