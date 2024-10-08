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
''' Represents the UI model for the 'Constituent Info Box View Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "5e7c52e5-fdff-4786-952a-9b78adfe31e6", "188ed3d2-ad8b-4b0d-a053-8916b8f4365e", "Constituent")>
Partial Public Class [ConstituentInfoBoxViewDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _message As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _anyuniquething As Global.Blackbaud.AppFx.UIModeling.Core.TimerUIAction

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3501.0")> _
    Public Sub New()
        MyBase.New()

        _message = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _anyuniquething = New Global.Blackbaud.AppFx.UIModeling.Core.TimerUIAction

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New System.Guid("5e7c52e5-fdff-4786-952a-9b78adfe31e6")
        MyBase.DataFormInstanceId = New System.Guid("188ed3d2-ad8b-4b0d-a053-8916b8f4365e")
        MyBase.RecordType = "Constituent"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/training/ConstituentInfoBoxViewDataForm.html"

        '
        '_message
        '
        _message.Name = "MESSAGE"
        _message.Caption = "Message"
        _message.DBReadOnly = True
        _message.MaxLength = 4000
        Me.Fields.Add(_message)
        '
        '_anyuniquething
        '
        _anyuniquething.Name = "ANY_UNIQUE_THING"
        _anyuniquething.Caption = "Timer"
        _anyuniquething.Description = "Start a timer?"
        _anyuniquething.TimerInterval = 1
        Me.Actions.Add(_anyuniquething)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Message
    ''' </summary>
    <System.ComponentModel.Description("Message")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3501.0")> _
    Public ReadOnly Property [MESSAGE]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _message
        End Get
    End Property
    
    ''' <summary>
    ''' Start a timer?
    ''' </summary>
    <System.ComponentModel.Description("Start a timer?")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3501.0")> _
    Public ReadOnly Property [ANY_UNIQUE_THING]() As Global.Blackbaud.AppFx.UIModeling.Core.TimerUIAction
        Get
            Return _anyuniquething
        End Get
    End Property
    
End Class
