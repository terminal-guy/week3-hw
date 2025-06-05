Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblState.Click

    End Sub

    Public Property Hour As Integer
        Get
            Return trkHour.Value
        End Get
        Set(value As Integer)

            trkHour.Value = value

            Dim statusText As String
            statusText = "At " & value & ":00, Albert is " & PredictAction(value).ToString()

            Me.lblState.Text = statusText

        End Set
    End Property


    Public CurrentState As DayAction

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hour = Date.Now.Hour
    End Sub

    Private Sub trkHour_Scroll(sender As Object, e As EventArgs) Handles trkHour.Scroll
        Me.Hour = trkHour.Value
    End Sub



    Private Function PredictAction(ByVal time As Integer) As DayAction
        Dim action As DayAction

        Select Case time
            Case 0 To 6
                action = DayAction.Asleep
            Case 7
                action = DayAction.GettingReadyForWork
            Case 8
                action = DayAction.TravellingToWork
            Case 9 To 11, 13 To 17
                action = DayAction.AtWork
            Case 12
                action = DayAction.AtLunch
            Case 18
                action = DayAction.TravellingFromWork
            Case 19 To 21
                action = DayAction.RelaxingWithFriends
            Case Else
                action = DayAction.PreparingForSleep
        End Select

        Me.CurrentState = action

        Return action
    End Function




End Class


Public Enum DayAction As Integer
    Asleep = 0
    GettingReadyForWork = 1
    TravellingToWork = 2
    AtWork = 3
    AtLunch = 4
    TravellingFromWork = 5
    RelaxingWithFriends = 6
    PreparingForSleep = 7
End Enum



