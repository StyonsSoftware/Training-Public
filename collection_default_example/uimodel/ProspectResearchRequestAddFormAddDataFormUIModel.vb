Public Class ProspectResearchRequestAddFormAddDataFormUIModel

    'requires a project reference to Blackbaud.AppFx.ProspectResearch.UIModel.dll
    Private _ParentModel As ProspectResearch.UIModel.ProspectResearchRequestAddFormUIModel

    'add form extensions cannot have a SQL Load procedure.  So we pull the default value in from a view form, which does the SQL for us.
    Private Sub ProspectResearchRequestAddFormAddDataFormUIModel_Loaded(sender As Object, e As LoadedEventArgs) Handles Me.Loaded
        'you don't really need the DEFAULTPROSPECTID field at all.
        'I'm leaving it in case you want to do something with it during the form's Save SQL
        DEFAULTPROSPECTID.Value = GetDefaultProspectID()
        DEFAULTPROSPECTID.Visible = False
    End Sub

    'when the parent form becomes available, grab a reference to it and set the default constituent
    Private Sub ProspectResearchRequestAddFormAddDataFormUIModel_HostModelChanged(sender As Object, e As HostModelChangedEventArgs) Handles Me.HostModelChanged
        If _ParentModel Is Nothing AndAlso HostModel IsNot Nothing Then
            _ParentModel = DirectCast(HostModel, ProspectResearch.UIModel.ProspectResearchRequestAddFormUIModel)
            If _ParentModel IsNot Nothing Then
                SetDefaultProspect(DEFAULTPROSPECTID.Value)
            End If
        End If
    End Sub

    Private Sub SetDefaultProspect(defaultConstituentID As Guid)
        If _ParentModel Is Nothing Then
            Exit Sub
        End If

        If Not _ParentModel.CONSTITUENTS.HasValue Then
            'if they already have a value, do nothing.
            'if there is no value there, put in the default.
            Dim defaultRow As New ProspectResearch.UIModel.ProspectResearchRequestAddFormCONSTITUENTSUIModel
            defaultRow.CONSTITUENTID.Value = defaultConstituentID
            _ParentModel.CONSTITUENTS.Value.Add(defaultRow)
            _ParentModel.CONSTITUENTS.Value(0).CONSTITUENTID.UpdateDisplayText()
        End If
    End Sub

    Private Function GetDefaultProspectID() As Guid
        'ask a view form for the right default value.
        'note that we are passing in an empty guid to the view form, but you could
        'give it something else if the default needs to change based on the context
        Dim req As New Server.DataFormLoadRequest()
        req.FormID = New Guid("9e26aad0-379e-4536-9c23-12f7429e2f6f")
        req.RecordID = Guid.Empty.ToString()
        Dim rep = Server.ServiceMethods.DataFormLoad(req, GetRequestContext())
        Return New Guid(rep.DataFormItem.Values("DEFAULTCONSTITUENTID").Value.ToString())
    End Function
End Class