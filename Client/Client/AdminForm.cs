using Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                await StaticStore.memoApi.Register(LoginTextBox.Text, PasswordTextBox.Text, StaticStore.Token);
                MessageBox.Show("Преподаватель успешно добавлен!");
            }
            catch
            {
                MessageBox.Show("Введите существующий Email!");
            }
        }

        private async void AddSubjectbutton_Click(object sender, EventArgs e)
        {
            await StaticStore.memoApi.AddSubject(SubjectTextbox.Text, StaticStore.Token);
            MessageBox.Show("Предмет успешно добавлен!");

        }

        private async void DeleteSubjectbutton_Click(object sender, EventArgs e)
        {
            try
            {
                await StaticStore.memoApi.DeleteSubject(SubjectTextbox.Text, StaticStore.Token);
                MessageBox.Show("Предмет успешно удвлен!");
            }
            catch
            {
                MessageBox.Show("Предмет c данным названием не существует!");
            }
        }

        private async void SubjectListbutton_Click(object sender, EventArgs e)
        {
            List<Subject> subjects = await StaticStore.memoApi.GetSubjects();
            SubjectlistBox.Items.Clear();
            SubjectlistBox.Items.AddRange(subjects.Select(x=>x.Name).ToArray());
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
