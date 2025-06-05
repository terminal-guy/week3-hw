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

    ' First, we cache the current action (later, we may do statistics).
    Me.CurrentState = action

    ' Finally, we return the current action to the point of call.
    Return action
End Function
