Imports Blackbaud.AppFx.XmlTypes

Public Class ImageDemoViewDataFormUIModel

    Private Sub ImageDemoViewDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        TESTIMAGE.ValueDisplayStyle = ValueDisplayStyle.CustomImageOnly(GetImageKeyForDecisionValue(DECISIONFIELD.Value))
    End Sub

    Private Function GetImageKeyForDecisionValue(decisionValue As Int16) As String
        Select Case decisionValue
            Case 0
                Return "CATALOG:SSC.BBISPowerTools.Catalog,SSC.BBISPowerTools.Catalog.group_16.png"
            Case 1
                Return "CATALOG:Training.Catalog,Training.Catalog.problem-solving.png"
                'Return "CATALOG:Blackbaud.AppFx.FAFEvent.Catalog,Blackbaud.AppFx.FAFEvent.Catalog.circle_yellow_12.png"
        End Select

        Return String.Empty
    End Function
End Class