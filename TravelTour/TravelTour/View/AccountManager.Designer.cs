namespace TravelTour.View
{
    partial class AccountManager
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtPass = new TextBox();
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
            label1.Location = new Point(207, 120);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 33);
            label1.TabIndex = 0;
            label1.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 197);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 33);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 268);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 33);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(395, 33);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(392, 47);
            label4.TabIndex = 3;
            label4.Text = "ACCOUNT MANAGER";
            // 
            // txtID
            // 
            txtID.Location = new Point(450, 117);
            txtID.Margin = new Padding(6, 5, 6, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(448, 39);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(450, 194);
            txtName.Margin = new Padding(6, 5, 6, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(448, 39);
            txtName.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(450, 265);
            txtPass.Margin = new Padding(6, 5, 6, 5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(448, 39);
            txtPass.TabIndex = 6;
            // 
            // butSave
            // 
            butSave.BackColor = Color.White;
            butSave.Location = new Point(733, 678);
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
            butDel.Location = new Point(943, 678);
            butDel.Margin = new Padding(5);
            butDel.Name = "butDel";
            butDel.Size = new Size(176, 46);
            butDel.TabIndex = 15;
            butDel.Text = "Delete";
            butDel.UseVisualStyleBackColor = false;
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.Location = new Point(523, 678);
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
            dataGridView.Location = new Point(68, 345);
            dataGridView.Margin = new Padding(5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1051, 302);
            dataGridView.TabIndex = 13;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // AccountManager
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1182, 753);
            Controls.Add(butSave);
            Controls.Add(butDel);
            Controls.Add(butBack);
            Controls.Add(dataGridView);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AccountManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountManager";
            Load += AccountManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPass;
        private Button butSave;
        private Button butDel;
        private Button butBack;
        private DataGridView dataGridView;
    }
}