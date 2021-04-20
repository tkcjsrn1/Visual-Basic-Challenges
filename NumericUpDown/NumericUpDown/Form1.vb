Public Class frmPicColor

    Private Sub NumericRed_Changed(sender As Object, e As EventArgs) Handles NumericRed.ValueChanged
        picColor.BackColor = Color.FromArgb(255, NumericRed.Value, NumericGreen.Value, NumericBlue.Value)
    End Sub
    Private Sub NumericGreen_Changed(sender As Object, e As EventArgs) Handles NumericGreen.ValueChanged
        picColor.BackColor = Color.FromArgb(255, NumericRed.Value, NumericGreen.Value, NumericBlue.Value)
    End Sub

    Private Sub NumericBlue_Changed(sender As Object, e As EventArgs) Handles NumericBlue.ValueChanged
        picColor.BackColor = Color.FromArgb(255, NumericRed.Value, NumericGreen.Value, NumericBlue.Value)
    End Sub
End Class
