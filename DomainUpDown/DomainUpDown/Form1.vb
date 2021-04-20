Public Class frmDomainUpDown
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub lblSelectedList_Click(sender As Object, e As EventArgs) Handles lblSelectedList.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblUpDown_Click(sender As Object, e As EventArgs) Handles lblUpDown.Click

    End Sub

    Private Sub upDownList_Changed(sender As Object, e As EventArgs) Handles upDownList.SelectedItemChanged
        Select Case upDownList.SelectedIndex
            Case 0
                lblSelectedList.Text = upDownList.SelectedItem.ToString()
            Case 1
                lblSelectedList.Text = upDownList.SelectedItem.ToString()
            Case 2
                lblSelectedList.Text = upDownList.SelectedItem.ToString()
            Case 3
                lblSelectedList.Text = upDownList.SelectedItem.ToString()
        End Select
    End Sub
End Class
