'looking for the JS implementation of the previous/next button?
'go back in the version history of this file (and, more importantly, the related HTML and JS files)
Public Class ConstituentInteractionViewFormExtensionUIModel

    Private Sub ConstituentInteractionViewFormExtensionUIModel_Loaded(sender As Object, e As LoadedEventArgs) Handles Me.Loaded
        SetVisibilities()
        ShowDataAtCurrentIndex()
    End Sub

    Private Sub SetVisibilities()
        RELATIVEINFO.Visible = False
        RECORDCOUNT.Visible = False
        CURRENTINDEX.Visible = False
        PRIORRECORD.Visible = (RECORDCOUNT.Value > 0)
        NEXTRECORD.Visible = PRIORRECORD.Visible
    End Sub

    Private Sub ShowDataAtCurrentIndex()
        Dim currentRecord As ConstituentInteractionViewFormExtensionRELATIVEINFOUIModel = RELATIVEINFO.Value(CURRENTINDEX.Value)
        With currentRecord
            FIRSTNAME.Value = .FIRSTNAME.Value
            KEYNAME.Value = .KEYNAME.Value
            AGE.Value = .AGE.Value
        End With
    End Sub

    Private Sub _nextrecord_InvokeAction(sender As Object, e As InvokeActionEventArgs) Handles _nextrecord.InvokeAction
        ChangeIndexValue(1)
        ShowDataAtCurrentIndex()
    End Sub

    Private Sub _priorrecord_InvokeAction(sender As Object, e As InvokeActionEventArgs) Handles _priorrecord.InvokeAction
        ChangeIndexValue(-1)
        ShowDataAtCurrentIndex()
    End Sub

    Private Sub ChangeIndexValue(inc As Integer)
        CURRENTINDEX.Value += inc
        If CURRENTINDEX.Value > RECORDCOUNT.Value - 1 Then
            CURRENTINDEX.Value = 0
        End If
        If CURRENTINDEX.Value < 0 Then
            CURRENTINDEX.Value = RECORDCOUNT.Value - 1
        End If
    End Sub
End Class