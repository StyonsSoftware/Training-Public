'these first two lines are copied exactly from this file:
'ConstituentAddressPicklistAVAILABLEADDRESSESUIModel.CodeGen.vb
Partial Public Class [ConstituentAddressPicklistAVAILABLEADDRESSESUIModel]
    Inherits UIModeling.Core.UIModel

    Private Sub ConstituentAddressPicklistAVAILABLEADDRESSESUIModel_CollectionFieldChanged(sender As Object, e As CollectionFieldChangedEventArgs) Handles Me.CollectionFieldChanged
        'put the code here, so that if you add/remove rows in the collection, the enabled property is applied to new rows
        _addressblock.Enabled = False
    End Sub
End Class
