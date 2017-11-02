<%@ Page Title="" Language="C#" MasterPageFile="~/crud/indexProduct.Master" AutoEventWireup="true" CodeBehind="insertProduct.aspx.cs" Inherits="Tarea2Bases.crud.product.IndexInsertProduct" %>

<asp:Content ID="ContentInsertProduct" ContentPlaceHolderID="ContentInsertProduct" runat="server">
    <form action="" class="form-horizontal" runat="server">
		<!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
			<!-- EL for es para poder enlazar el lebel con un input -->
			<div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Producto:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtProd" AutoComplete="off" class="form-control" type="text" placeholder="Producto" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Precio:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtPrice" AutoComplete="off" class="form-control" type="text" placeholder="Precio" runat="server"></asp:TextBox>
				</div>
			</div>
            
            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Cantidad:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtQuan" AutoComplete="off" class="form-control" type="text" placeholder="Cantidad" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Fabricante:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtMaker" AutoComplete="off" class="form-control" type="text" placeholder="Fabricante" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Fecha de ingreso:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtAdmission_date" AutoComplete="off" class="form-control" type="text" placeholder="Fecha de ingreso" runat="server"></asp:TextBox>
				</div>
			</div>

			<!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
			<div class="form-group">
				<!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
				<div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnSend" runat="server" Text="Insertar" class="btn btn-success" OnClick="btnSend_Click" />
				</div>
			</div>

		<!-- </fieldset> -->
	</form>
</asp:Content>
