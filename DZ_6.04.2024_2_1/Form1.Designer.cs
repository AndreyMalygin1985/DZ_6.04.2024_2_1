namespace DZ_6._04._2024_2_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Surname = new TextBox();
            SaveBottom = new Button();
            Name = new TextBox();
            Surname2 = new TextBox();
            Sex = new TextBox();
            FamilyStatus = new TextBox();
            AdditionalInformation = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            YearAndDateOfBirth = new TextBox();
            SuspendLayout();
            // 
            // Surname
            // 
            Surname.Font = new Font("Times New Roman", 16F);
            Surname.Location = new Point(10, 10);
            Surname.Margin = new Padding(4);
            Surname.Name = "Surname";
            Surname.Size = new Size(330, 32);
            Surname.TabIndex = 0;
            Surname.TextChanged += Surname_TextChanged;
            // 
            // SaveBottom
            // 
            SaveBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveBottom.BackColor = Color.Chartreuse;
            SaveBottom.BackgroundImageLayout = ImageLayout.Center;
            SaveBottom.Cursor = Cursors.SizeAll;
            SaveBottom.Font = new Font("Times New Roman", 50F);
            SaveBottom.ForeColor = Color.Red;
            SaveBottom.ImageAlign = ContentAlignment.BottomRight;
            SaveBottom.Location = new Point(521, 253);
            SaveBottom.Margin = new Padding(4);
            SaveBottom.Name = "SaveBottom";
            SaveBottom.Size = new Size(170, 170);
            SaveBottom.TabIndex = 1;
            SaveBottom.Text = "Save";
            SaveBottom.UseVisualStyleBackColor = false;
            SaveBottom.Click += button1_Click;
            // 
            // Name
            // 
            Name.Font = new Font("Times New Roman", 16F);
            Name.Location = new Point(10, 52);
            Name.Margin = new Padding(4);
            Name.Name = "Name";
            Name.Size = new Size(330, 32);
            Name.TabIndex = 2;
            Name.TextChanged += Name_TextChanged;
            // 
            // Surname2
            // 
            Surname2.Font = new Font("Times New Roman", 16F);
            Surname2.Location = new Point(10, 94);
            Surname2.Margin = new Padding(4);
            Surname2.Name = "Surname2";
            Surname2.Size = new Size(330, 32);
            Surname2.TabIndex = 3;
            Surname2.TextChanged += Surname2_TextChanged;
            // 
            // Sex
            // 
            Sex.Font = new Font("Times New Roman", 16F);
            Sex.Location = new Point(10, 136);
            Sex.Margin = new Padding(4);
            Sex.Name = "Sex";
            Sex.Size = new Size(330, 32);
            Sex.TabIndex = 4;
            Sex.TextChanged += Sex_TextChanged;
            // 
            // FamilyStatus
            // 
            FamilyStatus.Font = new Font("Times New Roman", 16F);
            FamilyStatus.Location = new Point(10, 220);
            FamilyStatus.Margin = new Padding(4);
            FamilyStatus.Name = "FamilyStatus";
            FamilyStatus.Size = new Size(330, 32);
            FamilyStatus.TabIndex = 6;
            FamilyStatus.TextChanged += FamilyStatus_TextChanged;
            // 
            // AdditionalInformation
            // 
            AdditionalInformation.Font = new Font("Times New Roman", 16F);
            AdditionalInformation.Location = new Point(10, 262);
            AdditionalInformation.Margin = new Padding(4);
            AdditionalInformation.Name = "AdditionalInformation";
            AdditionalInformation.Size = new Size(330, 161);
            AdditionalInformation.TabIndex = 8;
            AdditionalInformation.Text = "";
            AdditionalInformation.TextChanged += AdditionalInformation_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(355, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 9;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(355, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 10;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(355, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 11;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(355, 142);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 12;
            label4.Text = "Пол";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(355, 184);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 19);
            label5.TabIndex = 13;
            label5.Text = "Год и дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(355, 226);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 19);
            label6.TabIndex = 14;
            label6.Text = "Семейный статус";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(360, 333);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 15;
            label7.Text = "Доп инфа";
            // 
            // YearAndDateOfBirth
            // 
            YearAndDateOfBirth.Font = new Font("Times New Roman", 16F);
            YearAndDateOfBirth.Location = new Point(10, 178);
            YearAndDateOfBirth.Margin = new Padding(4);
            YearAndDateOfBirth.Name = "YearAndDateOfBirth";
            YearAndDateOfBirth.Size = new Size(330, 32);
            YearAndDateOfBirth.TabIndex = 16;
            YearAndDateOfBirth.TextChanged += YearAndDateOfBirth_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 441);
            Controls.Add(YearAndDateOfBirth);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AdditionalInformation);
            Controls.Add(FamilyStatus);
            Controls.Add(Sex);
            Controls.Add(Surname2);
            Controls.Add(Surname);
            Controls.Add(Name);
            Controls.Add(SaveBottom);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Surname;
        private Button SaveBottom;
        private TextBox Name;
        private TextBox Surname2;
        private TextBox Sex;
        private TextBox FamilyStatus;
        private RichTextBox AdditionalInformation;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox YearAndDateOfBirth;
    }
}
