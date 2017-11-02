﻿<%@ Page Title="" Language="C#" MasterPageFile="~/crud/indexService.Master" AutoEventWireup="true" CodeBehind="updateService.aspx.cs" Inherits="Tarea2Bases.crud.service.UpdateService" %>

<asp:Content ID="ContentUpdateService" ContentPlaceHolderID="ContentUpdateService" runat="server">
    <form action="" class="form-horizontal" runat="server">

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Tipo de servicio:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtLoad" AutoComplete="off" class="form-control" type="text" placeholder="Tipo de servicio" runat="server"></asp:TextBox>
				</div>
			</div>

			<!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
			<div class="form-group">
				<!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
				<div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnLoadService" class="btn btn-success" runat="server" Text="Cargar datos" OnClick="btnLoadService_Click" />
				</div>
			</div>
		    <!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
			<!-- EL for es para poder enlazar el lebel con un input -->
			<div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Tipo de servicio:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtTypeService" AutoComplete="off" class="form-control" type="text" placeholder="Tipo de servicio" runat="server"></asp:TextBox>
				</div>
			</div>

            <div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Precio:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtPrice" AutoComplete="off" class="form-control" type="text" placeholder="Precio" runat="server"></asp:TextBox>
				</div>
			</div>

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
