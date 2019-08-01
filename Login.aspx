<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">

    <p><asp:TextBox ID="TextBoxEmail" placeholder="email" runat="server"></asp:TextBox></p>   
    <p><asp:TextBox ID="TextBoxPass"  TextMode="Password" placeholder="password" runat="server"></asp:TextBox></p>
    <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" BackColor="Green" ForeColor="White" />
    <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" BackColor="Green" ForeColor="White" />

    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
</asp:Content>