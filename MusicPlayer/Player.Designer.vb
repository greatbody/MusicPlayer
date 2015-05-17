<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Player))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnInitAuto = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnChooseFile = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblNowTime = New System.Windows.Forms.Label()
        Me.lblNow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(134, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'btnInitAuto
        '
        Me.btnInitAuto.Location = New System.Drawing.Point(236, 5)
        Me.btnInitAuto.Name = "btnInitAuto"
        Me.btnInitAuto.Size = New System.Drawing.Size(68, 26)
        Me.btnInitAuto.TabIndex = 1
        Me.btnInitAuto.Text = "启动"
        Me.btnInitAuto.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.HideSelection = False
        Me.txtFilePath.Location = New System.Drawing.Point(15, 73)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(493, 21)
        Me.txtFilePath.TabIndex = 2
        '
        'btnChooseFile
        '
        Me.btnChooseFile.Location = New System.Drawing.Point(448, 5)
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.Size = New System.Drawing.Size(64, 26)
        Me.btnChooseFile.TabIndex = 3
        Me.btnChooseFile.Text = "选择文件"
        Me.btnChooseFile.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 103)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(493, 25)
        Me.ProgressBar1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "播放开始时间"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(328, 16)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(53, 12)
        Me.lblPosition.TabIndex = 7
        Me.lblPosition.Text = "--:--:--"
        '
        'lblNowTime
        '
        Me.lblNowTime.AutoSize = True
        Me.lblNowTime.Location = New System.Drawing.Point(13, 45)
        Me.lblNowTime.Name = "lblNowTime"
        Me.lblNowTime.Size = New System.Drawing.Size(53, 12)
        Me.lblNowTime.TabIndex = 8
        Me.lblNowTime.Text = "当前时间"
        '
        'lblNow
        '
        Me.lblNow.AutoSize = True
        Me.lblNow.Location = New System.Drawing.Point(72, 45)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(0, 12)
        Me.lblNow.TabIndex = 9
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 140)
        Me.Controls.Add(Me.lblNow)
        Me.Controls.Add(Me.lblNowTime)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnChooseFile)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.btnInitAuto)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Player"
        Me.Text = "音乐播放器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInitAuto As System.Windows.Forms.Button
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnChooseFile As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblNowTime As System.Windows.Forms.Label
    Friend WithEvents lblNow As System.Windows.Forms.Label

End Class
