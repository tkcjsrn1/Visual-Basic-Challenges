Public Class frmIfThen
    Private Sub lblGrade_Click(sender As Object, e As EventArgs) Handles lblGrade.Click

    End Sub

    Private Sub cmdCaculate_Click(sender As Object, e As EventArgs) Handles cmdCaculate.Click
        Dim Kor, Eng, Mat, Total As Double
        Dim Aver, Average As Double
        Kor = Val(txtKor.Text)
        Eng = Val(txtEng.Text)
        Mat = Val(txtMath.Text)
        Total = Kor + Eng + Mat
        Aver = Total / 3
        Average = Math.Round(Aver, 2)
        If Average >= 90 Then
            lblGradeDisp.Text = "A"
        ElseIf Average >= 80 Then
            lblGradeDisp.Text = "B"
        ElseIf Average >= 70 Then
            lblGradeDisp.Text = "C"
        Else
            lblGradeDisp.Text = "F"
        End If

    End Sub
End Class
