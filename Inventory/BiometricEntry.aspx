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
                <asp:Label ID="lblDates" runat="server" Text="Date :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateStock" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Product Code :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddpProduct" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpProduct_SelectedIndexChanged">
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
            <td>
                <asp:Label ID="Label5" runat="server" Text="Percentage Sample" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Supplier/ Source"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Date Acquired :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateAcquired" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Initial Stocking Density :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtInitialStocking" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="AQL-based sample size :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSample" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="SL(cm)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label17" runat="server" Text="TL(cm)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTL" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Width(cm)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Weight(g)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Deep(cm)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDeep" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label19" runat="server" Text="OperCulu :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtOperCulu" runat="server"></asp:TextBox>
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
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Last Complete Total Count"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLastCount" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="No. of Stocks Recovered :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRecovered" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label20" runat="server" Text="Survival Rate :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSurvialRate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label21" runat="server" Text="Deformed Fish :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDeformFish" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label22" runat="server" Text="Wounded Fish:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWoundedFish" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Label ID="Label23" runat="server" Text="Mortality record:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMortality" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Label ID="Label24" runat="server" Text="Missing:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMissing" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Label ID="Label25" runat="server" Text="Growth Rate:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGrowth" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Label ID="Label26" runat="server" Text="Stocking Rate:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtStocking" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
