using Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void AuthorizeUser() {
            try
            {
                StaticStore.memoApi = RestService.For<IMemoAPI>(ConfigurationSettings.AppSettings["MemoApiURL"]);
                StaticStore.Token = "Bearer " + StaticStore.memoApi.Login(LoginTextBox.Text, PasswordTextBox.Text).GetAwaiter().GetResult().Token;
            }
            catch
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            AuthorizeUser();
            try
            {
                StaticStore.memoApi.GetAllMemos(StaticStore.Token).GetAwaiter().GetResult();
                Form1 teacherForm = new Form1();
                this.Hide();
                teacherForm.Show();
            }
            catch
            {
                MessageBox.Show("Данная учетная запись не пренадлежит преподавателю!");
            }

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AuthorizeUser();
            try
            {
                AdminForm adminForm = new AdminForm();
                StaticStore.memoApi.AddSubject("8749674b-834a-4393-871a-d1421bee0c30", StaticStore.Token).GetAwaiter().GetResult();
                StaticStore.memoApi.DeleteSubject("8749674b-834a-4393-871a-d1421bee0c30", StaticStore.Token).GetAwaiter().GetResult();
                this.Hide();
                adminForm.Show();
            }
            catch
            {
                MessageBox.Show("Данная учетная запись не пренадлежит администратору!");

            }
        }

        private void Head_Click(object sender, EventArgs e)
        {
            AuthorizeUser();
            try
            {
                StaticStore.memoApi.GetAllReports(StaticStore.Token).GetAwaiter().GetResult();
                HeadForm headForm = new HeadForm();
                this.Hide();
                headForm.Show();
            }
            catch
            {
                MessageBox.Show("Данная учетная запись не пренадлежит Заведующему кафедрой!");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AuthorizeUser();
            await StaticStore.memoApi.Seed();
        }
    }
}
