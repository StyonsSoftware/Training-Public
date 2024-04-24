Public Class GlobalChangeSearchUIModel
    'see email exchange with Ray Porter on 04/24/2024 (in your jstyons@gmail.com account)
    Private Sub GlobalChangeSearchUIModel_Loaded(sender As Object, e As LoadedEventArgs) Handles Me.Loaded
        'This happens when the form loads (before, in fact, it even appears on-screen).  Suitable for setting default values, enabled/disabled states, etc.
        'Throw New Exception("Loaded!")
    End Sub

    Private Sub GlobalChangeSearchUIModel_Validated(sender As Object, e As ValidatedEventArgs) Handles Me.Validated
        'this happens when the user executes a search.  it corresponds to when the filter fields are validated.
        'Throw New Exception("Validated!")
    End Sub

    Private Sub GlobalChangeSearchUIModel_SearchItemSelected(sender As Object, e As SearchItemSelectedEventArgs) Handles Me.SearchItemSelected
        'This happens when the user actually picks something in the list, either by clicking directly on it or by clicking the "Select" button
        'Throw New Exception("Search item selected!")
    End Sub
End Class