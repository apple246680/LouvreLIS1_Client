using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSC1;

namespace System
{
    public static class Global
    {
        public static void ShowCreateAccountForm()
        {
            Main.ins.Text = "Seoul Stay - Create Account";
            Main.ins.Controls.Clear();
            CreateAccountForm createAccountForm = new CreateAccountForm();
            Main.ins.Controls.Add(createAccountForm);
            createAccountForm.Show();
        }
        public static void ShowLoginForm()
        {
            Main.ins.Text = "Seoul Stay - Welcome";
            Main.ins.Controls.Clear();
            LoginForm loginForm = new LoginForm();
            Main.ins.Controls.Add(loginForm);
            loginForm.Show();
        }
        public static long UserId { get; set; }
        public static void ShowManagementForm()
        {
            Main.ins.Text = "Seoul Stay - Management";
            Main.ins.Controls.Clear();
            ManagementForm managementForm = new ManagementForm();
            Main.ins.Controls.Add(managementForm);
            managementForm.Show();
        }
        public static long selectitemid { get; set; }
        public static void ShowAddAndEditForm()
        {
            Main.ins.Text= "Seoul Stay - Add/Edit Listing";
            Main.ins.Controls.Clear();
            AddAndEditForm addAndEditForm = new AddAndEditForm();
            Main.ins.Controls.Add(addAndEditForm);
            addAndEditForm.Show();
        }
    }
}
