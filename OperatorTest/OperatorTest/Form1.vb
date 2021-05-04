Public Class frmOperator
    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Long
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)
        lblOperator.Text = btnPlus.Text
        iResult = iNum1 + iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Long
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)
        lblOperator.Text = btnMinus.Text
        iResult = iNum1 - iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Long
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)
        lblOperator.Text = btnMultiply.Text
        iResult = iNum1 * iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnDevide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Long
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)
        lblOperator.Text = btnDivide.Text
        iResult = iNum1 / iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnGreaterthan_Click(sender As Object, e As EventArgs) Handles btnGreaterThan.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Boolean
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)

        lblOperator.Text = btnGreaterThan.Text

        iResult = iNum1 > iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnGreaterThanEql_Click(sender As Object, e As EventArgs) Handles btnGreaterThanEqual.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Boolean
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)

        lblOperator.Text = btnGreaterThanEqual.Text

        iResult = iNum1 >= iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnLessThan_Click(sender As Object, e As EventArgs) Handles btnLessThan.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Boolean
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)

        lblOperator.Text = btnLessThan.Text

        iResult = iNum1 < iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnLessThanEqual_Click(sender As Object, e As EventArgs) Handles btnLessThanEqual.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Boolean
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)

        lblOperator.Text = btnLessThanEqual.Text

        iResult = iNum1 <= iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Boolean
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)

        lblOperator.Text = btnEqual.Text

        iResult = iNum1 = iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnNotEqual_Click(sender As Object, e As EventArgs) Handles btnNotEqual.Click
        Dim iNum1, iNum2 As Integer
        Dim iResult As Boolean
        iNum1 = CInt(txtOperand1.Text)
        iNum2 = CInt(txtOperand2.Text)

        lblOperator.Text = btnNotEqual.Text

        iResult = iNum1 <> iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnLike_Click(sender As Object, e As EventArgs) Handles btnLike.Click
        Dim iNum1, iNum2 As String
        Dim iResult As Boolean
        iNum1 = txtOperand1.Text
        iNum2 = txtOperand2.Text

        lblOperator.Text = btnLike.Text

        iResult = iNum1 Like iNum2
        lblResult.Text = iResult
    End Sub

    Private Sub btnIs_Click(sender As Object, e As EventArgs) Handles btnIs.Click
        Dim thisobject, thatObject As Object
        Dim iResult As Boolean

        thisobject = New System.Windows.Forms.TextBox
        thatObject = New System.Windows.Forms.Label

        txtOperand1.Text = "TextBox"
        txtOperand2.Text = "Label"

        lblOperator.Text = btnIs.Text
        iResult = thisobject Is thatObject

        lblResult.Text = iResult
    End Sub
End Class
