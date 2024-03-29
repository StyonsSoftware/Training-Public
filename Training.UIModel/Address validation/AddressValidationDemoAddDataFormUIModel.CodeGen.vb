﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.3101.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Address Validation Demo Add Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Add, "837ba8fc-734b-4b7c-82ef-abfe3d5f8c09", "549644c5-3041-4813-973e-bd727d307f12", "Address Validation Demo", "Constituent")>
Partial Public Class [AddressValidationDemoAddDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _addresstypecodeid As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
    Private WithEvents _addressblock As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _city As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _stateid As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of System.Guid)
    Private WithEvents _postcode As Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of String)
    Private WithEvents _countryid As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of System.Guid)
    Private WithEvents _actionVALIDATE As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction

    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3101.0")>
    Public Sub New()
        MyBase.New()

        _addresstypecodeid = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        _addressblock = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _city = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _stateid = New Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of System.Guid)
        _postcode = New Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of String)
        _countryid = New Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of System.Guid)
        _actionVALIDATE = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Add
        MyBase.DataFormTemplateId = New System.Guid("837ba8fc-734b-4b7c-82ef-abfe3d5f8c09")
        MyBase.DataFormInstanceId = New System.Guid("549644c5-3041-4813-973e-bd727d307f12")
        MyBase.RecordType = "Address Validation Demo"
        MyBase.ContextRecordType = "Constituent"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/training/AddressValidationDemoAddDataForm.html"

        '
        '_addresstypecodeid
        '
        _addresstypecodeid.Name = "ADDRESSTYPECODEID"
        _addresstypecodeid.Caption = "Type"
        _addresstypecodeid.CodeTableName = "ADDRESSTYPECODE"
        Me.Fields.Add(_addresstypecodeid)
        '
        '_addressblock
        '
        _addressblock.Name = "ADDRESSBLOCK"
        _addressblock.Caption = "Address"
        _addressblock.MaxLength = 150
        Me.Fields.Add(_addressblock)
        '
        '_city
        '
        _city.Name = "CITY"
        _city.Caption = "City"
        _city.MaxLength = 50
        Me.Fields.Add(_city)
        '
        '_stateid
        '
        _stateid.Name = "STATEID"
        _stateid.Caption = "State"
        _stateid.SimpleDataListId = New System.Guid("7fa91401-596c-4f7c-936d-6e41683121d7")
        _stateid.Parameters.Add(New Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListParameter("COUNTRYID", "Fields!COUNTRYID"))
        Me.Fields.Add(_stateid)
        '
        '_postcode
        '
        _postcode.Name = "POSTCODE"
        _postcode.Caption = "ZIP"
        _postcode.MaxLength = 12
        _postcode.SearchListId = New System.Guid("e5de8c33-de58-4dc6-9a13-48be9f03db81")
        _postcode.DisplayTextIsValue = True
        Me.Fields.Add(_postcode)
        '
        '_countryid
        '
        _countryid.Name = "COUNTRYID"
        _countryid.Caption = "Country"
        _countryid.Required = True
        _countryid.SimpleDataListId = New System.Guid("c9649672-353d-42e8-8c25-4d34bbabfbba")
        Me.Fields.Add(_countryid)
        '
        '_actionVALIDATE
        '
        _actionVALIDATE.Name = "ACTION_VALIDATE"
        _actionVALIDATE.Caption = "Validate this address"
        Me.Actions.Add(_actionVALIDATE)

        OnCreated()

    End Sub

    ''' <summary>
    ''' Type
    ''' </summary>
    <System.ComponentModel.Description("Type")>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3101.0")>
    Public ReadOnly Property [ADDRESSTYPECODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _addresstypecodeid
        End Get
    End Property

    ''' <summary>
    ''' Address
    ''' </summary>
    <System.ComponentModel.Description("Address")>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3101.0")>
    Public ReadOnly Property [ADDRESSBLOCK]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _addressblock
        End Get
    End Property

    ''' <summary>
    ''' City
    ''' </summary>
    <System.ComponentModel.Description("City")>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3101.0")>
    Public ReadOnly Property [CITY]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _city
        End Get
    End Property

    ''' <summary>
    ''' State
    ''' </summary>
    <System.ComponentModel.Description("State")>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3101.0")>
    Public ReadOnly Property [STATEID]() As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of System.Guid)
        Get
            Return _stateid
        End Get
    End Property

    ''' <summary>
    ''' ZIP
    ''' </summary>
    <System.ComponentModel.Description("ZIP")>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3101.0")>
    Public ReadOnly Property [POSTCODE]() As Global.Blackbaud.AppFx.UIModeling.Core.SearchListField(Of String)
        Get
            Return _postcode
        End Get
    End Property

    ''' <summary>
    ''' Country
    ''' </summary>
    <System.ComponentModel.Description("Country")>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3101.0")>
    Public ReadOnly Property [COUNTRYID]() As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of System.Guid)
        Get
            Return _countryid
        End Get
    End Property

    ''' <summary>
    ''' Validate this address
    ''' </summary>
    <System.ComponentModel.Description("Validate this address")>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.3101.0")>
    Public ReadOnly Property [ACTION_VALIDATE]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _actionVALIDATE
        End Get
    End Property
    
End Class
