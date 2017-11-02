<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertSaleLimited.aspx.cs" Inherits="Tarea2Bases.crud.sale.insertSaleLimited" %>


<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8">

		<title>Electrónica y Telecomunicaciones D & K</title>

		<meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">

		<!-- Latest compiled and minified CSS -->
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

        <link href="../../css/css.css" rel="stylesheet" type="text/css">

        <link rel="shortcut icon" href="../../Images/ico.jpg">
	</head>
	<body>
        <div class="container">
            <nav class="navbar navbar-inverse">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <a class="navbar-brand">D & K</a>
                </div>

                <div class="navbar-header">
                    <a href="../../limitedUser.aspx" class="navbar-brand navbar-right">Volver a la pagina principal</a>
                </div>
            </nav>

            <form action="" class="form-horizontal div-color " runat="server">
                <center><h1 class="div-color">Generación de la venta</h1></center>
                <!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
                <!-- EL for es para poder enlazar el lebel con un input -->
                <div class="form-group has-success">
                    <!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
                    <label class="control-label col-md-2" for="name">Cédula empleado:</label>

                    <div class="col-md-4">
                        <asp:TextBox ID="txtCedEmp" class="form-control" type="text" placeholder="Cédula empleado" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group has-success">
                    <!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
                    <label class="control-label col-md-2" for="name">Cédula Cliente:</label>

                    <div class="col-md-4">
                        <asp:TextBox ID="txtCedCli" class="form-control" type="text" placeholder="Cédula Cliente" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
                <div class="form-group">
                    <!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
                    <div class="col-md-2 col-md-offset-2">
                        <asp:Button ID="btnInertSale" class="btn btn-success" runat="server" Text="Agregar venta" OnClick="btnInertSale_Click" />
                    </div>
                </div>
            
                <center><h1 class="div-color">Contenido de producto</h1></center>
                <!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
                <!-- EL for es para poder enlazar el lebel con un input -->
                <div class="form-group has-success">
                    <!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
                    <label class="control-label col-md-2" for="name">Producto:</label>

                    <div class="col-md-4">
                        <asp:TextBox ID="txtIdPro" class="form-control" type="text" placeholder="Producto" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group has-success">
                    <!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
                    <label class="control-label col-md-2" for="name">Cantidad:</label>

                    <div class="col-md-4">
                        <asp:TextBox ID="txtQuant" class="form-control" type="text" placeholder="Cantidad" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
                <div class="form-group">
                    <!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
                    <div class="col-md-2 col-md-offset-2">
                        <asp:Button ID="btnInsertCp" class="btn btn-success" runat="server" Text="Agregar contenido de producto" OnClick="Button1_Click" />
                    </div>
                </div>
                <!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
                <div class="form-group">
                    <!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
                    <div class="col-md-2 col-md-offset-2">
                        <asp:Button ID="btnDelPro" class="btn btn-warning" runat="server" Text="Quitar contenido de producto" OnClick="btnDelPro_Click" />
                    </div>
                </div>

            
                <center><h1 class="div-color">Contenido de servicio</h1></center>
                <!-- <fieldset disabled> : Desabilita todos los componentes dentro del formulario-->
                <!-- EL for es para poder enlazar el lebel con un input -->
                <div class="form-group has-success">
                    <!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
                    <label class="control-label col-md-2" for="name">Servicio:</label>

                    <div class="col-md-4">
                        <asp:TextBox ID="txtService" class="form-control" type="text" placeholder="Servicio" runat="server"></asp:TextBox>
                    </div>
                </div>

                <!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
                <div class="form-group">
                    <!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
                    <div class="col-md-2 col-md-offset-2">
                        <asp:Button ID="btnInsertCS" class="btn btn-success" runat="server" Text="Agregar contenido de servicio" OnClick="btnInsertCS_Click" />
                    </div>
                </div>

                <!-- Se encierra el boton en un form-group a pesar de ser un unico elemento por que debe trabajarse por columnas -->
                <div class="form-group">
                    <!-- col-md-offset-2 acomoda el elemento a la derecha dos columnas -->
                    <div class="col-md-2 col-md-offset-2">
                        <asp:Button ID="btnDeleteContent" class="btn btn-warning" runat="server" Text="Quitar contenido de servicio" OnClick="btnDeleteContent_Click" />
                    </div>
                </div>
                <br />
                <!-- </fieldset> -->
            </form>

        </div><!-- /.container-fluid -->
		<!-- Latest compiled and minified JavaScript -->
		<script src="https://code.jquery.com/jquery-3.1.1.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
	</body>
</html>