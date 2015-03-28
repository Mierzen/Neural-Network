Module ANN
    'Const numInputs As Integer = 6
    'Const numOutputs As Integer = 2
    'Const numLayers As Integer 'num hidden layers. Total layers - inputL - outputL



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

End Module
