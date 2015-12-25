<%@ Page Title="Add User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AddUser.aspx.cs" Inherits="Inventory.AddUser" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblFullName" runat="server" Text="FirstName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFullname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLastName" runat="server" Text="LastName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAccess" runat="server" Text="Access Level :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddpAccess" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <asp:ModalPopupExtender ID="HiddenField1_ModalPopupExtender" runat="server" TargetControlID="HiddenField1"
        BackgroundCssClass="modalBackground" PopupControlID="PNL" BehaviorID="mpe">
    </asp:ModalPopupExtender>
    <br />
    <asp:Panel ID="PNL" runat="server">
        <table class="promptBackground" style="width: 220px; border: solid 1px white;" cellpadding="2"
            cellspacing="2">
            <tr>
                <td colspan="2">
                    Confirmation!
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label18" runat="server" Text="Are you sure all data are correct?"></asp:Label>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center;">
                    <asp:Button ID="BtnOk" runat="server" Text="OK" OnClick="BtnOk_Click" />
                    <asp:Button ID="Button1" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
