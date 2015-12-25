<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Products.aspx.cs" Inherits="Inventory.Products" %>
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
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
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
