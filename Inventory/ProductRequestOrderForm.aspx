<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProductRequestOrderForm.aspx.cs" Inherits="Inventory.ProductRequestOrderForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>
Product Request Order Form
</h2>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Quantity"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            </td>
            <td><asp:Label ID="Label2" runat="server" Text="Unit of Measure"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUOM" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Product ID :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpProduct" runat="server">
                </asp:DropDownList>
            </td>
            <td><asp:Label ID="Label4" runat="server" Text="Item Description :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtItemDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Supplier : "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpSupplier" runat="server">
                </asp:DropDownList>
            </td>
            <td><asp:Label ID="Label6" runat="server" Text="Date Needed :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateNeeded" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
