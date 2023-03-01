'requires a reference to Blackbaud.AppFx.AddressValidation.Server.dll, found in the \sdk\dllreferences folder
Imports Blackbaud.AppFx.AddressValidation.Server

Friend NotInheritable Class AddressValidationArgs
    Friend countryId As Guid
    Friend addressBlock As String
    Friend city As String
    Friend stateId As Guid
    Friend postCode As String
End Class

Friend NotInheritable Class AddressValidationResult
    Friend validated As Boolean
    Friend countryId As Guid
    Friend addressBlock As String
    Friend city As String
    Friend stateId As Guid
    Friend postCode As String
    Friend dpc As String
    Friend cart As String
    Friend lot As String
    Friend countyId As Guid
    Friend congressionalDistrictCodeId As Guid
    Friend certificationData As Integer
    Friend lastValidationAttemptDate As Date
    Friend lastValidationMessage As String
    Friend browseType As Short
    Friend browseSupported As Boolean
End Class

Public NotInheritable Class AddressValidation

    Public Sub New()
    End Sub

    Public Shared Function ValidationAvailable(context As Server.RequestContext) As Boolean

        If context Is Nothing Then Return False

        Try
            Dim req = New AddressValidationAvailableRequest
            Dim reply = ServiceMethods.AddressValidationAvailable(req, context, True)
            Return reply.Available
        Catch
            ' If an error ocurrs -> validation is not available
            Return False
        End Try

        Return False

    End Function

    Friend Shared Function ValidateSingleAddress(context As Server.RequestContext, args As AddressValidationArgs) As AddressValidationResult

        If context Is Nothing Then Return New AddressValidationResult

        Dim req = New ValidateSingleAddressRequest
        req.CountryID = args.countryId
        req.AddressBlock = args.addressBlock
        req.City = args.city
        req.StateID = args.stateId
        req.PostCode = args.postCode

        Dim reply = ServiceMethods.ValidateSingleAddress(req, context, True)

        Dim res = New AddressValidationResult
        res.validated = reply.Validated
        res.browseSupported = reply.BrowseSupported
        res.browseType = reply.BrowseType

        If Not reply.ErrorOccurred Then
            If res.validated Then
                res.countryId = args.countryId
                'remove the double carriage return when it gets returned from the validation.
                res.addressBlock = reply.AddressBlock.Replace(vbCr + vbCr, vbCr)
                res.city = reply.City
                res.stateId = reply.StateID
                res.postCode = reply.PostCode
                res.dpc = reply.DPC
                res.cart = reply.CART
                res.lot = reply.LOT
                res.countyId = reply.CountyID
                res.congressionalDistrictCodeId = reply.CongressionalDistrictID
                res.certificationData = reply.CertificationData
            End If

            res.lastValidationAttemptDate = Now
            res.lastValidationMessage = reply.ValidationMessage

        Else
            Dim message As String = "An error occurred while attempting to validate the address: The address validation service is incorrectly configured, is not started, or has unexpectedly terminated. Please contact your system administrator."
            Throw New InvalidUIModelException(String.Format(Globalization.CultureInfo.CurrentCulture, message, reply.ValidationMessage))
        End If

        Return res
    End Function
End Class