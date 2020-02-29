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
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
            Report report = StaticStore.memoApi.GetAllReports(StaticStore.Token).GetAwaiter().GetResult();
            ReportrichTextBox.Text = "";
            ReportrichTextBox.Text += "Лекции:\n";
            foreach (var lec in report.Lectures)
            {
                ReportrichTextBox.Text += "Название: " + lec.SubjectName + " число занятий: " + lec.LectureHours + "\n";
            }
            ReportrichTextBox.Text += "Практики:\n";
            foreach (var lab in report.Labs)
            {
                ReportrichTextBox.Text += "Название: " + lab.SubjectName + " число занятий: " + lab.LabHours + "\n";
            }
            ReportrichTextBox.Text += "Студенты:\n";
            foreach (var lec in report.Students)
            {
                ReportrichTextBox.Text += "Название: " + lec.SubjectName + " число студентов: " + lec.StudentsCount + "\n";
            }
        }

        private void HeadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
