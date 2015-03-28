Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inputs() As Double = {1, 0.25, -0.5}
        Dim weights() As Double = {0.5, 0.5, 0.5}

        MsgBox(ANN.neuronSum(inputs, weights))

    End Sub
End Class
