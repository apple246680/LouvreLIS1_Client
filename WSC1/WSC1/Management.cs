using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WSC1
{
    public partial class ManagementForm : UserControl
    {
        public ManagementForm()
        {
            InitializeComponent();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Main.ins.Close();
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Global.ShowLoginForm();
        }
        private void imTravelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            TravelerForm frm = new TravelerForm();
            ShowPanel.Controls.Add(frm);
            frm.Show();
        }

        private void imOwnerManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Controls.Clear();
            ManagerForm managerForm = new ManagerForm();
            ShowPanel.Controls.Add(managerForm);
            managerForm.Show();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            Session1Entities entities=new Session1Entities();
            imTravelerToolStripMenuItem.Visible = entities.Users.Find(Global.UserId).UserType.Name == "user";
            imOwnerManagerToolStripMenuItem.Visible = entities.Users.Find(Global.UserId).UserType.Name == "employee";
        }
    }
}
