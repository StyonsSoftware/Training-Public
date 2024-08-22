Public Class ConstituentAddressPicklistUIModel

    Private Sub ConstituentAddressPicklistUIModel_Loaded(sender As Object, e As LoadedEventArgs) Handles Me.Loaded
        'marking these read-only means that if a user clicks on a row, it doesn't start editing the text inside
        'SELECTEDADDRESSES.DisplayReadOnly = True
        'AVAILABLEADDRESSES.DisplayReadOnly = True
    End Sub

    Private Sub _select_InvokeAction(sender As Object, e As InvokeActionEventArgs) Handles _select.InvokeAction
        'this happens when they click "Select" (the >>> button)

        'first detect what row they want to "slide over".  if no choice, just quit.
        Dim chosenRow As Integer = GetSelectedRowIndexOfAvailableAddresses()
        If chosenRow = -1 Then
            Exit Sub
        End If

        'we cant just add an "available" row to the "selected" rows, because even though they have the
        'same fields (addressid and addressblock) they are not technically the same data type.
        ''so we have to grab the values out of the selected "available" row
        'and push them into a brand new "selected" row, then add that new selected row to the selected grid.

        'create the new "selected" row
        Dim a As New ConstituentAddressPicklistSELECTEDADDRESSESUIModel

        'push the values out from the chosen row into it
        a.ADDRESSID.Value = AVAILABLEADDRESSES.Value(chosenRow).ADDRESSID.Value
        a.ADDRESSBLOCK.Value = AVAILABLEADDRESSES.Value(chosenRow).ADDRESSBLOCK.Value

        'actually add it to the "selected" grid
        SELECTEDADDRESSES.Value.Add(a)

        'now remove the entry from the "available" grid
        AVAILABLEADDRESSES.Value.RemoveAt(chosenRow)
    End Sub

    Private Sub _deselect_InvokeAction(sender As Object, e As InvokeActionEventArgs) Handles _deselect.InvokeAction
        'this happens when they click "Deselect" (the <<< button)
        'see notes on the "select_invokeaction" procedure - this is doing exactly the same thing, but in reverse

        Dim chosenRow As Integer = GetSelectedRowIndexOfSelectedAddresses()
        If chosenRow = -1 Then
            Exit Sub
        End If
        Dim a As New ConstituentAddressPicklistAVAILABLEADDRESSESUIModel
        a.ADDRESSID.Value = SELECTEDADDRESSES.Value(chosenRow).ADDRESSID.Value
        a.ADDRESSBLOCK.Value = SELECTEDADDRESSES.Value(chosenRow).ADDRESSBLOCK.Value
        AVAILABLEADDRESSES.Value.Add(a)
        SELECTEDADDRESSES.Value.RemoveAt(chosenRow)
    End Sub

    Private Function GetSelectedRowIndexOfAvailableAddresses() As Integer
        For i As Integer = 0 To AVAILABLEADDRESSES.Value.Count - 1
            If AVAILABLEADDRESSES.Value(i).Selected Then
                Return i
            End If
        Next
        Return -1
    End Function
    Private Function GetSelectedRowIndexOfSelectedAddresses() As Integer
        For i As Integer = 0 To SELECTEDADDRESSES.Value.Count - 1
            If SELECTEDADDRESSES.Value(i).Selected Then
                Return i
            End If
        Next
        Return -1
    End Function
End Class