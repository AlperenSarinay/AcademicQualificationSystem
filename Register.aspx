<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="Server">
    <h3>Register</h3>
    <p>
        <asp:TextBox ID="TextBoxFname" placeholder="First name" runat="server" EnableViewState="False"></asp:TextBox></p>
    <p>
        <asp:TextBox ID="TextBoxLastName" placeholder="Last name" runat="server"></asp:TextBox></p>
<p><asp:TextBox ID="TextBoxEmail" placeholder="email" runat="server" TextMode="Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
        runat="server" ControlToValidate="TextBoxEmail" ForeColor="red"
        ErrorMessage="You cannot leave the page without filling out this field.">

    </asp:RequiredFieldValidator>
</p>
    <p><asp:TextBox ID="TextBoxPass" placeholder="Password" minlength="8" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
            runat="server" ControlToValidate="TextBoxPass" ForeColor="red"
            ErrorMessage="You cannot leave the page without filling out this field.">

        </asp:RequiredFieldValidator>
    </p>
    <p> <asp:Button ID="ButtonSubmit" runat="server" Text="Kaydet" OnClick="ButtonSubmit_Click" BackColor="Green" ForeColor="White" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Login">Login</asp:HyperLink>    </p>
    </asp:Content>
