<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Products.aspx.cs" Inherits="Inventory.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Product Name :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtProdName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            <asp:Label ID="Label2" runat="server" Text="Product Description :"></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtProdDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Product Code :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            <asp:Label ID="Label3" runat="server" Text="Category Type :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpCategory" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
            <asp:Label ID="Label4" runat="server" Text="Unit of Measure :"></asp:Label>
            </td>
            <td>
            <asp:DropDownList ID="drpUOM" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
            <asp:Label ID="Label5" runat="server" Text="Size :"></asp:Label>
            </td>
            <td>
            <asp:DropDownList ID="drpSize" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
            </td>
            <td>
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        onpageindexchanging="GridView1_PageIndexChanging">
    </asp:GridView>
</asp:Content>
