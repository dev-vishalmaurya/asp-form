<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>            
    <div class="row mx-auto w-50">
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="EmailId"></asp:Label>
      <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>


        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>


        <asp:Label ID="Label4" runat="server" Text="Pincode"></asp:Label>
        <asp:TextBox ID="txtPinCode" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
        <asp:DropDownList ID="txtGender" runat="server">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>other</asp:ListItem>
            
            <asp:ListItem Selected="True">Male</asp:ListItem>
            
        </asp:DropDownList>
        

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineShopCon %>" ProviderName="<%$ ConnectionStrings:OnlineShopCon.ProviderName %>" SelectCommand="SELECT * FROM [tblUserSignUp]"></asp:SqlDataSource>
        

        <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="mt-2" OnClick="Button1_Click" />
        

    </div>
    </main>

</asp:Content>
