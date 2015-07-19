<%@ Page Title="Supplier" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SuppliersProfile.aspx.cs" Inherits="Inventory.SuppliersProfile" %>
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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    DataKeyNames="id" EnableModelValidation="True" ForeColor="#333333" GridLines="None"
                    OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                      <%--  <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="del">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:BoundField DataField="Company" HeaderText="Company" />
                        <asp:BoundField DataField="Address" HeaderText="Address" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" />
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                        <asp:BoundField DataField="TIN" HeaderText="TIN" />
                        <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" />
                        <asp:BoundField DataField="JobTitle" HeaderText="JobTitle" />
            <asp:BoundField DataField="BusinessPhone" HeaderText="BusinessPhone" />
            <asp:BoundField DataField="FaxNumber" HeaderText="FaxNumber" />
            <asp:BoundField DataField="ZipPostal" HeaderText="ZipPostal" />
            <asp:BoundField DataField="WebPage" HeaderText="WebPage" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>

</asp:Content>
