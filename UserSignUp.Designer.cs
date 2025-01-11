namespace CabRental
{
    partial class UserSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignUp));
            button3 = new Button();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button = new Button();
            button2 = new Button();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(535, 258);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 37;
            button3.Text = "SignUp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(592, 26);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 34;
            label4.Text = "SignUp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-4, 12);
            label1.Name = "label1";
            label1.Size = new Size(341, 32);
            label1.TabIndex = 33;
            label1.Text = "CAB MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-18, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 442);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // button
            // 
            button.BackColor = Color.White;
            button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.ForeColor = Color.Black;
            button.Location = new Point(784, 12);
            button.Name = "button";
            button.Size = new Size(35, 37);
            button.TabIndex = 31;
            button.Text = "X";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(685, 258);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 29;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(535, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(225, 29);
            txtPassword.TabIndex = 28;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(535, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 29);
            txtName.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(387, 192);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 26;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 143);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 25;
            label2.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(356, 4);
            button1.Name = "button1";
            button1.Size = new Size(49, 37);
            button1.TabIndex = 39;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 442);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button);
            Controls.Add(button2);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserSignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button;
        private Button button2;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}