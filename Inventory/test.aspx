<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Inventory.test" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
        <Report FileName="CrystalReport1.rpt">
        </Report>
</CR:CrystalReportSource>
<CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
    AutoDataBind="true" ReportSourceID="CrystalReportSource1" />
</asp:Content>
