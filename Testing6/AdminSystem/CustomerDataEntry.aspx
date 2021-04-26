<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number"></asp:Label>
            <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblCName" runat="server" Text="Name" width="262px"></asp:Label>
        <asp:TextBox ID="txtCName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCSurname" runat="server" Text="Surname" width="262px"></asp:Label>
        <asp:TextBox ID="txtCSurname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCAddress" runat="server" Text="Address" width="262px"></asp:Label>
        <asp:TextBox ID="txtCAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCMail" runat="server" Text="Email" width="262px"></asp:Label>
        <asp:TextBox ID="txtCMail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find " />
    </form>
</body>
</html>
