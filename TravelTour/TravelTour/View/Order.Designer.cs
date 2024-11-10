namespace TravelTour.View
{
    partial class Order
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
            dataGridView = new DataGridView();
            butChange = new Button();
            butBack = new Button();
            butDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 49);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 47);
            label1.TabIndex = 0;
            label1.Text = "Check Your Order";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(77, 138);
            dataGridView.Margin = new Padding(6, 5, 6, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1031, 462);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // butChange
            // 
            butChange.BackColor = Color.White;
            butChange.Location = new Point(932, 655);
            butChange.Margin = new Padding(6, 5, 6, 5);
            butChange.Name = "butChange";
            butChange.Size = new Size(176, 46);
            butChange.TabIndex = 3;
            butChange.Text = "Change";
            butChange.UseVisualStyleBackColor = false;
            butChange.Click += butChange_Click;
            // 
            // butBack
            // 
            butBack.BackColor = Color.White;
            butBack.Location = new Point(490, 655);
            butBack.Margin = new Padding(6, 5, 6, 5);
            butBack.Name = "butBack";
            butBack.Size = new Size(176, 46);
            butBack.TabIndex = 4;
            butBack.Text = "Back";
            butBack.UseVisualStyleBackColor = false;
            butBack.Click += butBack_Click;
            // 
            // butDetail
            // 
            butDetail.BackColor = Color.White;
            butDetail.Location = new Point(718, 655);
            butDetail.Margin = new Padding(6, 5, 6, 5);
            butDetail.Name = "butDetail";
            butDetail.Size = new Size(176, 46);
            butDetail.TabIndex = 5;
            butDetail.Text = "Detail";
            butDetail.UseVisualStyleBackColor = false;
            butDetail.Click += butDetail_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1182, 753);
            Controls.Add(butDetail);
            Controls.Add(butBack);
            Controls.Add(butChange);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView;
        private Button butChange;
        private Button butBack;
        private Button butDetail;
    }
}