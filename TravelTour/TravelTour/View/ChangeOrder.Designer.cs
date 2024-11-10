namespace TravelTour.View
{
    partial class ChangeOrder
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
            txtIDTour = new TextBox();
            txtIDAcc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            butCancel = new Button();
            butChange = new Button();
            txtQuantity = new TextBox();
            label5 = new Label();
            datePick = new DateTimePicker();
            txtIDOrder = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtIDTour
            // 
            txtIDTour.Location = new Point(247, 271);
            txtIDTour.Margin = new Padding(6, 5, 6, 5);
            txtIDTour.Name = "txtIDTour";
            txtIDTour.Size = new Size(398, 39);
            txtIDTour.TabIndex = 12;
            // 
            // txtIDAcc
            // 
            txtIDAcc.Location = new Point(247, 197);
            txtIDAcc.Margin = new Padding(6, 5, 6, 5);
            txtIDAcc.Name = "txtIDAcc";
            txtIDAcc.Size = new Size(398, 39);
            txtIDAcc.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(137, 33);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(455, 47);
            label4.TabIndex = 10;
            label4.Text = "YOU SURE TO CHANGE ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 348);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 33);
            label3.TabIndex = 9;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 274);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 33);
            label2.TabIndex = 8;
            label2.Text = "ID Tour";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 200);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 33);
            label1.TabIndex = 7;
            label1.Text = "ID Account";
            // 
            // butCancel
            // 
            butCancel.BackColor = Color.White;
            butCancel.Location = new Point(148, 505);
            butCancel.Margin = new Padding(6, 5, 6, 5);
            butCancel.Name = "butCancel";
            butCancel.Size = new Size(176, 46);
            butCancel.TabIndex = 15;
            butCancel.Text = "Cancel";
            butCancel.UseVisualStyleBackColor = false;
            butCancel.Click += butCancel_Click;
            // 
            // butChange
            // 
            butChange.BackColor = Color.White;
            butChange.Location = new Point(395, 505);
            butChange.Margin = new Padding(6, 5, 6, 5);
            butChange.Name = "butChange";
            butChange.Size = new Size(176, 46);
            butChange.TabIndex = 14;
            butChange.Text = "Change";
            butChange.UseVisualStyleBackColor = false;
            butChange.Click += butChange_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(247, 418);
            txtQuantity.Margin = new Padding(6, 5, 6, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(398, 39);
            txtQuantity.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 421);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 33);
            label5.TabIndex = 16;
            label5.Text = "Quantity";
            // 
            // datePick
            // 
            datePick.Format = DateTimePickerFormat.Short;
            datePick.Location = new Point(247, 343);
            datePick.Margin = new Padding(6, 5, 6, 5);
            datePick.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            datePick.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            datePick.Name = "datePick";
            datePick.Size = new Size(398, 39);
            datePick.TabIndex = 18;
            // 
            // txtIDOrder
            // 
            txtIDOrder.Location = new Point(247, 123);
            txtIDOrder.Margin = new Padding(6, 5, 6, 5);
            txtIDOrder.Name = "txtIDOrder";
            txtIDOrder.Size = new Size(398, 39);
            txtIDOrder.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 126);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 33);
            label6.TabIndex = 19;
            label6.Text = "ID Order";
            // 
            // ChangeOrder
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(732, 603);
            Controls.Add(txtIDOrder);
            Controls.Add(label6);
            Controls.Add(datePick);
            Controls.Add(txtQuantity);
            Controls.Add(label5);
            Controls.Add(butCancel);
            Controls.Add(butChange);
            Controls.Add(txtIDTour);
            Controls.Add(txtIDAcc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "ChangeOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIDTour;
        private TextBox txtIDAcc;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button butCancel;
        private Button butChange;
        private TextBox txtQuantity;
        private Label label5;
        private DateTimePicker datePick;
        private TextBox txtIDOrder;
        private Label label6;
    }
}