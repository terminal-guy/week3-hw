Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim principal As Double
        Dim ratepercentage As Double
        Dim time As Double
        Dim myformat As String = "$#,##0.00"

        If Not Double.TryParse(txtRate.Text, ratepercentage) Then
            MessageBox.Show("Please enter a interest Rate in %")
            Exit Sub
        End If

        If Not Double.TryParse(txtPrincipal.Text, principal) Then
            MessageBox.Show("Please enter a numerical value for principal amount")
            Exit Sub
        End If

        If Not Double.TryParse(txtTime.Text, time) Then
            MessageBox.Show("Please enter valid number for years")
            Exit Sub
        End If


        Dim rate As Double = ratepercentage / 100



        Dim interest As Double = principal * (1 + rate) ^ time
        lblresult.Text = Format(interest, myformat)
    End Sub
End Class
