<%@ Page Title="" Language="C#" MasterPageFile="~/crud/indexPaysheet.Master" AutoEventWireup="true" CodeBehind="GeneratePaysheet.aspx.cs" Inherits="Tarea2Bases.crud.paysheet.GeneratePaysheet" %>

<asp:Content ID="ContentPaysheet" ContentPlaceHolderID="ContentPaysheet" runat="server">
    <div class="row">
        <div class="col-lg-8">
            <i class="fa fa-bar-chart-o fa-fw"></i> Nómina

            <form id="form1" runat="server" class="form-horizontal">
                <div class="form-group">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="#009933"></asp:Calendar>
                </div>
                <div class="form-group">
                    <div class="col-sm-2">
                        <asp:Button ID="btnGenerate" class="btn btn-success" runat="server" Text="Generar nómina" OnClick="btnGenerate_Click" />
                    </div>
                </div>
            </form>
        </div>
           
            <!-- /.panel -->
        </div>
    </div>
</asp:Content>
