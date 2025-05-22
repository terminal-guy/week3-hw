Private Sub ComputeValues()
    Dim height As Double = Val(txtHeight.Text)
    Dim weight As Double = Val(txtWeight.Text)

    If height > 0 AndAlso weight > 0 Then
        Dim height_m As Double = height / 100
        Dim bmi As Double = weight / (height_m ^ 2)
        Dim stdWeight As Double = (height - 100) * 0.9

        lblBMI.Text = Format(bmi, "0.0")
        lblStdWeight.Text = Format(stdWeight, "0.0")

        If bmi < 18.5 Then
            lblStatus.Text = "Underweight"
        ElseIf bmi < 25 Then
            lblStatus.Text = "Normal"
        Else
            lblStatus.Text = "Overweight"
        End If
    Else
        lblBMI.Text = ""
        lblStdWeight.Text = ""
        lblStatus.Text = "Undetermined"
    End If
End Sub
