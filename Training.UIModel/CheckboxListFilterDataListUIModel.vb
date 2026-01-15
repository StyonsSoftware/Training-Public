Public Class CheckboxListFilterDataListUIModel

    Private Sub CheckboxListFilterDataListUIModel_Loaded(sender As Object, e As LoadedEventArgs) Handles Me.Loaded
        ADDRESSTYPECODES.AllowAdd = False
        SetVisibilities()
        RefreshAddressTypeCodeList()
    End Sub

    Private Sub SetVisibilities()
        ADDRESSTYPECODES.Visible = (ADDRESSINCLUDECODE.Value IsNot Nothing) AndAlso (ADDRESSINCLUDECODE.Value = ADDRESSINCLUDECODES.SelectedAddressTypes)
    End Sub

    Private Sub _addressincludecode_ValueChanged(sender As Object, e As ValueChangedEventArgs) Handles _addressincludecode.ValueChanged
        SetVisibilities()
    End Sub

    Private Sub RefreshAddressTypeCodeList()
        ADDRESSTYPECODES.Value.Clear()
        Dim atcs As New List(Of CheckboxListFilterDataListADDRESSTYPECODESUIModel)
        Dim atc As CheckboxListFilterDataListADDRESSTYPECODESUIModel

        atc = New CheckboxListFilterDataListADDRESSTYPECODESUIModel
        atc.ADDRESSTYPECODEDESCRIPTION.Value = "Home"
        atc.ADDRESSTYPECODEID.Value = New Guid("B8C70D93-C267-4B53-AA4B-4B777796C7A3")
        atc.ADDRESSTYPECODEINCLUDE.Value = False
        atcs.Add(atc)

        atc = New CheckboxListFilterDataListADDRESSTYPECODESUIModel
        atc.ADDRESSTYPECODEDESCRIPTION.Value = "Business"
        atc.ADDRESSTYPECODEID.Value = New Guid("C021E1F1-610F-4026-935D-35F8D474578B")
        atc.ADDRESSTYPECODEINCLUDE.Value = False
        atcs.Add(atc)

        ADDRESSTYPECODES.Value.AddRange(atcs)
    End Sub
End Class