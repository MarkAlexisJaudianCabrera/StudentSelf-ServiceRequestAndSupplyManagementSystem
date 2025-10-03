namespace StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StaffAdmin.Cashier
{
    partial class CashierDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashboard));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            button3 = new Button();
            panel6 = new Panel();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-23, 69);
            label1.Name = "label1";
            label1.Size = new Size(1337, 15);
            label1.TabIndex = 7;
            label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1074, 25);
            button1.Name = "button1";
            button1.Size = new Size(173, 38);
            button1.TabIndex = 4;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(11, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 424);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(11, 102);
            label3.Name = "label3";
            label3.Size = new Size(328, 38);
            label3.TabIndex = 9;
            label3.Text = "Cashier Dashboard";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(11, 197);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search...";
            textBox1.Size = new Size(973, 39);
            textBox1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkGreen;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Location = new Point(990, 197);
            flowLayoutPanel1.MaximumSize = new Size(254, 126);
            flowLayoutPanel1.MinimumSize = new Size(254, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(254, 39);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 39);
            panel2.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 10, 0);
            button2.Size = new Size(254, 39);
            button2.TabIndex = 12;
            button2.Text = "FILTER ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Location = new Point(0, 39);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(254, 42);
            panel5.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 10, 0);
            button3.Size = new Size(254, 39);
            button3.TabIndex = 12;
            button3.Text = "FILTER : STUDENT ID";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(0, 81);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(254, 43);
            panel6.TabIndex = 16;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 10, 0);
            button4.Size = new Size(254, 40);
            button4.TabIndex = 13;
            button4.Text = "FILTER : PAYMENT CODE";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1260, 677);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CashierDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierDashboard";
            Load += CashierDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}