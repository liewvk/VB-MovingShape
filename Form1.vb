Public Class Form1
    Dim enemyX As Integer = 150
    Dim enemyY As Integer = 20

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        enemyY += 5

        If enemyY > Me.ClientSize.Height Then
            enemyY = 0
        End If

        Me.Invalidate()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillEllipse(Brushes.Red, enemyX, enemyY, 30, 30)
    End Sub

End Class
