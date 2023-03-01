Public Class AddressValidationDemoAddDataFormUIModel
    Private Sub _actionVALIDATE_InvokeAction(sender As Object, e As InvokeActionEventArgs) Handles _actionVALIDATE.InvokeAction
        If Not AddressValidation.ValidationAvailable(GetRequestContext()) Then
            ShowAddressValidationUnavailableMessage()
            Exit Sub
        End If

        'describe the address you want to validate
        Dim addressToValidate As New AddressValidationArgs
        With addressToValidate
            .addressBlock = ADDRESSBLOCK.Value
            .city = CITY.Value
            .postCode = POSTCODE.Value
            .stateId = STATEID.Value
            .countryId = COUNTRYID.Value
        End With

        'feed that address to the validation service.  it will kick back the "corrected" version.
        Dim result = AddressValidation.ValidateSingleAddress(GetRequestContext(), addressToValidate)
        If result.validated Then
            ADDRESSBLOCK.Value = result.addressBlock
            CITY.Value = result.city
            POSTCODE.Value = result.postCode
            STATEID.Value = result.stateId
            COUNTRYID.Value = result.countryId
            ShowAddressValidationSuccessMessage()
        Else
            ShowAddressValidationFailedMessage()
        End If
    End Sub

    Private Sub AddressValidationDemoAddDataFormUIModel_Loaded(sender As Object, e As LoadedEventArgs) Handles Me.Loaded
        If Not AddressValidation.ValidationAvailable(GetRequestContext()) Then
            ShowAddressValidationUnavailableMessage()
        End If
    End Sub

    Private Sub ShowAddressValidationUnavailableMessage()
        Prompts.Add(New UIPrompt() With {
            .ButtonStyle = UIPromptButtonStyle.Ok,
            .Text = "Address validation is not available on this server.",
            .ImageStyle = UIPromptImageStyle.Warning,
            .Title = "Warning"
            })
    End Sub

    Private Sub ShowAddressValidationSuccessMessage()
        Prompts.Add(New UIPrompt() With {
            .ButtonStyle = UIPromptButtonStyle.Ok,
            .Text = "Address validation successful.",
            .ImageStyle = UIPromptImageStyle.Information,
            .Title = "Success"
            })
    End Sub
    Private Sub ShowAddressValidationFailedMessage()
        Prompts.Add(New UIPrompt() With {
            .ButtonStyle = UIPromptButtonStyle.Ok,
            .Text = "Address validation failed.",
            .ImageStyle = UIPromptImageStyle.Exclamation,
            .Title = "Failure"
            })
    End Sub
End Class