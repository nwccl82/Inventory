<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProductRequestOrderForm.aspx.cs" Inherits="Inventory.ProductRequestOrderForm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
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
            <td>
                <asp:Label ID="Label2" runat="server" Text="Unit of Measure"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUOM" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Unit Price"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Product ID :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpProduct" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="drpProduct_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Item Description :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtItemDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Supplier : "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpSupplier" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="drpSupplier_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Date Needed :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateNeeded" runat="server"></asp:TextBox>
                <asp:ImageButton runat="Server" ID="ImageButton1" ImageUrl="~/images/Calendar_scheduleHS.png"
                    AlternateText="Click to show calendar" Height="20px" Width="20px" />
                <asp:CalendarExtender ID="txtDOT_alendarExtender" runat="server" TargetControlID="txtDateNeeded"
                    PopupButtonID="ImageButton1" Format="MM/dd/yyyy">
                </asp:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
            </td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <asp:GridView ID="grdList" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" OnRowDeleting="grdList_RowDeleting"
        OnRowCommand="grdList_RowCommand">
    </asp:GridView>
</asp:Content>
