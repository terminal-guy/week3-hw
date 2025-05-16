Public Class Form1

    Dim lastScore As Integer


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
        Dim score = CType(txtScore.Text, Integer)
        lblResult.BackColor = Color.LightGreen

        If (score >= 90) Then
            lblResult.Text = "A+"
            MessageBox.Show("Congratulations!!", "MyStudentGrader")
        ElseIf (score >= 80) Then
            lblResult.Text = "A"
        ElseIf (score >= 70) Then
            lblResult.Text = "B"
        ElseIf (score >= 60) Then
            lblResult.Text = "C"
        Else
            lblResult.Text = "F"
            lblResult.BackColor = Color.IndianRed
        End If
    End Sub


    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
        Dim score = CType(txtScore.Text, Integer)
        lblResult.BackColor = Color.LightGreen

        Select Case score
            Case Is >= 90
                lblResult.Text = "A+"
                MessageBox.Show("Congratulations!!", "MyStudentGrader")
            Case Is >= 80
                lblResult.Text = "A"
            Case Is >= 70
                lblResult.Text = "B"
            Case Is >= 60
                lblResult.Text = "C"
            Case Else
                lblResult.Text = "F"
                lblResult.BackColor = Color.IndianRed
        End Select
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub






End Class
