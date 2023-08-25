using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class Global
    {
        public static void ShowCreateAccountForm()
        {
            Main.ins.Controls.Clear();
            CreateAccountForm createAccountForm = new CreateAccountForm();
            Main.ins.Controls.Add(createAccountForm);
            createAccountForm.Show();
        }
        public static void ShowLoginForm()
        {
            Main.ins.Controls.Clear();
            LoginForm loginForm = new LoginForm();
            Main.ins.Controls.Add(loginForm);
            loginForm.Show();
        }


    }
}
