Module ANN

    Public Sub ANN_Start()
        'Const numInputs As Integer = 6
        'Const numOutputs As Integer = 2
        Dim numHiddenLayers As Integer = Form1.DataGridView1.RowCount

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
        functionType = strings.LCase(functionType)

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
