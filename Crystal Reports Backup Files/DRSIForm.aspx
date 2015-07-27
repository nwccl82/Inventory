<%@ Page Title="DR SI Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="DRSIForm.aspx.cs" Inherits="Inventory.DRSIForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td colspan="2
            ">
                <asp:Label ID="Label1" runat="server" Text="Delivery & Sales Invoice ( Form )"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Customer Name:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpCustomer" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="drpCustomer_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Address :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="TIN:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblTin" runat="server" Text="TIN"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Tel No:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbltel" runat="server" Text="TEL"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Email:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Product ID:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpProduct" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="drpProduct_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Item Description:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblDescription" runat="server" Text="description"></asp:Label>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Batch No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBatchNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Module No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtModule" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Cage No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCage" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Weight"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Unit of Measure."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUnitMeasure" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
            </td>
        </tr>
    </table>
    <table border=1>
        <tr>
            <td>
            </td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Pieces"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Unit Of Measure"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Weight"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label17" runat="server" Text="Unit Of Measure"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Unit Cost"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label19" runat="server" Text="Total Cost"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label20" runat="server" Text="Total :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblPcs" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblUOM" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblWeight" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblUOMS" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblTCost" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <asp:GridView ID="grdList" runat="server" AutoGenerateColumns="False" OnRowDeleting="grdList_RowDeleting"
        OnRowCommand="grdList_RowCommand">
    </asp:GridView>
</asp:Content>
