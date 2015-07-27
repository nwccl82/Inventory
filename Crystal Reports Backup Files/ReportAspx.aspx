<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportAspx.aspx.cs" Inherits="Inventory.ReportAspx" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692FBEA5521E1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
        <Report FileName="Cr1.rpt">
        </Report>
    </CR:CrystalReportSource>
    <CR:CrystalReportViewer runat="server" AutoDataBind="true" 
        ReportSourceID="CrystalReportSource1" ID="CrystalReportViewer1">
    </CR:CrystalReportViewer>
    </asp:Content>
