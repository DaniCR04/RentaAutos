+<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="example.aspx.cs" Inherits="Tarea2Bases.example" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title></head><body><form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="sp_select_product" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <div>
    
    </div>
    </form>
</body>
</html>
