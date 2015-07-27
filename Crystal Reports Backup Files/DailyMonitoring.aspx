<%@ Page Title="Daily Monitoring" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="DailyMonitoring.aspx.cs" Inherits="Inventory.DailyMonitoring" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"/>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Date of Transaction: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtDOT" runat="server"></asp:TextBox>
                <asp:ImageButton runat="Server" ID="ImageButton1" ImageUrl="~/images/Calendar_scheduleHS.png"
                    AlternateText="Click to show calendar" Height="20px" Width="20px" />
                <asp:CalendarExtender ID="txtDOT_CalendarExtender" runat="server" 
                    TargetControlID="txtDOT" PopupButtonID="ImageButton1" Format="MM/dd/yyyy">
                </asp:CalendarExtender>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Time of Transaction: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Product ID: "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddpProduct" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Product Description: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtProductDesc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Batch No: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtBatch" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Module No: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtModule" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Cage No: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtCage" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Total Count: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtCount" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Dead: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtDead" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Deform: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtDeform" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Age of Fish: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Salinity: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtSalinity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Temp(C): "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtTemp" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Weather: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtweather" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Actual Weight of Food: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtWeightofFood" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Recorded by: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtRecordedBy" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label17" runat="server" Text="Checked By: "></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="txtCheckBy" runat="server"></asp:TextBox>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        onrowcommand="GridView1_RowCommand1" onrowdeleting="GridView1_RowDeleting1" >
    </asp:GridView>
</asp:Content>
