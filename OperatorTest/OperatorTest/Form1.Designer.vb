<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperator
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
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.lblEqual = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnGreaterThan = New System.Windows.Forms.Button()
        Me.btnGreaterThanEqual = New System.Windows.Forms.Button()
        Me.btnLessThan = New System.Windows.Forms.Button()
        Me.btnLessThanEqual = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnNotEqual = New System.Windows.Forms.Button()
        Me.btnLike = New System.Windows.Forms.Button()
        Me.btnIs = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOperand1
        '
        Me.txtOperand1.Location = New System.Drawing.Point(152, 83)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(100, 25)
        Me.txtOperand1.TabIndex = 0
        Me.txtOperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOperator
        '
        Me.lblOperator.BackColor = System.Drawing.SystemColors.Control
        Me.lblOperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOperator.Location = New System.Drawing.Point(275, 82)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(53, 23)
        Me.lblOperator.TabIndex = 1
        Me.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOperand2
        '
        Me.txtOperand2.Location = New System.Drawing.Point(360, 83)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(100, 25)
        Me.txtOperand2.TabIndex = 2
        Me.txtOperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEqual
        '
        Me.lblEqual.BackColor = System.Drawing.SystemColors.Control
        Me.lblEqual.Location = New System.Drawing.Point(466, 85)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(72, 23)
        Me.lblEqual.TabIndex = 3
        Me.lblEqual.Text = "="
        Me.lblEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.Control
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(531, 85)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(244, 148)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(30, 30)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(244, 199)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(30, 30)
        Me.btnMinus.TabIndex = 6
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(244, 248)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(30, 30)
        Me.btnMultiply.TabIndex = 7
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(244, 303)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(30, 30)
        Me.btnDivide.TabIndex = 8
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnGreaterThan
        '
        Me.btnGreaterThan.Location = New System.Drawing.Point(302, 148)
        Me.btnGreaterThan.Name = "btnGreaterThan"
        Me.btnGreaterThan.Size = New System.Drawing.Size(60, 30)
        Me.btnGreaterThan.TabIndex = 9
        Me.btnGreaterThan.Text = ">"
        Me.btnGreaterThan.UseVisualStyleBackColor = True
        '
        'btnGreaterThanEqual
        '
        Me.btnGreaterThanEqual.Location = New System.Drawing.Point(302, 199)
        Me.btnGreaterThanEqual.Name = "btnGreaterThanEqual"
        Me.btnGreaterThanEqual.Size = New System.Drawing.Size(60, 30)
        Me.btnGreaterThanEqual.TabIndex = 10
        Me.btnGreaterThanEqual.Text = ">="
        Me.btnGreaterThanEqual.UseVisualStyleBackColor = True
        '
        'btnLessThan
        '
        Me.btnLessThan.Location = New System.Drawing.Point(302, 248)
        Me.btnLessThan.Name = "btnLessThan"
        Me.btnLessThan.Size = New System.Drawing.Size(60, 30)
        Me.btnLessThan.TabIndex = 11
        Me.btnLessThan.Text = "<"
        Me.btnLessThan.UseVisualStyleBackColor = True
        '
        'btnLessThanEqual
        '
        Me.btnLessThanEqual.Location = New System.Drawing.Point(302, 303)
        Me.btnLessThanEqual.Name = "btnLessThanEqual"
        Me.btnLessThanEqual.Size = New System.Drawing.Size(60, 30)
        Me.btnLessThanEqual.TabIndex = 12
        Me.btnLessThanEqual.Text = "<="
        Me.btnLessThanEqual.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(386, 148)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(60, 30)
        Me.btnEqual.TabIndex = 13
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'btnNotEqual
        '
        Me.btnNotEqual.Location = New System.Drawing.Point(386, 199)
        Me.btnNotEqual.Name = "btnNotEqual"
        Me.btnNotEqual.Size = New System.Drawing.Size(60, 30)
        Me.btnNotEqual.TabIndex = 14
        Me.btnNotEqual.Text = "<>"
        Me.btnNotEqual.UseVisualStyleBackColor = True
        '
        'btnLike
        '
        Me.btnLike.Location = New System.Drawing.Point(386, 248)
        Me.btnLike.Name = "btnLike"
        Me.btnLike.Size = New System.Drawing.Size(60, 30)
        Me.btnLike.TabIndex = 15
        Me.btnLike.Text = "Like"
        Me.btnLike.UseVisualStyleBackColor = True
        '
        'btnIs
        '
        Me.btnIs.Location = New System.Drawing.Point(386, 303)
        Me.btnIs.Name = "btnIs"
        Me.btnIs.Size = New System.Drawing.Size(60, 30)
        Me.btnIs.TabIndex = 16
        Me.btnIs.Text = "IS"
        Me.btnIs.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(488, 148)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 70)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(488, 237)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 70)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmOperator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnIs)
        Me.Controls.Add(Me.btnLike)
        Me.Controls.Add(Me.btnNotEqual)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnLessThanEqual)
        Me.Controls.Add(Me.btnLessThan)
        Me.Controls.Add(Me.btnGreaterThanEqual)
        Me.Controls.Add(Me.btnGreaterThan)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblEqual)
        Me.Controls.Add(Me.txtOperand2)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.txtOperand1)
        Me.Name = "frmOperator"
        Me.Text = "계산기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOperand1 As TextBox
    Friend WithEvents lblOperator As Label
    Friend WithEvents txtOperand2 As TextBox
    Friend WithEvents lblEqual As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnGreaterThan As Button
    Friend WithEvents btnGreaterThanEqual As Button
    Friend WithEvents btnLessThan As Button
    Friend WithEvents btnLessThanEqual As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnNotEqual As Button
    Friend WithEvents btnLike As Button
    Friend WithEvents btnIs As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
