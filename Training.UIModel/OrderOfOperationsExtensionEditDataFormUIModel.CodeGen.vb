﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.3501.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Order Of Operations Extension Edit Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit, "6d3f750c-d96e-4787-be8f-1e2e162ffdba", "f8533eb0-c07f-4fb0-aa04-2e4b06a37e3f", "Constituent")>
Partial Public Class [OrderOfOperationsExtensionEditDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _middlename As Global.Blackbaud.AppFx.UIModeling.Core.StringField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3501.0")> _
    Public Sub New()
        MyBase.New()

        _middlename = New Global.Blackbaud.AppFx.UIModeling.Core.StringField

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit
        MyBase.DataFormTemplateId = New System.Guid("6d3f750c-d96e-4787-be8f-1e2e162ffdba")
        MyBase.DataFormInstanceId = New System.Guid("f8533eb0-c07f-4fb0-aa04-2e4b06a37e3f")
        MyBase.RecordType = "Constituent"
        MyBase.FORMHEADER.Value = "Edit an order of operations extension"
        MyBase.ExtensionTabCaption = "Extended fields"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/training/OrderOfOperationsExtensionEditDataForm.html"

        '
        '_middlename
        '
        _middlename.Name = "MIDDLENAME"
        _middlename.Caption = "M. name"
        _middlename.MaxLength = 100
        Me.Fields.Add(_middlename)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' M. name
    ''' </summary>
    <System.ComponentModel.Description("M. name")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3501.0")> _
    Public ReadOnly Property [MIDDLENAME]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _middlename
        End Get
    End Property
    
End Class