Public Class Activation

    Public Enum ActivationFunction
        Sigmoid
        SigmoidShouldered
        Tanh
        Linear
    End Enum

    NotInheritable Class ActivationFunctions
        Public Shared Function Evaluate(type As ActivationFunction, x As Double) As Double
            type = Strings.LCase(type)

            Select Case type
                Case ActivationFunction.Linear
                    Return Linear(x)
                Case ActivationFunction.Sigmoid
                    Return Sigmoid(x)
                Case ActivationFunction.SigmoidShouldered
                    Return SigmoidShouldered(x)
                Case ActivationFunction.Tanh
                    Return Tanh(x)
                Case Else
                    Return 0
            End Select
        End Function

        Public Shared Function EvaluateDerivative(type As ActivationFunction, x As Double) As Double
            type = Strings.LCase(type)

            Select Case type
                Case ActivationFunction.Sigmoid
                    Return Sigmoid_derivative(x)
                Case ActivationFunction.SigmoidShouldered
                    Return SigmoidShouldered_derivative(x)
                Case ActivationFunction.Tanh
                    Return Tanh_derivative(x)
                Case ActivationFunction.Linear
                    Return Linear_derivative(x)
                Case Else
                    Return 0.0
            End Select
        End Function

#Region "Activation Function and derivative definitions"
        Private Shared Function Sigmoid(x As Double) As Double
            Return (1 / (1 + Math.Exp(-x)))
        End Function

        Private Shared Function Sigmoid_derivative(x As Double) As Double
            Return Sigmoid(x) - Sigmoid(x) ^ 2
        End Function

        Private Shared Function SigmoidShouldered(x As Double) As Double
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

        Private Shared Function SigmoidShouldered_derivative(x As Double) As Double
            Dim f As Double = 0

            If x <= -Math.Log(9) Then
                f = 0
            ElseIf x >= Math.Log(9) Then
                f = 0
            Else
                f = Sigmoid_derivative(x)
            End If

            Return f
        End Function

        Private Shared Function Linear(x As Double) As Double
            Return x
        End Function

        Private Shared Function Linear_derivative(x As Double) As Double
            Return 1
        End Function

        Private Shared Function Tanh(x As Double) As Double
            Return Math.Tanh(x)
        End Function

        Private Shared Function Tanh_derivative(x As Double)
            Return 1 - Math.Tanh(x) ^ 2
        End Function
#End Region

    End Class
End Class
