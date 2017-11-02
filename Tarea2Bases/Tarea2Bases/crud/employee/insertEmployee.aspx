<%@ Page Title="" Language="C#" MasterPageFile="~/crud/indexEmployee.Master" AutoEventWireup="true" CodeBehind="insertEmployee.aspx.cs" Inherits="Tarea2Bases.crud.employee.InsertEmployee" %>

<asp:Content ID="ContentInsertEmployee" ContentPlaceHolderID="ContentInsertEmployee" runat="server">
    <form action="" class="form-horizontal" runat="server">
		<!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
			<!-- EL for es para poder enlazar el lebel con un input -->
			<div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Cédula:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtDni" class="form-control" type="text" placeholder="Cédula" runat="server"></asp:TextBox>
				</div>
			</div>
            
            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Nombre:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtName" class="form-control" type="text" placeholder="Nombre" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Apellido:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtLastName" class="form-control" type="text" placeholder="Apellido" runat="server"></asp:TextBox>
				</div>
			</div>
            
            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Salario:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtSalary" class="form-control" type="text" placeholder="Salario" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Teléfono:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtPhone" class="form-control" type="text" placeholder="Teléfono" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Número de cueta:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtAccount" class="form-control" type="text" placeholder="Número de cueta" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Número seguro social:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtSocial_sec" class="form-control" type="text" placeholder="Número seguro social" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Ciudad:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtCity" class="form-control" type="text" placeholder="Ciudad" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Distrito:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtDistrict" class="form-control" type="text" placeholder="Distrito" runat="server"></asp:TextBox>
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

