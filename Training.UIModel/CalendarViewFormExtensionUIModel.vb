Public Class CalendarViewFormExtensionUIModel
    Private _ParentModel As Platform.UIModel.CalendarViewFormUIModel 'requires a project reference to Blackbaud.AppFx.Platform.UIModel.dll

    Private Sub CalendarViewFormExtensionUIModel_HostModelChanged(sender As Object, e As HostModelChangedEventArgs) Handles Me.HostModelChanged
        If _ParentModel Is Nothing AndAlso HostModel IsNot Nothing Then
            _ParentModel = DirectCast(HostModel, Platform.UIModel.CalendarViewFormUIModel)

            If _ParentModel IsNot Nothing Then
                '_ParentModel.CALENDARFILTERS.Visible = False
            End If
        End If
    End Sub
End Class