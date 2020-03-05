using Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task UpdateAllMemoList()
        {
            List<MemoResponse> memoResponses = await StaticStore.memoApi.GetAllMemos(StaticStore.Token);
            AllMemosGridView.Rows.Clear();
            int rowIndex = 0;
            foreach(var memo in memoResponses)
            {
                AllMemosGridView.Rows.Add();
                AllMemosGridView[0, rowIndex].Value = memo.Id;
                AllMemosGridView[1, rowIndex].Value = memo.SubjectName;
                AllMemosGridView[2, rowIndex].Value = memo.LectureHours;
                AllMemosGridView[3, rowIndex].Value = memo.LabHours;
                AllMemosGridView[4, rowIndex].Value = ControlTupeToString(memo.ControlType);
                AllMemosGridView[5, rowIndex].Value = memo.StudentsCount;
                rowIndex++;
            }
        }

        private void OnExcaption()
        {
            MessageBox.Show("У вас нет прав не выполнение данного действия!");
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private string ControlTupeToString(int type)
        {
            if (type == 1)
                return "Зачет";
            else
                return "Экзамен";
        }

        private string GetControlType()
        {
            if (AddExam.Checked)
                return "Exam";
            else
                return "Test";
        }

        private void SetContentType(int type)
        {
            if(type == 1)
            {
                AddExam.Checked = false;
                AddOffset.Checked = true;
            }
            else
            {
                AddOffset.Checked = false;
                AddExam.Checked = true;
            }
        }

        private void SetAllFields(MemoResponse memoResponse)
        {
            IDText.Text = memoResponse.Id.ToString();
            AddSubject.Text = memoResponse.SubjectName;
            AddLectureHours.Text = memoResponse.LectureHours.ToString();
            AddLabHours.Text = memoResponse.LabHours.ToString();
            AddStudentsCount.Text = memoResponse.StudentsCount.ToString();
            SetContentType(memoResponse.ControlType);
        }

        private async void RefreshList_Click(object sender, EventArgs e)
        {
            try
            {
                await UpdateAllMemoList();
            }
            catch
            {
                OnExcaption();
            }
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(AddLectureHours.Text, out int res1) && int.TryParse(AddLabHours.Text, out int res2) && int.TryParse(AddStudentsCount.Text, out int res3))
            {
                CreateMemoReqest createMemoReqest = new CreateMemoReqest
                {
                    SubjectName = AddSubject.Text,
                    LectureHours = int.Parse(AddLectureHours.Text),
                    LabHours = int.Parse(AddLabHours.Text),
                    StudentsCount = int.Parse(AddStudentsCount.Text),
                    ControlType = GetControlType()
                };
                try
                {
                    MemoResponse memoResponse = await StaticStore.memoApi.CreateMemo(createMemoReqest, StaticStore.Token);
                    SetAllFields(memoResponse);
                    await UpdateAllMemoList();
                }
                catch
                {
                    OnExcaption();
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private async void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                MemoResponse memoResponse = await StaticStore.memoApi.GetMemo(int.Parse(IDText.Text), StaticStore.Token);
                SetAllFields(memoResponse);
            }
            catch
            {
                OnExcaption();
            }

        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateMemoReqest updateMemoReqest = new UpdateMemoReqest
            {
                Id = int.Parse(IDText.Text),
                SubjectName = AddSubject.Text,
                LectureHours = int.Parse(AddLectureHours.Text),
                LabHours = int.Parse(AddLabHours.Text),
                StudentsCount = int.Parse(AddStudentsCount.Text),
                ControlType = GetControlType()
            };
            try
            {
                MemoResponse memoResponse = await StaticStore.memoApi.UpdateMemo(updateMemoReqest, StaticStore.Token);
                SetAllFields(memoResponse);
                await UpdateAllMemoList();
            }
            catch
            {
                OnExcaption();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                await StaticStore.memoApi.DeleteMemo(int.Parse(IDText.Text), StaticStore.Token);
                await UpdateAllMemoList();
            }
            catch
            {
                OnExcaption();
            }
        }

        private async void RangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(minLec.Text, out int result) && int.TryParse(MaxLec.Text, out int result2))
                {
                    List<MemoResponse> memoResponses = await StaticStore.memoApi.GetMemosRange(int.Parse(minLec.Text), int.Parse(MaxLec.Text), StaticStore.Token);
                    RangeGridView.Rows.Clear();
                    int rowIndex = 0;
                    foreach (var memo in memoResponses)
                    {
                        RangeGridView.Rows.Add();
                        RangeGridView[0, rowIndex].Value = memo.Id;
                        RangeGridView[1, rowIndex].Value = memo.SubjectName;
                        RangeGridView[2, rowIndex].Value = memo.LectureHours;
                        RangeGridView[3, rowIndex].Value = memo.LabHours;
                        RangeGridView[4, rowIndex].Value = ControlTupeToString(memo.ControlType);
                        RangeGridView[5, rowIndex].Value = memo.StudentsCount;
                        rowIndex++;
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте введенные данные!");
                }
            }
            catch
            {
                OnExcaption();
            }
        }

        private async void reportButton_Click(object sender, EventArgs e)
        {
            try
            {
                Report report = await StaticStore.memoApi.GetReports(StaticStore.Token);
                ReportTextBox.Text = "";
                ReportTextBox.Text += "Лекции:\n";
                foreach(var lec in report.Lectures)
                {
                    ReportTextBox.Text += "Название: " + lec.SubjectName + " число занятий: " + lec.LectureHours + "\n"; 
                }
                ReportTextBox.Text += "Практики:\n";
                foreach (var lab in report.Labs)
                {
                    ReportTextBox.Text += "Название: " + lab.SubjectName + " число занятий: " + lab.LabHours + "\n";
                }
                ReportTextBox.Text += "Студенты:\n";
                foreach (var lec in report.Students)
                {
                    ReportTextBox.Text += "Название: " + lec.SubjectName + " число студентов: " + lec.StudentsCount + "\n";
                }
            }
            catch
            {
                OnExcaption();
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
