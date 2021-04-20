<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDomainUpDown
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblUpDown = New System.Windows.Forms.Label()
        Me.upDownList = New System.Windows.Forms.DomainUpDown()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblSelectedList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUpDown
        '
        Me.lblUpDown.AutoSize = True
        Me.lblUpDown.Location = New System.Drawing.Point(99, 107)
        Me.lblUpDown.Name = "lblUpDown"
        Me.lblUpDown.Size = New System.Drawing.Size(132, 15)
        Me.lblUpDown.TabIndex = 0
        Me.lblUpDown.Text = "목록을 선택하세요"
        '
        'upDownList
        '
        Me.upDownList.Items.Add("Visual Basic 2013")
        Me.upDownList.Items.Add("Visual C#")
        Me.upDownList.Items.Add("Visual C++")
        Me.upDownList.Items.Add("Visual J++")
        Me.upDownList.Location = New System.Drawing.Point(102, 155)
        Me.upDownList.Name = "upDownList"
        Me.upDownList.Size = New System.Drawing.Size(454, 25)
        Me.upDownList.TabIndex = 1
        Me.upDownList.Text = "항목을 선택하세요"
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(102, 230)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(112, 15)
        Me.lblSelected.TabIndex = 2
        Me.lblSelected.Text = "선택한 항목은 :"
        '
        'lblSelectedList
        '
        Me.lblSelectedList.Location = New System.Drawing.Point(278, 230)
        Me.lblSelectedList.Name = "lblSelectedList"
        Me.lblSelectedList.Size = New System.Drawing.Size(100, 23)
        Me.lblSelectedList.TabIndex = 3
        Me.lblSelectedList.Text = " """""
        '
        'frmDomainUpDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSelectedList)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.upDownList)
        Me.Controls.Add(Me.lblUpDown)
        Me.Name = "frmDomainUpDown"
        Me.Text = "도메인업다운 컨트롤 사용하기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUpDown As Label
    Friend WithEvents upDownList As Windows.Forms.DomainUpDown
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSelectedList As Label
End Class
