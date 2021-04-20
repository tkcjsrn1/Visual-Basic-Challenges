<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimer
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picTimer = New System.Windows.Forms.PictureBox()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTimer
        '
        Me.picTimer.Location = New System.Drawing.Point(198, 66)
        Me.picTimer.Name = "picTimer"
        Me.picTimer.Size = New System.Drawing.Size(428, 234)
        Me.picTimer.TabIndex = 0
        Me.picTimer.TabStop = False
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(333, 341)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(165, 53)
        Me.cmdStart.TabIndex = 1
        Me.cmdStart.Text = "Enabled=False"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.picTimer)
        Me.Name = "frmTimer"
        Me.Text = "타이머 이벤트 처리하기"
        CType(Me.picTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picTimer As PictureBox
    Friend WithEvents cmdStart As Button
    Friend WithEvents Timer1 As Timer
End Class
