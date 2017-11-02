<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Tarea2Bases.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Electrónica y Telecomunicaciones D & K</title>

            <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">

		    <!-- Latest compiled and minified CSS -->
		    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

            <script src="//code.jquery.com/jquery-1.12.0.min.js"></script>
            <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>  
            <script>
                $(document).ready(function()
                {
                    $("#mostrarmodal").modal("show");
                });
            </script>
        
            <link rel="shortcut icon" href="./Images/ico.jpg">
    </head>
    <body>
        <div class="modal fade" id="mostrarmodal" tabindex="-1" role="dialog" aria-labelledby="basicModal" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                            <h3>Login de usuario</h3>
                        </div>
                        <div class="modal-body">
                            <form id="form3" runat="server" class="form-horizontal">
                                <!-- EL for es para poder enlazar el lebel con un input -->
					            <div class="form-group has-success">
						            <!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
						            <label class="control-label col-md-2" for="name">Usuario:</label>

						            <div class="col-md-10">
                                        <asp:TextBox class="form-control" ID="txtEmpl" AutoComplete="off" placeholder="Usuario" runat="server"></asp:TextBox>
						            </div>
					            </div>
                                <div class="form-group has-success">
						            <!-- control-label : Nos permite trabajar el label por columnas y ademas centrarlo verticalmente el label,sirve para presentar diferentes estilos con el has- -->
						            <label class="control-label col-md-2" for="name">Contraseña:</label>

						            <div class="col-md-10">
                                        <asp:TextBox class="form-control" type="password"  ID="txtPass" AutoComplete="off" placeholder="Contraseña" runat="server"></asp:TextBox>
						            </div>
					            </div>
                                <div>
                                    <asp:Button ID="btnLogin" class="btn btn-success" runat="server" Text="Login" OnClick="btnLogin_Click" />
                                </div>
                            </form><!-- form -->
                        </div>
                    </div>
                </div>
            </div>
    </body>
</html>