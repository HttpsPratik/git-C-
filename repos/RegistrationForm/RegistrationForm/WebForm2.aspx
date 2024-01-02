<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="AutomaticWebDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        FirstName<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 37px" Width="155px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Name is Required !"></asp:RegularExpressionValidator>
        <br />
        LastName<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 38px" Width="155px"></asp:TextBox>
        <br />
        Address&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-left: 42px" Width="154px"></asp:TextBox>
        <br />
        <br />
        Gender&nbsp; <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="margin-left: 102px" Width="232px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Hobbies
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="margin-left: 96px" Width="194px">
            <asp:ListItem>Dancing</asp:ListItem>
            <asp:ListItem>Singing</asp:ListItem>
            <asp:ListItem>Listening</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>