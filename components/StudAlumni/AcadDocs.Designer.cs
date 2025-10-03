namespace StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StudAlumni
{
    partial class AcadDocs
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(197, 18);
            label1.TabIndex = 0;
            label1.Text = "Select Document Type: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(-4, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 358);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Academic Documents";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.LimeGreen;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(320, 302);
            button2.Name = "button2";
            button2.Size = new Size(89, 38);
            button2.TabIndex = 5;
            button2.Text = "Add Item";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(32, 322);
            label4.Name = "label4";
            label4.Size = new Size(128, 18);
            label4.TabIndex = 4;
            label4.Text = "Subtotal: ₱0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(32, 127);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 3;
            label3.Text = "Quantity: 0x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(32, 98);
            label2.Name = "label2";
            label2.Size = new Size(103, 18);
            label2.TabIndex = 2;
            label2.Text = "Price: ₱0.00";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 26);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AcadDocs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(426, 370);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AcadDocs";
            Text = "AcadDocs";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button2;
    }
}