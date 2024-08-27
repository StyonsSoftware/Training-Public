Imports Blackbaud.AppFx.Server

Public Class ConstituentInfoBoxViewDataFormUIModel
    Private _TimerTicks As Integer = 0
    Private Const _MaxTicks As Integer = 10

    Private Sub _anyuniquething_InvokeAction(sender As Object, e As InvokeActionEventArgs) Handles _anyuniquething.InvokeAction
        'this event fires every N seconds, where "N" is the interval on the timer

        'some ideas:
        '1) Just refresh the View form (firing it's SQL) every time the timer fires
        RefreshModel()

        '2) Check an endpoint for the current status, update this form based on that
        'Dim currentStatus = CurrentProcessStatus()
        'Select Case currentStatus
        '    Case "COMPLETE"
        '        _anyuniquething.Enabled = False
        '        MESSAGE.Value = "All done"
        'End Select

        '3) After a while, the timer turns itself off
        _TimerTicks += 1
        If _TimerTicks >= _MaxTicks Then
            _anyuniquething.Enabled = False
        End If
    End Sub

    Private Function CurrentProcessStatus() As String 'COMPLETE/INPROGRESS/FAILED/NONE
        Dim request As DataFormLoadRequest = New DataFormLoadRequest()
        request.FormID = New Guid("SOME_STATUS_VIEW_FORM")
        'request.RecordID = "optional record id"
        Dim reply As DataFormLoadReply = DataFormLoad(request, GetRequestContext())
        If reply IsNot Nothing Then
            Return reply.DataFormItem.Values("ISCOMPLETE").Value
        End If
        Return False
    End Function
End Class