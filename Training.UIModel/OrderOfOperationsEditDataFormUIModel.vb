Imports System.Data.SqlClient
Imports Blackbaud.AppFx.Server

Public Class OrderOfOperationsEditDataFormUIModel
    Public Sub LM(msg As String)
        msg = "UIModel: " + msg
        Using con As SqlConnection = New SqlConnection(RequestContext.Current.AppDBConnectionString)
            Using command As SqlCommand = con.CreateCommand()
                Try
                    command.CommandText = "USR_USP_RECORDLOGMESSAGE"
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandTimeout = 0
                    command.Parameters.AddWithValue("@MSG", msg)
                    con.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New ApplicationException("Unable to log message. Exception: " + ex.Message + "... ")
                Finally
                    con.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        'note: if an error happens during _Loaded, then the "editload" sproc still happens *once*
        LM("Loaded")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_BeginValidate(sender As Object, e As BeginValidateEventArgs) Handles Me.BeginValidate
        LM("BeginValidate")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_Canceling(sender As Object, e As CancelingEventArgs) Handles Me.Canceling
        LM("Canceling")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_DefaultValuesLoaded(sender As Object, e As DefaultValuesLoadedEventArgs) Handles Me.DefaultValuesLoaded
        LM("DefaultValuesLoaded")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_Saved(sender As Object, e As SavedEventArgs) Handles Me.Saved
        LM("Saved")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_SaveFailed(sender As Object, e As SaveFailedEventArgs) Handles Me.SaveFailed
        LM("SaveFailed")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_Saving(sender As Object, e As SavingEventArgs) Handles Me.Saving
        LM("Saving")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_Validated(sender As Object, e As ValidatedEventArgs) Handles Me.Validated
        LM("Validated")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_ValidateFailed(sender As Object, e As ValidateFailedEventArgs) Handles Me.ValidateFailed
        LM("ValidateFailed")
    End Sub

    Private Sub OrderOfOperationsEditDataFormUIModel_Validating(sender As Object, e As ValidatingEventArgs) Handles Me.Validating
        LM("Validating")
    End Sub
End Class