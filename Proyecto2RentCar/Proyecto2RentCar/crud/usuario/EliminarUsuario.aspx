<%@ Page Title="" Language="C#" MasterPageFile="~/IndexMaster.Master" AutoEventWireup="true" CodeBehind="EliminarUsuario.aspx.cs" Inherits="Proyecto2RentCar.crud.usuario.EliminarUsuario" %>

<asp:Content ID="ELiminarContentUsuario" ContentPlaceHolderID="ELiminarContentUsuario" runat="server">

    <form action="" class="form-horizontal" runat="server">
		<!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
			<!-- EL for es para poder enlazar el lebel con un input -->
			<div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Identificacion:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtidentificacion" AutoComplete="off" class="form-control" type="text" placeholder="Identificacion" runat="server"></asp:TextBox>
				</div>
			</div>
            
			<!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
			<div class="form-group">
				<!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
				<div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnDelete" class="btn btn-success" runat="server" Text="Eliminar" OnClick="btnDelete_Click" />
				</div>
			</div>

		<!-- </fieldset> -->
	</form>

</asp:Content>
