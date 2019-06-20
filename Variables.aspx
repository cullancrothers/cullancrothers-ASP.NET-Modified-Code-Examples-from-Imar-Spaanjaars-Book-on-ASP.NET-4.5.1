<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Variables.aspx.cs" Inherits="Demos_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Variables</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 5px"></asp:TextBox>
&nbsp;
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    
    </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
