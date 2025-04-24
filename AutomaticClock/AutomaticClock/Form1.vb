Public Class Form1

    Private Counter As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Int(Rnd() * 10)
        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)

    End Sub

    Private Sub btnCatch_Click(sender As Object, e As EventArgs) Handles btnCatch.Click

        Dim X, Y, Z As Integer

        Timer1.Enabled = False


        X = Label1.Text
        Y = Label2.Text
        Z = Label3.Text

        If (X = Y) Or (X = Z) Or (Y = Z) Then
            Beep()
            Label4.Text = "You win!"
            PictureBox1.Visible = True
        End If
    End Sub



    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Label4.Text = ""
        PictureBox1.Visible = False
        Timer1.Enabled = True
        Counter = Counter + 1

    End Sub

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        MessageBox.Show("You had " & Counter & " Wins!")
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
