<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicColor
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
        Me.picColor = New System.Windows.Forms.PictureBox()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.NumericRed = New System.Windows.Forms.NumericUpDown()
        Me.NumericGreen = New System.Windows.Forms.NumericUpDown()
        Me.NumericBlue = New System.Windows.Forms.NumericUpDown()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picColor
        '
        Me.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor.Location = New System.Drawing.Point(49, 116)
        Me.picColor.Name = "picColor"
        Me.picColor.Size = New System.Drawing.Size(277, 227)
        Me.picColor.TabIndex = 0
        Me.picColor.TabStop = False
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Location = New System.Drawing.Point(397, 148)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(47, 15)
        Me.lblRed.TabIndex = 1
        Me.lblRed.Text = "빨강 :"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Location = New System.Drawing.Point(397, 215)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(47, 15)
        Me.lblGreen.TabIndex = 2
        Me.lblGreen.Text = "초록 :"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Location = New System.Drawing.Point(397, 282)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(47, 15)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "파랑 :"
        '
        'NumericRed
        '
        Me.NumericRed.Location = New System.Drawing.Point(503, 138)
        Me.NumericRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericRed.Name = "NumericRed"
        Me.NumericRed.Size = New System.Drawing.Size(177, 25)
        Me.NumericRed.TabIndex = 4
        '
        'NumericGreen
        '
        Me.NumericGreen.Location = New System.Drawing.Point(503, 204)
        Me.NumericGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericGreen.Name = "NumericGreen"
        Me.NumericGreen.Size = New System.Drawing.Size(177, 25)
        Me.NumericGreen.TabIndex = 5
        '
        'NumericBlue
        '
        Me.NumericBlue.Location = New System.Drawing.Point(503, 282)
        Me.NumericBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericBlue.Name = "NumericBlue"
        Me.NumericBlue.Size = New System.Drawing.Size(177, 25)
        Me.NumericBlue.TabIndex = 6
        '
        'frmPicColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumericBlue)
        Me.Controls.Add(Me.NumericGreen)
        Me.Controls.Add(Me.NumericRed)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.picColor)
        Me.Name = "frmPicColor"
        Me.Text = "도형 색 변경하기"
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picColor As PictureBox
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents NumericRed As Windows.Forms.NumericUpDown
    Friend WithEvents NumericGreen As Windows.Forms.NumericUpDown
    Friend WithEvents NumericBlue As Windows.Forms.NumericUpDown
End Class
