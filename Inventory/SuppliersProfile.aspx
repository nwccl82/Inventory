<%@ Page Title="Supplier" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SuppliersProfile.aspx.cs" Inherits="Inventory.SuppliersProfile" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     <style type="text/css">
    .formLayout
    {
        background-color: #f3f3f3;
        border: solid 1px #a1a1a1;
        padding: 10px;
        width:600px;
    }
    
    .formLayout label, .formLayout input
    {
        display: block;
        width: 120px;
        float: left;
        margin-bottom: 10px;
    }
 
    .formLayout label
    {
        text-align: right;
        padding-right: 20px;
    }
 
    br
    {
        clear: left;
    }

    </style>
    <style type="text/css">
        /*** SECOND BUTTON ***/
 
        .simpleshape1
        {
            color: #fff;
            background-color:#2ecc71;
            height: 50px;
            width: 340px;
            padding:10px;
            border:none 0px transparent;
            font-size: 25px;
            font-weight: lighter;
            webkit-border-radius: 2px 16px 16px 16px;
            -moz-border-radius:  2px 16px 16px 16px;
            border-radius:  2px 16px 16px 16px;
        }
 
        .simpleshape1:hover
        {
            background-color: #e74c3c;
            border:solid 1px #fff;
        }
 
        .simpleshape1:focus
        {
            color: #383838;
            background-color: #fff;
            border:solid 3px rgba(98,176,255,0.3);
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
     <div class="formLayout">
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
      <h2>Suppliers Form</h2>
         <asp:HiddenField ID="hdnCompanyCode" runat="server" />
         <br />
       <br/>
        <label>Company Name</label>
       <asp:TextBox ID="txtCompanyName" runat="server" Width="300px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCompanyName" ErrorMessage="company name is required!">*</asp:RequiredFieldValidator>
         <br/>
        <label>Address</label>
        <br/>
         <label>No</label>
        <asp:TextBox ID="txtNo" runat="server" Width="60px"></asp:TextBox><br/>
         <label>Street</label>
        <asp:TextBox ID="txtStreet" runat="server" Width="150px"></asp:TextBox><br/>
         <label>Country</label>
         <asp:DropDownList ID="ddlCountry" runat="server"></asp:DropDownList><br/>
          <label>Zip Code</label>
        <asp:TextBox ID="txtZipCode" runat="server" Width="60px"></asp:TextBox><br/>
        <label>TIN</label>
        <asp:TextBox ID="txtTIN" runat="server" Width="100px"></asp:TextBox><br/>
        <label>Telephone</label>
        <asp:TextBox ID="txtTelephone" runat="server" Width="150px"></asp:TextBox><br/>
        <label>Fax</label>
        <asp:TextBox ID="txtFax" runat="server" Width="150px"></asp:TextBox><br/>
        <label>Email</label>
        <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox><br/>
         <label>Website</label>
        <asp:TextBox ID="txtWebsite" runat="server" Width="150px"></asp:TextBox><br/>
        <label>Contact Person</label>
      <br/>
         <label>Last Name</label>
        <asp:TextBox ID="txtLastName" runat="server" Width="150px"></asp:TextBox><br/>
         <label>First Name</label>
        <asp:TextBox ID="txtFirstName" runat="server" Width="150px"></asp:TextBox><br/>
        <label>Designation</label>
         <asp:DropDownList ID="ddlDesignation" runat="server">
             <asp:ListItem>Supervisor</asp:ListItem>
             <asp:ListItem>Manager</asp:ListItem>
             <asp:ListItem>Sales Agent</asp:ListItem>
         </asp:DropDownList><br/>
         <br />
         <br />
         <label><asp:Button ID="btnSave" CssClass="simpleshape1" runat="server" Text="Save" OnClick="btnSave_Click" /></label>
        </div>
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
