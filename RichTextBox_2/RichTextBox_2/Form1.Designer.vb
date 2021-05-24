<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRichText
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
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.cboFontSize = New System.Windows.Forms.ComboBox()
        Me.lblFontColor = New System.Windows.Forms.Label()
        Me.coboFontColor = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox = New System.Windows.Forms.GroupBox()
        Me.optUnderline = New System.Windows.Forms.RadioButton()
        Me.optStrikeThru = New System.Windows.Forms.RadioButton()
        Me.optItalic = New System.Windows.Forms.RadioButton()
        Me.optBold = New System.Windows.Forms.RadioButton()
        Me.RichTextBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(47, 44)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(82, 15)
        Me.lblFontSize.TabIndex = 0
        Me.lblFontSize.Text = "글꼴 크기 :"
        '
        'cboFontSize
        '
        Me.cboFontSize.FormattingEnabled = True
        Me.cboFontSize.Location = New System.Drawing.Point(50, 73)
        Me.cboFontSize.Name = "cboFontSize"
        Me.cboFontSize.Size = New System.Drawing.Size(142, 23)
        Me.cboFontSize.TabIndex = 1
        '
        'lblFontColor
        '
        Me.lblFontColor.AutoSize = True
        Me.lblFontColor.Location = New System.Drawing.Point(47, 114)
        Me.lblFontColor.Name = "lblFontColor"
        Me.lblFontColor.Size = New System.Drawing.Size(62, 15)
        Me.lblFontColor.TabIndex = 2
        Me.lblFontColor.Text = "글꼴 색:"
        '
        'coboFontColor
        '
        Me.coboFontColor.FormattingEnabled = True
        Me.coboFontColor.Location = New System.Drawing.Point(50, 142)
        Me.coboFontColor.Name = "coboFontColor"
        Me.coboFontColor.Size = New System.Drawing.Size(142, 23)
        Me.coboFontColor.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(269, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(477, 401)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox
        '
        Me.RichTextBox.Controls.Add(Me.optUnderline)
        Me.RichTextBox.Controls.Add(Me.optStrikeThru)
        Me.RichTextBox.Controls.Add(Me.optItalic)
        Me.RichTextBox.Controls.Add(Me.optBold)
        Me.RichTextBox.Location = New System.Drawing.Point(26, 199)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(213, 216)
        Me.RichTextBox.TabIndex = 5
        Me.RichTextBox.TabStop = False
        Me.RichTextBox.Text = "속성"
        '
        'optUnderline
        '
        Me.optUnderline.AutoSize = True
        Me.optUnderline.Location = New System.Drawing.Point(46, 153)
        Me.optUnderline.Name = "optUnderline"
        Me.optUnderline.Size = New System.Drawing.Size(58, 19)
        Me.optUnderline.TabIndex = 3
        Me.optUnderline.TabStop = True
        Me.optUnderline.Text = "밑줄"
        Me.optUnderline.UseVisualStyleBackColor = True
        '
        'optStrikeThru
        '
        Me.optStrikeThru.AutoSize = True
        Me.optStrikeThru.Location = New System.Drawing.Point(46, 116)
        Me.optStrikeThru.Name = "optStrikeThru"
        Me.optStrikeThru.Size = New System.Drawing.Size(73, 19)
        Me.optStrikeThru.TabIndex = 2
        Me.optStrikeThru.TabStop = True
        Me.optStrikeThru.Text = "취소선"
        Me.optStrikeThru.UseVisualStyleBackColor = True
        '
        'optItalic
        '
        Me.optItalic.AutoSize = True
        Me.optItalic.Location = New System.Drawing.Point(46, 76)
        Me.optItalic.Name = "optItalic"
        Me.optItalic.Size = New System.Drawing.Size(88, 19)
        Me.optItalic.TabIndex = 1
        Me.optItalic.TabStop = True
        Me.optItalic.Text = "이탤릭체"
        Me.optItalic.UseVisualStyleBackColor = True
        '
        'optBold
        '
        Me.optBold.AutoSize = True
        Me.optBold.Location = New System.Drawing.Point(46, 39)
        Me.optBold.Name = "optBold"
        Me.optBold.Size = New System.Drawing.Size(58, 19)
        Me.optBold.TabIndex = 0
        Me.optBold.TabStop = True
        Me.optBold.Text = "굵게"
        Me.optBold.UseVisualStyleBackColor = True
        '
        'frmRichText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.coboFontColor)
        Me.Controls.Add(Me.lblFontColor)
        Me.Controls.Add(Me.cboFontSize)
        Me.Controls.Add(Me.lblFontSize)
        Me.Name = "frmRichText"
        Me.Text = "글꼴 속성 적용하기"
        Me.RichTextBox.ResumeLayout(False)
        Me.RichTextBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFontSize As Label
    Friend WithEvents cboFontSize As ComboBox
    Friend WithEvents lblFontColor As Label
    Friend WithEvents coboFontColor As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox As GroupBox
    Friend WithEvents optStrikeThru As RadioButton
    Friend WithEvents optItalic As RadioButton
    Friend WithEvents optBold As RadioButton
    Friend WithEvents optUnderline As RadioButton
End Class
