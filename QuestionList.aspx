<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="QuestionList.aspx.cs" Inherits="QuestionList" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="question_id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="1392px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="question_id" HeaderText="question_id" InsertVisible="False" ReadOnly="True" SortExpression="question_id" />
                <asp:BoundField DataField="question_by" HeaderText="question_by" SortExpression="question_by" />
                <asp:BoundField DataField="question_include" HeaderText="question_include" SortExpression="question_include" />
                <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:c1511048ConnectionString %>" SelectCommand="SELECT [question_id], [question_by], [question_include], [title] FROM [question] ORDER BY [question_id]"></asp:SqlDataSource>
        
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="question_id" DataValueField="question_id"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:c1511048ConnectionString %>" SelectCommand="SELECT [question_id] FROM [question]"></asp:SqlDataSource>
            <asp:TextBox ID="TextBoxAnswer" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" BackColor="Green" ForeColor="White" />
        
    </div>
</asp:Content>
