using Neodynamic.SDK.Web;
using System;
using System.Web.UI;

namespace PrintWithWebClientPrint
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PrintFile file = null;
            string filePath = @"~/FIle/Document.pdf";
            string fileName = Guid.NewGuid().ToString("N");
            file = new PrintFilePDF(MapPath(filePath), fileName);
            ((PrintFilePDF)file).PrintRotation = PrintRotation.None;

            ClientPrintJob cpj = new ClientPrintJob
            {
                PrintFile = file,
                ClientPrinter = new DefaultPrinter()
                //ClientPrinter =  new NetworkPrinter("192.168.1.1.8", 9100)
            };
            var pr = cpj.GetContent();
            System.Web.HttpContext.Current.Response.ContentType = "application/octet-stream";
            System.Web.HttpContext.Current.Response.BinaryWrite(cpj.GetContent());
            System.Web.HttpContext.Current.Response.End();
        }
    }
}