namespace TravelTour.View
{
    partial class StaffAccount
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtPass = new TextBox();
            raManager = new RadioButton();
            raStaff = new RadioButton();
            butSave = new Button();
            butDel = new Button();
            butBack = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 30);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 47);
            label1.TabIndex = 0;
            label1.Text = "STAFF ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 110);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 33);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 176);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 33);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 240);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 33);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 305);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 33);
            label5.TabIndex = 4;
            label5.Text = "Role";
            // 
            // txtID
            // 
            txtID.Location = new Point(517, 107);
            txtID.Margin = new Padding(6, 5, 6, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(467, 39);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(517, 173);
            txtName.Margin = new Padding(6, 5, 6, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(467, 39);
            txtName.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(517, 237);
            txtPass.Margin = new Padding(6, 5, 6, 5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(467, 39);
            txtPass.TabIndex = 7;
            // 
            // raManager
            // 
            raManager.AutoSize = true;
            raManager.Location = new Point(569, 305);
            raManager.Margin = new Padding(6, 5, 6, 5);
            raManager.Name = "raManager";
            raManager.Size = new Size(143, 37);
            raManager.TabIndex = 8;
            raManager.TabStop = true;
            raManager.Text = "Manager";
            raManager.UseVisualStyleBackColor = true;
            // 
            // raStaff
            // 
            raStaff.AutoSize = true;
            raStaff.Location = new Point(762, 305);
            raStaff.Margin = new Padding(6, 5, 6, 5);
            raStaff.Name = "raStaff";
            raStaff.Size = new Size(89, 37);
            raStaff.TabIndex = 9;
            raStaff.TabStop = true;
            raStaff.Text = "Staff";
            raStaff.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            butSave.BackColor = Color.White;
            butSave.Location = new Point(736, 681);
            butSave.Margin = new Padding(5);
            butSave.Name = "butSave";
            butSave.Size = new Size(176, 46);
            butSave.TabIndex = 16;
            butSave.Text = "Save";
            butSave.UseVisualStyleBackColor = false;
            butSave.Click += butSave_Click;
            // 
            // butDel
            // 
            butDel.BackColor = Color.White;
            butDel.Location = new Point(946, 681);
            butDel.Margin = new Padding(5);
            butDel.Name = "butDel";
            butDel.Size = new Size(176, 46);
            butDel.TabIndex = 15;
            butDel.Text = "Delete";
            butDel.UseVisualStyleBackColor = false;
            butDel.Click += butDel_Click;
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.Location = new Point(526, 681);
            butBack.Margin = new Padding(5);
            butBack.Name = "butBack";
            butBack.Size = new Size(176, 46);
            butBack.TabIndex = 14;
            butBack.Text = "Back";
            butBack.UseVisualStyleBackColor = false;
            butBack.Click += butBack_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(71, 374);
            dataGridView.Margin = new Padding(5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1051, 276);
            dataGridView.TabIndex = 13;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // StaffAccount
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1182, 753);
            Controls.Add(butSave);
            Controls.Add(butDel);
            Controls.Add(butBack);
            Controls.Add(dataGridView);
            Controls.Add(raStaff);
            Controls.Add(raManager);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "StaffAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Account";
            Load += StaffAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPass;
        private RadioButton raManager;
        private RadioButton raStaff;
        private Button butSave;
        private Button butDel;
        private Button butBack;
        private DataGridView dataGridView;
    }
}