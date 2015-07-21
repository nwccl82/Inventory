<%@ Page Title="View DR SI Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ViewDRSIForm.aspx.cs" Inherits="Inventory.ViewDRSIForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="View DR SI Form"></asp:Label>
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
                    OnSelectedIndexChanged="GridView_SelectedIndexChanged" 
                    OnRowCommand="GridView_RowCommand" AllowPaging="True" 
                    onpageindexchanging="GridView1_PageIndexChanging">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <%--  <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="del">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:BoundField DataField="Company" HeaderText="Company" />
                        <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
                        <asp:BoundField DataField="TotalPcs" HeaderText="TotalPcs" />
                        <asp:BoundField DataField="TotalUOM" HeaderText="TotalUOM" />
                        <asp:BoundField DataField="TotalWeight" HeaderText="TotalWeight" />
                        <asp:BoundField DataField="TotalUnitCost" HeaderText="TotalUnitCost" />
                        <asp:BoundField DataField="TotalCost" HeaderText="TotalCost" />
                        <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" />
                        <asp:BoundField DataField="OrderBy" HeaderText="OrderBy" />
                        <asp:BoundField DataField="CheckBy" HeaderText="CheckBy" />
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
                        <asp:BoundField DataField="BatchNo" HeaderText="BatchNo" />
                        <asp:BoundField DataField="ModuleNo" HeaderText="ModuleNo" />
                        <asp:BoundField DataField="CageNo" HeaderText="CageNo" />
                        <asp:BoundField DataField="Weight" HeaderText="Weight" />
                        <asp:BoundField DataField="UnitOfMeasure" HeaderText="UnitOfMeasure" />
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
