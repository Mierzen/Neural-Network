﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_main
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tc_modes = New System.Windows.Forms.TabControl()
        Me.tp_training = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.btn_selectInput = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tlp_advancedSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.tb_maxEpochs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_learningRate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chk_showGraph = New System.Windows.Forms.CheckBox()
        Me.tb_momentum = New System.Windows.Forms.TextBox()
        Me.chk_updateBias = New System.Windows.Forms.CheckBox()
        Me.tb_maxError = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lb_graphSecondary = New System.Windows.Forms.Label()
        Me.tb_graphSecondaryPoints = New System.Windows.Forms.TextBox()
        Me.lb_biasNotice = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_deleteRow = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HiddenLayerNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerNeuronCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerActivationFunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btn_addRow = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_output = New System.Windows.Forms.TextBox()
        Me.btn_selectOutput = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combo_outputLayerAF = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tp_calculation = New System.Windows.Forms.TabPage()
        Me.tlp_calculateDataSet = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_calcDataSet = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tb_calcOutputDataSet = New System.Windows.Forms.TextBox()
        Me.btn_outputDataSet = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_calcInputDataSet = New System.Windows.Forms.TextBox()
        Me.btn_iputDataSet = New System.Windows.Forms.Button()
        Me.gb_calcMode = New System.Windows.Forms.GroupBox()
        Me.rd_calcDataSet = New System.Windows.Forms.RadioButton()
        Me.rd_calcExample = New System.Windows.Forms.RadioButton()
        Me.tlp_calculateExample = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_calcInputExample = New System.Windows.Forms.TextBox()
        Me.tb_calcOutputExample = New System.Windows.Forms.TextBox()
        Me.btn_calculateExample = New System.Windows.Forms.Button()
        Me.btn_loadNetwork = New System.Windows.Forms.Button()
        Me.chart_error = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.chart_errorSecondary = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lb_currentError = New System.Windows.Forms.Label()
        Me.panel_charts = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lb_iterationNum = New System.Windows.Forms.Label()
        Me.panel_stats = New System.Windows.Forms.TableLayoutPanel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip_RoT = New System.Windows.Forms.ToolTip(Me.components)
        Me.tc_modes.SuspendLayout()
        Me.tp_training.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tlp_advancedSettings.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tp_calculation.SuspendLayout()
        Me.tlp_calculateDataSet.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.gb_calcMode.SuspendLayout()
        Me.tlp_calculateExample.SuspendLayout()
        CType(Me.chart_error, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.chart_errorSecondary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_charts.SuspendLayout()
        Me.panel_stats.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "csv files|*.csv"
        Me.OpenFileDialog1.Title = "Select file to open"
        '
        'tc_modes
        '
        Me.tc_modes.Controls.Add(Me.tp_training)
        Me.tc_modes.Controls.Add(Me.tp_calculation)
        Me.tc_modes.Location = New System.Drawing.Point(12, 12)
        Me.tc_modes.Name = "tc_modes"
        Me.tc_modes.SelectedIndex = 0
        Me.tc_modes.Size = New System.Drawing.Size(747, 568)
        Me.tc_modes.TabIndex = 21
        '
        'tp_training
        '
        Me.tp_training.BackColor = System.Drawing.SystemColors.Control
        Me.tp_training.Controls.Add(Me.TableLayoutPanel5)
        Me.tp_training.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_training.Location = New System.Drawing.Point(4, 22)
        Me.tp_training.Name = "tp_training"
        Me.tp_training.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_training.Size = New System.Drawing.Size(739, 542)
        Me.tp_training.TabIndex = 0
        Me.tp_training.Text = "TRAINING MODE"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox4, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 6)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(730, 537)
        Me.TableLayoutPanel5.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(567, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 77)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tb_input, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_selectInput, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(561, 55)
        Me.TableLayoutPanel4.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Select csv file containing raw input data." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The file should not have any headers." & _
    " Each row represents one ""example"" of inputs."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_input
        '
        Me.tb_input.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_input.Location = New System.Drawing.Point(3, 30)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(521, 20)
        Me.tb_input.TabIndex = 9
        '
        'btn_selectInput
        '
        Me.btn_selectInput.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_selectInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selectInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectInput.Image = Global.NeuralNetwork.My.Resources.Resources.openfolder
        Me.btn_selectInput.Location = New System.Drawing.Point(530, 29)
        Me.btn_selectInput.Name = "btn_selectInput"
        Me.btn_selectInput.Size = New System.Drawing.Size(23, 23)
        Me.btn_selectInput.TabIndex = 10
        Me.btn_selectInput.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.Controls.Add(Me.tlp_advancedSettings)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 429)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(567, 105)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ADVANCED SETTINGS"
        '
        'tlp_advancedSettings
        '
        Me.tlp_advancedSettings.AutoSize = True
        Me.tlp_advancedSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlp_advancedSettings.ColumnCount = 6
        Me.tlp_advancedSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_advancedSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_advancedSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_advancedSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_advancedSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_advancedSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_advancedSettings.Controls.Add(Me.tb_maxEpochs, 3, 0)
        Me.tlp_advancedSettings.Controls.Add(Me.Label9, 2, 0)
        Me.tlp_advancedSettings.Controls.Add(Me.Label7, 0, 0)
        Me.tlp_advancedSettings.Controls.Add(Me.tb_learningRate, 1, 0)
        Me.tlp_advancedSettings.Controls.Add(Me.Label8, 0, 1)
        Me.tlp_advancedSettings.Controls.Add(Me.chk_showGraph, 4, 0)
        Me.tlp_advancedSettings.Controls.Add(Me.tb_momentum, 1, 1)
        Me.tlp_advancedSettings.Controls.Add(Me.chk_updateBias, 0, 2)
        Me.tlp_advancedSettings.Controls.Add(Me.tb_maxError, 3, 1)
        Me.tlp_advancedSettings.Controls.Add(Me.Label10, 2, 1)
        Me.tlp_advancedSettings.Controls.Add(Me.lb_graphSecondary, 4, 1)
        Me.tlp_advancedSettings.Controls.Add(Me.tb_graphSecondaryPoints, 5, 1)
        Me.tlp_advancedSettings.Controls.Add(Me.lb_biasNotice, 2, 2)
        Me.tlp_advancedSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_advancedSettings.Location = New System.Drawing.Point(3, 19)
        Me.tlp_advancedSettings.Name = "tlp_advancedSettings"
        Me.tlp_advancedSettings.Padding = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.tlp_advancedSettings.RowCount = 3
        Me.tlp_advancedSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_advancedSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_advancedSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_advancedSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_advancedSettings.Size = New System.Drawing.Size(561, 83)
        Me.tlp_advancedSettings.TabIndex = 32
        '
        'tb_maxEpochs
        '
        Me.tb_maxEpochs.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_maxEpochs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_maxEpochs.Location = New System.Drawing.Point(272, 3)
        Me.tb_maxEpochs.Name = "tb_maxEpochs"
        Me.tb_maxEpochs.Size = New System.Drawing.Size(42, 20)
        Me.tb_maxEpochs.TabIndex = 38
        Me.tb_maxEpochs.Text = "10000"
        Me.tb_maxEpochs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(144, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Max. iterations (epochs):"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Learning rate:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip_RoT.SetToolTip(Me.Label7, "Between 0.001 and 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.01 is a good starting point")
        '
        'tb_learningRate
        '
        Me.tb_learningRate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_learningRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_learningRate.Location = New System.Drawing.Point(81, 3)
        Me.tb_learningRate.Name = "tb_learningRate"
        Me.tb_learningRate.Size = New System.Drawing.Size(42, 20)
        Me.tb_learningRate.TabIndex = 29
        Me.tb_learningRate.Text = "0.01"
        Me.tb_learningRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip_RoT.SetToolTip(Me.tb_learningRate, "Between 0.001 and 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.01 is a good starting point")
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Momentum:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip_RoT.SetToolTip(Me.Label8, "Between 0.3 and 0.95" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.9 usually gives good results")
        '
        'chk_showGraph
        '
        Me.chk_showGraph.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chk_showGraph.AutoSize = True
        Me.chk_showGraph.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_showGraph.Checked = True
        Me.chk_showGraph.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tlp_advancedSettings.SetColumnSpan(Me.chk_showGraph, 2)
        Me.chk_showGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chk_showGraph.Location = New System.Drawing.Point(320, 4)
        Me.chk_showGraph.Name = "chk_showGraph"
        Me.chk_showGraph.Size = New System.Drawing.Size(113, 17)
        Me.chk_showGraph.TabIndex = 33
        Me.chk_showGraph.Text = "Show error graph?"
        Me.chk_showGraph.UseVisualStyleBackColor = True
        '
        'tb_momentum
        '
        Me.tb_momentum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_momentum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_momentum.Location = New System.Drawing.Point(81, 29)
        Me.tb_momentum.Name = "tb_momentum"
        Me.tb_momentum.Size = New System.Drawing.Size(42, 20)
        Me.tb_momentum.TabIndex = 31
        Me.tb_momentum.Text = "0.9"
        Me.tb_momentum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip_RoT.SetToolTip(Me.tb_momentum, "Between 0.3 and 0.95" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.9 usually gives good results")
        '
        'chk_updateBias
        '
        Me.chk_updateBias.AutoSize = True
        Me.chk_updateBias.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_updateBias.Checked = True
        Me.chk_updateBias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tlp_advancedSettings.SetColumnSpan(Me.chk_updateBias, 2)
        Me.chk_updateBias.Dock = System.Windows.Forms.DockStyle.Top
        Me.chk_updateBias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chk_updateBias.Location = New System.Drawing.Point(3, 55)
        Me.chk_updateBias.Name = "chk_updateBias"
        Me.chk_updateBias.Size = New System.Drawing.Size(135, 17)
        Me.chk_updateBias.TabIndex = 32
        Me.chk_updateBias.Text = "Update biases as well?"
        Me.chk_updateBias.UseVisualStyleBackColor = True
        '
        'tb_maxError
        '
        Me.tb_maxError.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_maxError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_maxError.Location = New System.Drawing.Point(272, 29)
        Me.tb_maxError.Name = "tb_maxError"
        Me.tb_maxError.Size = New System.Drawing.Size(42, 20)
        Me.tb_maxError.TabIndex = 39
        Me.tb_maxError.Text = "0.001"
        Me.tb_maxError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(144, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Max. network error;:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_graphSecondary
        '
        Me.lb_graphSecondary.AutoSize = True
        Me.lb_graphSecondary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_graphSecondary.Location = New System.Drawing.Point(320, 26)
        Me.lb_graphSecondary.MaximumSize = New System.Drawing.Size(179, 0)
        Me.lb_graphSecondary.Name = "lb_graphSecondary"
        Me.lb_graphSecondary.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.tlp_advancedSettings.SetRowSpan(Me.lb_graphSecondary, 2)
        Me.lb_graphSecondary.Size = New System.Drawing.Size(179, 32)
        Me.lb_graphSecondary.TabIndex = 35
        Me.lb_graphSecondary.Text = "Number of previous iterations to plot on secondary chart:"
        '
        'tb_graphSecondaryPoints
        '
        Me.tb_graphSecondaryPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_graphSecondaryPoints.Location = New System.Drawing.Point(505, 29)
        Me.tb_graphSecondaryPoints.Name = "tb_graphSecondaryPoints"
        Me.tlp_advancedSettings.SetRowSpan(Me.tb_graphSecondaryPoints, 2)
        Me.tb_graphSecondaryPoints.Size = New System.Drawing.Size(38, 20)
        Me.tb_graphSecondaryPoints.TabIndex = 36
        Me.tb_graphSecondaryPoints.Text = "50"
        Me.tb_graphSecondaryPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_biasNotice
        '
        Me.lb_biasNotice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_biasNotice.AutoSize = True
        Me.tlp_advancedSettings.SetColumnSpan(Me.lb_biasNotice, 2)
        Me.lb_biasNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_biasNotice.Location = New System.Drawing.Point(144, 63)
        Me.lb_biasNotice.Name = "lb_biasNotice"
        Me.lb_biasNotice.Size = New System.Drawing.Size(150, 12)
        Me.lb_biasNotice.TabIndex = 41
        Me.lb_biasNotice.Text = "If not, biases will be kept equal to 1."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 86)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(567, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 219)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "HIDDEN LAYERS"
        Me.ToolTip_RoT.SetToolTip(Me.GroupBox2, resources.GetString("GroupBox2.ToolTip"))
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.btn_deleteRow, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridView1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_addRow, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(561, 197)
        Me.TableLayoutPanel3.TabIndex = 32
        '
        'btn_deleteRow
        '
        Me.btn_deleteRow.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteRow.Location = New System.Drawing.Point(3, 70)
        Me.btn_deleteRow.MinimumSize = New System.Drawing.Size(24, 24)
        Me.btn_deleteRow.Name = "btn_deleteRow"
        Me.btn_deleteRow.Size = New System.Drawing.Size(24, 24)
        Me.btn_deleteRow.TabIndex = 38
        Me.btn_deleteRow.Text = "-"
        Me.btn_deleteRow.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.NeuralNetwork.My.Resources.Resources.Info
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(31, 31)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(31, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HiddenLayerNumber, Me.HiddenLayerNeuronCount, Me.HiddenLayerActivationFunction})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(40, 3)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.TableLayoutPanel3.SetRowSpan(Me.DataGridView1, 3)
        Me.DataGridView1.Size = New System.Drawing.Size(525, 191)
        Me.DataGridView1.TabIndex = 10
        Me.ToolTip_RoT.SetToolTip(Me.DataGridView1, resources.GetString("DataGridView1.ToolTip"))
        '
        'HiddenLayerNumber
        '
        Me.HiddenLayerNumber.HeaderText = "Hidden Layer #"
        Me.HiddenLayerNumber.Name = "HiddenLayerNumber"
        Me.HiddenLayerNumber.Width = 159
        '
        'HiddenLayerNeuronCount
        '
        Me.HiddenLayerNeuronCount.HeaderText = "# neurons per layer"
        Me.HiddenLayerNeuronCount.Name = "HiddenLayerNeuronCount"
        Me.HiddenLayerNeuronCount.Width = 159
        '
        'HiddenLayerActivationFunction
        '
        Me.HiddenLayerActivationFunction.HeaderText = "Activation Function"
        Me.HiddenLayerActivationFunction.Name = "HiddenLayerActivationFunction"
        Me.HiddenLayerActivationFunction.Width = 193
        '
        'btn_addRow
        '
        Me.btn_addRow.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addRow.Location = New System.Drawing.Point(3, 40)
        Me.btn_addRow.MinimumSize = New System.Drawing.Size(24, 24)
        Me.btn_addRow.Name = "btn_addRow"
        Me.btn_addRow.Size = New System.Drawing.Size(24, 24)
        Me.btn_addRow.TabIndex = 11
        Me.btn_addRow.Text = "+"
        Me.btn_addRow.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 311)
        Me.GroupBox3.MinimumSize = New System.Drawing.Size(567, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(567, 112)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OUTPUT"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tb_output, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_selectOutput, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.combo_outputLayerAF, 2, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(561, 90)
        Me.TableLayoutPanel2.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label6, 5)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(411, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Select csv file containing raw output data (expected outputs), for use in trainin" & _
    "g." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The file should not have any headers. Each row represents one ""example"" of o" & _
    "utputs."
        '
        'tb_output
        '
        Me.tb_output.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.SetColumnSpan(Me.tb_output, 4)
        Me.tb_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_output.Location = New System.Drawing.Point(3, 30)
        Me.tb_output.Name = "tb_output"
        Me.tb_output.Size = New System.Drawing.Size(518, 20)
        Me.tb_output.TabIndex = 23
        '
        'btn_selectOutput
        '
        Me.btn_selectOutput.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_selectOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selectOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectOutput.Image = Global.NeuralNetwork.My.Resources.Resources.openfolder
        Me.btn_selectOutput.Location = New System.Drawing.Point(527, 29)
        Me.btn_selectOutput.Name = "btn_selectOutput"
        Me.btn_selectOutput.Size = New System.Drawing.Size(23, 23)
        Me.btn_selectOutput.TabIndex = 30
        Me.btn_selectOutput.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Output layer activation function"
        '
        'combo_outputLayerAF
        '
        Me.combo_outputLayerAF.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.SetColumnSpan(Me.combo_outputLayerAF, 3)
        Me.combo_outputLayerAF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_outputLayerAF.FormattingEnabled = True
        Me.combo_outputLayerAF.Location = New System.Drawing.Point(163, 58)
        Me.combo_outputLayerAF.Name = "combo_outputLayerAF"
        Me.combo_outputLayerAF.Size = New System.Drawing.Size(167, 21)
        Me.combo_outputLayerAF.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(605, 227)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.TableLayoutPanel5.SetRowSpan(Me.Button1, 4)
        Me.Button1.Size = New System.Drawing.Size(123, 82)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "TRAIN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NETWORK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(576, 258)
        Me.Label11.Name = "Label11"
        Me.TableLayoutPanel5.SetRowSpan(Me.Label11, 4)
        Me.Label11.Size = New System.Drawing.Size(24, 21)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "→"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tp_calculation
        '
        Me.tp_calculation.BackColor = System.Drawing.SystemColors.Control
        Me.tp_calculation.Controls.Add(Me.tlp_calculateDataSet)
        Me.tp_calculation.Controls.Add(Me.gb_calcMode)
        Me.tp_calculation.Controls.Add(Me.tlp_calculateExample)
        Me.tp_calculation.Controls.Add(Me.btn_loadNetwork)
        Me.tp_calculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_calculation.Location = New System.Drawing.Point(4, 22)
        Me.tp_calculation.Name = "tp_calculation"
        Me.tp_calculation.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_calculation.Size = New System.Drawing.Size(739, 542)
        Me.tp_calculation.TabIndex = 1
        Me.tp_calculation.Text = "CALCULATION MODE"
        '
        'tlp_calculateDataSet
        '
        Me.tlp_calculateDataSet.AutoSize = True
        Me.tlp_calculateDataSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlp_calculateDataSet.ColumnCount = 1
        Me.tlp_calculateDataSet.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_calculateDataSet.Controls.Add(Me.btn_calcDataSet, 0, 2)
        Me.tlp_calculateDataSet.Controls.Add(Me.GroupBox6, 0, 1)
        Me.tlp_calculateDataSet.Controls.Add(Me.GroupBox5, 0, 0)
        Me.tlp_calculateDataSet.Location = New System.Drawing.Point(12, 312)
        Me.tlp_calculateDataSet.Name = "tlp_calculateDataSet"
        Me.tlp_calculateDataSet.Padding = New System.Windows.Forms.Padding(0, 0, 0, 19)
        Me.tlp_calculateDataSet.RowCount = 3
        Me.tlp_calculateDataSet.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_calculateDataSet.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_calculateDataSet.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_calculateDataSet.Size = New System.Drawing.Size(573, 192)
        Me.tlp_calculateDataSet.TabIndex = 6
        Me.tlp_calculateDataSet.Visible = False
        '
        'btn_calcDataSet
        '
        Me.btn_calcDataSet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_calcDataSet.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcDataSet.Location = New System.Drawing.Point(238, 161)
        Me.btn_calcDataSet.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btn_calcDataSet.MinimumSize = New System.Drawing.Size(97, 23)
        Me.btn_calcDataSet.Name = "btn_calcDataSet"
        Me.btn_calcDataSet.Size = New System.Drawing.Size(97, 23)
        Me.btn_calcDataSet.TabIndex = 33
        Me.btn_calcDataSet.Text = "CALCULATE"
        Me.btn_calcDataSet.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSize = True
        Me.GroupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox6.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(3, 86)
        Me.GroupBox6.MinimumSize = New System.Drawing.Size(567, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(567, 64)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "OUTPUT"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.AutoSize = True
        Me.TableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.tb_calcOutputDataSet, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_outputDataSet, 1, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(561, 42)
        Me.TableLayoutPanel8.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.TableLayoutPanel8.SetColumnSpan(Me.Label15, 2)
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(426, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Select the file path and name where the output from the neural network should be " & _
    "saved."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_calcOutputDataSet
        '
        Me.tb_calcOutputDataSet.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_calcOutputDataSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_calcOutputDataSet.Location = New System.Drawing.Point(3, 17)
        Me.tb_calcOutputDataSet.Name = "tb_calcOutputDataSet"
        Me.tb_calcOutputDataSet.Size = New System.Drawing.Size(521, 20)
        Me.tb_calcOutputDataSet.TabIndex = 9
        '
        'btn_outputDataSet
        '
        Me.btn_outputDataSet.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_outputDataSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_outputDataSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_outputDataSet.Image = Global.NeuralNetwork.My.Resources.Resources.openfolder
        Me.btn_outputDataSet.Location = New System.Drawing.Point(530, 16)
        Me.btn_outputDataSet.Name = "btn_outputDataSet"
        Me.btn_outputDataSet.Size = New System.Drawing.Size(23, 23)
        Me.btn_outputDataSet.TabIndex = 10
        Me.btn_outputDataSet.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSize = True
        Me.GroupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.MinimumSize = New System.Drawing.Size(567, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(567, 77)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "INPUT"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.AutoSize = True
        Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.tb_calcInputDataSet, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.btn_iputDataSet, 1, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(561, 55)
        Me.TableLayoutPanel7.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.TableLayoutPanel7.SetColumnSpan(Me.Label14, 2)
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(369, 26)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Select csv file containing raw input data." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The file should not have any headers." & _
    " Each row represents one set of inputs."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_calcInputDataSet
        '
        Me.tb_calcInputDataSet.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb_calcInputDataSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_calcInputDataSet.Location = New System.Drawing.Point(3, 30)
        Me.tb_calcInputDataSet.Name = "tb_calcInputDataSet"
        Me.tb_calcInputDataSet.Size = New System.Drawing.Size(521, 20)
        Me.tb_calcInputDataSet.TabIndex = 9
        '
        'btn_iputDataSet
        '
        Me.btn_iputDataSet.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_iputDataSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_iputDataSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iputDataSet.Image = Global.NeuralNetwork.My.Resources.Resources.openfolder
        Me.btn_iputDataSet.Location = New System.Drawing.Point(530, 29)
        Me.btn_iputDataSet.Name = "btn_iputDataSet"
        Me.btn_iputDataSet.Size = New System.Drawing.Size(23, 23)
        Me.btn_iputDataSet.TabIndex = 10
        Me.btn_iputDataSet.UseVisualStyleBackColor = True
        '
        'gb_calcMode
        '
        Me.gb_calcMode.Controls.Add(Me.rd_calcDataSet)
        Me.gb_calcMode.Controls.Add(Me.rd_calcExample)
        Me.gb_calcMode.Location = New System.Drawing.Point(6, 61)
        Me.gb_calcMode.Name = "gb_calcMode"
        Me.gb_calcMode.Size = New System.Drawing.Size(196, 50)
        Me.gb_calcMode.TabIndex = 5
        Me.gb_calcMode.TabStop = False
        Me.gb_calcMode.Text = "CALCULATION MODE"
        Me.gb_calcMode.Visible = False
        '
        'rd_calcDataSet
        '
        Me.rd_calcDataSet.AutoSize = True
        Me.rd_calcDataSet.Location = New System.Drawing.Point(121, 19)
        Me.rd_calcDataSet.Name = "rd_calcDataSet"
        Me.rd_calcDataSet.Size = New System.Drawing.Size(65, 17)
        Me.rd_calcDataSet.TabIndex = 1
        Me.rd_calcDataSet.TabStop = True
        Me.rd_calcDataSet.Text = "Data set"
        Me.rd_calcDataSet.UseVisualStyleBackColor = True
        '
        'rd_calcExample
        '
        Me.rd_calcExample.AutoSize = True
        Me.rd_calcExample.Location = New System.Drawing.Point(6, 19)
        Me.rd_calcExample.Name = "rd_calcExample"
        Me.rd_calcExample.Size = New System.Drawing.Size(96, 17)
        Me.rd_calcExample.TabIndex = 0
        Me.rd_calcExample.TabStop = True
        Me.rd_calcExample.Text = "Single example"
        Me.rd_calcExample.UseVisualStyleBackColor = True
        '
        'tlp_calculateExample
        '
        Me.tlp_calculateExample.AutoSize = True
        Me.tlp_calculateExample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlp_calculateExample.ColumnCount = 5
        Me.tlp_calculateExample.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_calculateExample.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_calculateExample.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_calculateExample.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_calculateExample.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_calculateExample.Controls.Add(Me.Label13, 1, 1)
        Me.tlp_calculateExample.Controls.Add(Me.Label3, 3, 1)
        Me.tlp_calculateExample.Controls.Add(Me.tb_calcInputExample, 0, 0)
        Me.tlp_calculateExample.Controls.Add(Me.tb_calcOutputExample, 4, 0)
        Me.tlp_calculateExample.Controls.Add(Me.btn_calculateExample, 2, 1)
        Me.tlp_calculateExample.Location = New System.Drawing.Point(12, 117)
        Me.tlp_calculateExample.Name = "tlp_calculateExample"
        Me.tlp_calculateExample.RowCount = 3
        Me.tlp_calculateExample.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_calculateExample.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_calculateExample.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_calculateExample.Size = New System.Drawing.Size(515, 236)
        Me.tlp_calculateExample.TabIndex = 4
        Me.tlp_calculateExample.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(179, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 21)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "→"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "→"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_calcInputExample
        '
        Me.tb_calcInputExample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_calcInputExample.Location = New System.Drawing.Point(3, 3)
        Me.tb_calcInputExample.MaximumSize = New System.Drawing.Size(170, 230)
        Me.tb_calcInputExample.MinimumSize = New System.Drawing.Size(170, 230)
        Me.tb_calcInputExample.Multiline = True
        Me.tb_calcInputExample.Name = "tb_calcInputExample"
        Me.tlp_calculateExample.SetRowSpan(Me.tb_calcInputExample, 3)
        Me.tb_calcInputExample.Size = New System.Drawing.Size(170, 230)
        Me.tb_calcInputExample.TabIndex = 1
        Me.tb_calcInputExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_calcOutputExample
        '
        Me.tb_calcOutputExample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_calcOutputExample.Location = New System.Drawing.Point(342, 3)
        Me.tb_calcOutputExample.MaximumSize = New System.Drawing.Size(170, 230)
        Me.tb_calcOutputExample.MinimumSize = New System.Drawing.Size(170, 230)
        Me.tb_calcOutputExample.Multiline = True
        Me.tb_calcOutputExample.Name = "tb_calcOutputExample"
        Me.tb_calcOutputExample.ReadOnly = True
        Me.tlp_calculateExample.SetRowSpan(Me.tb_calcOutputExample, 3)
        Me.tb_calcOutputExample.Size = New System.Drawing.Size(170, 230)
        Me.tb_calcOutputExample.TabIndex = 2
        Me.tb_calcOutputExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_calculateExample
        '
        Me.btn_calculateExample.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculateExample.Location = New System.Drawing.Point(209, 106)
        Me.btn_calculateExample.Name = "btn_calculateExample"
        Me.btn_calculateExample.Size = New System.Drawing.Size(97, 23)
        Me.btn_calculateExample.TabIndex = 3
        Me.btn_calculateExample.Text = "CALCULATE"
        Me.btn_calculateExample.UseVisualStyleBackColor = True
        '
        'btn_loadNetwork
        '
        Me.btn_loadNetwork.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_loadNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_loadNetwork.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_loadNetwork.Location = New System.Drawing.Point(6, 6)
        Me.btn_loadNetwork.Name = "btn_loadNetwork"
        Me.btn_loadNetwork.Size = New System.Drawing.Size(113, 49)
        Me.btn_loadNetwork.TabIndex = 0
        Me.btn_loadNetwork.Text = "LOAD NEURAL NETWORK"
        Me.btn_loadNetwork.UseVisualStyleBackColor = False
        '
        'chart_error
        '
        Me.chart_error.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea_big"
        Me.chart_error.ChartAreas.Add(ChartArea1)
        Me.TableLayoutPanel6.SetColumnSpan(Me.chart_error, 2)
        Me.chart_error.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Enabled = False
        Legend1.Name = "Legend_big"
        Me.chart_error.Legends.Add(Legend1)
        Me.chart_error.Location = New System.Drawing.Point(3, 3)
        Me.chart_error.Name = "chart_error"
        Series2.ChartArea = "ChartArea_big"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend_big"
        Series2.Name = "Series_output1"
        Series2.YValuesPerPoint = 6
        Me.chart_error.Series.Add(Series2)
        Me.chart_error.Size = New System.Drawing.Size(469, 320)
        Me.chart_error.TabIndex = 26
        Me.chart_error.Text = "Network error (RMSE)"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "title_big"
        Title2.Text = "Network error (RMSE)"
        Me.chart_error.Titles.Add(Title2)
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = True
        Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.Controls.Add(Me.chart_errorSecondary, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.chart_error, 0, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(475, 539)
        Me.TableLayoutPanel6.TabIndex = 30
        '
        'chart_errorSecondary
        '
        Me.chart_errorSecondary.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea_secondary"
        Me.chart_errorSecondary.ChartAreas.Add(ChartArea2)
        Me.TableLayoutPanel6.SetColumnSpan(Me.chart_errorSecondary, 2)
        Me.chart_errorSecondary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chart_errorSecondary.Location = New System.Drawing.Point(3, 329)
        Me.chart_errorSecondary.Name = "chart_errorSecondary"
        Series1.ChartArea = "ChartArea_secondary"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Name = "Series_secondary_1"
        Series1.YValuesPerPoint = 6
        Me.chart_errorSecondary.Series.Add(Series1)
        Me.chart_errorSecondary.Size = New System.Drawing.Size(469, 207)
        Me.chart_errorSecondary.TabIndex = 29
        Me.chart_errorSecondary.Text = "Network error (RMSE)"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title_secondary"
        Title1.Text = "Network error (RMSE)"
        Me.chart_errorSecondary.Titles.Add(Title1)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Network error (RMSE):"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_currentError
        '
        Me.lb_currentError.AutoSize = True
        Me.lb_currentError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_currentError.Location = New System.Drawing.Point(3, 39)
        Me.lb_currentError.Name = "lb_currentError"
        Me.lb_currentError.Size = New System.Drawing.Size(135, 13)
        Me.lb_currentError.TabIndex = 32
        Me.lb_currentError.Text = "it num"
        Me.lb_currentError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_charts
        '
        Me.panel_charts.AutoSize = True
        Me.panel_charts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_charts.Controls.Add(Me.TableLayoutPanel6)
        Me.panel_charts.Location = New System.Drawing.Point(765, 32)
        Me.panel_charts.Name = "panel_charts"
        Me.panel_charts.Size = New System.Drawing.Size(483, 547)
        Me.panel_charts.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Iteration number:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_iterationNum
        '
        Me.lb_iterationNum.AutoSize = True
        Me.lb_iterationNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_iterationNum.Location = New System.Drawing.Point(3, 13)
        Me.lb_iterationNum.Name = "lb_iterationNum"
        Me.lb_iterationNum.Size = New System.Drawing.Size(135, 13)
        Me.lb_iterationNum.TabIndex = 35
        Me.lb_iterationNum.Text = "it num"
        Me.lb_iterationNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_stats
        '
        Me.panel_stats.AutoSize = True
        Me.panel_stats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel_stats.ColumnCount = 1
        Me.panel_stats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panel_stats.Controls.Add(Me.lb_currentError, 0, 3)
        Me.panel_stats.Controls.Add(Me.Label12, 0, 2)
        Me.panel_stats.Controls.Add(Me.lb_iterationNum, 0, 1)
        Me.panel_stats.Controls.Add(Me.Label5, 0, 0)
        Me.panel_stats.Location = New System.Drawing.Point(613, 524)
        Me.panel_stats.Name = "panel_stats"
        Me.panel_stats.RowCount = 4
        Me.panel_stats.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_stats.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_stats.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_stats.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panel_stats.Size = New System.Drawing.Size(141, 52)
        Me.panel_stats.TabIndex = 37
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xml"
        Me.SaveFileDialog1.Filter = "xml files|*.xml|All files|*.*"
        Me.SaveFileDialog1.Title = "Save neural network file"
        '
        'ToolTip_RoT
        '
        Me.ToolTip_RoT.AutoPopDelay = 5000
        Me.ToolTip_RoT.InitialDelay = 200
        Me.ToolTip_RoT.ReshowDelay = 100
        Me.ToolTip_RoT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip_RoT.ToolTipTitle = "Rules of thumb"
        '
        'form_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.panel_stats)
        Me.Controls.Add(Me.panel_charts)
        Me.Controls.Add(Me.tc_modes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "form_main"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artificial Neural Network:  Backpropagation with momentum"
        Me.tc_modes.ResumeLayout(False)
        Me.tp_training.ResumeLayout(False)
        Me.tp_training.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tlp_advancedSettings.ResumeLayout(False)
        Me.tlp_advancedSettings.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tp_calculation.ResumeLayout(False)
        Me.tp_calculation.PerformLayout()
        Me.tlp_calculateDataSet.ResumeLayout(False)
        Me.tlp_calculateDataSet.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.gb_calcMode.ResumeLayout(False)
        Me.gb_calcMode.PerformLayout()
        Me.tlp_calculateExample.ResumeLayout(False)
        Me.tlp_calculateExample.PerformLayout()
        CType(Me.chart_error, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.chart_errorSecondary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_charts.ResumeLayout(False)
        Me.panel_charts.PerformLayout()
        Me.panel_stats.ResumeLayout(False)
        Me.panel_stats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tc_modes As System.Windows.Forms.TabControl
    Friend WithEvents tp_training As System.Windows.Forms.TabPage
    Friend WithEvents chart_error As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tp_calculation As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_selectInput As System.Windows.Forms.Button
    Friend WithEvents tb_input As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_addRow As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_outputLayerAF As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_output As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_selectOutput As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents HiddenLayerNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLayerNeuronCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLayerActivationFunction As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents tb_momentum As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_learningRate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chk_updateBias As System.Windows.Forms.CheckBox
    Friend WithEvents tb_graphSecondaryPoints As System.Windows.Forms.TextBox
    Friend WithEvents lb_graphSecondary As System.Windows.Forms.Label
    Friend WithEvents chk_showGraph As System.Windows.Forms.CheckBox
    Friend WithEvents tlp_advancedSettings As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tb_maxEpochs As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_maxError As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lb_currentError As System.Windows.Forms.Label
    Friend WithEvents panel_charts As System.Windows.Forms.Panel
    Friend WithEvents lb_biasNotice As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_iterationNum As System.Windows.Forms.Label
    Friend WithEvents chart_errorSecondary As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents panel_stats As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_loadNetwork As System.Windows.Forms.Button
    Friend WithEvents tlp_calculateExample As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tb_calcInputExample As System.Windows.Forms.TextBox
    Friend WithEvents tb_calcOutputExample As System.Windows.Forms.TextBox
    Friend WithEvents btn_calculateExample As System.Windows.Forms.Button
    Friend WithEvents gb_calcMode As System.Windows.Forms.GroupBox
    Friend WithEvents rd_calcDataSet As System.Windows.Forms.RadioButton
    Friend WithEvents rd_calcExample As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tlp_calculateDataSet As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tb_calcOutputDataSet As System.Windows.Forms.TextBox
    Friend WithEvents btn_outputDataSet As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_calcInputDataSet As System.Windows.Forms.TextBox
    Friend WithEvents btn_iputDataSet As System.Windows.Forms.Button
    Friend WithEvents btn_calcDataSet As System.Windows.Forms.Button
    Friend WithEvents ToolTip_RoT As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_deleteRow As System.Windows.Forms.Button

End Class
