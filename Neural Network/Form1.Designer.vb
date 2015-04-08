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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tc_modes = New System.Windows.Forms.TabControl()
        Me.tp_training = New System.Windows.Forms.TabPage()
        Me.chart_error200 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lb_iterationNum = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chart_error = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.combo_outputLayerAF = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_learningMode = New System.Windows.Forms.CheckBox()
        Me.tb_output = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_numOutputs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_addRow = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HiddenLayerNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerNeuronCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerActivationFunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tp_calculation = New System.Windows.Forms.TabPage()
        Me.tc_modes.SuspendLayout()
        Me.tp_training.SuspendLayout()
        CType(Me.chart_error200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_error, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tc_modes
        '
        Me.tc_modes.Controls.Add(Me.tp_training)
        Me.tc_modes.Controls.Add(Me.tp_calculation)
        Me.tc_modes.Location = New System.Drawing.Point(12, 26)
        Me.tc_modes.Name = "tc_modes"
        Me.tc_modes.SelectedIndex = 0
        Me.tc_modes.Size = New System.Drawing.Size(1218, 511)
        Me.tc_modes.TabIndex = 21
        '
        'tp_training
        '
        Me.tp_training.BackColor = System.Drawing.SystemColors.Control
        Me.tp_training.Controls.Add(Me.chart_error200)
        Me.tp_training.Controls.Add(Me.lb_iterationNum)
        Me.tp_training.Controls.Add(Me.Label5)
        Me.tp_training.Controls.Add(Me.chart_error)
        Me.tp_training.Controls.Add(Me.combo_outputLayerAF)
        Me.tp_training.Controls.Add(Me.Label4)
        Me.tp_training.Controls.Add(Me.chk_learningMode)
        Me.tp_training.Controls.Add(Me.tb_output)
        Me.tp_training.Controls.Add(Me.Label3)
        Me.tp_training.Controls.Add(Me.tb_numOutputs)
        Me.tp_training.Controls.Add(Me.Label2)
        Me.tp_training.Controls.Add(Me.Button1)
        Me.tp_training.Controls.Add(Me.btn_addRow)
        Me.tp_training.Controls.Add(Me.DataGridView1)
        Me.tp_training.Controls.Add(Me.Button2)
        Me.tp_training.Controls.Add(Me.tb_input)
        Me.tp_training.Controls.Add(Me.Label1)
        Me.tp_training.Location = New System.Drawing.Point(4, 22)
        Me.tp_training.Name = "tp_training"
        Me.tp_training.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_training.Size = New System.Drawing.Size(1210, 485)
        Me.tp_training.TabIndex = 0
        Me.tp_training.Text = "Training mode"
        '
        'chart_error200
        '
        Me.chart_error200.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.chart_error200.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.Name = "Legend1"
        Me.chart_error200.Legends.Add(Legend3)
        Me.chart_error200.Location = New System.Drawing.Point(908, 141)
        Me.chart_error200.Name = "chart_error200"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series3.YValuesPerPoint = 6
        Me.chart_error200.Series.Add(Series3)
        Me.chart_error200.Size = New System.Drawing.Size(294, 185)
        Me.chart_error200.TabIndex = 29
        Me.chart_error200.Text = "Network error (RMSE)"
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Network error (RMSE)"
        Me.chart_error200.Titles.Add(Title3)
        '
        'lb_iterationNum
        '
        Me.lb_iterationNum.AutoSize = True
        Me.lb_iterationNum.Location = New System.Drawing.Point(774, 373)
        Me.lb_iterationNum.Name = "lb_iterationNum"
        Me.lb_iterationNum.Size = New System.Drawing.Size(13, 13)
        Me.lb_iterationNum.TabIndex = 28
        Me.lb_iterationNum.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(682, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Iteration number:"
        '
        'chart_error
        '
        Me.chart_error.BackColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.chart_error.ChartAreas.Add(ChartArea4)
        Legend4.BackColor = System.Drawing.Color.Transparent
        Legend4.Name = "Legend1"
        Me.chart_error.Legends.Add(Legend4)
        Me.chart_error.Location = New System.Drawing.Point(552, 52)
        Me.chart_error.Name = "chart_error"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Series4.YValuesPerPoint = 6
        Me.chart_error.Series.Add(Series4)
        Me.chart_error.Size = New System.Drawing.Size(469, 320)
        Me.chart_error.TabIndex = 26
        Me.chart_error.Text = "Network error (RMSE)"
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "Network error (RMSE)"
        Me.chart_error.Titles.Add(Title4)
        '
        'combo_outputLayerAF
        '
        Me.combo_outputLayerAF.FormattingEnabled = True
        Me.combo_outputLayerAF.Location = New System.Drawing.Point(384, 238)
        Me.combo_outputLayerAF.Name = "combo_outputLayerAF"
        Me.combo_outputLayerAF.Size = New System.Drawing.Size(121, 21)
        Me.combo_outputLayerAF.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Output layer activation function"
        '
        'chk_learningMode
        '
        Me.chk_learningMode.AutoSize = True
        Me.chk_learningMode.Checked = True
        Me.chk_learningMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_learningMode.Location = New System.Drawing.Point(13, 263)
        Me.chk_learningMode.Name = "chk_learningMode"
        Me.chk_learningMode.Size = New System.Drawing.Size(96, 17)
        Me.chk_learningMode.TabIndex = 23
        Me.chk_learningMode.Text = "Learning mode"
        Me.chk_learningMode.UseVisualStyleBackColor = True
        '
        'tb_output
        '
        Me.tb_output.Location = New System.Drawing.Point(122, 280)
        Me.tb_output.Name = "tb_output"
        Me.tb_output.Size = New System.Drawing.Size(255, 20)
        Me.tb_output.TabIndex = 22
        Me.tb_output.Text = "C:\Users\Stephan Taljaard\Desktop\output.csv"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Expected outputs"
        '
        'tb_numOutputs
        '
        Me.tb_numOutputs.Location = New System.Drawing.Point(115, 234)
        Me.tb_numOutputs.Name = "tb_numOutputs"
        Me.tb_numOutputs.Size = New System.Drawing.Size(45, 20)
        Me.tb_numOutputs.TabIndex = 20
        Me.tb_numOutputs.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Number of outputs"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(291, 358)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_addRow
        '
        Me.btn_addRow.Location = New System.Drawing.Point(13, 140)
        Me.btn_addRow.Name = "btn_addRow"
        Me.btn_addRow.Size = New System.Drawing.Size(24, 23)
        Me.btn_addRow.TabIndex = 10
        Me.btn_addRow.Text = "+"
        Me.btn_addRow.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Location = New System.Drawing.Point(47, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(332, 150)
        Me.DataGridView1.TabIndex = 9
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(508, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 20)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tb_input
        '
        Me.tb_input.Location = New System.Drawing.Point(43, 19)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(459, 20)
        Me.tb_input.TabIndex = 7
        Me.tb_input.Text = "C:\Users\Stephan Taljaard\Desktop\test.csv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input"
        '
        'tp_calculation
        '
        Me.tp_calculation.BackColor = System.Drawing.SystemColors.Control
        Me.tp_calculation.Location = New System.Drawing.Point(4, 22)
        Me.tp_calculation.Name = "tp_calculation"
        Me.tp_calculation.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_calculation.Size = New System.Drawing.Size(1210, 485)
        Me.tp_calculation.TabIndex = 1
        Me.tp_calculation.Text = "Calculation mode"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 549)
        Me.Controls.Add(Me.tc_modes)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tc_modes.ResumeLayout(False)
        Me.tp_training.ResumeLayout(False)
        Me.tp_training.PerformLayout()
        CType(Me.chart_error200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_error, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tc_modes As System.Windows.Forms.TabControl
    Friend WithEvents tp_training As System.Windows.Forms.TabPage
    Friend WithEvents chart_error200 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lb_iterationNum As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chart_error As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents combo_outputLayerAF As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chk_learningMode As System.Windows.Forms.CheckBox
    Friend WithEvents tb_output As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_numOutputs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_addRow As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HiddenLayerNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLayerNeuronCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLayerActivationFunction As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tb_input As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tp_calculation As System.Windows.Forms.TabPage

End Class
