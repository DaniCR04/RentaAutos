<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="Tarea2Bases.error" %>

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
                            <h3>Error de datos de usuario</h3>
                        </div>
                        <div class="modal-body">

                            Error !!! los de datos suministrados no son correctos
                            <br/>
                            <br/>
                            <form id="form3" runat="server" class="form-horizontal">
                                <div>
                                    <asp:Button ID="btnLogin" class="btn btn-warning" runat="server" Text="Continuar" OnClick="btnLogin_Click" />
                                </div>
                            </form><!-- form -->
                        </div>
                    </div>
                </div>
            </div>
    </body>
</html>