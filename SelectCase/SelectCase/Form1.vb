Public Class frmIfThen
    Private Sub cmdCaculate_Click(sender As Object, e As EventArgs) Handles cmdCaculate.Click
        Dim Kor, Eng, Mat, Total As Integer
        Dim Aver, Average As Double
        Kor = Val(txtKor.Text)
        Eng = Val(txtEng.Text)
        Mat = Val(txtMath.Text)
        Total = Kor + Eng + Mat
        Aver = Total / 3
        Average = Math.Round(Aver, 2)
        Select Case Average
            Case 90 To 100
                lblGradeDisp.Text = "A"
            Case 80 To 89.99
                lblGradeDisp.Text = "B"
            Case 70 To 79.99
                lblGradeDisp.Text = "C"
            Case Else
                lblGradeDisp.Text = "F"
        End Select
    End Sub
End Class
