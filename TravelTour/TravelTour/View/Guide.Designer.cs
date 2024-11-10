namespace TravelTour.View
{
    partial class Guide
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
            butBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.Location = new Point(24, 33);
            butBack.Margin = new Padding(5);
            butBack.Name = "butBack";
            butBack.Size = new Size(176, 46);
            butBack.TabIndex = 15;
            butBack.Text = "Back";
            butBack.UseVisualStyleBackColor = false;
            butBack.Click += butBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 40);
            label1.Name = "label1";
            label1.Size = new Size(742, 33);
            label1.TabIndex = 16;
            label1.Text = "<= Chiếc nút giúp bạn có thể trở về Form trước bất kì lúc nào.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(96, 33);
            label2.TabIndex = 17;
            label2.Text = "Lưu ý:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 93);
            label3.Name = "label3";
            label3.Size = new Size(1036, 33);
            label3.TabIndex = 18;
            label3.Text = "Hãy sử dụng nút này nếu bạn muốn thêm mới nhưng đã lỡ ấn vào bảng DataGridView.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(24, 154);
            label4.Name = "label4";
            label4.Size = new Size(87, 33);
            label4.TabIndex = 19;
            label4.Text = "Login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 154);
            label5.Name = "label5";
            label5.Size = new Size(455, 33);
            label5.TabIndex = 20;
            label5.Text = "Có 3 Account đã tạo trước trong SQL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(587, 154);
            label6.Name = "label6";
            label6.Size = new Size(388, 33);
            label6.TabIndex = 21;
            label6.Text = "1. quyquynh - 12345 - Manager";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 204);
            label7.Name = "label7";
            label7.Size = new Size(320, 33);
            label7.TabIndex = 22;
            label7.Text = "2. trantran - 09876 - Staff";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(587, 253);
            label8.Name = "label8";
            label8.Size = new Size(358, 33);
            label8.TabIndex = 23;
            label8.Text = "3. uyDuong - ABC - Customer";
            // 
            // Guide
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1182, 553);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butBack);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Guide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guide";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}