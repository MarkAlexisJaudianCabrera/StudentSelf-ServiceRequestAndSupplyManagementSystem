namespace StudentSelf_ServiceRequestAndSupplyManagementSystem
{
    partial class StaffAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffAdminLogin));
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Arial Rounded MT Bold", 30F);
            textBox4.Location = new Point(289, 222);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Staff ID";
            textBox4.Size = new Size(682, 54);
            textBox4.TabIndex = 7;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial Rounded MT Bold", 30F);
            textBox1.Location = new Point(289, 310);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(682, 54);
            textBox1.TabIndex = 8;
            textBox1.Tag = "";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(488, 399);
            button1.Name = "button1";
            button1.Size = new Size(302, 52);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // StaffAdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1260, 677);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StaffAdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffAdminLogin";
            Load += StaffAdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}