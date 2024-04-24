Imports Blackbaud.AppFx.Server

Public NotInheritable Class RecordOperationSpecRecordOperation
    Inherits AppCatalog.AppRecordOperationPerform

    Public Overrides Function Perform() As AppCatalog.AppRecordOperationPerformResult
        Dim result As New AppCatalog.AppRecordOperationPerformResult
        Dim finished As Boolean
        Do
            finished = IsItFinishedYet()
            Threading.Thread.Sleep(5000) 'check every 5 seconds
        Loop Until finished
        Return result
    End Function

    Private Function IsItFinishedYet()
        'select status from SomeTable where ID = whatever
    End Function
End Class