<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ArithmeticOperators.aspx.cs" Inherits="Demos_ArithmeticOperators" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ArithmeticOperators</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Addition"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxAddition" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Subtraction"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxSubtraction" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Multiplication"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxMultiplication" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Division"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxDivision" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Modulus"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxModulus" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
