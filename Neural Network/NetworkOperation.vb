Imports NeuralNetwork.Activation

Module NetworkOperation
    Public Sub loadTrainingData()
        'load testing inputs
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Form1.tb_input.Text) 'todo: have separate input for training set and "real" data set
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            ReDim ANN.inputData(ANN.numInputLines - 1, ANN.numInputs - 1)
            Dim i As Integer = 0
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim currentField As String
                    Dim tempRow(3) As Double
                    Dim j As Integer = 0
                    For Each currentField In currentRow
                        ANN.inputData(i, j) = currentField
                        j += 1
                    Next

                    i += 1
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

        'load expected outputs
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Form1.tb_output.Text)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            ReDim ANN.expectedOutputs(ANN.numOutputLines - 1, ANN.expectedOutputsPerLine - 1)
            Dim i As Integer = 0
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim currentField As String
                    Dim j As Integer = 0
                    For Each currentField In currentRow
                        ANN.expectedOutputs(i, j) = currentField
                        j += 1
                    Next

                    i += 1
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

    Private Sub layerCalculate(network As BackpropagationNetwork, layerIndex As Integer)
        Dim currentLayer As Layer = network.Layer(layerIndex)
        Dim prevLayer As Layer = network.Layer(layerIndex - 1)

        Dim sum(currentLayer.NeuronCount - 1) As Double
        Const bias = 1

        'Pre-populate sums with bias values
        For i = 0 To sum.Length - 1
            sum(i) = bias
        Next

        'calculate each node's sum
        For currentNeuronInCurrentLayer = 0 To currentLayer.NeuronCount - 1
            For currentNeuronInPrevLayer = 0 To prevLayer.NeuronCount - 1
                sum(currentNeuronInCurrentLayer) += prevLayer.Outputs(currentNeuronInPrevLayer) * prevLayer.Weights(currentNeuronInPrevLayer, currentNeuronInCurrentLayer)
            Next
        Next

        currentLayer.Inputs = sum

        'calcute the function value (output) using an activation function
        Dim functionValue(currentLayer.NeuronCount - 1) As Double
        For i = 0 To currentLayer.NeuronCount - 1
            functionValue(i) = ActivationFunctions.Evaluate(currentLayer.ActivationFunction, sum(i))
        Next

        currentLayer.Outputs = functionValue
    End Sub

    Public Sub networkCalculate(networkToCalculate As BackpropagationNetwork)
        Dim i As Integer = 0
        For Each layer In networkToCalculate.Layers
            If layer.LayerType = ILayer.LayerType_.Input Then
                'do nothing
            Else
                layerCalculate(networkToCalculate, i)
            End If

            i += 1
        Next
    End Sub

    Public Sub trainNetwork(ByRef network As BackpropagationNetwork)
        'TODO: add epoch looping
        For i = 0 To numInputLines - 1 'for each example
            Dim totalError As Double = 0

            network.Layer(0).Outputs = Util.GetRow(i, inputData)

            networkCalculate(network)

            For j = 0 To network.LastLayer.NeuronCount - 1 'for each output neuron
                Dim diff As Double
                diff = expectedOutputs(i, j) - network.LastLayer.Outputs(j)

                totalError += diff ^ 2
            Next

            totalError *= 0.5

            Form1.chart_error.Series("Series1").Points.Add(totalError)
            Form1.Update()

            calcDeltas()

        Next
    End Sub

    Private Sub calcDeltas()

    End Sub
End Module
