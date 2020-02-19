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
    public partial class Form1 : Form
    {
        IMemoAPI memoApi;
        public Form1()
        {
            InitializeComponent();
            memoApi = RestService.For<IMemoAPI>(ConfigurationSettings.AppSettings["MemoApiURL"]);
        }

        private async Task UpdateAllMemoList()
        {
            List<MemoResponse> memoResponses = await memoApi.GetAllMemos();
            AllMemosGridView.Rows.Clear();
            int rowIndex = 0;
            foreach (var memo in memoResponses)
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
            if (type == 1)
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
            await UpdateAllMemoList();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateLabHoursField() && ValidateLectureHoursField())
            {
                CreateMemoReqest createMemoReqest = new CreateMemoReqest
                {
                    SubjectName = AddSubject.Text,
                    LectureHours = int.Parse(AddLectureHours.Text),
                    LabHours = int.Parse(AddLabHours.Text),
                    StudentsCount = int.Parse(AddStudentsCount.Text),
                    ControlType = GetControlType()
                };

                MemoResponse memoResponse = await memoApi.CreateMemo(createMemoReqest);

                SetAllFields(memoResponse);
                await UpdateAllMemoList();
            }
        }

        private async void GetButton_Click(object sender, EventArgs e)
        {
            if (ValidateIdField())
            {
                MemoResponse memoResponse = await memoApi.GetMemo(int.Parse(IDText.Text));
                SetAllFields(memoResponse);
            }

        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            if(ValidateIdField() && ValidateLabHoursField() && ValidateLectureHoursField())
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
                MemoResponse memoResponse = await memoApi.UpdateMemo(updateMemoReqest);
                SetAllFields(memoResponse);
                await UpdateAllMemoList();
            }

        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ValidateIdField())
            {
                await memoApi.DeleteMemo(int.Parse(IDText.Text));
                await UpdateAllMemoList();
            }
        }

        private async void RangeButton_Click(object sender, EventArgs e)
        {
            if(ValidateminLecField() && ValidateMaxLecField())
            {
                List<MemoResponse> memoResponses = await memoApi.GetMemosRange(int.Parse(minLec.Text), int.Parse(MaxLec.Text));
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
        }

        private bool ValidateIdField()
        {
            if(!int.TryParse(IDText.Text, out int Num))
            {
                MessageBox.Show("Проверьте введенные данные!");
                return false;
            }
            return true;
        }

        private bool ValidateLectureHoursField()
        {
            if (!int.TryParse(AddLectureHours.Text, out int Num))
            {
                MessageBox.Show("Проверьте введенные данные!");
                return false;
            }
            return true;
        }

        private bool ValidateLabHoursField()
        {
            if (!int.TryParse(AddLabHours.Text, out int Num))
            {
                MessageBox.Show("Проверьте введенные данные!");
                return false;
            }
            return true;
        }

        private bool ValidateminLecField()
        {
            if (!int.TryParse(minLec.Text, out int Num))
            {
                MessageBox.Show("Проверьте введенные данные!");
                return false;
            }
            return true;
        }

        private bool ValidateMaxLecField()
        {
            if (!int.TryParse(MaxLec.Text, out int Num))
            {
                MessageBox.Show("Проверьте введенные данные!");
                return false;
            }
            return true;
        }
    }
}
