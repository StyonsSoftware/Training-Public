Public Class NamingOpportunityAddFormAddDataFormUIModel

    Private _ParentModel As NamingOpportunity.UIModel.NamingOpportunityAddFormUIModel

    Private Sub NamingOpportunityAddFormAddDataFormUIModel_HostModelChanged(sender As Object, e As HostModelChangedEventArgs) Handles Me.HostModelChanged
        If _ParentModel Is Nothing AndAlso HostModel IsNot Nothing Then
            _ParentModel = TryCast(HostModel, NamingOpportunity.UIModel.NamingOpportunityAddFormUIModel)
            If _ParentModel IsNot Nothing Then
                'un-comment this line to hide the SITE field from code.
                'instead, we are doing it from JS.
                '_ParentModel.SITEID.Visible = False
            End If
        End If
    End Sub
End Class