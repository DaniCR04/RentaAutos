using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Tarea2Bases.Reports
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //server folder path which is stored your PDF documents
            string pdfFileName = Request.PhysicalApplicationPath + "\\files\\" + "GenerateHTMLTOPDF.pdf";

            string imagepath = Server.MapPath("../Images");

            //Create new PDF document 
            Document document = new Document(PageSize.A4, 20f, 20f, 20f, 20f);

            document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());

            PdfWriter.GetInstance(document, new FileStream(pdfFileName, FileMode.Create));
            document.Open();

            //Se carga la imagen
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagepath + "/report3.jpg");
            image.Alignment = Element.ALIGN_CENTER;
            document.Add(image);

            //Caracteristicas de la letra
            Font arial = FontFactory.GetFont("Arial", 28, Font.BOLDITALIC, new BaseColor(50, 205, 50));
            Paragraph paragraph = new Paragraph("Datos de factura", arial);
            paragraph.Alignment = Element.ALIGN_CENTER;

            document.Add(paragraph);

            //Generate table
            PdfPTable tableTitles = new PdfPTable(10);
            tableTitles.HorizontalAlignment = Element.ALIGN_LEFT;
            //actual width of table in points
            tableTitles.TotalWidth = 800f;
            //fix the absolute width of the table
            tableTitles.LockedWidth = true;

            //ancho de cada cuadro en puntos
            float[] values = new float[] { 20f, 20f, 200f, 200f, 200f, 200f, 200f, 200f, 200f, 200f };
            tableTitles.SetWidths(values);
            tableTitles.SpacingBefore = 20f;

            PdfPCell cellTitles = new PdfPCell();
            cellTitles.Colspan = 2;
            cellTitles.Border = 0;
            cellTitles.HorizontalAlignment = -1;
            tableTitles.AddCell(cellTitles);

            //Nombre de las columnas
            tableTitles.AddCell(new Paragraph("@earnings", FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, new BaseColor(255, 140, 0))));
            tableTitles.AddCell(new Paragraph("@total_sales", FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, new BaseColor(255, 140, 0))));
            tableTitles.AddCell(new Paragraph("@total_tax", FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, new BaseColor(255, 140, 0))));
            tableTitles.AddCell(new Paragraph("@Payroll", FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, new BaseColor(255, 140, 0))));
            tableTitles.AddCell(new Paragraph("@secure", FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, new BaseColor(255, 140, 0))));
            tableTitles.AddCell(new Paragraph("@totalService", FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, new BaseColor(255, 140, 0))));
            tableTitles.AddCell(new Paragraph("@totalProduct ", FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, new BaseColor(255, 140, 0))));
            tableTitles.AddCell(new Paragraph("@inversion ", FontFactory.GetFont("Arial", 10, Font.BOLDITALIC, new BaseColor(255, 140, 0))));

            document.Add(tableTitles);

            //setup connection to SQL and retrieve data
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            //Se obtiene la cantidad de filas que posee la tabla con base en el parametro de busqueda
            var dsTemp = new DataSet();
            var daTemp = new SqlDataAdapter(new SqlCommand("select count(*) as count from tb_invoice", conn));
            //El dataset llena el adapter
            daTemp.Fill(dsTemp); 

            var count = dsTemp.Tables[0].Rows[0]["count"];

            int n = 0, limit = Int32.Parse(count.ToString());

            string conex = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            string date = Request.QueryString["date"];

            if (n < limit)
            {
                //establecemos la conexion
                SqlConnection connection = new SqlConnection(conex);

                //sql de insercion
                string sqlStoredProcedure = "monthly_closing";
                SqlCommand cmdLog = new SqlCommand(sqlStoredProcedure, connection);

                //configurar el sql command
                cmdLog.CommandType = CommandType.StoredProcedure;

                //definir los parametros normales
                //cmdLog.Parameters.Add(new SqlParameter("@date", date));

                //definir los parametros output
                SqlParameter earnings = new SqlParameter("@earnings", SqlDbType.Money);
                earnings.Direction = ParameterDirection.Output;

                SqlParameter total_sales = new SqlParameter("@total_sales", SqlDbType.Money);
                total_sales.Direction = ParameterDirection.Output;

                SqlParameter total_tax = new SqlParameter("@total_tax", SqlDbType.Money);
                total_tax.Direction = ParameterDirection.Output;

                SqlParameter payroll = new SqlParameter("@Payroll", SqlDbType.Money);
                payroll.Direction = ParameterDirection.Output;

                SqlParameter secure = new SqlParameter("@secure", SqlDbType.Money);
                secure.Direction = ParameterDirection.Output;

                SqlParameter totalService = new SqlParameter("@totalService", SqlDbType.Money);
                totalService.Direction = ParameterDirection.Output;

                SqlParameter totalProduct = new SqlParameter("@totalProduct", SqlDbType.Money);
                totalProduct.Direction = ParameterDirection.Output;

                SqlParameter inversion = new SqlParameter("@inversion", SqlDbType.Money);
                @inversion.Direction = ParameterDirection.Output;

                //Se asignan los parametros ouput
                cmdLog.Parameters.Add(earnings);
                cmdLog.Parameters.Add(total_sales);
                cmdLog.Parameters.Add(total_tax);
                cmdLog.Parameters.Add(payroll);
                cmdLog.Parameters.Add(secure);
                cmdLog.Parameters.Add(totalService);
                cmdLog.Parameters.Add(totalProduct);
                cmdLog.Parameters.Add(inversion);
                cmdLog.Parameters.Add(new SqlParameter("@date", date));

                //ejecutamos el store procedure
                cmdLog.Connection.Open();
                cmdLog.ExecuteNonQuery();

                string getEarnings = "", getTotal_sales = "", getTotal_tax = "", getPayroll = "", getSecure = "",
                    getTotalService = "", getInversion = "", getTotalProduct = "";


                if (!string.IsNullOrEmpty(cmdLog.Parameters["@earnings"].Value.ToString())) {
                    getEarnings = cmdLog.Parameters["@earnings"].Value.ToString();
                }


                if (!string.IsNullOrEmpty(cmdLog.Parameters["@total_sales"].Value.ToString()))
                {
                    getTotal_sales = cmdLog.Parameters["@total_sales"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(cmdLog.Parameters["@total_tax"].Value.ToString()))
                {
                    getTotal_tax = cmdLog.Parameters["@total_tax"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(cmdLog.Parameters["@Payroll"].Value.ToString()))
                {
                    getPayroll = cmdLog.Parameters["@Payroll"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(cmdLog.Parameters["@secure"].Value.ToString()))
                {
                    getSecure = cmdLog.Parameters["@secure"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(cmdLog.Parameters["@totalService"].Value.ToString()))
                {
                    getTotalService = cmdLog.Parameters["@totalService"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(cmdLog.Parameters["@totalProduct"].Value.ToString()))
                {
                    getTotalProduct = cmdLog.Parameters["@totalProduct"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(cmdLog.Parameters["@inversion"].Value.ToString()))
                {
                    getInversion = cmdLog.Parameters["@inversion"].Value.ToString();
                }
             
                PdfPTable table = new PdfPTable(10);
                table.HorizontalAlignment = Element.ALIGN_LEFT;
                //actual width of table in points
                table.TotalWidth = 800f;
                //fix the absolute width of the table
                table.LockedWidth = true;

                //ancho de cada cuadro en puntos
                float[] widths = new float[] { 20f, 20f, 200f, 200f, 200f, 200f, 200f, 200f, 200f, 200f };
                table.SetWidths(widths);

                PdfPCell cell = new PdfPCell();
                cell.Colspan = 2;
                cell.Border = 0;
                cell.HorizontalAlignment = -1;
                table.AddCell(cell);

                /*Asignacion de columnas a la tabla*/
                table.AddCell(getEarnings.ToString());
                table.AddCell(getTotal_sales.ToString());
                table.AddCell(getTotal_tax.ToString());
                table.AddCell(getPayroll.ToString());
                table.AddCell(getSecure.ToString());
                table.AddCell(getTotalService.ToString());
                table.AddCell(getTotalProduct.ToString());
                table.AddCell(getInversion.ToString());

                document.Add(table);
            }

            document.Close();

            ShowPdf(pdfFileName);
        }

        public void ShowPdf(string filename)
        {
            //Clears all content output from Buffer Stream
            Response.ClearContent();
            //Clears all headers from Buffer Stream
            Response.ClearHeaders();
            //Gets or Sets the HTTP MIME type of the output stream
            Response.ContentType = "application/pdf";
            //Writes the content of the specified file directory to an HTTP response output stream as a file block
            Response.WriteFile(filename);
            //sends all currently buffered output to the client
            Response.Flush();
            //Clears all content output from Buffer Stream
            Response.Clear();
        }
    }
}