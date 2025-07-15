Public Class ConstituentPetAddDataFormStoredProcedureUIModel

    Private Sub ConstituentPetAddDataFormStoredProcedureUIModel_Loaded(sender As Object, e As LoadedEventArgs) Handles Me.Loaded

    End Sub

    Private Sub _petimage_ValueChanged(sender As Object, e As ValueChangedEventArgs) Handles _petimage.ValueChanged
        If Date.Now.Hour = 99 Then
            Throw New Exception("Just a place for a breakpoint")
        End If
    End Sub

    Private Sub _petimagefilename_ValueChanged(sender As Object, e As ValueChangedEventArgs) Handles _petimagefilename.ValueChanged
        If Date.Now.Hour = 99 Then
            Throw New Exception("Just a place for a breakpoint")
        End If
    End Sub

    Private Sub ConstituentPetAddDataFormStoredProcedureUIModel_Validating(sender As Object, e As ValidatingEventArgs) Handles Me.Validating
        If Date.Now.Hour = 99 Then
            Throw New Exception("Just a place for a breakpoint")
        End If
    End Sub

    Private Sub ConstituentPetAddDataFormStoredProcedureUIModel_Saved(sender As Object, e As SavedEventArgs) Handles Me.Saved
        If Date.Now.Hour = 99 Then
            Throw New Exception("Just a place for a breakpoint")
        End If
    End Sub
End Class