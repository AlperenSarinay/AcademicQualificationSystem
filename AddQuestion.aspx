<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AddQuestion.aspx.cs" Inherits="AddQuestion" %>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
         <p>
            <asp:TextBox ID="TextBoxTitle" runat="server" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                 runat="server" ControlToValidate ="TextBoxTitle" ForeColor="red"
                 ErrorMessage="You cannot leave the page without filling out this field.">
             </asp:RequiredFieldValidator>
        </p>
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Question Text"></asp:Label>
        </p>
       
        <p>
            <asp:TextBox ID="TextBoxQuestionText" minlength="2" runat="server" Height="116px" Width="309px" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                runat="server" ControlToValidate ="TextBoxQuestionText" ForeColor="red"
                ErrorMessage="You cannot leave the page without filling out this field.">

            </asp:RequiredFieldValidator>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Asnwer"></asp:Label>
        <p>
            <asp:TextBox ID="TextBoxQuestionAnswer" minlength="1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                runat="server" ControlToValidate="TextBoxQuestionAnswer" ForeColor="red"
                ErrorMessage="You cannot leave the page without filling out this field.">

            </asp:RequiredFieldValidator>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Add"  OnClick="Button1_Click" BackColor="Green" ForeColor="White"/>
    <p>
           <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    </p>
 
    </asp:Content>