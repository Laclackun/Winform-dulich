namespace TravelTour.View
{
    partial class Infor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtLoca = new TextBox();
            txtAge = new TextBox();
            datePick = new DateTimePicker();
            comboSex = new ComboBox();
            picAccount = new PictureBox();
            butSave = new Button();
            butBack = new Button();
            butDispose = new Button();
            ((System.ComponentModel.ISupportInitialize)picAccount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 40);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(474, 47);
            label1.TabIndex = 0;
            label1.Text = "ACCOUNT INFORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 143);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 33);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 223);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 33);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 295);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 33);
            label4.TabIndex = 3;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 378);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 33);
            label5.TabIndex = 4;
            label5.Text = "Sex";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 463);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 33);
            label6.TabIndex = 5;
            label6.Text = "Age";
            // 
            // txtName
            // 
            txtName.Location = new Point(260, 140);
            txtName.Margin = new Padding(6, 5, 6, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(449, 39);
            txtName.TabIndex = 6;
            // 
            // txtLoca
            // 
            txtLoca.Location = new Point(260, 292);
            txtLoca.Margin = new Padding(6, 5, 6, 5);
            txtLoca.Name = "txtLoca";
            txtLoca.Size = new Size(449, 39);
            txtLoca.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(260, 460);
            txtAge.Margin = new Padding(6, 5, 6, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(179, 39);
            txtAge.TabIndex = 10;
            // 
            // datePick
            // 
            datePick.Format = DateTimePickerFormat.Short;
            datePick.Location = new Point(260, 218);
            datePick.Margin = new Padding(6, 5, 6, 5);
            datePick.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            datePick.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datePick.Name = "datePick";
            datePick.Size = new Size(449, 39);
            datePick.TabIndex = 13;
            // 
            // comboSex
            // 
            comboSex.FormattingEnabled = true;
            comboSex.Location = new Point(260, 375);
            comboSex.Margin = new Padding(6, 5, 6, 5);
            comboSex.Name = "comboSex";
            comboSex.Size = new Size(179, 40);
            comboSex.TabIndex = 14;
            // 
            // picAccount
            // 
            picAccount.BackColor = Color.White;
            picAccount.Location = new Point(763, 140);
            picAccount.Margin = new Padding(6, 5, 6, 5);
            picAccount.Name = "picAccount";
            picAccount.Size = new Size(280, 271);
            picAccount.SizeMode = PictureBoxSizeMode.Zoom;
            picAccount.TabIndex = 15;
            picAccount.TabStop = false;
            picAccount.Click += picAccount_Click;
            // 
            // butSave
            // 
            butSave.BackColor = Color.White;
            butSave.Location = new Point(867, 526);
            butSave.Margin = new Padding(5);
            butSave.Name = "butSave";
            butSave.Size = new Size(176, 46);
            butSave.TabIndex = 17;
            butSave.Text = "Save";
            butSave.UseVisualStyleBackColor = false;
            butSave.Click += butSave_Click;
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.Location = new Point(657, 526);
            butBack.Margin = new Padding(5);
            butBack.Name = "butBack";
            butBack.Size = new Size(176, 46);
            butBack.TabIndex = 16;
            butBack.Text = "Back";
            butBack.UseVisualStyleBackColor = false;
            butBack.Click += butBack_Click;
            // 
            // butDispose
            // 
            butDispose.BackColor = Color.White;
            butDispose.Location = new Point(844, 421);
            butDispose.Margin = new Padding(5);
            butDispose.Name = "butDispose";
            butDispose.Size = new Size(131, 46);
            butDispose.TabIndex = 18;
            butDispose.Text = "Dispose";
            butDispose.UseVisualStyleBackColor = false;
            butDispose.Click += butDispose_Click;
            // 
            // Infor
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1082, 603);
            Controls.Add(butDispose);
            Controls.Add(butSave);
            Controls.Add(butBack);
            Controls.Add(picAccount);
            Controls.Add(comboSex);
            Controls.Add(datePick);
            Controls.Add(txtAge);
            Controls.Add(txtLoca);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Infor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Infor";
            ((System.ComponentModel.ISupportInitialize)picAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtLoca;
        private TextBox txtAge;
        private DateTimePicker datePick;
        private ComboBox comboSex;
        private PictureBox picAccount;
        private Button butSave;
        private Button butBack;
        private Button butDispose;
    }
}