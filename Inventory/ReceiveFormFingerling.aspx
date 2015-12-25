<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ReceiveFormFingerling.aspx.cs" Inherits="Inventory.ReceiveFormFingerling" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager runat="server">
    </asp:ToolkitScriptManager>
    <h2>
        Receive Order Form
    </h2>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Supplier : "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpSupplier" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpSupplier_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="PRO # :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPro" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Address : "></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
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
                <asp:Label ID="Label11" runat="server" Text="TIN :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblTin" runat="server" Text="TIN :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Tel Num : "></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbltel" runat="server" Text="Tel Num : "></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                Enter Products
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Product ID :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpProduct" runat="server" OnSelectedIndexChanged="drpProduct_SelectedIndexChanged"
                    AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Item Description :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblDescription" runat="server" Text="Item Description"></asp:Label>
            </td>
        </tr>
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
                <asp:Label ID="Label27" runat="server" Text="Packaging (boxex)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPackagine" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="4">
                Airport
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbldate" runat="server" Text="Date of Shipment"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateShipment" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Time of Shipment"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTimeShipment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Date of Arrival"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateArrival" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Time of Arrival"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTimeArrival" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Date Receive"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateReceive" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Time Receive"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTimeReceive" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Reoxygenation start"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtReoxygen" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Finish"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFinish" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label17" runat="server" Text="Salinity inside the bag"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSalinity" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Temperature"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTemp" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label19" runat="server" Text="Time after receipt from Airport"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTimeReceiveAirport" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label20" runat="server" Text="Mortality"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMortality" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                At Stocking Site
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label21" runat="server" Text="Time of Arrival"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTimeArrival1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label22" runat="server" Text="Time of Stocking"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTimeStocking" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label23" runat="server" Text="Mortality"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMortality1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label24" runat="server" Text="Deformed"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDeformed" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label25" runat="server" Text="Injured"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtInjured" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label26" runat="server" Text="Missing"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMissing" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label28" runat="server" Text="Module No. "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtModule" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label29" runat="server" Text="Cage No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCage" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label30" runat="server" Text="Quantity Stocked "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQuantity1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label31" runat="server" Text="Salinity "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSalinity1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label32" runat="server" Text="Temperature "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTemperature" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnAdd0" runat="server" OnClick="btnAdd0_Click" Text="Add" />
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp; Summary
            </td>
            <td>
                &nbsp;
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
                &nbsp;
                <asp:Label ID="Label33" runat="server" Text="Total initial Quantity Stock"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtTotalQuantity" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:Label ID="Label34" runat="server" Text="Total Mortality"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtTotalMortality" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
                <asp:Label ID="Label35" runat="server" Text="Total Deformed"></asp:Label>
            </td>
            <td>
                &nbsp;
            <asp:TextBox ID="txtTotalDeform" runat="server"></asp:TextBox></td>
            <td>
                &nbsp;
                <asp:Label ID="Label36" runat="server" Text="Total Injured"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTotalInjured" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
                <asp:Label ID="Label37" runat="server" Text="Missing"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTMissing" runat="server"></asp:TextBox>
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
            </td>
            <td>
            </td>
            <td>
                <asp:Button ID="btnSave1" runat="server" Text="Save" OnClick="btnSave1_Click" />
            </td>
            <td>
            </td>
        </tr>
    </table>
    <asp:GridView ID="grdList" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        OnRowDeleting="grdList_RowDeleting" OnRowCommand="grdList_RowCommand">
    </asp:GridView>
    <asp:GridView ID="grdList1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        OnRowDeleting="grdList1_RowDeleting" OnRowCommand="grdList1_RowCommand">
    </asp:GridView>
</asp:Content>
