using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Авторизация_и_регистрация
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string login = txtLoginReg.Text.ToString();
            string adres = txtAdresReg.Text.ToString();
            string password = txtPasswordReg.Text.ToString();
            string password2 = txtPassword2Reg.Text.ToString();

            if (password == password2)
            {
                StreamWriter f = new StreamWriter("test.txt", true);
                f.WriteLine(login + "," + adres + "," + password + "," + password2);
                f.Close();
                this.Close();
            }
            else
            {
                lblCheck.Text = "Пароли не совпадают! Попробуйте еще разочек!";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
