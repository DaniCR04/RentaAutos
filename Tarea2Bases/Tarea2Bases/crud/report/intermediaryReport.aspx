<%@ Page Title="" Language="C#" MasterPageFile="~/crud/indexReport.Master" AutoEventWireup="true" CodeBehind="intermediaryReport.aspx.cs" Inherits="Tarea2Bases.crud.report.IntermediaryReport" %>

<asp:Content ID="ContentReport" ContentPlaceHolderID="ContentReport" runat="server">
    <form action="" class="form-horizontal" runat="server">
		<!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
			<!-- EL for es para poder enlazar el lebel con un input -->
			<div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Fecha:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtRepo" class="form-control" type="text" placeholder="Fecha" runat="server"></asp:TextBox>
				</div>
			</div>

			<!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
			<div class="form-group">
				<!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
				<div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnRep" runat="server" Text="Report" class="btn btn-success" OnClick="btnRep_Click"/>
				</div>
			</div>

		<!-- </fieldset> -->
	</form>
</asp:Content>

