Private Sub btnGCD_Click(sender As Object, e As EventArgs) Handles btnGCD.Click
    Dim a As Integer = Val(txtA.Text)
    Dim b As Integer = Val(txtB.Text)
    Dim cycle As Integer = 0

    lstData.Items.Clear()
    lstData.Items.Add("Your Name - Your ID") ' Replace with your actual name and ID

    Do While b <> 0
        cycle += 1
        If a > b Then
            a = a - b
        Else
            b = b - a
        End If
        lstData.Items.Add("Cycle " & cycle & ": A = " & a & ", B = " & b)
    Loop

    lstData.Items.Add("Converged!")
    lstData.Items.Add("GCD = " & a)
End Sub


        lstData.Items.Add("After Cycle [" & cycle & "]: (a = " & a & ", b = " & b & ")")
