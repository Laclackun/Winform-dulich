
namespace TravelTour
{
    partial class Homepage
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
            txtSreach = new TextBox();
            butSreach = new Button();
            dataGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            loginMenu = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem1 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            tourMenu = new ToolStripMenuItem();
            tourManagerToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            accountMenu = new ToolStripMenuItem();
            inforAccountToolStripMenuItem = new ToolStripMenuItem();
            accountManagerToolStripMenuItem = new ToolStripMenuItem();
            staffManagerToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnToolStripMenuItem = new ToolStripMenuItem();
            butDetail = new Button();
            butClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 72);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 55);
            label1.TabIndex = 0;
            label1.Text = "Travel Tour";
            // 
            // txtSreach
            // 
            txtSreach.Location = new Point(434, 189);
            txtSreach.Margin = new Padding(6, 5, 6, 5);
            txtSreach.Name = "txtSreach";
            txtSreach.Size = new Size(489, 39);
            txtSreach.TabIndex = 2;
            // 
            // butSreach
            // 
            butSreach.BackColor = Color.White;
            butSreach.Location = new Point(951, 185);
            butSreach.Margin = new Padding(6, 5, 6, 5);
            butSreach.Name = "butSreach";
            butSreach.Size = new Size(176, 46);
            butSreach.TabIndex = 3;
            butSreach.Text = "Search";
            butSreach.UseVisualStyleBackColor = false;
            butSreach.Click += butSreach_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(56, 252);
            dataGridView.Margin = new Padding(6, 5, 6, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1071, 392);
            dataGridView.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Snow;
            menuStrip1.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginMenu, tourMenu, accountMenu, hướngDẫnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 3, 0, 3);
            menuStrip1.Size = new Size(1182, 37);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginMenu
            // 
            loginMenu.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, loginToolStripMenuItem1, logoutToolStripMenuItem });
            loginMenu.Font = new Font("Cambria", 13.8F);
            loginMenu.Name = "loginMenu";
            loginMenu.Size = new Size(80, 31);
            loginMenu.Text = "Login";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Font = new Font("Cambria", 13.8F);
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(179, 32);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem1
            // 
            loginToolStripMenuItem1.Font = new Font("Cambria", 13.8F);
            loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            loginToolStripMenuItem1.Size = new Size(179, 32);
            loginToolStripMenuItem1.Text = "Login";
            loginToolStripMenuItem1.Click += loginToolStripMenuItem1_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(179, 32);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // tourMenu
            // 
            tourMenu.DropDownItems.AddRange(new ToolStripItem[] { tourManagerToolStripMenuItem, orderToolStripMenuItem });
            tourMenu.Font = new Font("Cambria", 13.8F);
            tourMenu.Name = "tourMenu";
            tourMenu.Size = new Size(73, 31);
            tourMenu.Text = "Tour";
            // 
            // tourManagerToolStripMenuItem
            // 
            tourManagerToolStripMenuItem.Name = "tourManagerToolStripMenuItem";
            tourManagerToolStripMenuItem.Size = new Size(236, 32);
            tourManagerToolStripMenuItem.Text = "Tour Manager";
            tourManagerToolStripMenuItem.Click += tourManagerToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(236, 32);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // accountMenu
            // 
            accountMenu.DropDownItems.AddRange(new ToolStripItem[] { inforAccountToolStripMenuItem, accountManagerToolStripMenuItem, staffManagerToolStripMenuItem });
            accountMenu.Font = new Font("Cambria", 13.8F);
            accountMenu.Name = "accountMenu";
            accountMenu.Size = new Size(106, 31);
            accountMenu.Text = "Account";
            // 
            // inforAccountToolStripMenuItem
            // 
            inforAccountToolStripMenuItem.Name = "inforAccountToolStripMenuItem";
            inforAccountToolStripMenuItem.Size = new Size(285, 32);
            inforAccountToolStripMenuItem.Text = "Infor Account";
            inforAccountToolStripMenuItem.Click += inforAccountToolStripMenuItem_Click;
            // 
            // accountManagerToolStripMenuItem
            // 
            accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            accountManagerToolStripMenuItem.Size = new Size(285, 32);
            accountManagerToolStripMenuItem.Text = "Customer Manager";
            accountManagerToolStripMenuItem.Click += accountManagerToolStripMenuItem_Click;
            // 
            // staffManagerToolStripMenuItem
            // 
            staffManagerToolStripMenuItem.Name = "staffManagerToolStripMenuItem";
            staffManagerToolStripMenuItem.Size = new Size(285, 32);
            staffManagerToolStripMenuItem.Text = "Staff Manager";
            staffManagerToolStripMenuItem.Click += staffManagerToolStripMenuItem_Click;
            // 
            // hướngDẫnToolStripMenuItem
            // 
            hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            hướngDẫnToolStripMenuItem.Size = new Size(138, 31);
            hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            hướngDẫnToolStripMenuItem.Click += hướngDẫnToolStripMenuItem_Click;
            // 
            // butDetail
            // 
            butDetail.BackColor = Color.White;
            butDetail.Location = new Point(737, 673);
            butDetail.Margin = new Padding(6, 5, 6, 5);
            butDetail.Name = "butDetail";
            butDetail.Size = new Size(176, 46);
            butDetail.TabIndex = 6;
            butDetail.Text = "Detail";
            butDetail.UseVisualStyleBackColor = false;
            butDetail.Click += butDetail_Click;
            // 
            // butClose
            // 
            butClose.BackColor = Color.White;
            butClose.Location = new Point(951, 673);
            butClose.Margin = new Padding(6, 5, 6, 5);
            butClose.Name = "butClose";
            butClose.Size = new Size(176, 46);
            butClose.TabIndex = 7;
            butClose.Text = "Close";
            butClose.UseVisualStyleBackColor = false;
            butClose.Click += butClose_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1182, 753);
            Controls.Add(butClose);
            Controls.Add(butDetail);
            Controls.Add(dataGridView);
            Controls.Add(butSreach);
            Controls.Add(txtSreach);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox txtSreach;
        private Button butSreach;
        private DataGridView dataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginMenu;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem1;
        private ToolStripMenuItem tourMenu;
        private ToolStripMenuItem tourManagerToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem accountMenu;
        private ToolStripMenuItem inforAccountToolStripMenuItem;
        private ToolStripMenuItem accountManagerToolStripMenuItem;
        private Button butDetail;
        private Button butClose;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem staffManagerToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnToolStripMenuItem;
    }
}