# week3-hw


Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
    Dim score As Integer = Val(txtScore.Text)
    Dim grade As String

    If score >= 90 Then
        grade = "A"
        If score >= 95 Then
            MessageBox.Show("Excellent! You got an A+")
        End If
    ElseIf score >= 80 Then
        grade = "B"
    ElseIf score >= 70 Then
        grade = "C"
    ElseIf score >= 60 Then
        grade = "D"
    Else
        grade = "F"
    End If

    lblResult.Text = "Grade: " & grade
End Sub


Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Me.Close()
End Sub



