<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIfThen
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
        Me.lblKor = New System.Windows.Forms.Label()
        Me.lblEng = New System.Windows.Forms.Label()
        Me.lblMath = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAberage = New System.Windows.Forms.Label()
        Me.txtKor = New System.Windows.Forms.TextBox()
        Me.txtEng = New System.Windows.Forms.TextBox()
        Me.txtMath = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblGradeDisp = New System.Windows.Forms.Label()
        Me.cmdCaculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKor
        '
        Me.lblKor.AutoSize = True
        Me.lblKor.Location = New System.Drawing.Point(134, 120)
        Me.lblKor.Name = "lblKor"
        Me.lblKor.Size = New System.Drawing.Size(47, 15)
        Me.lblKor.TabIndex = 0
        Me.lblKor.Text = "국어 :"
        '
        'lblEng
        '
        Me.lblEng.AutoSize = True
        Me.lblEng.Location = New System.Drawing.Point(134, 157)
        Me.lblEng.Name = "lblEng"
        Me.lblEng.Size = New System.Drawing.Size(47, 15)
        Me.lblEng.TabIndex = 1
        Me.lblEng.Text = "영어 :"
        '
        'lblMath
        '
        Me.lblMath.AutoSize = True
        Me.lblMath.Location = New System.Drawing.Point(134, 194)
        Me.lblMath.Name = "lblMath"
        Me.lblMath.Size = New System.Drawing.Size(47, 15)
        Me.lblMath.TabIndex = 2
        Me.lblMath.Text = "수학 :"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(134, 236)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 15)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "총점 :"
        '
        'lblAberage
        '
        Me.lblAberage.AutoSize = True
        Me.lblAberage.Location = New System.Drawing.Point(134, 273)
        Me.lblAberage.Name = "lblAberage"
        Me.lblAberage.Size = New System.Drawing.Size(47, 15)
        Me.lblAberage.TabIndex = 4
        Me.lblAberage.Text = "평균 :"
        '
        'txtKor
        '
        Me.txtKor.Location = New System.Drawing.Point(203, 117)
        Me.txtKor.Name = "txtKor"
        Me.txtKor.Size = New System.Drawing.Size(153, 25)
        Me.txtKor.TabIndex = 5
        '
        'txtEng
        '
        Me.txtEng.Location = New System.Drawing.Point(203, 157)
        Me.txtEng.Name = "txtEng"
        Me.txtEng.Size = New System.Drawing.Size(153, 25)
        Me.txtEng.TabIndex = 6
        '
        'txtMath
        '
        Me.txtMath.Location = New System.Drawing.Point(203, 194)
        Me.txtMath.Name = "txtMath"
        Me.txtMath.Size = New System.Drawing.Size(153, 25)
        Me.txtMath.TabIndex = 7
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(203, 233)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(153, 25)
        Me.txtTotal.TabIndex = 8
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(203, 267)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(153, 25)
        Me.txtAverage.TabIndex = 9
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(450, 197)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(47, 15)
        Me.lblGrade.TabIndex = 10
        Me.lblGrade.Text = "등급 :"
        '
        'lblGradeDisp
        '
        Me.lblGradeDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeDisp.Location = New System.Drawing.Point(519, 183)
        Me.lblGradeDisp.Name = "lblGradeDisp"
        Me.lblGradeDisp.Padding = New System.Windows.Forms.Padding(5)
        Me.lblGradeDisp.Size = New System.Drawing.Size(100, 43)
        Me.lblGradeDisp.TabIndex = 11
        '
        'cmdCaculate
        '
        Me.cmdCaculate.Location = New System.Drawing.Point(244, 323)
        Me.cmdCaculate.Name = "cmdCaculate"
        Me.cmdCaculate.Size = New System.Drawing.Size(93, 23)
        Me.cmdCaculate.TabIndex = 12
        Me.cmdCaculate.TabStop = False
        Me.cmdCaculate.Text = "계산하기"
        Me.cmdCaculate.UseVisualStyleBackColor = True
        '
        'frmIfThen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdCaculate)
        Me.Controls.Add(Me.lblGradeDisp)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtMath)
        Me.Controls.Add(Me.txtEng)
        Me.Controls.Add(Me.txtKor)
        Me.Controls.Add(Me.lblAberage)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblMath)
        Me.Controls.Add(Me.lblEng)
        Me.Controls.Add(Me.lblKor)
        Me.Name = "frmIfThen"
        Me.Text = "IF~THEN문 사용하기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKor As Label
    Friend WithEvents lblEng As Label
    Friend WithEvents lblMath As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAberage As Label
    Friend WithEvents txtKor As TextBox
    Friend WithEvents txtEng As TextBox
    Friend WithEvents txtMath As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblGradeDisp As Label
    Friend WithEvents cmdCaculate As Button
End Class
