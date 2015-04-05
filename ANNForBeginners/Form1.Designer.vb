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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_addRow = New System.Windows.Forms.Button()
        Me.tb_numOutputs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_output = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_learningMode = New System.Windows.Forms.CheckBox()
        Me.HiddenLayerNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerNeuronCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLayerActivationFunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Size = New System.Drawing.Size(332, 150)
        Me.DataGridView1.TabIndex = 8
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
        Me.HiddenLayerActivationFunction.Items.AddRange(New Object() {"item 1", "item 2"})
        Me.HiddenLayerActivationFunction.Name = "HiddenLayerActivationFunction"
        Me.HiddenLayerActivationFunction.Width = 94
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 378)
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

End Class
