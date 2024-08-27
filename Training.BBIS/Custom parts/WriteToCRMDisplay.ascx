<%@ assembly Name="Training.BBIS"%>
<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="WriteToCRMDisplay.ascx.vb" Inherits="Training.BBIS.WriteToCRMDisplay" %>
<%@ import Namespace="Training.BBIS"%>
<asp:Label ID="lblError" runat="server" Font-Bold="true" ForeColor="red" />
<asp:TextBox ID="txbLogMessage" runat="server">Type your message here</asp:TextBox>
<asp:Button ID="btnClickMe" runat="server" Text="Write to log" />
