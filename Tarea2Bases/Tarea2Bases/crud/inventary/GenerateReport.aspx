<%@ Page Title="" Language="C#" MasterPageFile="~/crud/ReportSell.Master" AutoEventWireup="true" CodeBehind="GenerateReport.aspx.cs" Inherits="Tarea2Bases.crud.inventary.GenerateReportSell" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentGenerateReport" runat="server">
    <form action="" class="form-horizontal" runat="server">
		<!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
			<!-- EL for es para poder enlazar el lebel con un input -->
			<div class="form-group has-success">
				<!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
				<label class="control-label col-md-2" for="name">Producto:</label>

				<div class="col-md-4">
                    <asp:TextBox ID="txtProd" AutoComplete="off" class="form-control" type="text" placeholder="Nombre producto" runat="server"></asp:TextBox>
				</div>
			</div>

			<!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
			<div class="form-group">
				<!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
				<div class="col-md-2 col-md-offset-2">
                    <asp:Button ID="btnGenerate" Class="btn btn-success" runat="server" Text="Generar reporte" OnClick="btnGenerate_Click" />
				</div>
			</div>

		<!-- </fieldset> -->
	</form>
</asp:Content>

