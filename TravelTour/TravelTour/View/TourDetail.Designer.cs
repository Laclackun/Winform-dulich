namespace TravelTour.View
{
    partial class TourDetail
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
            label7 = new Label();
            picTravel = new PictureBox();
            butBack = new Button();
            label8 = new Label();
            txtIDTour = new TextBox();
            txtName = new TextBox();
            txtDesciption = new TextBox();
            datePickStart = new DateTimePicker();
            datePickEnd = new DateTimePicker();
            comboType = new ComboBox();
            txtQuantity = new TextBox();
            txtLocation = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picTravel).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 59);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 33);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 145);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 33);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 229);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 33);
            label3.TabIndex = 2;
            label3.Text = "Start at";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 229);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 33);
            label4.TabIndex = 3;
            label4.Text = "End at";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 307);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 33);
            label5.TabIndex = 4;
            label5.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(551, 307);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 33);
            label6.TabIndex = 5;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 390);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 33);
            label7.TabIndex = 6;
            label7.Text = "Location";
            // 
            // picTravel
            // 
            picTravel.Location = new Point(66, 469);
            picTravel.Margin = new Padding(6, 5, 6, 5);
            picTravel.Name = "picTravel";
            picTravel.Size = new Size(685, 219);
            picTravel.TabIndex = 9;
            picTravel.TabStop = false;
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.Location = new Point(866, 599);
            butBack.Margin = new Padding(6, 5, 6, 5);
            butBack.Name = "butBack";
            butBack.Size = new Size(176, 59);
            butBack.TabIndex = 10;
            butBack.Text = "Back";
            butBack.UseVisualStyleBackColor = false;
            butBack.Click += butBack_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 67);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 33);
            label8.TabIndex = 12;
            label8.Text = "TourID";
            // 
            // txtIDTour
            // 
            txtIDTour.Location = new Point(236, 56);
            txtIDTour.Margin = new Padding(6, 5, 6, 5);
            txtIDTour.Name = "txtIDTour";
            txtIDTour.Size = new Size(258, 39);
            txtIDTour.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(688, 56);
            txtName.Margin = new Padding(6, 5, 6, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(354, 39);
            txtName.TabIndex = 14;
            // 
            // txtDesciption
            // 
            txtDesciption.Location = new Point(236, 142);
            txtDesciption.Margin = new Padding(6, 5, 6, 5);
            txtDesciption.Name = "txtDesciption";
            txtDesciption.Size = new Size(806, 39);
            txtDesciption.TabIndex = 15;
            // 
            // datePickStart
            // 
            datePickStart.Format = DateTimePickerFormat.Short;
            datePickStart.Location = new Point(236, 224);
            datePickStart.Margin = new Padding(6, 5, 6, 5);
            datePickStart.Name = "datePickStart";
            datePickStart.Size = new Size(258, 39);
            datePickStart.TabIndex = 16;
            // 
            // datePickEnd
            // 
            datePickEnd.Format = DateTimePickerFormat.Short;
            datePickEnd.Location = new Point(688, 224);
            datePickEnd.Margin = new Padding(6, 5, 6, 5);
            datePickEnd.Name = "datePickEnd";
            datePickEnd.Size = new Size(354, 39);
            datePickEnd.TabIndex = 17;
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(236, 304);
            comboType.Margin = new Padding(6, 5, 6, 5);
            comboType.Name = "comboType";
            comboType.Size = new Size(258, 40);
            comboType.TabIndex = 18;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(688, 304);
            txtQuantity.Margin = new Padding(6, 5, 6, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(146, 39);
            txtQuantity.TabIndex = 19;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(236, 387);
            txtLocation.Margin = new Padding(6, 5, 6, 5);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(258, 39);
            txtLocation.TabIndex = 20;
            // 
            // TourDetail
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1182, 720);
            Controls.Add(txtLocation);
            Controls.Add(txtQuantity);
            Controls.Add(comboType);
            Controls.Add(datePickEnd);
            Controls.Add(datePickStart);
            Controls.Add(txtDesciption);
            Controls.Add(txtName);
            Controls.Add(txtIDTour);
            Controls.Add(label8);
            Controls.Add(butBack);
            Controls.Add(picTravel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "TourDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TourDetail";
            ((System.ComponentModel.ISupportInitialize)picTravel).EndInit();
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
        private Label label7;
        private PictureBox picTravel;
        private Button butBack;
        private Label label8;
        private TextBox txtIDTour;
        private TextBox txtName;
        private TextBox txtDesciption;
        private DateTimePicker datePickStart;
        private DateTimePicker datePickEnd;
        private ComboBox comboType;
        private TextBox txtQuantity;
        private TextBox txtLocation;
    }
}