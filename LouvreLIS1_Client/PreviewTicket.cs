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
        LouvreEntities entities = new LouvreEntities();
        TicketData find = null;
        Dictionary<string, string> bookmarksToReplace = null;
        public void getdataandrun(string ticket)
        {
            this.Text = $"Preview Ticket-{ticket}";
            find = entities.TicketDatas.FirstOrDefault(x => x.TicketNumber == ticket);
            if (find != null)
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document doc = wordApp.Documents.Open(System.Windows.Forms.Application.StartupPath + "\\Ticket Example.docx");
                var asd = doc.Bookmarks;
                bookmarksToReplace = new Dictionary<string, string>
            {
                { "Name", find.Visitor.Account.LastName+" "+find.Visitor.Account.FirstName },
                { "Name2", find.Visitor.Account.LastName+" "+find.Visitor.Account.FirstName },
                {"Price",find.PriceEUR.ToString()},
                {"PurchaseDate",find.PurchaseDate.Value.ToString("MM/dd/yyyy")},
                {"PurchaseTime",find.PurchaseDate.Value.ToString("HH:mm")},
                {"TicketNumber",ticket},
                {"VisitDate",find.VisitDateTime.ToString("MM/dd/yyyy")},
                {"VisitTime",find.VisitDateTime.ToString("HH:mm")},
                {"QRCODE",System.Windows.Forms.Application.StartupPath + "\\image.jpg"}
            };
                foreach (var item in bookmarksToReplace)
                {
                    Bookmark bookmark = doc.Bookmarks[item.Key];
                    if (item.Key != "QRCODE")
                    {
                        bookmark.Range.Text = item.Value;
                        doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                    else
                    {
                        InlineShape picture = bookmark.Range.InlineShapes.AddPicture(item.Value);
                        picture.Width = 97;
                        picture.Height = 97;
                        doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                }
                doc.ExportAsFixedFormat(System.Windows.Forms.Application.StartupPath + "\\Ticket.pdf", WdExportFormat.wdExportFormatPDF);
                doc.Close(false);
                wordApp.Quit();
                webBrowser1.Navigate(System.Windows.Forms.Application.StartupPath + "\\Ticket.pdf");
            }
        }
        public void getqrcode()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string jsonData = JsonSerializer.Serialize(new
            {
                Text = find.InternalserialNumber,
                SizePixels = 220,
                CorrectionLevel = 0
            });
            HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage esponse = httpClient.PostAsync("http://localhost:500/Image/GenerateQRCode", content).Result;
            if (esponse.IsSuccessStatusCode)
            {
                byte[] imageBytes = esponse.Content.ReadAsByteArrayAsync().Result;
                File.WriteAllBytes(System.Windows.Forms.Application.StartupPath + "\\image.jpg", imageBytes);
            }
        }
        private void SavePDFBtn_Click(object sender, EventArgs e)
        {
            if (find != null)
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document doc = wordApp.Documents.Open(System.Windows.Forms.Application.StartupPath + "\\Ticket Example.docx");
                var asd = doc.Bookmarks;
                getqrcode();
                foreach (var item in bookmarksToReplace)
                {
                    Bookmark bookmark = doc.Bookmarks[item.Key];
                    if (item.Key != "QRCODE")
                    {
                        bookmark.Range.Text = item.Value;
                        doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                    else
                    {
                        InlineShape picture = bookmark.Range.InlineShapes.AddPicture(item.Value);
                        picture.Width = 97;
                        picture.Height = 97;
                        doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                }
                doc.ExportAsFixedFormat(System.Windows.Forms.Application.StartupPath + "\\Tickets.pdf", WdExportFormat.wdExportFormatPDF);
                doc.Close(false);
                wordApp.Quit();
            }
        }
    }
}
