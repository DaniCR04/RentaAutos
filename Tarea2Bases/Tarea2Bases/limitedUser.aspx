<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="limitedUser.aspx.cs" Inherits="Tarea2Bases.limitedUser" %>

<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8">

		<title>Electrónica y Telecomunicaciones D & K</title>

		<meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">

		<!-- Latest compiled and minified CSS -->
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

        <link href="./css/css.css" rel="stylesheet" type="text/css">

        <link rel="shortcut icon" href="./Images/ico.jpg">
	</head>
	<body>
        <div class="container">
            <nav class="navbar navbar-inverse">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <a class="navbar-brand" href="./IndexEmployee.aspx">D & K</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Venta <span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="./crud/sale/InsertSale.aspx">Generar venta</a></li>
                            </ul>
                        </li>
                    </ul>
                    <div class="navbar-header">
                        <a href="./index.aspx" class="navbar-brand navbar-right">Cerrar sesión</a>
                    </div>
                </div><!-- /.navbar-collapse -->
            </nav>
        </div><!-- /.container-fluid -->
		<!-- Latest compiled and minified JavaScript -->
		<script src="https://code.jquery.com/jquery-3.1.1.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
	</body>
</html>