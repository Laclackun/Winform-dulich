namespace TravelTour.View
{
    partial class TourManager
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
            datePickStart = new DateTimePicker();
            datePickEnd = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView = new DataGridView();
            txtIDTour = new TextBox();
            txtName = new TextBox();
            txtDesciption = new TextBox();
            txtLocation = new TextBox();
            comboType = new ComboBox();
            txtQuantity = new TextBox();
            picTravel = new PictureBox();
            butDispose = new Button();
            butSave = new Button();
            butBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTravel).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(443, 29);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(321, 47);
            label1.TabIndex = 0;
            label1.Text = "TOUR MANAGER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 229);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 33);
            label2.TabIndex = 1;
            label2.Text = "ID Tour";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 229);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 33);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 309);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 33);
            label4.TabIndex = 3;
            label4.Text = "Start at";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 309);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 33);
            label5.TabIndex = 4;
            label5.Text = "End at";
            // 
            // datePickStart
            // 
            datePickStart.Format = DateTimePickerFormat.Short;
            datePickStart.Location = new Point(206, 304);
            datePickStart.Margin = new Padding(6, 5, 6, 5);
            datePickStart.Name = "datePickStart";
            datePickStart.Size = new Size(219, 39);
            datePickStart.TabIndex = 5;
            // 
            // datePickEnd
            // 
            datePickEnd.Format = DateTimePickerFormat.Short;
            datePickEnd.Location = new Point(607, 304);
            datePickEnd.Margin = new Padding(6, 5, 6, 5);
            datePickEnd.Name = "datePickEnd";
            datePickEnd.Size = new Size(217, 39);
            datePickEnd.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 149);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 33);
            label6.TabIndex = 7;
            label6.Text = "Desciption";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 392);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 33);
            label7.TabIndex = 8;
            label7.Text = "Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 392);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 33);
            label8.TabIndex = 9;
            label8.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(615, 149);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(118, 33);
            label9.TabIndex = 10;
            label9.Text = "Quantity";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(56, 460);
            dataGridView.Margin = new Padding(6, 5, 6, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1069, 304);
            dataGridView.TabIndex = 11;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // txtIDTour
            // 
            txtIDTour.Location = new Point(206, 226);
            txtIDTour.Margin = new Padding(6, 5, 6, 5);
            txtIDTour.Name = "txtIDTour";
            txtIDTour.Size = new Size(219, 39);
            txtIDTour.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(607, 226);
            txtName.Margin = new Padding(6, 5, 6, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 39);
            txtName.TabIndex = 13;
            // 
            // txtDesciption
            // 
            txtDesciption.Location = new Point(206, 146);
            txtDesciption.Margin = new Padding(6, 5, 6, 5);
            txtDesciption.Name = "txtDesciption";
            txtDesciption.Size = new Size(397, 39);
            txtDesciption.TabIndex = 14;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(206, 389);
            txtLocation.Margin = new Padding(6, 5, 6, 5);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(219, 39);
            txtLocation.TabIndex = 15;
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(607, 389);
            comboType.Margin = new Padding(6, 5, 6, 5);
            comboType.Name = "comboType";
            comboType.Size = new Size(217, 40);
            comboType.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(745, 146);
            txtQuantity.Margin = new Padding(6, 5, 6, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(79, 39);
            txtQuantity.TabIndex = 17;
            // 
            // picTravel
            // 
            picTravel.BackColor = Color.Snow;
            picTravel.Location = new Point(848, 108);
            picTravel.Margin = new Padding(6, 5, 6, 5);
            picTravel.Name = "picTravel";
            picTravel.Size = new Size(277, 267);
            picTravel.SizeMode = PictureBoxSizeMode.Zoom;
            picTravel.TabIndex = 18;
            picTravel.TabStop = false;
            picTravel.Click += picTravel_Click;
            // 
            // butDispose
            // 
            butDispose.BackColor = Color.White;
            butDispose.Location = new Point(927, 385);
            butDispose.Margin = new Padding(5);
            butDispose.Name = "butDispose";
            butDispose.Size = new Size(131, 46);
            butDispose.TabIndex = 19;
            butDispose.Text = "Dispose";
            butDispose.UseVisualStyleBackColor = false;
            butDispose.Click += butDispose_Click;
            // 
            // butSave
            // 
            butSave.BackColor = Color.White;
            butSave.Location = new Point(949, 784);
            butSave.Margin = new Padding(5);
            butSave.Name = "butSave";
            butSave.Size = new Size(176, 46);
            butSave.TabIndex = 21;
            butSave.Text = "Save";
            butSave.UseVisualStyleBackColor = false;
            butSave.Click += butSave_Click;
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.Location = new Point(739, 784);
            butBack.Margin = new Padding(5);
            butBack.Name = "butBack";
            butBack.Size = new Size(176, 46);
            butBack.TabIndex = 20;
            butBack.Text = "Back";
            butBack.UseVisualStyleBackColor = false;
            butBack.Click += butBack_Click;
            // 
            // TourManager
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1182, 853);
            Controls.Add(butSave);
            Controls.Add(butBack);
            Controls.Add(butDispose);
            Controls.Add(picTravel);
            Controls.Add(txtQuantity);
            Controls.Add(comboType);
            Controls.Add(txtLocation);
            Controls.Add(txtDesciption);
            Controls.Add(txtName);
            Controls.Add(txtIDTour);
            Controls.Add(dataGridView);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(datePickEnd);
            Controls.Add(datePickStart);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "TourManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TourManager";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
        private DateTimePicker datePickStart;
        private DateTimePicker datePickEnd;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView;
        private TextBox txtIDTour;
        private TextBox txtName;
        private TextBox txtDesciption;
        private TextBox txtLocation;
        private ComboBox comboType;
        private TextBox txtQuantity;
        private PictureBox picTravel;
        private Button butDispose;
        private Button butSave;
        private Button butBack;
    }
}