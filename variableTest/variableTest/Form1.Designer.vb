<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataType
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
        Me.lblKor = New System.Windows.Forms.Label()
        Me.lblMath = New System.Windows.Forms.Label()
        Me.lblEng = New System.Windows.Forms.Label()
        Me.txtKor = New System.Windows.Forms.TextBox()
        Me.txtMath = New System.Windows.Forms.TextBox()
        Me.txtEng = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdSum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKor
        '
        Me.lblKor.AutoSize = True
        Me.lblKor.Location = New System.Drawing.Point(142, 130)
        Me.lblKor.Name = "lblKor"
        Me.lblKor.Size = New System.Drawing.Size(47, 15)
        Me.lblKor.TabIndex = 0
        Me.lblKor.Text = "국어 :"
        '
        'lblMath
        '
        Me.lblMath.AutoSize = True
        Me.lblMath.Location = New System.Drawing.Point(142, 199)
        Me.lblMath.Name = "lblMath"
        Me.lblMath.Size = New System.Drawing.Size(47, 15)
        Me.lblMath.TabIndex = 1
        Me.lblMath.Text = "수학 :"
        '
        'lblEng
        '
        Me.lblEng.AutoSize = True
        Me.lblEng.Location = New System.Drawing.Point(142, 269)
        Me.lblEng.Name = "lblEng"
        Me.lblEng.Size = New System.Drawing.Size(47, 15)
        Me.lblEng.TabIndex = 2
        Me.lblEng.Text = "영어 :"
        '
        'txtKor
        '
        Me.txtKor.Location = New System.Drawing.Point(275, 127)
        Me.txtKor.Name = "txtKor"
        Me.txtKor.Size = New System.Drawing.Size(133, 25)
        Me.txtKor.TabIndex = 3
        '
        'txtMath
        '
        Me.txtMath.Location = New System.Drawing.Point(275, 199)
        Me.txtMath.Name = "txtMath"
        Me.txtMath.Size = New System.Drawing.Size(133, 25)
        Me.txtMath.TabIndex = 4
        '
        'txtEng
        '
        Me.txtEng.Location = New System.Drawing.Point(275, 269)
        Me.txtEng.Name = "txtEng"
        Me.txtEng.Size = New System.Drawing.Size(133, 25)
        Me.txtEng.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(182, 334)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(157, 15)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "세 과목 점수의 합계는"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(357, 333)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(15, 15)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "0"
        '
        'cmdSum
        '
        Me.cmdSum.Location = New System.Drawing.Point(500, 199)
        Me.cmdSum.Name = "cmdSum"
        Me.cmdSum.Size = New System.Drawing.Size(75, 23)
        Me.cmdSum.TabIndex = 8
        Me.cmdSum.Text = "계산"
        Me.cmdSum.UseVisualStyleBackColor = True
        '
        'frmDataType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdSum)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtEng)
        Me.Controls.Add(Me.txtMath)
        Me.Controls.Add(Me.txtKor)
        Me.Controls.Add(Me.lblEng)
        Me.Controls.Add(Me.lblMath)
        Me.Controls.Add(Me.lblKor)
        Me.Name = "frmDataType"
        Me.Text = "데이터 타입 바꾸기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKor As Label
    Friend WithEvents lblMath As Label
    Friend WithEvents lblEng As Label
    Friend WithEvents txtKor As TextBox
    Friend WithEvents txtMath As TextBox
    Friend WithEvents txtEng As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdSum As Button
End Class
