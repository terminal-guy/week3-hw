Public Class Form1

    ' Declare the array at class-level so it's accessible across methods
    Dim friends() As String = {"Fred", "Betty", "Barney", "Dino", "Tralfaz"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Resize and add your name
        ReDim Preserve friends(5)
        friends(5) = "YourName_12345678" ' ← Replace with your actual name and ID
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Clear the list first
        lstFriends.Items.Clear()

        ' Call sorting and displaying subroutine
        SortAndDisplay(friends)
    End Sub

    ' Subroutine to sort and display the array
    Private Sub SortAndDisplay(ByVal temp As String())
        Array.Sort(temp)
        For Each friendName As String In temp
            lstFriends.Items.Add(friendName)
        Next
    End Sub

    ' Exit button logic
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Thank you!" & vbCrLf & "Name: YourName" & vbCrLf & "ID: 12345678")
        Me.Close()
    End Sub
End Class
