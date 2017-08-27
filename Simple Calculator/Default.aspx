<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Simple_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Calculator</h1>
        <p>
            First Value&nbsp;
            <asp:TextBox ID="textboxFirstValue" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value&nbsp;
            <asp:TextBox ID="textboxSecondValue" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;<asp:Button ID="buttonPlus" runat="server" OnClick="buttonPlus_Click" Text="+" />
&nbsp;
            <asp:Button ID="buttonMinus" runat="server" OnClick="ButtonMinus_Click" Text="-" />
&nbsp;
            <asp:Button ID="buttonMultiply" runat="server" OnClick="buttonMultiply_Click" Text="*" />
&nbsp;
            <asp:Button ID="buttonDivide" runat="server" OnClick="buttonDivide_Click" Text="/" />
&nbsp;</p>
        <p>
            <asp:Label ID="answerLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
