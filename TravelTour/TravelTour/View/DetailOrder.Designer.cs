namespace TravelTour.View
{
    partial class DetailOrder
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
            txtIDTour = new TextBox();
            label2 = new Label();
            txtIDOrder = new TextBox();
            label6 = new Label();
            txtIDAcc = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtNameAcc = new TextBox();
            txtNameTour = new TextBox();
            datePick = new DateTimePicker();
            txtQuantity = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.Location = new Point(609, 410);
            butBack.Margin = new Padding(6, 5, 6, 5);
            butBack.Name = "butBack";
            butBack.Size = new Size(176, 46);
            butBack.TabIndex = 5;
            butBack.Text = "Back";
            butBack.UseVisualStyleBackColor = false;
            butBack.Click += butBack_Click;
            // 
            // txtIDTour
            // 
            txtIDTour.Location = new Point(227, 266);
            txtIDTour.Margin = new Padding(6, 5, 6, 5);
            txtIDTour.Name = "txtIDTour";
            txtIDTour.Size = new Size(200, 39);
            txtIDTour.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 269);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 33);
            label2.TabIndex = 13;
            label2.Text = "ID Tour";
            // 
            // txtIDOrder
            // 
            txtIDOrder.Location = new Point(227, 118);
            txtIDOrder.Margin = new Padding(6, 5, 6, 5);
            txtIDOrder.Name = "txtIDOrder";
            txtIDOrder.Size = new Size(200, 39);
            txtIDOrder.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 121);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 33);
            label6.TabIndex = 23;
            label6.Text = "ID Order";
            // 
            // txtIDAcc
            // 
            txtIDAcc.Location = new Point(227, 192);
            txtIDAcc.Margin = new Padding(6, 5, 6, 5);
            txtIDAcc.Name = "txtIDAcc";
            txtIDAcc.Size = new Size(200, 39);
            txtIDAcc.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 195);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 33);
            label1.TabIndex = 21;
            label1.Text = "ID Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(316, 30);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(295, 47);
            label4.TabIndex = 25;
            label4.Text = "DETAIL ORDER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 195);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 33);
            label3.TabIndex = 26;
            label3.Text = "Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(478, 269);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 33);
            label5.TabIndex = 27;
            label5.Text = "Name Tour";
            // 
            // txtNameAcc
            // 
            txtNameAcc.Location = new Point(653, 192);
            txtNameAcc.Margin = new Padding(6, 5, 6, 5);
            txtNameAcc.Name = "txtNameAcc";
            txtNameAcc.Size = new Size(235, 39);
            txtNameAcc.TabIndex = 28;
            // 
            // txtNameTour
            // 
            txtNameTour.Location = new Point(653, 266);
            txtNameTour.Margin = new Padding(6, 5, 6, 5);
            txtNameTour.Name = "txtNameTour";
            txtNameTour.Size = new Size(235, 39);
            txtNameTour.TabIndex = 29;
            // 
            // datePick
            // 
            datePick.Format = DateTimePickerFormat.Short;
            datePick.Location = new Point(227, 341);
            datePick.Margin = new Padding(6, 5, 6, 5);
            datePick.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            datePick.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datePick.Name = "datePick";
            datePick.Size = new Size(200, 39);
            datePick.TabIndex = 33;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(227, 414);
            txtQuantity.Margin = new Padding(6, 5, 6, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 39);
            txtQuantity.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 417);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 33);
            label7.TabIndex = 31;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 341);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 33);
            label8.TabIndex = 30;
            label8.Text = "Date";
            // 
            // DetailOrder
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(932, 503);
            Controls.Add(datePick);
            Controls.Add(txtQuantity);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtNameTour);
            Controls.Add(txtNameAcc);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtIDOrder);
            Controls.Add(label6);
            Controls.Add(txtIDAcc);
            Controls.Add(label1);
            Controls.Add(txtIDTour);
            Controls.Add(label2);
            Controls.Add(butBack);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "DetailOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butBack;
        private TextBox txtIDTour;
        private Label label2;
        private TextBox txtIDOrder;
        private Label label6;
        private TextBox txtIDAcc;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtNameAcc;
        private TextBox txtNameTour;
        private DateTimePicker datePick;
        private TextBox txtQuantity;
        private Label label7;
        private Label label8;
    }
}