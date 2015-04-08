Public Class Form1

    Private Sub DataGridView1_RowsAdded(ByVal sender As System.Object, _
                  ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) _
                   Handles DataGridView1.RowsAdded

        If e.RowCount <= 1 Then
            Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1

        Else

            For i As Integer = e.RowIndex To (e.RowIndex + e.RowCount)
                Me.DataGridView1.Rows(i).Cells(0).Value = i + 1

            Next

        End If

    End Sub

    Private Sub dataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        If e.ColumnIndex = 1 Then
            ' 1 should be your column index
            Dim i As Integer
            
            If Not (Integer.TryParse(Convert.ToString(e.FormattedValue), i)) OrElse (Math.Sign(CInt(e.FormattedValue)) = -1) OrElse e.FormattedValue = "" Then
                e.Cancel = True
                MsgBox("Please enter a positive integer for the number of neurons")
                ' the input is numeric 
            Else
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.UseWaitCursor() = True

        'TODO: remove this->
        Dim inputs() As Double = {1, 0.25, -0.5}
        Dim weights() As Double = {0.5, 0.5, 0.5}

        Me.Select()

        Dim dataIsValid As Boolean = True
        'TODO: check if each rows' AF has been selected chosen
        If DataGridView1.Rows.Count() = 0 Then
            dataIsValid = False
        Else
            For i = 1 To DataGridView1.Rows.Count()
                Dim n As Object = DataGridView1.Rows(i - 1).Cells(1).FormattedValue

                If n = "" Then
                    dataIsValid = False
                    Exit For
                End If

                If Math.Sign(CInt(n)) <> 1 Then
                    dataIsValid = False
                End If

                If dataIsValid = False Then
                    Exit For
                End If
            Next
        End If

        If dataIsValid = False Then
            MsgBox("Please check the table values")
        Else
            ANN.ANN_Start()
        End If

        Application.UseWaitCursor = False
    End Sub

    Private Sub btn_selectInput2_Click(sender As Object, e As EventArgs) Handles btn_selectInput.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            tb_input.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns(0).ReadOnly = True

        Dim activationFunctionColumn As DataGridViewComboBoxColumn = DataGridView1.Columns("HiddenLayerActivationFunction")

        Dim items As Array
        items = System.Enum.GetNames(GetType(NeuralNetwork.Activation.ActivationFunction))
        Dim item As String
        For Each item In items
            activationFunctionColumn.Items.Add(item)
            combo_outputLayerAF.Items.Add(item)
        Next

        chart_error200.Titles(0).Text = "Network error (RMSE)" & vbNewLine & "Last 200 iterations"
    End Sub

    Private Sub btn_addRow_Click(sender As Object, e As EventArgs) Handles btn_addRow.Click
        DataGridView1.Rows.Add()
    End Sub

    Private Sub btn_selectOutput_Click(sender As Object, e As EventArgs) Handles btn_selectOutput.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            tb_output.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class
