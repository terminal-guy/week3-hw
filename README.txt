Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    End
End Sub

Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
    Dim score = CType(txtScore.Text, Integer)
    lblGrade.BackColor = Color.LightGreen

    If (score >= 90) Then
        lblGrade.Text = "A+"
        MessageBox.Show("Congratulations!!", "MyStudentGrader")
    ElseIf (score >= 80) Then
        lblGrade.Text = "A"
    ElseIf (score >= 70) Then
        lblGrade.Text = "B"
    ElseIf (score >= 60) Then
        lblGrade.Text = "C"
    Else
        lblGrade.Text = "F"
        lblGrade.BackColor = Color.IndianRed
    End If
End Sub


Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
    Dim score = CType(txtScore.Text, Integer)
    lblGrade.BackColor = Color.LightGreen

    Select Case score
        Case Is >= 90
            lblGrade.Text = "A+"
            MessageBox.Show("Congratulations!!", "MyStudentGrader")
        Case Is >= 80
            lblGrade.Text = "A"
        Case Is >= 70
            lblGrade.Text = "B"
        Case Is >= 60
            lblGrade.Text = "C"
        Case Else
            lblGrade.Text = "F"
            lblGrade.BackColor = Color.IndianRed
    End Select
End Sub
