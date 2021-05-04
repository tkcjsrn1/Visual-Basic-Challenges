Public Class frmDataType
    Private Sub sum_Click(sender As Object, e As EventArgs) Handles cmdSum.Click
        Dim Kor, Mat, Eng, Total As Integer
        Kor = Val(txtKor.Text)
        Mat = Val(txtMath.Text)
        Eng = Val(txtEng.Text)
        Total = Kor + Mat + Eng
        lblOutput.Text = Str(Total)
    End Sub
End Class
