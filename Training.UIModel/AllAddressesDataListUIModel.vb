Public Class AllAddressesDataListUIModel

    Private Sub AllAddressesDataListUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        STATEID.Value = Guid.Empty
    End Sub

    Private Sub _countryid_ValueChanged(sender As Object, e As ValueChangedEventArgs) Handles _countryid.ValueChanged
        STATEID.ResetDataSource()
        STATEID.Value = Guid.Empty
    End Sub
End Class