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
    Public expectedOutputs() As Double
    Public actualOutputs() As Double
    Public E As Double 'error (e.g. MSE, RMSE)
    Public deltak() As Double

    Public Sub loadTrainingData()
        Dim lineLength As Integer
        Dim lineCount As Integer

        'Read the input data into memory
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Form1.tb_input.Text)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            'Dim inputData(lineLength, lineCount) As Double
            ReDim inputData(lineCount - 1, lineLength - 1)
            Dim i As Integer = 0
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim currentField As String
                    Dim tempRow(3) As Double
                    Dim j As Integer = 0
                    For Each currentField In currentRow
                        inputData(i, j) = currentField
                        j += 1
                    Next

                    i += 1
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

        numNodesInLayer(0) = lineLength
        For i = 1 To Form1.DataGridView1.Rows.Count
            numNodesInLayer(i) = Form1.DataGridView1.Rows(i - 1).Cells(1).FormattedValue
        Next
        numNodesInLayer(numHiddenLayers + 1) = numOutputs

        If Form1.chk_learningMode.Checked Then
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Form1.tb_output.Text)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")

                Dim i As Integer = 0
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()

                        Dim currentField As String
                        Dim j As Integer = 0
                        For Each currentField In currentRow
                            expectedOutputs(j) = currentField
                            j += 1
                        Next

                        i += 1
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try
                End While
            End Using
        End If
    End Sub

    Public Sub ANN_Start()
        numHiddenLayers = Form1.DataGridView1.RowCount
        ReDim numNodesInLayer(0 To numHiddenLayers + 1)
        numOutputs = Form1.tb_numOutputs.Text
        ReDim layerSums(0 To numHiddenLayers + 1)
        ReDim deltak(0 To numOutputs - 1)

        ReDim expectedOutputs(numOutputs - 1)
        ReDim actualOutputs(numOutputs - 1)

        'TODO: validate input and output csv's
        'TODO: after that, create the network

        loadTrainingData()
        initialiseWeightsAllRandom()

        Dim network As New BackpropagationNetwork
        network.AddLayer(New Layer(inputData.GetLength(1), ActivationFunction.Linear, ILayer.LayerType_.Input))

        neuronCalcAll()
        'normaliseData()

        calcE("MSE")
        calcDeltas()
    End Sub

    Sub initialiseWeightsAllRandom()
        'hidden layer weights
        For currentLayer = 1 To numHiddenLayers
            For currentNeuron = 0 To numNodesInLayer(currentLayer) - 1
                initialiseRandomWeights(currentLayer, currentNeuron, numNodesInLayer(currentLayer - 1))
            Next
        Next

        'output layer weights
        For currentNeuron = 0 To numNodesInLayer(numHiddenLayers + 1) - 1
            initialiseRandomWeights(numHiddenLayers + 1, currentNeuron, numNodesInLayer(numHiddenLayers))
        Next
    End Sub

    Sub initialiseRandomWeights(currentLayer As Integer, currentNeuron As Integer, numWeights As Integer)
        Dim filepath As String = "C:\data\weights_L" & currentLayer & "N" & currentNeuron & ".csv"

        Dim str As String = Nothing
        For i = 1 To numWeights
            str &= random() & ","
        Next
        str = Strings.Left(str, Strings.Len(str) - 1)

        csvCreate(filepath, str)
    End Sub

    Sub neuronCalcAll()
        For currentLayer = 0 To numHiddenLayers '0 to num HL = HL + output layer = HL + 1
            neuronCalc(currentLayer + 1)
        Next
    End Sub

    Sub neuronCalc(layerToSum As Integer)
        Dim numNeuronsInLayer As Integer = numNodesInLayer(layerToSum)
        Dim numNeuronsInPrevLayer As Integer = numNodesInLayer(layerToSum - 1)
        Dim sum(numNeuronsInLayer - 1) As Double
        Const bias = 1

        'Pre-populate sum with bias values
        For i = 0 To sum.Length - 1
            sum(i) = bias
        Next

        'read the inputs into memory
        Dim inputs(numNeuronsInPrevLayer - 1) As Double
        If layerToSum = 1 Then 'the original input data should be used
            For i = 0 To inputs.Length - 1
                inputs(i) = inputData(0, i)
            Next
        Else 'read from file (it will be the previous HL's activation function values)

        End If

        're-read weights from file
        For currentNeuron = 0 To numNeuronsInLayer - 1
            Dim weights(numNeuronsInPrevLayer - 1) As Double

            Dim filePathWeights As String = "C:\data\weights_L" & layerToSum & "N" & currentNeuron & ".csv"
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePathWeights)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")

                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()

                        Dim currentField As String
                        Dim j As Integer = 0
                        For Each currentField In currentRow
                            weights(j) = currentField
                            j += 1
                        Next
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try
                End While
            End Using

            'calculate each node's sum
            For i = 0 To numNeuronsInPrevLayer - 1
                sum(currentNeuron) += inputs(i) * weights(i)
            Next
        Next

        'calcute the function value using an activation function
        Dim str As String = Nothing
        For i = 0 To numNeuronsInLayer - 1
            Dim functionValue As Double = ActivationFunctions.Evaluate(ActivationFunction.Sigmoid, sum(i))

            str &= functionValue & ","

            If layerToSum = numHiddenLayers + 1 Then
                actualOutputs(i) = functionValue
            End If
        Next
        str = Strings.Left(str, Strings.Len(str) - 1)

        Dim filePath As String
        filePath = "C:\data\functionValues_L" & layerToSum & ".csv"
        csvCreate(filePath, str)
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

        If Not (csvType = "input") OrElse Not (csvType = "output") Then
            Throw New ArgumentException("Please specify ONLY ""input"" or ""output"".", csvType)
        End If

        Dim numParameters As Integer
        Dim numLines As integer

        'check if each line of the INPUT.csv is the same lenght (same number of inputs)
        'also gets the number of inputs per line and number of lines
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Form1.tb_input.Text)
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

        If csvType = "input" Then
            numInputs = numParameters
            numInputLines = numLines
        End If
    End Sub

    Sub csvCreate(filePath As String, contents As String)
        Dim fs As FileStream = File.Create(filePath)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(contents)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Function random() As Double
        Dim upperbound1 As Integer = -1
        Dim lowerbound1 As Integer = 4
        Dim upperbound2 As Integer = -7
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
