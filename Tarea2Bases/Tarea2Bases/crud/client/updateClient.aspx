<%@ Page Title="" Language="C#" MasterPageFile="~/crud/indexClient.Master" AutoEventWireup="true" CodeBehind="updateClient.aspx.cs" Inherits="Tarea2Bases.crud.client.UpdateClient" %>

<asp:Content ID="ContentUpdateClient" ContentPlaceHolderID="ContentUpdateClient" runat="server">
    <form action="" class="form-horizontal" runat="server">
            
            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Cédula:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtLoadCli" AutoComplete="off" class="form-control" type="text" placeholder="Cédula" runat="server"></asp:TextBox>
				</div>
			</div>
            <div class="form-group">
				<!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
				<div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnLoadCli" class="btn btn-success" runat="server" Text="Cargar Datos" OnClick="txtLoadCli_Click" />
				</div>
			</div>

		    <!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
			<!-- EL for es para poder enlazar el lebel con un input -->
			<div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Cédula:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtDni" AutoComplete="off" class="form-control" type="text" placeholder="Cédula" runat="server"></asp:TextBox>
				</div>
			</div>
            
            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Nombre:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtName" AutoComplete="off" class="form-control" type="text" placeholder="Nombre" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Apellido:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtLastName" AutoComplete="off" class="form-control" type="text" placeholder="Apellido" runat="server"></asp:TextBox>
				</div>
			</div>
            
            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Número de teléfono:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtPhone_number" AutoComplete="off" class="form-control" type="text" placeholder="Número de teléfono" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Código postal:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtPostal_code" AutoComplete="off" class="form-control" type="text" placeholder="Código postal" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Número de ruc:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtRuc" AutoComplete="off" class="form-control" type="text" placeholder="Número de ruc" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Ciudad:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtCity"  AutoComplete="off" class="form-control" type="text" placeholder="Ciudad" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Distrito:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtDistrict" AutoComplete="off" class="form-control" type="text" placeholder="Distrito" runat="server"></asp:TextBox>
				</div>
			</div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
			<!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
			<div class="form-group">
				<!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
				<div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnUpdate" class="btn btn-success" runat="server" Text="Actualizar" OnClick="btnUpdate_Click" />
				</div>
			</div>

		<!-- </fieldset> -->
	</form>
</asp:Content>
