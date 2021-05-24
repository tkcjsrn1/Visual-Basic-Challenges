Public Class frmRichText
    Private Sub frmRichText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 8 To 50 Step 2
            cboFontSize.Items.Add(i)
        Next
        coboFontColor.Items.Add("빨강")
        coboFontColor.Items.Add("파랑")
        coboFontColor.Items.Add("노랑")
        coboFontColor.Items.Add("다홍")
        coboFontColor.Items.Add("보라")
        coboFontColor.Items.Add("초록")
        cboFontSize.Text = "글꼴 선택"
        cboFontSize.Text = "크기 선택"
        coboFontColor.Text = "색 선택"

    End Sub

    Private Sub cboFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFontSize.SelectedIndexChanged
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSansSerif,
        Val(cboFontSize.Text))

    End Sub

    Private Sub cboFontColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coboFontColor.SelectedIndexChanged
        RichTextBox1.SelectAll()
        Select Case coboFontColor.SelectedIndex
            Case 0
                RichTextBox1.SelectionColor = Color.Red
            Case 1
                RichTextBox1.SelectionColor = Color.Blue
            Case 2
                RichTextBox1.SelectionColor = Color.Yellow
            Case 3
                RichTextBox1.SelectionColor = Color.Magenta
            Case 4
                RichTextBox1.SelectionColor = Color.Purple
            Case 5
                RichTextBox1.SelectionColor = Color.Green
        End Select
    End Sub

    Private Sub optBold_CheckedChanged(sender As Object, e As EventArgs) Handles optBold.CheckedChanged
        Dim sizeFont As Integer
        sizeFont = Val(cboFontSize.Text)
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, sizeFont,
        FontStyle.Bold)
    End Sub

    Private Sub optItalic_CheckedChanged(sender As Object, e As EventArgs) Handles optItalic.CheckedChanged
        Dim sizeFont As Integer
        sizeFont = Val(cboFontSize.Text)
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, sizeFont,
        FontStyle.Italic)
    End Sub

    Private Sub optStrikeThru_CheckedChanged(sender As Object, e As EventArgs) Handles optStrikeThru.CheckedChanged
        Dim sizeFont As Integer
        sizeFont = Val(cboFontSize.Text)
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, sizeFont,
        FontStyle.Strikeout)
    End Sub

    Private Sub optUnderline_CheckedChanged(sender As Object, e As EventArgs) Handles optUnderline.CheckedChanged
        Dim sizeFont As Integer
        sizeFont = Val(cboFontSize.Text)
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, sizeFont,
        FontStyle.Underline)
    End Sub
End Class
