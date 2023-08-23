using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Net.Http.Headers;
using System.Text.Json;

namespace LouvreLIS_Management
{
    public partial class Main : Form
    {
        static Main instance = new Main();
        public Main()
        {
            InitializeComponent();
            instance=this;
        }
        Account account = null;
        public void getlogindata(Account asd)
        {
            SignBtn.Text = "Sign Out";
            UsernameLabel.Text = "Current User:" + asd.Username;
            account = asd;
            AccountInfoBtn_Click(null, null);
            AccountInfoBtn.Visible = true;
        }
        static public void staticgetlogindata(Account asd)
        {
            instance.getlogindata(asd);
        }
        private void SignBtn_Click(object sender, EventArgs e)
        {
            if (SignBtn.Text=="Sign In")
            {
                LoginForm loginForm=new LoginForm();
                ShowPanel.Controls.Clear();
                loginForm.TopLevel = false;
                ShowPanel.Controls.Add(loginForm);
                loginForm.Show();
            }
            else
            {
                UsernameLabel.Text = "Current User:Not Signed In";
                SignBtn.Text = "Sign In";
                SignBtn_Click(sender,e);
                AccountInfoBtn.Visible = false;
            }
        }
        AccountInfoForm accountInfoForm=new AccountInfoForm();
        private void AccountInfoBtn_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            accountInfoForm.TopLevel = false;
            ShowPanel.Controls.Add(accountInfoForm);
            accountInfoForm.run(account);
            accountInfoForm.Show();
        }
        HttpResponseMessage response = new HttpResponseMessage();
        HttpClient http=new HttpClient();
        string jsonData;
        private void Main_Load(object sender, EventArgs e)
        {
            SignBtn_Click(sender, e);
            Random rd = new Random();
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            jsonData = JsonSerializer.Serialize(new
            {
                StationNumber=rd.Next(1,20)
            });
            
            Every5S_Tick(null,null);
            Every5S.Start();
        }
        private async void Every5S_Tick(object sender, EventArgs e)
        {
            var  content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage  esponse = await http.PostAsync("http://localhost:500/api/ConnectionMonitor/RetrieveSiteStatus", content);
            if (esponse.IsSuccessStatusCode)
            {
                string jsonResponse1 = esponse.Content.ReadAsStringAsync().Result;
                JsonDocument doc1 = JsonDocument.Parse(jsonResponse1);
                int Status = doc1.RootElement.GetProperty("Status").GetInt32();
                ApiStatusLabel.Text = "API Status:"+(Status==2? "Warning" : "Good");
                ApiNumberLabel.Text = $"[{doc1.RootElement.GetProperty("Data").GetString()}]";
                ApiStatusBallLabel.ForeColor=Status==2?Color.Yellow:Color.Lime;
            }
        }
    }
}
