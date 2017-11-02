<%@ Page Title="" Language="C#" MasterPageFile="~/crud/ReportSell.Master" AutoEventWireup="true" CodeBehind="ShowReport.aspx.cs" Inherits="Tarea2Bases.crud.inventary.ShowReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ShowSellsReport" runat="server">
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="idProduct" HeaderText="idProduct" SortExpression="idProduct" />
            <asp:BoundField DataField="quantityInStock" HeaderText="quantityInStock" SortExpression="quantityInStock" />
            <asp:BoundField DataField="priceInStock" HeaderText="priceInStock" SortExpression="priceInStock" />
            <asp:BoundField DataField="totalPriceInStock" HeaderText="totalPriceInStock" SortExpression="totalPriceInStock" />
            <asp:BoundField DataField="totalQuantitysell" HeaderText="totalQuantitysell" SortExpression="totalQuantitysell" />
            <asp:BoundField DataField="totalPriceSell" HeaderText="totalPriceSell" SortExpression="totalPriceSell" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="sp_getReportSell" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </form>
</asp:Content>
