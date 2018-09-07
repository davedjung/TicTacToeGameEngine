<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Conf
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbxBasic = New System.Windows.Forms.GroupBox()
        Me.rdbBasicOff = New System.Windows.Forms.RadioButton()
        Me.rdbBasicOn = New System.Windows.Forms.RadioButton()
        Me.gbxKeyLength = New System.Windows.Forms.GroupBox()
        Me.rdb18Inputs = New System.Windows.Forms.RadioButton()
        Me.rdb9Inputs = New System.Windows.Forms.RadioButton()
        Me.gbxMode = New System.Windows.Forms.GroupBox()
        Me.rdbAIX = New System.Windows.Forms.RadioButton()
        Me.rdbAIO = New System.Windows.Forms.RadioButton()
        Me.txtKeyPath = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbxKey = New System.Windows.Forms.GroupBox()
        Me.rdbKeyOff = New System.Windows.Forms.RadioButton()
        Me.rdbKeyOn = New System.Windows.Forms.RadioButton()
        Me.rdbVectorOff = New System.Windows.Forms.RadioButton()
        Me.rdbVectorOn = New System.Windows.Forms.RadioButton()
        Me.gbxVector = New System.Windows.Forms.GroupBox()
        Me.txtVectorPath = New System.Windows.Forms.TextBox()
        Me.txtVectorOutputPath = New System.Windows.Forms.TextBox()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.gbxBasic.SuspendLayout()
        Me.gbxKeyLength.SuspendLayout()
        Me.gbxMode.SuspendLayout()
        Me.gbxKey.SuspendLayout()
        Me.gbxVector.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxBasic
        '
        Me.gbxBasic.Controls.Add(Me.rdbBasicOff)
        Me.gbxBasic.Controls.Add(Me.rdbBasicOn)
        Me.gbxBasic.Location = New System.Drawing.Point(10, 10)
        Me.gbxBasic.Name = "gbxBasic"
        Me.gbxBasic.Size = New System.Drawing.Size(122, 69)
        Me.gbxBasic.TabIndex = 0
        Me.gbxBasic.TabStop = False
        Me.gbxBasic.Text = "BasicAI"
        '
        'rdbBasicOff
        '
        Me.rdbBasicOff.AutoSize = True
        Me.rdbBasicOff.Location = New System.Drawing.Point(6, 43)
        Me.rdbBasicOff.Name = "rdbBasicOff"
        Me.rdbBasicOff.Size = New System.Drawing.Size(73, 18)
        Me.rdbBasicOff.TabIndex = 1
        Me.rdbBasicOff.TabStop = True
        Me.rdbBasicOff.Text = "Disabled"
        Me.rdbBasicOff.UseVisualStyleBackColor = True
        '
        'rdbBasicOn
        '
        Me.rdbBasicOn.AutoSize = True
        Me.rdbBasicOn.Location = New System.Drawing.Point(6, 19)
        Me.rdbBasicOn.Name = "rdbBasicOn"
        Me.rdbBasicOn.Size = New System.Drawing.Size(71, 18)
        Me.rdbBasicOn.TabIndex = 0
        Me.rdbBasicOn.TabStop = True
        Me.rdbBasicOn.Text = "Enabled"
        Me.rdbBasicOn.UseVisualStyleBackColor = True
        '
        'gbxKeyLength
        '
        Me.gbxKeyLength.Controls.Add(Me.rdb18Inputs)
        Me.gbxKeyLength.Controls.Add(Me.rdb9Inputs)
        Me.gbxKeyLength.Location = New System.Drawing.Point(138, 10)
        Me.gbxKeyLength.Name = "gbxKeyLength"
        Me.gbxKeyLength.Size = New System.Drawing.Size(122, 69)
        Me.gbxKeyLength.TabIndex = 2
        Me.gbxKeyLength.TabStop = False
        Me.gbxKeyLength.Text = "Key Length"
        '
        'rdb18Inputs
        '
        Me.rdb18Inputs.AutoSize = True
        Me.rdb18Inputs.Location = New System.Drawing.Point(6, 43)
        Me.rdb18Inputs.Name = "rdb18Inputs"
        Me.rdb18Inputs.Size = New System.Drawing.Size(80, 18)
        Me.rdb18Inputs.TabIndex = 1
        Me.rdb18Inputs.TabStop = True
        Me.rdb18Inputs.Text = "18 Inputs"
        Me.rdb18Inputs.UseVisualStyleBackColor = True
        '
        'rdb9Inputs
        '
        Me.rdb9Inputs.AutoSize = True
        Me.rdb9Inputs.Location = New System.Drawing.Point(6, 19)
        Me.rdb9Inputs.Name = "rdb9Inputs"
        Me.rdb9Inputs.Size = New System.Drawing.Size(73, 18)
        Me.rdb9Inputs.TabIndex = 0
        Me.rdb9Inputs.TabStop = True
        Me.rdb9Inputs.Text = "9 Inputs"
        Me.rdb9Inputs.UseVisualStyleBackColor = True
        '
        'gbxMode
        '
        Me.gbxMode.Controls.Add(Me.rdbAIX)
        Me.gbxMode.Controls.Add(Me.rdbAIO)
        Me.gbxMode.Location = New System.Drawing.Point(138, 85)
        Me.gbxMode.Name = "gbxMode"
        Me.gbxMode.Size = New System.Drawing.Size(122, 69)
        Me.gbxMode.TabIndex = 4
        Me.gbxMode.TabStop = False
        Me.gbxMode.Text = "Game Mode"
        '
        'rdbAIX
        '
        Me.rdbAIX.AutoSize = True
        Me.rdbAIX.Location = New System.Drawing.Point(6, 43)
        Me.rdbAIX.Name = "rdbAIX"
        Me.rdbAIX.Size = New System.Drawing.Size(113, 18)
        Me.rdbAIX.TabIndex = 1
        Me.rdbAIX.TabStop = True
        Me.rdbAIX.Text = "Computer First"
        Me.rdbAIX.UseVisualStyleBackColor = True
        '
        'rdbAIO
        '
        Me.rdbAIO.AutoSize = True
        Me.rdbAIO.Location = New System.Drawing.Point(6, 19)
        Me.rdbAIO.Name = "rdbAIO"
        Me.rdbAIO.Size = New System.Drawing.Size(93, 18)
        Me.rdbAIO.TabIndex = 0
        Me.rdbAIO.TabStop = True
        Me.rdbAIO.Text = "Player First"
        Me.rdbAIO.UseVisualStyleBackColor = True
        '
        'txtKeyPath
        '
        Me.txtKeyPath.Location = New System.Drawing.Point(10, 160)
        Me.txtKeyPath.Name = "txtKeyPath"
        Me.txtKeyPath.Size = New System.Drawing.Size(250, 20)
        Me.txtKeyPath.TabIndex = 5
        Me.txtKeyPath.Text = "Path to Keys.txt"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(266, 160)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 72)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbxKey
        '
        Me.gbxKey.Controls.Add(Me.rdbKeyOff)
        Me.gbxKey.Controls.Add(Me.rdbKeyOn)
        Me.gbxKey.Location = New System.Drawing.Point(10, 85)
        Me.gbxKey.Name = "gbxKey"
        Me.gbxKey.Size = New System.Drawing.Size(122, 69)
        Me.gbxKey.TabIndex = 2
        Me.gbxKey.TabStop = False
        Me.gbxKey.Text = "Read Keys"
        '
        'rdbKeyOff
        '
        Me.rdbKeyOff.AutoSize = True
        Me.rdbKeyOff.Location = New System.Drawing.Point(6, 43)
        Me.rdbKeyOff.Name = "rdbKeyOff"
        Me.rdbKeyOff.Size = New System.Drawing.Size(73, 18)
        Me.rdbKeyOff.TabIndex = 1
        Me.rdbKeyOff.TabStop = True
        Me.rdbKeyOff.Text = "Disabled"
        Me.rdbKeyOff.UseVisualStyleBackColor = True
        '
        'rdbKeyOn
        '
        Me.rdbKeyOn.AutoSize = True
        Me.rdbKeyOn.Location = New System.Drawing.Point(6, 19)
        Me.rdbKeyOn.Name = "rdbKeyOn"
        Me.rdbKeyOn.Size = New System.Drawing.Size(71, 18)
        Me.rdbKeyOn.TabIndex = 0
        Me.rdbKeyOn.TabStop = True
        Me.rdbKeyOn.Text = "Enabled"
        Me.rdbKeyOn.UseVisualStyleBackColor = True
        '
        'rdbVectorOff
        '
        Me.rdbVectorOff.AutoSize = True
        Me.rdbVectorOff.Location = New System.Drawing.Point(6, 43)
        Me.rdbVectorOff.Name = "rdbVectorOff"
        Me.rdbVectorOff.Size = New System.Drawing.Size(73, 18)
        Me.rdbVectorOff.TabIndex = 1
        Me.rdbVectorOff.TabStop = True
        Me.rdbVectorOff.Text = "Disabled"
        Me.rdbVectorOff.UseVisualStyleBackColor = True
        '
        'rdbVectorOn
        '
        Me.rdbVectorOn.AutoSize = True
        Me.rdbVectorOn.Location = New System.Drawing.Point(6, 19)
        Me.rdbVectorOn.Name = "rdbVectorOn"
        Me.rdbVectorOn.Size = New System.Drawing.Size(71, 18)
        Me.rdbVectorOn.TabIndex = 0
        Me.rdbVectorOn.TabStop = True
        Me.rdbVectorOn.Text = "Enabled"
        Me.rdbVectorOn.UseVisualStyleBackColor = True
        '
        'gbxVector
        '
        Me.gbxVector.Controls.Add(Me.rdbVectorOff)
        Me.gbxVector.Controls.Add(Me.rdbVectorOn)
        Me.gbxVector.Location = New System.Drawing.Point(266, 10)
        Me.gbxVector.Name = "gbxVector"
        Me.gbxVector.Size = New System.Drawing.Size(122, 69)
        Me.gbxVector.TabIndex = 3
        Me.gbxVector.TabStop = False
        Me.gbxVector.Text = "Generate Vectors"
        '
        'txtVectorPath
        '
        Me.txtVectorPath.Location = New System.Drawing.Point(10, 186)
        Me.txtVectorPath.Name = "txtVectorPath"
        Me.txtVectorPath.Size = New System.Drawing.Size(250, 20)
        Me.txtVectorPath.TabIndex = 7
        Me.txtVectorPath.Text = "Path to Vector.txt"
        '
        'txtVectorOutputPath
        '
        Me.txtVectorOutputPath.Location = New System.Drawing.Point(10, 212)
        Me.txtVectorOutputPath.Name = "txtVectorOutputPath"
        Me.txtVectorOutputPath.Size = New System.Drawing.Size(250, 20)
        Me.txtVectorOutputPath.TabIndex = 8
        Me.txtVectorOutputPath.Text = "Path to Ultimate_Vector.txt"
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(266, 85)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(122, 69)
        Me.btnDefault.TabIndex = 9
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'Conf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 245)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.txtVectorOutputPath)
        Me.Controls.Add(Me.txtVectorPath)
        Me.Controls.Add(Me.gbxVector)
        Me.Controls.Add(Me.gbxKey)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtKeyPath)
        Me.Controls.Add(Me.gbxMode)
        Me.Controls.Add(Me.gbxKeyLength)
        Me.Controls.Add(Me.gbxBasic)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Conf"
        Me.Text = "Configuration"
        Me.gbxBasic.ResumeLayout(False)
        Me.gbxBasic.PerformLayout()
        Me.gbxKeyLength.ResumeLayout(False)
        Me.gbxKeyLength.PerformLayout()
        Me.gbxMode.ResumeLayout(False)
        Me.gbxMode.PerformLayout()
        Me.gbxKey.ResumeLayout(False)
        Me.gbxKey.PerformLayout()
        Me.gbxVector.ResumeLayout(False)
        Me.gbxVector.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxBasic As GroupBox
    Friend WithEvents rdbBasicOff As RadioButton
    Friend WithEvents rdbBasicOn As RadioButton
    Friend WithEvents gbxKeyLength As GroupBox
    Friend WithEvents rdb18Inputs As RadioButton
    Friend WithEvents rdb9Inputs As RadioButton
    Friend WithEvents gbxMode As GroupBox
    Friend WithEvents rdbAIX As RadioButton
    Friend WithEvents rdbAIO As RadioButton
    Friend WithEvents txtKeyPath As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents gbxKey As GroupBox
    Friend WithEvents rdbKeyOff As RadioButton
    Friend WithEvents rdbKeyOn As RadioButton
    Friend WithEvents rdbVectorOff As RadioButton
    Friend WithEvents rdbVectorOn As RadioButton
    Friend WithEvents gbxVector As GroupBox
    Friend WithEvents txtVectorPath As TextBox
    Friend WithEvents txtVectorOutputPath As TextBox
    Friend WithEvents btnDefault As Button
End Class
