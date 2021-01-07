Public Class CollectionDrivenSDLAddDataFormLOCATIONSUIModel
    Private Sub _countryid_ValueChanged(sender As Object, e As ValueChangedEventArgs) Handles _countryid.ValueChanged
        STATEID.ResetDataSource()
    End Sub
End Class
