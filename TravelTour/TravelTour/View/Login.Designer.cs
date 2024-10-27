namespace TravelTour.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            linkForgot = new LinkLabel();
            butLog = new Button();
            checkShow = new CheckBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            txtPass = new TextBox();
            pictureBox2 = new PictureBox();
            txtName = new TextBox();
            butReg = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // linkForgot
            // 
            linkForgot.AutoSize = true;
            linkForgot.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkForgot.Location = new Point(98, 341);
            linkForgot.Name = "linkForgot";
            linkForgot.Size = new Size(198, 27);
            linkForgot.TabIndex = 19;
            linkForgot.TabStop = true;
            linkForgot.Text = "Forgot Password ?";
            linkForgot.LinkClicked += linkForgot_LinkClicked;
            // 
            // butLog
            // 
            butLog.BackColor = Color.White;
            butLog.BackgroundImageLayout = ImageLayout.None;
            butLog.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butLog.Location = new Point(388, 414);
            butLog.Margin = new Padding(2);
            butLog.Name = "butLog";
            butLog.Size = new Size(203, 57);
            butLog.TabIndex = 18;
            butLog.Text = "Login";
            butLog.UseVisualStyleBackColor = false;
            butLog.Click += butLog_Click;
            // 
            // checkShow
            // 
            checkShow.AutoSize = true;
            checkShow.Font = new Font("Cambria", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkShow.Location = new Point(433, 341);
            checkShow.Name = "checkShow";
            checkShow.Size = new Size(184, 31);
            checkShow.TabIndex = 17;
            checkShow.Text = "Show Password";
            checkShow.UseVisualStyleBackColor = true;
            checkShow.CheckedChanged += checkShow_CheckedChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 51);
            label4.Name = "label4";
            label4.Size = new Size(708, 51);
            label4.TabIndex = 16;
            label4.Text = "Login";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(98, 244);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.AccessibleName = "Password_Textbox";
            txtPass.BackColor = Color.Snow;
            txtPass.Font = new Font("Cambria", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(193, 243);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(424, 51);
            txtPass.TabIndex = 14;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(98, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Snow;
            txtName.Font = new Font("Cambria", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(193, 148);
            txtName.MaxLength = 255;
            txtName.Name = "txtName";
            txtName.Size = new Size(424, 51);
            txtName.TabIndex = 12;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // butReg
            // 
            butReg.BackColor = Color.White;
            butReg.BackgroundImageLayout = ImageLayout.None;
            butReg.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butReg.Location = new Point(127, 414);
            butReg.Margin = new Padding(2);
            butReg.Name = "butReg";
            butReg.Size = new Size(203, 57);
            butReg.TabIndex = 11;
            butReg.Text = "Register";
            butReg.UseVisualStyleBackColor = false;
            butReg.Click += butReg_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(732, 553);
            Controls.Add(linkForgot);
            Controls.Add(butLog);
            Controls.Add(checkShow);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(txtPass);
            Controls.Add(pictureBox2);
            Controls.Add(txtName);
            Controls.Add(butReg);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkForgot;
        private Button butLog;
        private CheckBox checkShow;
        private Label label4;
        private PictureBox pictureBox3;
        private TextBox txtPass;
        private PictureBox pictureBox2;
        private TextBox txtName;
        private Button butReg;
    }
}