Public Class Util
    Public NotInheritable Class Array
        Public Shared Function GetRow(rowNumber As Integer, array As Double(,))
            Dim arrayParameterCount As Integer = array.GetLength(1)

            Dim returnArray(arrayParameterCount - 1) As Double

            For i = 0 To arrayParameterCount - 1
                returnArray(i) = array(rowNumber, i)
            Next

            Return returnArray
        End Function
    End Class

    Public NotInheritable Class Random
        Private Sub New()
        End Sub
        Private Shared gen As New System.Random()

        Public Shared Function Gaussian() As Double
            Return Gaussian(0.0, 1.0)
        End Function

        Public Shared Function Gaussian(mean As Double, stddev As Double) As Double
            Dim rVal1 As Double
            Dim rVal2 As Double

            Gaussian(mean, stddev, rVal1, rVal2)

            Return rVal1
        End Function

        Public Shared Sub Gaussian(mean As Double, stddev As Double, ByRef val1 As Double, ByRef val2 As Double)
            Dim u As Double, v As Double, s As Double, t As Double

            Do
                u = 2 * gen.NextDouble() - 1
                v = 2 * gen.NextDouble() - 1
            Loop While u * u + v * v > 1 OrElse (u = 0 AndAlso v = 0)

            s = u * u + v * v
            t = Math.Sqrt((-2.0 * Math.Log(s)) / s)

            val1 = stddev * u * t + mean
            val2 = stddev * v * t + mean
        End Sub
    End Class
End Class
