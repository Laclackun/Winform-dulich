namespace TravelTour.View
{
    partial class Register
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
            username = new Label();
            password = new Label();
            label1 = new Label();
            txtName = new TextBox();
            txtPass = new TextBox();
            butRegis = new Button();
            butBack = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(113, 168);
            username.Margin = new Padding(6, 0, 6, 0);
            username.Name = "username";
            username.Size = new Size(138, 33);
            username.TabIndex = 0;
            username.Text = "Username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(113, 272);
            password.Margin = new Padding(6, 0, 6, 0);
            password.Name = "password";
            password.Size = new Size(133, 33);
            password.TabIndex = 1;
            password.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 49);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 47);
            label1.TabIndex = 2;
            label1.Text = "REGISTER";
            // 
            // txtName
            // 
            txtName.Location = new Point(305, 168);
            txtName.Margin = new Padding(6, 5, 6, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 39);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(305, 272);
            txtPass.Margin = new Padding(6, 5, 6, 5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(293, 39);
            txtPass.TabIndex = 4;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // butRegis
            // 
            butRegis.BackColor = Color.White;
            butRegis.BackgroundImageLayout = ImageLayout.None;
            butRegis.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butRegis.Location = new Point(419, 398);
            butRegis.Margin = new Padding(2);
            butRegis.Name = "butRegis";
            butRegis.Size = new Size(203, 57);
            butRegis.TabIndex = 20;
            butRegis.Text = "Register";
            butRegis.UseVisualStyleBackColor = false;
            butRegis.Click += butRegis_Click;
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.BackgroundImageLayout = ImageLayout.None;
            butBack.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butBack.Location = new Point(113, 398);
            butBack.Margin = new Padding(2);
            butBack.Name = "butBack";
            butBack.Size = new Size(203, 57);
            butBack.TabIndex = 19;
            butBack.Text = "Back";
            butBack.UseVisualStyleBackColor = false;
            butBack.Click += butBack_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(732, 553);
            Controls.Add(butRegis);
            Controls.Add(butBack);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label password;
        private Label label1;
        private TextBox txtName;
        private TextBox txtPass;
        private Button butRegis;
        private Button butBack;
    }
}