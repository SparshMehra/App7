Imports System.Drawing.Text

Public Class Form1
    Dim ballXSpeed As Integer = 5
    Dim ballYSpeed As Integer = 5
    Dim playerScore As Integer = 0
    Dim computerScore As Integer = 0
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblComputerScore.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ball.Left += ballXSpeed
        ball.Top += ballYSpeed

        If ball.Top < 0 Or ball.Bottom > Me.ClientSize.Height Then
            ballYSpeed = -ballXSpeed
        End If
        If ball.Bounds.IntersectsWith(paddlePlayer.Bounds) Or ball.Bounds.IntersectsWith(paddleComputer.Bounds) Then
            ballXSpeed = -ballXSpeed
        End If
        If ball.Left < 0 Then
            computerScore += 1
            lblComputerScore.Text = playerScore.ToString()
            ResetBall()
        End If
        If ball.Right > Me.ClientSize.Width Then
            playerScore += 1
            lblPlayerScore.Text = playerScore.ToString()
            ResetBall()
        End If

        paddleComputer.Top = ball.Top - (paddleComputer.Height / 2)
        If playerScore = 5 Or computerScore = 5 Then
            Timer1.Stop()
            Dim winner As String
            If playerScore = 5 Then
                winner = "Player"
            Else
                winner = "Computer"
            End If
            Dim result = MessageBox.Show(winner And " Wins! Play Again?,Game Over", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    RestartGame()
                Else
                    Me.Close()
                End If
            End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W AndAlso paddlePlayer.Bottom < Me.ClientSize.Height Then
            paddlePlayer.Top += 10
        End If
    End Sub

    Private Sub ResetBall()
        ball.Left = Me.ClientSize.Width / 2 - ball.Width / 2
        ball.Top = Me.ClientSize.Height / 2 - ball.Height / 2
        ballXSpeed = -ballXSpeed
    End Sub
    Private Sub RestartGame()
        playerScore = 0
        computerScore = 0
        lblPlayerScore.Text = "0"
        lblComputerScore.Text = "0"
        ResetBall()
        Timer1.Start()
    End Sub

End Class
