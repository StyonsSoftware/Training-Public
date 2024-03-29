﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.2103.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Constituent HTML View Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "154adf1f-de1b-4890-a70d-ac1d32df459f", "fd0d9cbe-f3fb-4554-82dc-cf2226f2d9f5", "Constituent HTML")>
Partial Public Class [ConstituentHTMLViewFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _constituentid As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
    Private WithEvents _htmlvalue As Global.Blackbaud.AppFx.UIModeling.Core.HtmlField
    Private WithEvents _plaintextvalue As Global.Blackbaud.AppFx.UIModeling.Core.StringField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.2103.0")> _
    Public Sub New()
        MyBase.New()

        _constituentid = New Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        _htmlvalue = New Global.Blackbaud.AppFx.UIModeling.Core.HtmlField
        _plaintextvalue = New Global.Blackbaud.AppFx.UIModeling.Core.StringField

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New System.Guid("154adf1f-de1b-4890-a70d-ac1d32df459f")
        MyBase.DataFormInstanceId = New System.Guid("fd0d9cbe-f3fb-4554-82dc-cf2226f2d9f5")
        MyBase.RecordType = "Constituent HTML"
        MyBase.FixedDialog = True
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/html/ConstituentHTMLViewForm.html"

        '
        '_constituentid
        '
        _constituentid.Name = "CONSTITUENTID"
        _constituentid.Caption = "Constituent"
        _constituentid.DBReadOnly = True
        Me.Fields.Add(_constituentid)
        '
        '_htmlvalue
        '
        _htmlvalue.Name = "HTMLVALUE"
        _htmlvalue.Caption = "Htmlvalue"
        _htmlvalue.DBReadOnly = True
        Me.Fields.Add(_htmlvalue)
        '
        '_plaintextvalue
        '
        _plaintextvalue.Name = "PLAINTEXTVALUE"
        _plaintextvalue.Caption = "Plaintextvalue"
        _plaintextvalue.DBReadOnly = True
        Me.Fields.Add(_plaintextvalue)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Constituent
    ''' </summary>
    <System.ComponentModel.Description("Constituent")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.2103.0")> _
    Public ReadOnly Property [CONSTITUENTID]() As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        Get
            Return _constituentid
        End Get
    End Property
    
    ''' <summary>
    ''' Htmlvalue
    ''' </summary>
    <System.ComponentModel.Description("Htmlvalue")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.2103.0")> _
    Public ReadOnly Property [HTMLVALUE]() As Global.Blackbaud.AppFx.UIModeling.Core.HtmlField
        Get
            Return _htmlvalue
        End Get
    End Property
    
    ''' <summary>
    ''' Plaintextvalue
    ''' </summary>
    <System.ComponentModel.Description("Plaintextvalue")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.2103.0")> _
    Public ReadOnly Property [PLAINTEXTVALUE]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _plaintextvalue
        End Get
    End Property
    
End Class
