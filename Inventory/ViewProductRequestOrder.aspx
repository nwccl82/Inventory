<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ViewProductRequestOrder.aspx.cs" Inherits="Inventory.ViewProductRequestOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="View Product Request Order"></asp:Label>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Summary Form"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id"
                    CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="Company" HeaderText="Company" />
                        <asp:BoundField DataField="Address" HeaderText="Address" />
                        <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" />
                        <asp:BoundField DataField="ExpectedDate" HeaderText="ExpectedDate" />
                        <asp:BoundField DataField="PaymentAmount" HeaderText="PaymentAmount" />
                        <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" />
                        <asp:BoundField DataField="TIN" HeaderText="TIN" />
                        <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" />
                        <asp:BoundField DataField="BusinessPhone" HeaderText="BusinessPhone" />
                        <asp:BoundField DataField="CreatedById" HeaderText="CreatedById" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Detail Form:"></asp:Label>
            </td>
            <td>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:BoundField DataField="ProductID" HeaderText="ProductID" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="UnitCost" HeaderText="UnitCost" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
