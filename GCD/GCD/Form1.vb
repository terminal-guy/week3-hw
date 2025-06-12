Public Class Form1
    Private Sub btnGO_Click(sender As Object, e As EventArgs)

        For i As Integer = 0 To 10 Step 1
            Dim myString As String = "I'm item " & i & "in the list!"
            lstData.Items.Add(myString)
        Next

    End Sub

    Private Sub btnGo_Click_1(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim a As Integer = Val(txtbtn1.Text)
        Dim b As Integer = Val(txtbtn2.Text)
        Dim cycle As Integer = 0

        lstData.Items.Add(">>> Intermediates shown below:")

        Do While b <> 0
            cycle += 1
            If a > b Then
                a = a - b
            Else
                b = b - a
            End If
            lstData.Items.Add("After Cycle [" & cycle & "]: (a = " & a & ", b = " & b & ")")
        Loop

        lstData.Items.Add("Converged!")
        txtGCD.Text = a.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtGCD.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
