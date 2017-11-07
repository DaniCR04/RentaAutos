<%@ Page Title="" Language="C#" MasterPageFile="~/IndexMaster.Master" AutoEventWireup="true" CodeBehind="InsertarUsuario.aspx.cs" Inherits="Proyecto2RentCar.crud.usuario.InsertarUsuario" %>

<asp:Content ID="InsertContentUsuario" ContentPlaceHolderID="InsertContentUsuario" runat="server">

      <form action="" class="form-horizontal" runat="server">
		<!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
			<!-- EL for es para poder enlazar el lebel con un input -->
			<div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">identificacion:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtidentificacion" AutoComplete="off" class="form-control" type="text" placeholder="identificacion" runat="server"></asp:TextBox>
				</div>
			</div>
            
            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">tipoUsuario:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txttipoUsuario" AutoComplete="off" class="form-control" type="text" placeholder="tipoUsuario" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">nombre:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtnombre" AutoComplete="off" class="form-control" type="text" placeholder="nombre" runat="server"></asp:TextBox>
				</div>
			</div>
            
            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">apellidos:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtapellidos" AutoComplete="off" class="form-control" type="text" placeholder="apellidos" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">provincia:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtprovincia" AutoComplete="off" class="form-control" type="text" placeholder="provincia" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">canton:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtcanton" AutoComplete="off" class="form-control" type="text" placeholder="canton" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">distrito:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtdistrito"  AutoComplete="off" class="form-control" type="text" placeholder="distrito" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">correo:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtcorreo" AutoComplete="off" class="form-control" type="text" placeholder="correo" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">fechaRegistro:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtfechaRegistro" AutoComplete="off" class="form-control" type="text" placeholder="fechaRegistro" runat="server"></asp:TextBox>
				</div>
			</div>

			<!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
			<div class="form-group">
				<!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
				<div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnInsert" class="btn btn-success" runat="server" Text="Insertar" OnClick="btnInsert_Click" />
				</div>
			</div>

		<!-- </fieldset> -->
	</form>

</asp:Content>

