using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.IO;

namespace LouvreLIS_Client
{
    public partial class PreviewTicketForm : Form
    {
        public PreviewTicketForm()
        {
            InitializeComponent();
        }
        LouvreEntities Entities = new LouvreEntities();
        TicketData FindData = null;
        Dictionary<string, string> bookmarksToReplace = null;
        public void GetDataAndRun(string ticket)
        {
            this.Text = $"Preview Ticket-{ticket}";
            FindData = Entities.TicketDatas.FirstOrDefault(x => x.TicketNumber == ticket);
            if (FindData != null)
            {
                Microsoft.Office.Interop.Word.Application WordApp = new Microsoft.Office.Interop.Word.Application();
                Document Doc = WordApp.Documents.Open(System.Windows.Forms.Application.StartupPath + "\\Ticket Example.docx");
                bookmarksToReplace = new Dictionary<string, string>
            {
                { "Name", FindData.Visitor.Account.LastName+" "+FindData.Visitor.Account.FirstName },
                { "Name2", FindData.Visitor.Account.LastName+" "+FindData.Visitor.Account.FirstName },
                {"Price",FindData.PriceEUR.ToString()},
                {"PurchaseDate",FindData.PurchaseDate.Value.ToString("MM/dd/yyyy")},
                {"PurchaseTime",FindData.PurchaseDate.Value.ToString("HH:mm")},
                {"TicketNumber",ticket},
                {"VisitDate",FindData.VisitDateTime.ToString("MM/dd/yyyy")},
                {"VisitTime",FindData.VisitDateTime.ToString("HH:mm")},
                {"QRCODE",System.Windows.Forms.Application.StartupPath + "\\image.jpg"}
            };
                foreach (var item in bookmarksToReplace)
                {
                    Bookmark bookmark = Doc.Bookmarks[item.Key];
                    if (item.Key != "QRCODE")
                    {
                        bookmark.Range.Text = item.Value;
                        Doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                    else
                    {
                        InlineShape picture = bookmark.Range.InlineShapes.AddPicture(item.Value);
                        picture.Width = 97;
                        picture.Height = 97;
                        Doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                }
                Doc.ExportAsFixedFormat(System.Windows.Forms.Application.StartupPath + "\\Ticket.pdf", WdExportFormat.wdExportFormatPDF);
                Doc.Close(false);
                WordApp.Quit();
                webBrowser1.Navigate(System.Windows.Forms.Application.StartupPath + "\\Ticket.pdf");
            }
        }
        public void GetQRCode()
        {
            var HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string JsonData = JsonSerializer.Serialize(new
            {
                Text = FindData.InternalserialNumber,
                SizePixels = 220,
                CorrectionLevel = 0
            });
            HttpContent content = new StringContent(JsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage Response = HttpClient.PostAsync("http://localhost:500/Image/GenerateQRCode", content).Result;
            if (Response.IsSuccessStatusCode)
            {
                byte[] imageBytes = Response.Content.ReadAsByteArrayAsync().Result;
                File.WriteAllBytes(System.Windows.Forms.Application.StartupPath + "\\image.jpg", imageBytes);
            }
        }
        private void SavePDFBtn_Click(object sender, EventArgs e)
        {
            if (FindData != null)
            {
                Microsoft.Office.Interop.Word.Application WordApp = new Microsoft.Office.Interop.Word.Application();
                Document Doc = WordApp.Documents.Open(System.Windows.Forms.Application.StartupPath + "\\Ticket Example.docx");
                GetQRCode();
                foreach (var item in bookmarksToReplace)
                {
                    Bookmark bookmark = Doc.Bookmarks[item.Key];
                    if (item.Key != "QRCODE")
                    {
                        bookmark.Range.Text = item.Value;
                        Doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                    else
                    {
                        InlineShape Picture = bookmark.Range.InlineShapes.AddPicture(item.Value);
                        Picture.Width = 97;
                        Picture.Height = 97;
                        Doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                }
                Doc.ExportAsFixedFormat(System.Windows.Forms.Application.StartupPath + "\\Tickets.pdf", WdExportFormat.wdExportFormatPDF);
                Doc.Close(false);
                WordApp.Quit();
            }
        }
    }
}
