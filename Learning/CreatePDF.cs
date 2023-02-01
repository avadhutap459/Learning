
using System.Net.Mail;
using System.Net;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iText.Html2pdf;

namespace Learning
{
    public class CreatePDF
    {
        public void GeneratePDF()
        {

            byte[] bytes;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            //  string strHtml = string.Empty;
            HtmlConverter.ConvertToPdf(
      new FileInfo(@"D:\Dumpy.html"),
      new FileInfo(@"C:\Users\AVDUT\Downloads\sample (1).pdf")
  );

            string htmlFileName = @"D:\Dumpy.html";
            string QMAP_HTML = File.ReadAllText(htmlFileName);

            string CSSFileName = @"D:\QMapCssFile.css";
            string QMAP_Css = File.ReadAllText(CSSFileName);

            StringReader sr = new StringReader(QMAP_HTML);
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                pdfDoc.Open();

                htmlparser.Parse(sr);
                pdfDoc.Close();

                bytes = memoryStream.ToArray();
                memoryStream.Close();
            }


            string FROM = "assessment@questaenneagram.com";
            string FROMNAME = "Questa Enneagram Assessment";

            string TO = "parabavadhut18@gmail.com";

            //string[] BCC = ObjMailBody.BCCEmail.Split(';');//"support@questaenneagram.com";

            string RecevierName = "Avadhut"; //+ ' ' + ObjMailBody.RecevierLastName;

            string SMTP_USERNAME = "AKIAYNH52N4VNGNPG774";

            string SMTP_PASSWORD = "BLhNdOkLRjvzh2VQO3v5dgu5AK1LnBpYFVUWQljxEP5e";

            string CONFIGSET = "QuestaEmailServer";

            string HOST = "email-smtp.ap-south-1.amazonaws.com";

            int PORT = Convert.ToInt32(587);

            string SUBJECT = "Questa Enneagram Assessment - Complete Personality Assessment";

            // The body of the email
            string HTMLContent = "<html><head><style>.image{margin - left: auto; margin - right: auto;}p{font-size: 12px;font-family: Arial, Helvetica, sans-serif;text-align: justify;text-align-last: left;-moz-text-align-last: left;}";
            HTMLContent = HTMLContent + ".image - container {justify - content: center;}li{font-size: 12px;font-family: Arial, Helvetica, sans-serif;text-align: justify;text-align-last: left;-moz-text-align-last: left;}.border{border: 1px solid black;}</style></head><body>";
            string HTMLEndContent = "<p>Please find attachment</p></body></html> ";
            string BODY = HTMLContent + HTMLEndContent;


            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            //create Alrternative HTML view
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(BODY, null, "text/html");


            //Add view to the Email Message
            message.AlternateViews.Add(htmlView);

            message.From = new MailAddress(FROM, FROMNAME);
            message.To.Add(new MailAddress(TO));
            message.Subject = SUBJECT;
            message.Body = BODY;



            var memStream = new MemoryStream(bytes);
            memStream.Position = 0;
            var contentType = new System.Net.Mime.ContentType(System.Net.Mime.MediaTypeNames.Application.Pdf);
            var reportAttachment = new Attachment(memStream, contentType);

            reportAttachment.ContentDisposition.FileName = RecevierName + "-Questa Enneagram Assessment Profile.pdf";
            message.Attachments.Add(reportAttachment);




            message.Headers.Add("X-SES-CONFIGURATION-SET", CONFIGSET);

            using (var client1 = new System.Net.Mail.SmtpClient(HOST, PORT))
            {
                // Pass SMTP credentials
                client1.Credentials = new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

                // Enable SSL encryption
                client1.EnableSsl = true;

                client1.Send(message);

                client1.Dispose();

            }

            message.Dispose();
        }
    }
}
