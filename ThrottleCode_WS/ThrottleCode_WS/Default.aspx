<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThrottleCode_WS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
    .Over { overflow: auto; width: 95%; }
</style>

    <form id="form1" runat="server">
        <p>
            <asp:Table ID="Table1" runat="server" BorderStyle="None" Width="483px">
                <asp:TableRow runat="server" BorderStyle="Solid" HorizontalAlign="Left">
                    <asp:TableCell runat="server">Insert the Throttling Reason Code:</asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="reason" ReadOnly="False" runat="server" Width="200px"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" BorderColor="Black" BorderStyle="Solid">
                    <asp:TableCell runat="server">Throttling Mode:</asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="throttleMode" ReadOnly="True" runat="server" Width="200px"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" BorderStyle="Solid">
                    <asp:TableCell runat="server">Throttling Type:</asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="throttleType" ReadOnly="True" runat="server" Width="200px"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" BorderStyle="Solid">
                    <asp:TableCell runat="server">Throttling Resource</asp:TableCell>
                    <asp:TableCell runat="server"><asp:TextBox ID="resourceType" ReadOnly="True" runat="server" Width="200px"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
            </asp:Table></p>
            <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" /> 
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="clear" />
        </p>
        <asp:TextBox ID="errorBox" runat="server" BorderStyle="None" BorderWidth="0px" Height="241px" 
            ReadOnly="True" TextMode="MultiLine" Rows="10" Width="441px" CssClass="Over" ForeColor ="red"></asp:TextBox>
    </form>
</body>
</html>
