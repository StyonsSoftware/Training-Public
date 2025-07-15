Imports System.IO
Imports Blackbaud.AppFx.Server

Public NotInheritable Class ConstituentPetCLRAddDataForm
    Inherits AppCatalog.AppAddDataForm

    Public PETNAME As String
    Public PETIMAGE As String 'note this is a binary file, but it is declared as a string
    Public PETIMAGEFILENAME As String

    Public Overrides Function Save() As AppCatalog.AppAddDataFormSaveResult
        Dim fileContents As Byte() = GetUploadedFileContentsAsByte(PETIMAGE)
        If Date.Now.Hour = 99 Then
            Throw New Exception("Just a place for a breakpoint")
        End If
        Return New AppCatalog.AppAddDataFormSaveResult With {.ID = Guid.NewGuid().ToString()}
    End Function

    Private Function GetUploadedFileContentsAsByte(filePath As String) As Byte()
        If Not String.IsNullOrEmpty(filePath) Then
            Dim fileContent As Byte() = File.ReadAllBytes(filePath)
            If Not fileContent Is Nothing Then
                Return fileContent
            End If
        End If
        Return Nothing
    End Function
End Class