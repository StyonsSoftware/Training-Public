Imports System.Web

Public Class ParamsFromURLDataListUIModel
    Private Sub ParamsFromURLDataListUIModel_Loaded(sender As Object, e As LoadedEventArgs) Handles Me.Loaded
        Try
            Dim url = GetRequestContext.HTTPContext.Request.Url
            Dim fname = HttpUtility.ParseQueryString(url.Query).Get("FIRSTNAME")
            Dim lname = HttpUtility.ParseQueryString(url.Query).Get("KEYNAME")
            If String.IsNullOrEmpty(FIRSTNAME.Value) AndAlso Not String.IsNullOrEmpty(fname) Then
                FIRSTNAME.Value = fname
            End If
            If String.IsNullOrEmpty(KEYNAME.Value) AndAlso Not String.IsNullOrEmpty(fname) Then
                KEYNAME.Value = lname
            End If
        Catch ex As Exception
            'swalllow exceptions
        End Try
    End Sub
End Class