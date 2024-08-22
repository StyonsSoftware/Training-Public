Imports System.Runtime.ExceptionServices

Public Class EditDataFormTemplateSpecEditDataFormUIModel

    Private Sub EditDataFormTemplateSpecEditDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded

    End Sub

    Private Sub EditDataFormTemplateSpecEditDataFormUIModel_Saved(sender As Object, e As SavedEventArgs) Handles Me.Saved
        Dim msg As String = "Your ID is: " + DUMMYID.Value.ToString()
        Throw New Exception(msg)
    End Sub
End Class