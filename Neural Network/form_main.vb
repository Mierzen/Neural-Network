Public Class form_main

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
        Me.Select()

        'validate input file
        Select Case TrainingMode.validateCSV(tb_input.Text, numInputs, numInputLines) 'TODO: just check this again after everything is done
            Case "FileNotExist"
                MsgBox("Please make sure the selected input training data file exists and is of the correct format.", vbOKOnly Or vbCritical, "Invalid input training file")
                Exit Sub
            Case "NotConsistentFields"
                MsgBox("All lines in the input training data csv file are not the same lenght (the same number of parameters)." & vbNewLine & "Please fix the line(s).", vbOKOnly Or vbCritical, "Invalid input training file")
                Exit Sub
            Case "FileEmpty"
                MsgBox("Please make sure the selected input training data file is not empty.", vbOKOnly Or vbCritical, "Empty input file training file")
                Exit Sub
        End Select

        Dim dataIsValid As Boolean = True

        If DataGridView1.Rows.Count() = 0 Then
            dataIsValid = False
        Else
            For i = 1 To DataGridView1.Rows.Count()
                'check HiddenLayerNeuronCount column
                Dim n As Object = DataGridView1.Rows(i - 1).Cells("HiddenLayerNeuronCount").FormattedValue

                If n = "" OrElse n = Nothing Then
                    dataIsValid = False
                    Exit For
                End If

                Dim temp As Boolean
                Integer.TryParse(n.ToString, temp)
                If temp = False Then
                    dataIsValid = False
                    Exit For
                End If

                If Math.Sign(CInt(n)) <> 1 Then
                    dataIsValid = False
                    Exit For
                End If

                'check HiddenLayerActivationFunction column
                n = DataGridView1.Rows(i - 1).Cells("HiddenLayerActivationFunction").FormattedValue
                If n = "" OrElse n = Nothing Then
                    dataIsValid = False
                    Exit For
                End If

                If dataIsValid = False Then
                    Exit For
                End If
            Next
        End If

        If dataIsValid = False Then
            MsgBox("Not all rows in the table are correct." & vbNewLine & vbNewLine & "Please enter at least one row and make sure that all values are correct." & vbNewLine & "The hidden layer neuron count should be a positive, non-zero integer and an activation function should be selected per row.", vbOKOnly Or vbCritical, "Incorrect hidden layer input")
        Else
            'validate output layer entry.
            Select Case TrainingMode.validateCSV(tb_output.Text, numOutputLines, expectedOutputsPerLine) 'TODO: just check this again after everything is done
                Case "FileNotExist"
                    MsgBox("Please make sure the selected output training data file exists and is of the correct format.", vbOKOnly Or vbCritical, "Invalid output training file")
                    Exit Sub
                Case "NotConsistentFields"
                    MsgBox("All lines in the output training data csv file are not the same lenght (the same number of parameters)." & vbNewLine & "Please fix the line(s).", vbOKOnly Or vbCritical, "Invalid output training file")
                    Exit Sub
                Case "FileEmpty"
                    MsgBox("Please make sure the selected output training data file is not empty.", vbOKOnly Or vbCritical, "Empty output file training file")
                    Exit Sub
            End Select


            If combo_outputLayerAF.Text = "" OrElse combo_outputLayerAF.Text = Nothing OrElse combo_outputLayerAF.SelectedItem = Nothing Then
                MsgBox("Please select an activation function to use for the output layer.", vbOKOnly Or vbCritical, "Output layer activation function not selected")
                Exit Sub
            End If

            TrainingMode.Training_Start()
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
        Dim textboxes = tlp_advancedSettings.Controls.OfType(Of TextBox)()
        For Each tb In textboxes
            AddHandler tb.TextChanged, AddressOf tbTextChanged
        Next

        AddHandler rd_calcExample.CheckedChanged, AddressOf radio_CheckedChanged
        AddHandler rd_calcDataSet.CheckedChanged, AddressOf radio_CheckedChanged

        lb_biasNotice.Visible = False
        panel_stats.Visible = False
        panel_charts.Visible = False

        DataGridView1.Columns(0).ReadOnly = True

        Dim activationFunctionColumn As DataGridViewComboBoxColumn = DataGridView1.Columns("HiddenLayerActivationFunction")

        Dim items As Array
        items = System.Enum.GetNames(GetType(NeuralNetwork.Activation.ActivationFunction))
        Dim item As String
        For Each item In items
            activationFunctionColumn.Items.Add(item)
            combo_outputLayerAF.Items.Add(item)
        Next

        tlp_calculateDataSet.Location = New Point(tlp_calculateExample.Location.X, tlp_calculateExample.Location.Y)
    End Sub

    Private Sub tbTextChanged(sender As Object, e As EventArgs)
        Dim tb = DirectCast(sender, TextBox)
        Dim tbContents As String = tb.Text

        If IsNumeric(tbContents) = False Then
            MsgBox("Please enter only numeric values.", MsgBoxStyle.OkOnly Or vbCritical, "Non-numeric input")
            Exit Sub
        End If
        If Math.Sign(CDbl(tbContents)) = -1 Then
            MsgBox("Please enter only positive values.", MsgBoxStyle.OkOnly Or vbCritical, "Negative input")
            Exit Sub
        End If


        'list of textboxes that can contain only integers
        Dim intList As New List(Of TextBox)
        intList.AddRange({tb_maxEpochs, tb_graphSecondaryPoints})

        Dim zeroAllowedList As New List(Of TextBox)
        zeroAllowedList.Add(tb_momentum)

        If intList.Contains(tb) Then 'check if it contains only positive, non-zero integers
            Dim parseResult As Boolean
            Integer.TryParse(tbContents, parseResult)

            If parseResult = False And tbContents <> "0" Then
                MsgBox("Please enter only integer values.", MsgBoxStyle.OkOnly Or vbCritical, "Non-integer input")
                Exit Sub
            End If
        End If

        If zeroAllowedList.Contains(tb) = False Then
            If tbContents = "0" Then
                MsgBox("Please enter a non-zero value.", MsgBoxStyle.OkOnly Or vbCritical, "Zero input")
                Exit Sub
            End If
        End If
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

    Private Sub chk_updateBias_CheckedChanged(sender As Object, e As EventArgs) Handles chk_updateBias.CheckedChanged
        If chk_updateBias.Checked Then
            lb_biasNotice.Visible = False
        Else
            lb_biasNotice.Visible = True
        End If
    End Sub

    Private Sub tc_modes_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_modes.Selecting
        panel_charts.Visible = False
        panel_stats.Visible = False
    End Sub

    Friend calcNetwork As New BackpropagationNetwork
    Private Sub btn_loadNetwork_Click(sender As Object, e As EventArgs) Handles btn_loadNetwork.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Title = "Select neural network file to open"
        OpenFileDialog.Filter = "xml files|*.xml"

        Dim path As String = Nothing

        OpenFileDialog.ShowDialog()
        If OpenFileDialog.FileName <> "" Then
            path = OpenFileDialog.FileName.ToString
        End If

        Dim networkLoaded As Boolean
        If path <> Nothing Then
            networkLoaded = NetworkOperation.Load(calcNetwork, path)
        End If

        If networkLoaded = True Then
            gb_calcMode.Visible = True
        End If
    End Sub

    Private Sub btn_calculateExample_Click(sender As Object, e As EventArgs) Handles btn_calculateExample.Click
        Dim networkNumInputs As Integer = calcNetwork.Layers(0).NeuronCount
        Dim networkNumOutputs As Integer = calcNetwork.LastLayer.NeuronCount
        Dim textboxNumInputs As Integer = tb_calcInputExample.Lines.Count

        If textboxNumInputs <> networkNumInputs Then
            MsgBox("The number of inputs entered into the textbox does not equal the number required by the network." & vbNewLine & "Please enter " & networkNumInputs & If(networkNumInputs = 1, " input", " inputs") & " into the textbox.", MsgBoxStyle.OkOnly Or vbCritical, "Incorrect number of inputs")
            Exit Sub
        End If

        For i = 0 To textboxNumInputs - 1
            calcNetwork.Layers(0).Outputs(i) = tb_calcInputExample.Lines(i)
        Next

        networkCalculate(calcNetwork)

        Dim outputString As String = Nothing
        For i = 0 To networkNumOutputs - 1
            outputString &= calcNetwork.LastLayer.Outputs(i) & vbNewLine
        Next
        outputString = Strings.Left(outputString, Len(outputString) - 1)

        tb_calcOutputExample.Text = outputString
    End Sub

    Private Sub radio_CheckedChanged(sender As Object, e As EventArgs)
        If rd_calcExample.Checked Then
            tlp_calculateExample.Visible = True
            tlp_calculateDataSet.Visible = False
        ElseIf rd_calcDataSet.Checked Then
            tlp_calculateExample.Visible = False
            tlp_calculateDataSet.Visible = True
        End If
    End Sub

    Private Sub btn_iputDataSet_Click(sender As Object, e As EventArgs) Handles btn_iputDataSet.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            tb_calcInputDataSet.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_outputDataSet_Click(sender As Object, e As EventArgs) Handles btn_outputDataSet.Click
        Dim path As String
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.Title = "Select file path for output"
        SaveFileDialog.Filter = "csv files|*.csv|All files|*.*"

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            path = SaveFileDialog.FileName.ToString

            If (path IsNot Nothing) Then
                tb_calcOutputDataSet.Text = path
            End If
        End If
    End Sub

    Private Sub btn_calcDataSet_Click(sender As Object, e As EventArgs) Handles btn_calcDataSet.Click
        Dim inputPath As String = tb_calcInputDataSet.Text
        Dim outputPath As String = tb_calcOutputDataSet.Text
        Dim networkInputCount As Integer = calcNetwork.Layers(0).NeuronCount
        Dim inputNumCount As Integer = Util.File.CSV.GetFieldCount(inputPath)
        Dim numInputLines As Integer = Util.File.GetLineCount(inputPath)
        Dim inputDataSet(numInputLines - 1, networkInputCount) As Double

        'check for data entry
        If inputPath = "" OrElse outputPath = "" Then
            MsgBox("Please select an input and output file.", vbOKOnly Or vbCritical, "Invalid input")
        End If

        'validate input file
        If Util.File.CSV.HasConsistentFields(inputPath) = False Then
            MsgBox("All lines in the csv file are not the same lenght." & vbNewLine & "Please fix the line(s).", vbOKOnly Or vbCritical, "Invalid input dataset")
            Exit Sub
        End If

        If Strings.Right(outputPath, 4) <> ".csv" Then
            MsgBox("Only csv output is supported.", vbOKOnly Or vbCritical, "Invalid output format")
            Exit Sub
        End If

        If inputNumCount <> networkInputCount Then
            MsgBox("The neural network is incompatible with the data set." & vbNewLine & vbNewLine & "The number of inputs as set up in the network " & networkInputCount & " do not agree with the number of inputs in the data set " & inputNumCount & ".", vbOKOnly Or MsgBoxStyle.Critical, "Incompatible input data set")
            Exit Sub
        End If


        'read input data into memory
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(inputPath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim i As Integer = 0
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim currentField As String
                    Dim j As Integer = 0
                    For Each currentField In currentRow
                        inputDataSet(i, j) = currentField
                        j += 1
                    Next

                    i += 1
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

        Dim csvOutputString As String = ""

        For i = 0 To numInputLines - 1
            calcNetwork.Layers(0).Outputs = Util.Array.GetRow(i, inputDataSet)
            networkCalculate(calcNetwork)

            For j = 0 To calcNetwork.LastLayer.NeuronCount - 1
                csvOutputString &= calcNetwork.LastLayer.Outputs(j)
                csvOutputString &= ","
            Next

            csvOutputString = Strings.Left(csvOutputString, Len(csvOutputString) - 1)
            csvOutputString &= vbNewLine
        Next

        csvOutputString = Strings.Left(csvOutputString, Len(csvOutputString) - 1)

        Util.File.CSV.Create(outputPath, csvOutputString)

        Beep()
    End Sub
End Class
