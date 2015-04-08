<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HiddenLayerNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerNeuronCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerActivationFunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btn_addRow = New System.Windows.Forms.Button()
        Me.tb_numOutputs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_output = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_learningMode = New System.Windows.Forms.CheckBox()
        Me.chart_error = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combo_outputLayerAF = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lb_iterationNum = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_error, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(432, 337)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tb_input
        '
        Me.tb_input.Location = New System.Drawing.Point(73, 30)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(459, 20)
        Me.tb_input.TabIndex = 6
        Me.tb_input.Text = "C:\Users\Stephan Taljaard\Desktop\test.csv"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(538, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 20)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HiddenLayerNumber, Me.HiddenLayerNeuronCount, Me.HiddenLayerActivationFunction})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataGridView1.Location = New System.Drawing.Point(27, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(523, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'HiddenLayerNumber
        '
        Me.HiddenLayerNumber.HeaderText = "Hidden Layer number"
        Me.HiddenLayerNumber.Name = "HiddenLayerNumber"
        Me.HiddenLayerNumber.Width = 122
        '
        'HiddenLayerNeuronCount
        '
        Me.HiddenLayerNeuronCount.HeaderText = "Number of hidden neurons"
        Me.HiddenLayerNeuronCount.Name = "HiddenLayerNeuronCount"
        Me.HiddenLayerNeuronCount.Width = 109
        '
        'HiddenLayerActivationFunction
        '
        Me.HiddenLayerActivationFunction.HeaderText = "Activation Function"
        Me.HiddenLayerActivationFunction.Name = "HiddenLayerActivationFunction"
        Me.HiddenLayerActivationFunction.Width = 94
        '
        'btn_addRow
        '
        Me.btn_addRow.Location = New System.Drawing.Point(3, 85)
        Me.btn_addRow.Name = "btn_addRow"
        Me.btn_addRow.Size = New System.Drawing.Size(24, 23)
        Me.btn_addRow.TabIndex = 9
        Me.btn_addRow.Text = "+"
        Me.btn_addRow.UseVisualStyleBackColor = True
        '
        'tb_numOutputs
        '
        Me.tb_numOutputs.Location = New System.Drawing.Point(136, 266)
        Me.tb_numOutputs.Name = "tb_numOutputs"
        Me.tb_numOutputs.Size = New System.Drawing.Size(45, 20)
        Me.tb_numOutputs.TabIndex = 11
        Me.tb_numOutputs.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Number of outputs"
        '
        'tb_output
        '
        Me.tb_output.Location = New System.Drawing.Point(148, 312)
        Me.tb_output.Name = "tb_output"
        Me.tb_output.Size = New System.Drawing.Size(255, 20)
        Me.tb_output.TabIndex = 13
        Me.tb_output.Text = "C:\Users\Stephan Taljaard\Desktop\output.csv"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Expected outputs"
        '
        'chk_learningMode
        '
        Me.chk_learningMode.AutoSize = True
        Me.chk_learningMode.Checked = True
        Me.chk_learningMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_learningMode.Location = New System.Drawing.Point(39, 295)
        Me.chk_learningMode.Name = "chk_learningMode"
        Me.chk_learningMode.Size = New System.Drawing.Size(96, 17)
        Me.chk_learningMode.TabIndex = 14
        Me.chk_learningMode.Text = "Learning mode"
        Me.chk_learningMode.UseVisualStyleBackColor = True
        '
        'chart_error
        '
        Me.chart_error.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.chart_error.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Name = "Legend1"
        Me.chart_error.Legends.Add(Legend1)
        Me.chart_error.Location = New System.Drawing.Point(580, 12)
        Me.chart_error.Name = "chart_error"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.YValuesPerPoint = 6
        Me.chart_error.Series.Add(Series1)
        Me.chart_error.Size = New System.Drawing.Size(469, 320)
        Me.chart_error.TabIndex = 15
        Me.chart_error.Text = "Network error"
        Title1.Name = "Title1"
        Title1.Text = "Network error"
        Me.chart_error.Titles.Add(Title1)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Output layer activation function"
        '
        'combo_outputLayerAF
        '
        Me.combo_outputLayerAF.FormattingEnabled = True
        Me.combo_outputLayerAF.Location = New System.Drawing.Point(347, 261)
        Me.combo_outputLayerAF.Name = "combo_outputLayerAF"
        Me.combo_outputLayerAF.Size = New System.Drawing.Size(121, 21)
        Me.combo_outputLayerAF.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(710, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Iteration number:"
        '
        'lb_iterationNum
        '
        Me.lb_iterationNum.AutoSize = True
        Me.lb_iterationNum.Location = New System.Drawing.Point(802, 333)
        Me.lb_iterationNum.Name = "lb_iterationNum"
        Me.lb_iterationNum.Size = New System.Drawing.Size(13, 13)
        Me.lb_iterationNum.TabIndex = 19
        Me.lb_iterationNum.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 378)
        Me.Controls.Add(Me.lb_iterationNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combo_outputLayerAF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chart_error)
        Me.Controls.Add(Me.chk_learningMode)
        Me.Controls.Add(Me.tb_output)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_numOutputs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_addRow)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tb_input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_error, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tb_input As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_addRow As System.Windows.Forms.Button
    Friend WithEvents tb_numOutputs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_output As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk_learningMode As System.Windows.Forms.CheckBox
    Friend WithEvents HiddenLayerNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLayerNeuronCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLayerActivationFunction As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents chart_error As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents combo_outputLayerAF As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_iterationNum As System.Windows.Forms.Label

End Class
