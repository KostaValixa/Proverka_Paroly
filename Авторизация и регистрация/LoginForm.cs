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
        public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnEnt_Click(object sender, EventArgs e)
        {
            Dictionary<string, UserData> dictUsers = new Dictionary<string, UserData>();
            using (StreamReader read = new StreamReader("test.txt"))
            {
                while (!read.EndOfStream)
                {
                    string[] data = read.ReadLine().Split(',');
                    dictUsers.Add(data.ElementAt(0), new UserData() { login = data.ElementAt(0),
                                                                      email = data.ElementAt(1),
                                                                      password = data.ElementAt(2)});

                };
            };
            if(dictUsers.ContainsKey(txtLogin.Text)){
                if(txtPassword.Text == dictUsers[txtLogin.Text].password)
                {
                    lblCheck.Text = "Пароль верен!\nВы успешно вошли в систему!";
                    MainForm mainMenu = new MainForm();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    lblCheck.Text = "Пароль не верен!";
                }
            }
            else
            {
                lblCheck.Text = "Логина нет в базе данных!\nПожалуйста зарегистрируйтесь!";
            }
        }
    }

class UserData
{
    public string login;
    public string password;
    public string email;
}

}
