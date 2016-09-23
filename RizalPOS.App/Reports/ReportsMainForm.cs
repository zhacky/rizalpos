using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using ContentAlignment = System.Windows.Forms.VisualStyles.ContentAlignment;

namespace RizalPOS.App.Reports
{
    public partial class ReportsMainForm : MetroForm
    {
        public ReportsMainForm()
        {
            InitializeComponent();
        }

        private void ReportsMainForm_Load(object sender, EventArgs e)
        {
            SetupPDFPage();
        }

        private void SetupPDFPage()
        {
            //var document = new Document(PageSize.LETTER, 50, 50, 25, 25);
            //var output = new MemoryStream();
            //var writer = PdfWriter.GetInstance(document, output);
            //// -- open document to begin writing
            //document.Open();
            //// -- create the fonts

            pdf_url = string.Format("{0}{1}", Application.StartupPath, @"\Reports\pdfs\sampler.pdf");
            newpdf_url = string.Format("{0}{1}", Application.StartupPath, @"\Reports\pdfs\sampler2.pdf");
            Console.WriteLine(pdf_url);
            ReportBrowser.Navigate(pdf_url);
        }

        private string pdf_url;
        private string newpdf_url;
        private void Vandalize()
        {
            var reader = new PdfReader(pdf_url);
            var size = reader.GetPageSizeWithRotation(1);
            var doc = new Document(size);

            // open the writer
            var fs = new FileStream(newpdf_url, FileMode.Create, FileAccess.Write);
            var writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            // pdf content
            var cb = writer.DirectContent;
            var bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            cb.SetColorFill(BaseColor.LIGHT_GRAY);
            cb.SetFontAndSize(bf,8);
            // coordinates
            // write text
            cb.BeginText();
            string txt = "This is the method.";
            cb.ShowTextAligned(1,txt, 200, 200,0);
            cb.ShowText("Show text only");
            cb.EndText();
            

            doc.Close();
            fs.Close();
            writer.Close();
           reader.Close();
           ReportBrowser.Navigate(newpdf_url);


        }

        private void VandalizeButton_Click(object sender, EventArgs e)
        {
            Vandalize();
        }

        
    }
}
