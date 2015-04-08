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
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title9 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title10 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tc_modes = New System.Windows.Forms.TabControl()
        Me.tp_training = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_addRow = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_selectInput = New System.Windows.Forms.Button()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.chart_error200 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lb_iterationNum = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chart_error = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chk_learningMode = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tp_calculation = New System.Windows.Forms.TabPage()
        Me.HiddenLayerNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerNeuronCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerActivationFunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_output = New System.Windows.Forms.TextBox()
        Me.combo_outputLayerAF = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_numOutputs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_selectOutput = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tc_modes.SuspendLayout()
        Me.tp_training.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chart_error200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_error, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "*.csv|*.CSV"
        '
        'tc_modes
        '
        Me.tc_modes.Controls.Add(Me.tp_training)
        Me.tc_modes.Controls.Add(Me.tp_calculation)
        Me.tc_modes.Location = New System.Drawing.Point(12, 12)
        Me.tc_modes.Name = "tc_modes"
        Me.tc_modes.SelectedIndex = 0
        Me.tc_modes.Size = New System.Drawing.Size(782, 539)
        Me.tc_modes.TabIndex = 21
        '
        'tp_training
        '
        Me.tp_training.BackColor = System.Drawing.SystemColors.Control
        Me.tp_training.Controls.Add(Me.GroupBox3)
        Me.tp_training.Controls.Add(Me.GroupBox1)
        Me.tp_training.Controls.Add(Me.GroupBox2)
        Me.tp_training.Controls.Add(Me.chart_error200)
        Me.tp_training.Controls.Add(Me.lb_iterationNum)
        Me.tp_training.Controls.Add(Me.Label5)
        Me.tp_training.Controls.Add(Me.chart_error)
        Me.tp_training.Controls.Add(Me.Button1)
        Me.tp_training.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_training.Location = New System.Drawing.Point(4, 22)
        Me.tp_training.Name = "tp_training"
        Me.tp_training.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_training.Size = New System.Drawing.Size(774, 513)
        Me.tp_training.TabIndex = 0
        Me.tp_training.Text = "TRAINING MODE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_addRow)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 219)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "HIDDEN LAYERS"
        '
        'btn_addRow
        '
        Me.btn_addRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addRow.Location = New System.Drawing.Point(12, 78)
        Me.btn_addRow.Name = "btn_addRow"
        Me.btn_addRow.Size = New System.Drawing.Size(24, 23)
        Me.btn_addRow.TabIndex = 11
        Me.btn_addRow.Text = "+"
        Me.btn_addRow.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HiddenLayerNumber, Me.HiddenLayerNeuronCount, Me.HiddenLayerActivationFunction})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataGridView1.Location = New System.Drawing.Point(40, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(504, 176)
        Me.DataGridView1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_selectInput)
        Me.GroupBox1.Controls.Add(Me.tb_input)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 95)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(537, 34)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Select csv file containing raw input data." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The file should not have any headers." & _
    " Each row represents one ""example"" of inputs."
        '
        'btn_selectInput
        '
        Me.btn_selectInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selectInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectInput.Image = Global.NeuralNetwork.My.Resources.Resources.openfolder
        Me.btn_selectInput.Location = New System.Drawing.Point(533, 58)
        Me.btn_selectInput.Name = "btn_selectInput"
        Me.btn_selectInput.Size = New System.Drawing.Size(23, 23)
        Me.btn_selectInput.TabIndex = 10
        Me.btn_selectInput.UseVisualStyleBackColor = True
        '
        'tb_input
        '
        Me.tb_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_input.Location = New System.Drawing.Point(9, 58)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(521, 23)
        Me.tb_input.TabIndex = 9
        Me.tb_input.Text = "C:\Users\Stephan Taljaard\Desktop\test.csv"
        '
        'chart_error200
        '
        Me.chart_error200.BackColor = System.Drawing.Color.Transparent
        ChartArea9.Name = "ChartArea1"
        Me.chart_error200.ChartAreas.Add(ChartArea9)
        Legend9.BackColor = System.Drawing.Color.Transparent
        Legend9.Name = "Legend1"
        Me.chart_error200.Legends.Add(Legend9)
        Me.chart_error200.Location = New System.Drawing.Point(908, 141)
        Me.chart_error200.Name = "chart_error200"
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Series9.YValuesPerPoint = 6
        Me.chart_error200.Series.Add(Series9)
        Me.chart_error200.Size = New System.Drawing.Size(294, 185)
        Me.chart_error200.TabIndex = 29
        Me.chart_error200.Text = "Network error (RMSE)"
        Title9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title9.Name = "Title1"
        Title9.Text = "Network error (RMSE)"
        Me.chart_error200.Titles.Add(Title9)
        '
        'lb_iterationNum
        '
        Me.lb_iterationNum.AutoSize = True
        Me.lb_iterationNum.Location = New System.Drawing.Point(774, 373)
        Me.lb_iterationNum.Name = "lb_iterationNum"
        Me.lb_iterationNum.Size = New System.Drawing.Size(18, 20)
        Me.lb_iterationNum.TabIndex = 28
        Me.lb_iterationNum.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(682, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Iteration number:"
        '
        'chart_error
        '
        Me.chart_error.BackColor = System.Drawing.Color.Transparent
        ChartArea10.Name = "ChartArea1"
        Me.chart_error.ChartAreas.Add(ChartArea10)
        Legend10.BackColor = System.Drawing.Color.Transparent
        Legend10.Name = "Legend1"
        Me.chart_error.Legends.Add(Legend10)
        Me.chart_error.Location = New System.Drawing.Point(552, 52)
        Me.chart_error.Name = "chart_error"
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series10.Legend = "Legend1"
        Series10.Name = "Series1"
        Series10.YValuesPerPoint = 6
        Me.chart_error.Series.Add(Series10)
        Me.chart_error.Size = New System.Drawing.Size(469, 320)
        Me.chart_error.TabIndex = 26
        Me.chart_error.Text = "Network error (RMSE)"
        Title10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title10.Name = "Title1"
        Title10.Text = "Network error (RMSE)"
        Me.chart_error.Titles.Add(Title10)
        '
        'chk_learningMode
        '
        Me.chk_learningMode.AutoSize = True
        Me.chk_learningMode.Checked = True
        Me.chk_learningMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_learningMode.Location = New System.Drawing.Point(1169, 48)
        Me.chk_learningMode.Name = "chk_learningMode"
        Me.chk_learningMode.Size = New System.Drawing.Size(113, 19)
        Me.chk_learningMode.TabIndex = 23
        Me.chk_learningMode.Text = "Learning mode"
        Me.chk_learningMode.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(566, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tp_calculation
        '
        Me.tp_calculation.BackColor = System.Drawing.SystemColors.Control
        Me.tp_calculation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_calculation.Location = New System.Drawing.Point(4, 22)
        Me.tp_calculation.Name = "tp_calculation"
        Me.tp_calculation.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_calculation.Size = New System.Drawing.Size(774, 513)
        Me.tp_calculation.TabIndex = 1
        Me.tp_calculation.Text = "CALCULATION MODE"
        '
        'HiddenLayerNumber
        '
        Me.HiddenLayerNumber.HeaderText = "Hidden Layer #"
        Me.HiddenLayerNumber.Name = "HiddenLayerNumber"
        Me.HiddenLayerNumber.Width = 155
        '
        'HiddenLayerNeuronCount
        '
        Me.HiddenLayerNeuronCount.HeaderText = "# neurons per layer"
        Me.HiddenLayerNeuronCount.Name = "HiddenLayerNeuronCount"
        Me.HiddenLayerNeuronCount.Width = 155
        '
        'HiddenLayerActivationFunction
        '
        Me.HiddenLayerActivationFunction.HeaderText = "Activation Function"
        Me.HiddenLayerActivationFunction.Name = "HiddenLayerActivationFunction"
        Me.HiddenLayerActivationFunction.Width = 190
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_selectOutput)
        Me.GroupBox3.Controls.Add(Me.combo_outputLayerAF)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.tb_numOutputs)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tb_output)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 332)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(565, 141)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OUTPUT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(546, 34)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Select csv file containing raw output data (expected outputs), for use in trainin" & _
    "g." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The file should not have any headers. Each row represents one ""example"" of o" & _
    "utputs."
        '
        'tb_output
        '
        Me.tb_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_output.Location = New System.Drawing.Point(12, 65)
        Me.tb_output.Name = "tb_output"
        Me.tb_output.Size = New System.Drawing.Size(518, 23)
        Me.tb_output.TabIndex = 23
        Me.tb_output.Text = "C:\Users\Stephan Taljaard\Desktop\output.csv"
        '
        'combo_outputLayerAF
        '
        Me.combo_outputLayerAF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_outputLayerAF.FormattingEnabled = True
        Me.combo_outputLayerAF.Location = New System.Drawing.Point(388, 103)
        Me.combo_outputLayerAF.Name = "combo_outputLayerAF"
        Me.combo_outputLayerAF.Size = New System.Drawing.Size(167, 24)
        Me.combo_outputLayerAF.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Output layer activation function"
        '
        'tb_numOutputs
        '
        Me.tb_numOutputs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_numOutputs.Location = New System.Drawing.Point(139, 103)
        Me.tb_numOutputs.Name = "tb_numOutputs"
        Me.tb_numOutputs.Size = New System.Drawing.Size(42, 23)
        Me.tb_numOutputs.TabIndex = 27
        Me.tb_numOutputs.Text = "2"
        Me.tb_numOutputs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Number of outputs:"
        '
        'btn_selectOutput
        '
        Me.btn_selectOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selectOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectOutput.Image = Global.NeuralNetwork.My.Resources.Resources.openfolder
        Me.btn_selectOutput.Location = New System.Drawing.Point(533, 65)
        Me.btn_selectOutput.Name = "btn_selectOutput"
        Me.btn_selectOutput.Size = New System.Drawing.Size(23, 23)
        Me.btn_selectOutput.TabIndex = 30
        Me.btn_selectOutput.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(963, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1491, 563)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tc_modes)
        Me.Controls.Add(Me.chk_learningMode)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tc_modes.ResumeLayout(False)
        Me.tp_training.ResumeLayout(False)
        Me.tp_training.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chart_error200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_error, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tc_modes As System.Windows.Forms.TabControl
    Friend WithEvents tp_training As System.Windows.Forms.TabPage
    Friend WithEvents chart_error200 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lb_iterationNum As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chart_error As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chk_learningMode As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tp_calculation As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_selectInput As System.Windows.Forms.Button
    Friend WithEvents tb_input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_addRow As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HiddenLayerNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLayerNeuronCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLayerActivationFunction As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_outputLayerAF As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_numOutputs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_output As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_selectOutput As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
