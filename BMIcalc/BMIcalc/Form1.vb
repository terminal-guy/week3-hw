Public Class Form1






    Private Sub ComputeValues()
        Dim height As Double = Val(txtheight.Text)
        Dim weight As Double = Val(txtweight.Text)

        If height > 0 AndAlso weight > 0 Then
            Dim height_m As Double = height / 100
            Dim bmi As Double = weight / (height_m ^ 2)
            Dim stdWeight As Double = (height - 100) * 0.9

            txtbmi.Text = Format(bmi, "0.0")
            txtstdweight.Text = Format(stdWeight, "0.0")

            If bmi < 18.5 Then
                lblStatus.Text = "Underweight"
                lblStatus.BackColor = Color.Lavender
            ElseIf bmi < 25 Then
                lblStatus.Text = "Normal Weight"
                lblStatus.BackColor = Color.LightBlue
            Else
                lblStatus.Text = "Obese"
                lblStatus.BackColor = Color.Red
            End If
        Else
            txtbmi.Text = ""
            txtstdweight.Text = ""
            lblStatus.Text = "Undetermined"
            lblStatus.BackColor = Color.Aqua
        End If

    End Sub



    Private Sub txtheight_TextChanged(sender As Object, e As EventArgs) Handles txtheight.TextChanged
        ComputeValues()
    End Sub

    Private Sub txtweight_TextChanged(sender As Object, e As EventArgs) Handles txtweight.TextChanged
        ComputeValues()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        MessageBox.Show("Goodbye", "Vishal Adhithya APU")
    End Sub
End Class


