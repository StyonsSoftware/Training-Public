Imports BBNCExtensions

Partial Public Class WriteToCRMEditor
    Inherits BBNCExtensions.Parts.CustomPartEditorBase

    Private mContent As WriteToCRMProperties

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Public Overrides Function OnSaveContent(Optional ByVal bDialogIsClosing As Boolean = True) As Boolean
        With MyContent
            '.Title = txtTitle.Text
        End With
        Me.Content.SaveContent(MyContent)
        Return True
    End Function

    Private ReadOnly Property MyContent() As WriteToCRMProperties
        Get
            If mContent Is Nothing Then
                mContent = Me.Content.GetContent(GetType(WriteToCRMProperties))
                If mContent Is Nothing Then
                    mContent = New WriteToCRMProperties
                End If
            End If
            Return mContent
        End Get
    End Property


End Class