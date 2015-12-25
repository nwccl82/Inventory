<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="Inventory.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
<tr>
<td><asp:Label ID="lblLastName" runat="server" Text="Last Name : "></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
    
    <asp:Button ID="btnSearch" runat="server" Text="Search" 
        onclick="btnSearch_Click" />
</td>
</tr>
  <tr>
            <td colspan='2'>
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
                        <asp:BoundField DataField="Login" HeaderText="Login" />
                        <asp:BoundField DataField="FullName" HeaderText="FullName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <%--<asp:BoundField DataField="fullName" HeaderText="Full Name" />--%>
                        <%--<asp:BoundField DataField="address" HeaderText="Address" />--%>
                        <%--<asp:BoundField DataField="phoneNo" HeaderText="Phone No" />
            <asp:BoundField DataField="cellphoneNo" HeaderText="CellPhone No" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="position" HeaderText="Position" />--%>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
            </td>
        </tr>
</table>
</asp:Content>
