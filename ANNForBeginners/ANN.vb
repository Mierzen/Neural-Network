Imports System
Imports System.IO
Imports System.Text

Module ANN
    Public inputs As DataTable
    Public numInputNodes As Integer

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

        numInputNodes = lineLength

        'Read the data into memory
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Form1.tb_input.Text)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            'Dim inputData(lineLength, lineCount) As Double
            Dim inputData(lineCount - 1, lineLength - 1) As Double
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


    End Sub

    Public Sub ANN_Start()
        'Const numInputs As Integer = 6
        'Const numOutputs As Integer = 2
        Dim numHiddenLayers As Integer = Form1.DataGridView1.RowCount

        loadData()
        initialiseWeightsAllRandom()

        neuronSumAll()
        'normaliseData()
    End Sub

    Sub initialiseWeightsAllRandom()
        'input layer weights
        initialiseRandomWeights(0, numInputNodes)

        'hidden layer weights
        Dim i As Integer = 1
        For j = 1 To Form1.DataGridView1.Rows.Count()
            Dim n As Object = Form1.DataGridView1.Rows(j - 1).Cells(1).FormattedValue
            initialiseRandomWeights(i, j)
            i += 1
        Next
    End Sub

    Sub initialiseRandomWeights(layerNumber As Integer, numWeights As Integer)
        Dim fs As FileStream = File.Create("C:\data\weights" & layerNumber & ".csv")

        Dim str As String = Nothing

        For i = 1 To numWeights
            str &= "0.5,"
        Next
        str = Strings.Left(str, Strings.Len(str) - 1)

        Dim info As Byte() = New UTF8Encoding(True).GetBytes(str)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Sub neuronSumAll()
        For i = 1 To Form1.DataGridView1.Rows.Count()

        Next
    End Sub

    Function neuronSum(ByVal inputs() As Double, ByVal weights As Double()) As Double
        If inputs.Length <> weights.Length Then
            MsgBox("Input array and weight array not equal lenght")
            Return 0
        End If

        Dim sum As Double = 0

        For i = 0 To inputs.Length - 1
            sum += inputs(i) * weights(i)
        Next

        Return sum
    End Function

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
