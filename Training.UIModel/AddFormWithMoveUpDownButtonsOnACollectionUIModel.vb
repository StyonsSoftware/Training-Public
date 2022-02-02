Public Class AddFormWithMoveUpDownButtonsOnACollectionUIModel

    Private Sub AddFormWithMoveUpDownButtonsOnACollectionUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        LOCATIONS.AllowDragDrop = True
    End Sub

    Private Sub _moveup_InvokeAction(sender As Object, e As InvokeActionEventArgs) Handles _moveup.InvokeAction
        Dim selectedIndex = GetSelectedRowIndex()
        If 0 < selectedIndex Then '0 because you can't move the top row up any further
            Dim replacedRow = LOCATIONS.Value(selectedIndex - 1)
            LOCATIONS.Value(selectedIndex - 1) = LOCATIONS.Value(selectedIndex)
            LOCATIONS.Value(selectedIndex) = replacedRow
        End If
    End Sub

    Private Function GetSelectedRowIndex() As Integer
        For i As Integer = 0 To LOCATIONS.Value.Count
            If LOCATIONS.Value(i).Selected Then
                Return i
            End If
        Next
        Return -1
    End Function
End Class