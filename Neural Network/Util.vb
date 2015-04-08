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
End Class
