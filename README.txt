Public Class Form1

    ' === Class-level variable ===
    Dim lastScore As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set button background colors (as per slides)
        btnIfThen.BackColor = Color.LightBlue
        btnIfThen.ForeColor = Color.Black

        btnSelectCase.BackColor = Color.LightGreen
        btnSelectCase.ForeColor = Color.Black

        btnExit.BackColor = Color.IndianRed
        btnExit.ForeColor = Color.White
    End Sub

    Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
        ' === Method-level variables ===
        Dim score As Integer = CType(txtScore.Text, Integer)
        Dim message As String

        ' === Block-level variable ===
        Dim grade As String

        lastScore = score ' Save to class-level variable

        ' === If...Then...ElseIf...Else structure ===
        If (score >= 95) Then
            grade = "A+"
            MessageBox.Show("Excellent! You got an A+")
        ElseIf (score >= 90) Then
            grade = "A"
        ElseIf (score >= 80) Then
            grade = "B"
        ElseIf (score >= 70) Then
            grade = "C"
        ElseIf (score >= 60) Then
            grade = "D"
        Else
            grade = "F"
        End If

        message = "Grade: " & grade
        lblResult.Text = message
    End Sub

    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
        ' === Method-level variables ===
        Dim score As Integer = CType(txtScore.Text, Integer)
        Dim message As String

        ' === Block-level variable ===
        Dim grade As String

        lastScore = score ' Save to class-level variable

        ' === Select Case structure ===
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

        message = "Grade: " & grade
        lblResult.Text = message
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
