Imports Blackbaud.AppFx.Server

Public NotInheritable Class GlobalChangeSearch
    Inherits AppCatalog.AppSearchList

    Public GLOBALCHANGENAME As String

    Public Overrides Function GetSearchResults() As AppCatalog.AppSearchListResult
        Dim sb As New Text.StringBuilder
        Dim cmd As New SqlClient.SqlCommand
        With sb
            .AppendLine("SELECT")
            .AppendLine("  GC.ID AS GLOBALCHANGEID")
            .AppendLine(" ,GC.[NAME] AS GLOBALCHANGENAME")
            .AppendLine(" ,GCC.DISPLAYNAME AS GLOBALCHANGECATALOGDISPLAYNAME")
            .AppendLine("FROM")
            .AppendLine("  GLOBALCHANGE GC")
            .AppendLine("  JOIN GLOBALCHANGECATALOG GCC ON GCC.ID = GC.GLOBALCHANGECATALOGID")
            .AppendLine("WHERE 1=1")
            If Not String.IsNullOrEmpty(GLOBALCHANGENAME) Then
                .AppendLine("  AND GC.[NAME] LIKE '%" + GLOBALCHANGENAME + "%'")
            End If
        End With
        cmd.CommandTimeout = ProcessContext.TimeOutSeconds
        cmd.CommandText = sb.ToString()
        Return New AppCatalog.AppSearchListResult(cmd)
    End Function
End Class