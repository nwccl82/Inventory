<%@ Page Title="Color" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Color.aspx.cs" Inherits="Inventory.Color" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .formLayout
        {
            background-color: #f3f3f3;
            border: solid 1px #a1a1a1;
            padding: 10px;
            width: 600px;
        }
        
        .formLayout label, .formLayout input
        {
            display: block;
            float: left;
            margin-bottom: 10px;
        }
        
        .formLayout label
        {
            text-align: right;
            padding-right: 20px;
        }
        
        br
        {
            clear: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="formLayout">
     <h2>COLOR Form</h2>
     <br />
        <asp:Label ID="Label1" runat="server" Text="Color :"></asp:Label>
        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="80px" 
            onclick="btnSave_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
</asp:Content>
