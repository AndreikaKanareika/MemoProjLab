namespace Client
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectTextbox = new System.Windows.Forms.RichTextBox();
            this.AddSubjectbutton = new System.Windows.Forms.Button();
            this.DeleteSubjectbutton = new System.Windows.Forms.Button();
            this.SubjectlistBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectListbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(33, 34);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(66, 24);
            this.login.TabIndex = 0;
            this.login.Text = "EMAIL";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(106, 34);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(330, 29);
            this.LoginTextBox.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(442, 34);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(116, 64);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Добавить";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавить преподавателя";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(106, 69);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(330, 29);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(129, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Добавить / Удалить предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Название";
            // 
            // SubjectTextbox
            // 
            this.SubjectTextbox.Location = new System.Drawing.Point(106, 149);
            this.SubjectTextbox.Name = "SubjectTextbox";
            this.SubjectTextbox.Size = new System.Drawing.Size(330, 82);
            this.SubjectTextbox.TabIndex = 8;
            this.SubjectTextbox.Text = "";
            // 
            // AddSubjectbutton
            // 
            this.AddSubjectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSubjectbutton.Location = new System.Drawing.Point(442, 149);
            this.AddSubjectbutton.Name = "AddSubjectbutton";
            this.AddSubjectbutton.Size = new System.Drawing.Size(116, 39);
            this.AddSubjectbutton.TabIndex = 9;
            this.AddSubjectbutton.Text = "Добавить";
            this.AddSubjectbutton.UseVisualStyleBackColor = true;
            this.AddSubjectbutton.Click += new System.EventHandler(this.AddSubjectbutton_Click);
            // 
            // DeleteSubjectbutton
            // 
            this.DeleteSubjectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSubjectbutton.Location = new System.Drawing.Point(442, 194);
            this.DeleteSubjectbutton.Name = "DeleteSubjectbutton";
            this.DeleteSubjectbutton.Size = new System.Drawing.Size(116, 39);
            this.DeleteSubjectbutton.TabIndex = 10;
            this.DeleteSubjectbutton.Text = "Удалить";
            this.DeleteSubjectbutton.UseVisualStyleBackColor = true;
            this.DeleteSubjectbutton.Click += new System.EventHandler(this.DeleteSubjectbutton_Click);
            // 
            // SubjectlistBox
            // 
            this.SubjectlistBox.FormattingEnabled = true;
            this.SubjectlistBox.Location = new System.Drawing.Point(106, 263);
            this.SubjectlistBox.Name = "SubjectlistBox";
            this.SubjectlistBox.Size = new System.Drawing.Size(330, 173);
            this.SubjectlistBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(174, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Список предметов";
            // 
            // SubjectListbutton
            // 
            this.SubjectListbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectListbutton.Location = new System.Drawing.Point(442, 263);
            this.SubjectListbutton.Name = "SubjectListbutton";
            this.SubjectListbutton.Size = new System.Drawing.Size(116, 39);
            this.SubjectListbutton.TabIndex = 13;
            this.SubjectListbutton.Text = "Получить";
            this.SubjectListbutton.UseVisualStyleBackColor = true;
            this.SubjectListbutton.Click += new System.EventHandler(this.SubjectListbutton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.SubjectListbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubjectlistBox);
            this.Controls.Add(this.DeleteSubjectbutton);
            this.Controls.Add(this.AddSubjectbutton);
            this.Controls.Add(this.SubjectTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.login);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox SubjectTextbox;
        private System.Windows.Forms.Button AddSubjectbutton;
        private System.Windows.Forms.Button DeleteSubjectbutton;
        private System.Windows.Forms.ListBox SubjectlistBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubjectListbutton;
    }
}