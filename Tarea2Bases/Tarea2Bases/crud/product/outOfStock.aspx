<%@ Page Title="" Language="C#" MasterPageFile="~/crud/indexProduct.Master" AutoEventWireup="true" CodeBehind="outOfStock.aspx.cs" Inherits="Tarea2Bases.crud.product.outOfStock" %>

<asp:Content ID="ContentOutStockProduct" ContentPlaceHolderID="ContentOutStockProduct" runat="server">
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
            <asp:BoundField DataField="maker" HeaderText="maker" SortExpression="maker" />
            <asp:BoundField DataField="admission_date" HeaderText="admission_date" SortExpression="admission_date" />
            <asp:CheckBoxField DataField="active_product" HeaderText="active_product" SortExpression="active_product" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="sp_get_out_stock_product" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </form>
</asp:Content>
