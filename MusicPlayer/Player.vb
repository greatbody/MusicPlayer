Imports SunSoftUtility
Imports System.Threading

Public Class Player
    Dim _timedPlayer As Audio
    Private Const PosInterver = 100
    Private _mPlayThread As Thread
    Private _bKeepPlay As Boolean = True
#Region "控件事件代码"
    ''' <summary>
    ''' 启动、重置按钮控制
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInitAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitAuto.Click
        Dim obj As New Object
        If btnInitAuto.Text = "启动" Then
            If txtFilePath.Text.Length > 0 Then
                _timedPlayer = New Audio(txtFilePath.Text)
                '设置进度条
                With ProgressBar1
                    .Minimum = 0
                    .Maximum = CInt(_timedPlayer.Length / 1000)
                End With
                If Not _mPlayThread Is Nothing AndAlso _mPlayThread.ThreadState <> ThreadState.Aborted Then
                    _mPlayThread.Abort()
                End If
                _mPlayThread = New Thread(AddressOf AutoPlay)
                _mPlayThread.Start(DateTimePicker1.Value)
                btnInitAuto.Text = "重置"
                btnChooseFile.Enabled = False
                SyncLock obj
                    _bKeepPlay = True
                End SyncLock

            Else
                MsgBox("请选择音乐文件！")
                Exit Sub
            End If
        Else

            SyncLock obj
                _bKeepPlay = False
            End SyncLock
            btnInitAuto.Text = "启动"
            lblPosition.Text = "--:--:--"
            ProgressBar1.Value = 0
            '文件选择解锁
            btnChooseFile.Enabled = True
        End If

    End Sub
    ''' <summary>
    ''' 选择文件按钮控制
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFile.Click
        txtFilePath.Text = FileSystem.SelectFiles("请选择一个音乐文件")
    End Sub
    ''' <summary>
    ''' 窗口关闭前操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Player_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    ''' <summary>
    ''' 窗口初始化操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Player_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        Call (New Thread(AddressOf UpdateTimeDisplay)).Start()
    End Sub
#End Region

#Region "线程函数"
    Private Sub AutoPlay(ByVal BeginTime As Date)
        Dim i As Integer = 0
        Dim volume As Integer = 0

        BeginTime = BeginTime.AddSeconds(_timedPlayer.Length / 1000 * -1)
        While True
            Application.DoEvents()
            Thread.Sleep(PosInterver)
            Select Case i
                Case 0
                    If BeginTime < Now Then
                        _timedPlayer.Play()
                        _timedPlayer.Volume = 0
                        i = 1
                    End If
                Case 1
                    If volume < 1000 Then
                        volume += CInt(PosInterver / 8)
                        _timedPlayer.Volume = volume
                    Else
                        i = 2
                        Console.WriteLine("log finish")
                    End If
            End Select
            Console.WriteLine(_bKeepPlay)
            If _bKeepPlay = False Then
                _timedPlayer.Pause()
                Exit Sub
            End If
            Invoke(New VSetProgress(AddressOf SetProgress), CInt(_timedPlayer.Position / 1000))
            Invoke(New VSetPositionString(AddressOf SetPositionString), _timedPlayer.CurrentPos)
        End While
    End Sub

    Private Sub UpdateTimeDisplay()
        While True
            Invoke(New VSetPositionString(AddressOf SetTimeString), Format(Now, "yyyy-MM-dd HH:mm:ss"))
            Application.DoEvents()
            Thread.Sleep(250)
        End While

    End Sub
#End Region

#Region "委托-窗体控件操作"
    Delegate Sub VSetProgress(ByVal Value As Integer)
    Public Sub SetProgress(ByVal Value As Integer)
        ProgressBar1.Value = Value
        Console.WriteLine(Value)
    End Sub

    Delegate Sub VSetPositionString(ByVal s As String)
    Public Sub SetPositionString(ByVal Position As String)
        lblPosition.Text = Position
    End Sub
    Public Sub SetTimeString(ByVal CurTime As String)
        lblNow.Text = CurTime
    End Sub
#End Region


End Class
