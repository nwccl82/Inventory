<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BiometricEntry.aspx.cs" Inherits="Inventory.BiometricEntry" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <h2>
        Biometric Entry Form
    </h2>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Product ID :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpProduct" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpProduct_SelectedIndexChanged">
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
                <asp:Label ID="Label9" runat="server" Text="Batch No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBatchNo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblDates" runat="server" Text="Date Stocked"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateStock" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Module No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtModule" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Supplier/ Source"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Cage No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCage" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Percentage Sample"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Date Last Counted"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateLast" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Last Complete Total Count"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Sample Number:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSample" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Length(cm)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Width(cm)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Weight(g)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Remarks"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRemark" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Last Complete Total Count"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
