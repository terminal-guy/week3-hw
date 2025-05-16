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



Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
    Dim score As Integer = Val(txtScore.Text)
    Dim grade As String

    Select Case score
        Case Is >= 95
            grade = "A+"
            MessageBox.Show("Excellent! You got an A+")
        Case 90 To 94
            grade = "A"
        Case 80 To 89
            grade = "B"
        Case 70 To 79
            grade = "C"
        Case 60 To 69
            grade = "D"
        Case Else
            grade = "F"
    End Select

    lblResult.Text = "Grade: " & grade
End Sub


Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Me.Close()
End Sub



