namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshList = new System.Windows.Forms.Button();
            this.AllMemosGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.IDLable = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddExam = new System.Windows.Forms.RadioButton();
            this.AddOffset = new System.Windows.Forms.RadioButton();
            this.AddStudentsCount = new System.Windows.Forms.TextBox();
            this.AddLabHours = new System.Windows.Forms.TextBox();
            this.AddLectureHours = new System.Windows.Forms.TextBox();
            this.AddSubject = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minLec = new System.Windows.Forms.TextBox();
            this.MaxLec = new System.Windows.Forms.TextBox();
            this.RangeButton = new System.Windows.Forms.Button();
            this.RangeGridView = new System.Windows.Forms.DataGridView();
            this.memoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabsHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlTupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllMemosGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshList);
            this.groupBox1.Controls.Add(this.AllMemosGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 801);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список заметок";
            // 
            // RefreshList
            // 
            this.RefreshList.Location = new System.Drawing.Point(290, 773);
            this.RefreshList.Name = "RefreshList";
            this.RefreshList.Size = new System.Drawing.Size(289, 23);
            this.RefreshList.TabIndex = 1;
            this.RefreshList.Text = "Обновить список";
            this.RefreshList.UseVisualStyleBackColor = true;
            this.RefreshList.Click += new System.EventHandler(this.RefreshList_Click);
            // 
            // AllMemosGridView
            // 
            this.AllMemosGridView.AllowUserToAddRows = false;
            this.AllMemosGridView.AllowUserToDeleteRows = false;
            this.AllMemosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllMemosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Subject,
            this.LectureHours,
            this.LabHours,
            this.ControlType,
            this.StudentsCount});
            this.AllMemosGridView.Location = new System.Drawing.Point(6, 19);
            this.AllMemosGridView.Name = "AllMemosGridView";
            this.AllMemosGridView.ReadOnly = true;
            this.AllMemosGridView.Size = new System.Drawing.Size(574, 747);
            this.AllMemosGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 150;
            // 
            // LectureHours
            // 
            this.LectureHours.HeaderText = "Часы лекций";
            this.LectureHours.Name = "LectureHours";
            this.LectureHours.ReadOnly = true;
            this.LectureHours.Width = 60;
            // 
            // LabHours
            // 
            this.LabHours.HeaderText = "Часы лабораторных";
            this.LabHours.Name = "LabHours";
            this.LabHours.ReadOnly = true;
            // 
            // ControlType
            // 
            this.ControlType.HeaderText = "Вид контроля";
            this.ControlType.Name = "ControlType";
            this.ControlType.ReadOnly = true;
            // 
            // StudentsCount
            // 
            this.StudentsCount.HeaderText = "Количество Студентов";
            this.StudentsCount.Name = "StudentsCount";
            this.StudentsCount.ReadOnly = true;
            this.StudentsCount.Width = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.UpdateButton);
            this.groupBox2.Controls.Add(this.GetButton);
            this.groupBox2.Controls.Add(this.IDLable);
            this.groupBox2.Controls.Add(this.IDText);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.AddExam);
            this.groupBox2.Controls.Add(this.AddOffset);
            this.groupBox2.Controls.Add(this.AddStudentsCount);
            this.groupBox2.Controls.Add(this.AddLabHours);
            this.groupBox2.Controls.Add(this.AddLectureHours);
            this.groupBox2.Controls.Add(this.AddSubject);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(604, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление/Изменение/Удаление/Получение";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(413, 279);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(116, 40);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(0, 279);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(407, 40);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(145, 233);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(384, 40);
            this.GetButton.TabIndex = 15;
            this.GetButton.Text = "Получить";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLable.Location = new System.Drawing.Point(7, 233);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(26, 20);
            this.IDLable.TabIndex = 14;
            this.IDLable.Text = "ID";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(39, 233);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 20);
            this.IDText.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 186);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(523, 40);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddExam
            // 
            this.AddExam.AutoSize = true;
            this.AddExam.Location = new System.Drawing.Point(399, 127);
            this.AddExam.Name = "AddExam";
            this.AddExam.Size = new System.Drawing.Size(70, 17);
            this.AddExam.TabIndex = 11;
            this.AddExam.TabStop = true;
            this.AddExam.Text = "Экзамен";
            this.AddExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddExam.UseVisualStyleBackColor = true;
            // 
            // AddOffset
            // 
            this.AddOffset.AutoSize = true;
            this.AddOffset.Location = new System.Drawing.Point(277, 127);
            this.AddOffset.Name = "AddOffset";
            this.AddOffset.Size = new System.Drawing.Size(54, 17);
            this.AddOffset.TabIndex = 10;
            this.AddOffset.TabStop = true;
            this.AddOffset.Text = "Зачет";
            this.AddOffset.UseVisualStyleBackColor = true;
            // 
            // AddStudentsCount
            // 
            this.AddStudentsCount.Location = new System.Drawing.Point(196, 150);
            this.AddStudentsCount.Name = "AddStudentsCount";
            this.AddStudentsCount.Size = new System.Drawing.Size(333, 20);
            this.AddStudentsCount.TabIndex = 9;
            // 
            // AddLabHours
            // 
            this.AddLabHours.Location = new System.Drawing.Point(174, 105);
            this.AddLabHours.Name = "AddLabHours";
            this.AddLabHours.Size = new System.Drawing.Size(355, 20);
            this.AddLabHours.TabIndex = 7;
            // 
            // AddLectureHours
            // 
            this.AddLectureHours.Location = new System.Drawing.Point(119, 79);
            this.AddLectureHours.Name = "AddLectureHours";
            this.AddLectureHours.Size = new System.Drawing.Size(410, 20);
            this.AddLectureHours.TabIndex = 6;
            // 
            // AddSubject
            // 
            this.AddSubject.Location = new System.Drawing.Point(91, 16);
            this.AddSubject.Name = "AddSubject";
            this.AddSubject.Size = new System.Drawing.Size(438, 60);
            this.AddSubject.TabIndex = 5;
            this.AddSubject.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество студентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вид контроля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Часы лабораторных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Часы лекций";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предмет";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RangeGridView);
            this.groupBox6.Controls.Add(this.RangeButton);
            this.groupBox6.Controls.Add(this.MaxLec);
            this.groupBox6.Controls.Add(this.minLec);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(604, 352);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(535, 461);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Список заметок в диопазоне";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Минимальное количиство часов лекций";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Минимальное количиство часов лекций";
            // 
            // minLec
            // 
            this.minLec.Location = new System.Drawing.Point(224, 13);
            this.minLec.Name = "minLec";
            this.minLec.Size = new System.Drawing.Size(100, 20);
            this.minLec.TabIndex = 18;
            // 
            // MaxLec
            // 
            this.MaxLec.Location = new System.Drawing.Point(224, 38);
            this.MaxLec.Name = "MaxLec";
            this.MaxLec.Size = new System.Drawing.Size(100, 20);
            this.MaxLec.TabIndex = 18;
            // 
            // RangeButton
            // 
            this.RangeButton.Location = new System.Drawing.Point(330, 13);
            this.RangeButton.Name = "RangeButton";
            this.RangeButton.Size = new System.Drawing.Size(199, 45);
            this.RangeButton.TabIndex = 18;
            this.RangeButton.Text = "Получить";
            this.RangeButton.UseVisualStyleBackColor = true;
            this.RangeButton.Click += new System.EventHandler(this.RangeButton_Click);
            // 
            // RangeGridView
            // 
            this.RangeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RangeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memoId,
            this.MemoSubject,
            this.LecHours,
            this.LabsHours,
            this.ControlTupe,
            this.StudentCount});
            this.RangeGridView.Location = new System.Drawing.Point(6, 64);
            this.RangeGridView.Name = "RangeGridView";
            this.RangeGridView.Size = new System.Drawing.Size(523, 391);
            this.RangeGridView.TabIndex = 19;
            // 
            // memoId
            // 
            this.memoId.HeaderText = "Id";
            this.memoId.Name = "memoId";
            this.memoId.ReadOnly = true;
            this.memoId.Width = 30;
            // 
            // MemoSubject
            // 
            this.MemoSubject.HeaderText = "Предмет";
            this.MemoSubject.Name = "MemoSubject";
            this.MemoSubject.ReadOnly = true;
            this.MemoSubject.Width = 150;
            // 
            // LecHours
            // 
            this.LecHours.HeaderText = "Часы лекций";
            this.LecHours.Name = "LecHours";
            this.LecHours.ReadOnly = true;
            this.LecHours.Width = 60;
            // 
            // LabsHours
            // 
            this.LabsHours.HeaderText = "Часы лабораторных";
            this.LabsHours.Name = "LabsHours";
            this.LabsHours.ReadOnly = true;
            this.LabsHours.Width = 80;
            // 
            // ControlTupe
            // 
            this.ControlTupe.HeaderText = "Вид контроля";
            this.ControlTupe.Name = "ControlTupe";
            this.ControlTupe.ReadOnly = true;
            this.ControlTupe.Width = 80;
            // 
            // StudentCount
            // 
            this.StudentCount.HeaderText = "Количество студентов";
            this.StudentCount.Name = "StudentCount";
            this.StudentCount.ReadOnly = true;
            this.StudentCount.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 825);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1167, 864);
            this.MinimumSize = new System.Drawing.Size(1167, 864);
            this.Name = "Form1";
            this.Text = "Заметки преподавателю";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllMemosGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView AllMemosGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox AddSubject;
        private System.Windows.Forms.TextBox AddLectureHours;
        private System.Windows.Forms.RadioButton AddExam;
        private System.Windows.Forms.RadioButton AddOffset;
        private System.Windows.Forms.TextBox AddStudentsCount;
        private System.Windows.Forms.TextBox AddLabHours;
        private System.Windows.Forms.Button RefreshList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label IDLable;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView RangeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabsHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlTupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCount;
        private System.Windows.Forms.Button RangeButton;
        private System.Windows.Forms.TextBox MaxLec;
        private System.Windows.Forms.TextBox minLec;
    }
}

