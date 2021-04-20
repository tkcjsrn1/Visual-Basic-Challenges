Public Class frmTimer
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = False
    End Sub

    Private Sub TimerEnabled_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        If cmdStart.Text = "Stop" Then
            cmdStart.Text = "Start"
            Timer1.Enabled = False
        Else
            cmdStart.Text = "Stop"
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If picTimer.BackColor = Color.Red Then
            picTimer.BackColor = Color.Blue
        Else
            picTimer.BackColor = Color.Red
        End If

    End Sub

    Private Sub picTimer_Click(sender As Object, e As EventArgs) Handles picTimer.Click

    End Sub
End Class
