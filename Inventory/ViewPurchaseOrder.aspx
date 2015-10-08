<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPurchaseOrder.aspx.cs" Inherits="Inventory.ViewPurchaseOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="View PO Form"></asp:Label>
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
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    DataKeyNames="id" EnableModelValidation="True" ForeColor="#333333" GridLines="None"
                    OnSelectedIndexChanged="GridView_SelectedIndexChanged" OnRowCommand="GridView_RowCommand"
                    AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
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
                        <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" />
                        <asp:BoundField DataField="ExpectedDate" HeaderText="ExpectedDate" />
                        <asp:BoundField DataField="PaymentAmount" HeaderText="PaymentAmount" />
                        <%--<asp:BoundField DataField="SupplierID" HeaderText="SupplierID" />--%>
                        <asp:BoundField DataField="TIN" HeaderText="TIN" />
                        <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" />
                        <asp:BoundField DataField="BusinessPhone" HeaderText="BusinessPhone" />
                        <%--<asp:BoundField DataField="CreatedById" HeaderText="CreatedById" />--%>
                        <asp:BoundField DataField="FullName" HeaderText="FullName" />
                        <%-- <asp:BoundField DataField="cellphoneNo" HeaderText="CellPhone No" />
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
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Detail Form"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    DataKeyNames="id" EnableModelValidation="True" ForeColor="#333333" GridLines="None"
                    OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnRowCommand="GridView2_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <%-- <asp:CommandField ShowSelectButton="True" />--%>
                        <%--  <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="del">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:BoundField DataField="ProductID" HeaderText="ProductID" />
                        <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="UnitCost" HeaderText="UnitCost" />
                       <%-- <asp:BoundField DataField="Weight" HeaderText="Weight" />
                        <asp:BoundField DataField="UnitOfMeasure" HeaderText="UnitOfMeasure" />--%>
                        <%-- <asp:BoundField DataField="cellphoneNo" HeaderText="CellPhone No" />
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
