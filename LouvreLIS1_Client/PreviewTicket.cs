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
namespace LouvreLIS_Client
{
    public partial class PreviewTicketForm : Form
    {
        static public PreviewTicketForm ins;
        public PreviewTicketForm()
        {
            InitializeComponent();
            ins = this;
        }
        LouvreEntities entities = new LouvreEntities();
        public void getdataandrun(string ticket)
        {
            this.Text = $"Preview Ticket-{ticket}";
            var find = entities.TicketDatas.FirstOrDefault(x=>x.TicketNumber==ticket);
            if (find != null)
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                //Document worddoc = wordApp.Documents.Open(System.Windows.Forms.Application.StartupPath + "\\Ticket Example.docx");
                //FindAndReplace("07/19/2023", find.VisitDateTime.ToString("MM/dd/yyyy"));
                //FindAndReplace("10:00",find.VisitDateTime.ToString("HH:mm"));
                //FindAndReplace("17,00",find.PriceEUR);
                //FindAndReplace("Antonio Royal",find.Visitor.Account.LastName+" "+find.Visitor.Account.FirstName);
                //FindAndReplace("70544587",ticket);
                //FindAndReplace("06/21/2023",find.PurchaseDate.Value.ToString("MM/dd/yyyy"));
                //FindAndReplace("15:25",find.PurchaseDate.Value.ToString("HH:mm"));
                //ReplaceImage(worddoc, System.Windows.Forms.Application.StartupPath + "\\123.png");
                //worddoc.ExportAsFixedFormat(System.Windows.Forms.Application.StartupPath + "\\Ticket.pdf", WdExportFormat.wdExportFormatPDF);
                //worddoc.Close(false);
                //wordApp.Quit();
                Document doc = wordApp.Documents.Open(System.Windows.Forms.Application.StartupPath+"\\Ticket Example.docx");
                var asd=doc.Bookmarks;
                Dictionary<string, string> bookmarksToReplace = new Dictionary<string, string>
            {
                { "Name", find.Visitor.Account.LastName+" "+find.Visitor.Account.FirstName },
                { "Name2", find.Visitor.Account.LastName+" "+find.Visitor.Account.FirstName },
                {"Price",find.PriceEUR.ToString()},
                {"PurchaseDate",find.PurchaseDate.Value.ToString("MM/dd/yyyy")},
                {"PurchaseTime",find.PurchaseDate.Value.ToString("HH:mm")},
                {"TicketNumber",ticket},
                {"VisitDate",find.VisitDateTime.ToString("MM/dd/yyyy")},
                {"VisitTime",find.VisitDateTime.ToString("HH:mm")},
                {"QRCODE",System.Windows.Forms.Application.StartupPath + "\\123.png"}
            };
                foreach (var item in bookmarksToReplace)
                {
                        Bookmark bookmark = doc.Bookmarks[item.Key];
                    if (item.Key!="QRCODE")
                    {
                        bookmark.Range.Text = item.Value;
                        doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                    else
                    {
                        bookmark.Range.InlineShapes.AddPicture(item.Value);
                        doc.Bookmarks.Add(item.Key, bookmark.Range);
                    }
                }
                doc.ExportAsFixedFormat(System.Windows.Forms.Application.StartupPath + "\\Ticket.pdf", WdExportFormat.wdExportFormatPDF);
                doc.Close(false);
                wordApp.Quit();
                MessageBox.Show("成功");
            }
        }
        //static void FindAndReplace(object findText, object replaceWithText)
        //{
        //    ins.wordApp.Selection.Find.Execute(ref findText, ReplaceWith: ref replaceWithText, Replace: WdReplace.wdReplaceAll);
        //}
        //static void ReplaceImage(Document wordDoc, string newImagePath)
        //{
        //    InlineShape inlineShape = wordDoc.InlineShapes[2];
        //    float originalWidth = inlineShape.Width;
        //    float originalHeight = inlineShape.Height;
        //    inlineShape.Select();
        //    InlineShape newInlineShape = wordDoc.Application.Selection.InlineShapes.AddPicture(newImagePath, LinkToFile: false, SaveWithDocument: true);
        //    newInlineShape.Width = originalWidth;
        //    newInlineShape.Height = originalHeight;
        //}
        private void SavePDFBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
