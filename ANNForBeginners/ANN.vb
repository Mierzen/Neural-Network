Imports System
Imports System.IO
Imports System.Text

Module ANN
    Public inputData(,) As Double
    Public numHiddenLayers As Integer
    Public numNodesInLayer() As Integer 'index = layer number: 0 = input layer, last = last hidden layer.  value = number of neurons in layer
    Public numOutputs As Integer
    Public layerSums() As Double

    Public Sub loadData()
        Dim lineLength As Integer
        Dim lineCount As Integer

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Form1.tb_input.Text)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            'first check if each line of the csv is the same lenght
            lineLength = MyReader.ReadFields().Length
            lineCount = 1

            While Not MyReader.EndOfData
                Try
                    If lineLength <> MyReader.ReadFields().Length Then
                        MsgBox("All lines in the csv file are not the same lenght." & vbNewLine & "Please fix the line(s).")
                        Exit Sub
                    Else
                        lineCount += 1
                    End If
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

        'Read the data into memory
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
    End Sub

    Public Sub ANN_Start()
        numHiddenLayers = Form1.DataGridView1.RowCount
        ReDim numNodesInLayer(0 To numHiddenLayers + 1)
        numOutputs = Form1.tb_numOutputs.Text
        ReDim layerSums(0 To numHiddenLayers + 1)

        loadData()
        initialiseWeightsAllRandom()

        neuronCalcAll()
        'normaliseData()
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
        Dim fs As FileStream = File.Create(filepath)

        Dim str As String = Nothing

        For i = 1 To numWeights
            str &= "0.5,"
        Next
        str = Strings.Left(str, Strings.Len(str) - 1)

        Dim info As Byte() = New UTF8Encoding(True).GetBytes(str)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Sub neuronCalcAll()
        For currentLayer = 0 To numHiddenLayers '0 to num HL = HL + output layer = HL + 1
            neuronCalc(currentLayer + 1)
        Next
    End Sub

    Sub neuronCalc(layerToSum As Integer)
        Dim numNeuronsInLayer As Integer = numNodesInLayer(layerToSum)
        Dim numNeuronsInPrevLayer As Integer = numNodesInLayer(layerToSum - 1)
        Dim sum() As Double

        'read the inputs into memory
        Dim inputs(numNeuronsInPrevLayer - 1) As Double
        If layerToSum = 1 Then 'the original input data should be used
            For i = 0 To inputs.Length - 1
                inputs(i) = inputData(0, i)
            Next
        Else 'read from file (it will be the previous HL's activation function values)

        End If

        ReDim sum(numNeuronsInLayer - 1)

        're-read weights from file
        For currentNeuron = 0 To numNeuronsInLayer - 1
            Dim weights(numNeuronsInPrevLayer - 1) As Double

            Dim filepath As String = "C:\data\weights_L" & layerToSum & "N" & currentNeuron & ".csv"
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filepath)
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

            For i = 0 To numNeuronsInPrevLayer - 1
                sum(currentNeuron) += inputs(i) * weights(i)
            Next
        Next
    End Sub

    Function neuronActivationFunction(functionType As String, x As Double) As Double
        functionType = Strings.LCase(functionType)

        Select Case functionType
            Case "sigmoid"
                activationFunction_Sigmoid(x)
            Case Else
                MsgBox("Select a valid activation function type")
                Return 0
        End Select

        Return 0
    End Function

    Function activationFunction_Sigmoid(x As Double) As Double
        Dim F As Double
        F = (1 / (1 + Math.Exp(-x)))

        'https://takinginitiative.wordpress.com/2008/04/03/basic-neural-network-tutorial-theory/
        If F < 0.1 Then
            F = 0
        ElseIf F > 0.9 Then
            F = 0.9
        End If

        Return F
    End Function
End Module
