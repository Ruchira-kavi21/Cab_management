namespace CabRental
{
    partial class driverInterface
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
            button7 = new Button();
            textBox2 = new TextBox();
            button6 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(657, 4);
            button7.Name = "button7";
            button7.Size = new Size(89, 32);
            button7.TabIndex = 44;
            button7.Text = "Log out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(269, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 43);
            textBox2.TabIndex = 43;
            textBox2.Text = "DRIVER  SCREEN";
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(763, 1);
            button6.Name = "button6";
            button6.Size = new Size(35, 37);
            button6.TabIndex = 42;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 1);
            button2.Name = "button2";
            button2.Size = new Size(49, 37);
            button2.TabIndex = 41;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(798, 93);
            textBox1.TabIndex = 40;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(732, 235);
            dataGridView1.TabIndex = 45;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(346, 379);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 46;
            button1.Text = "click here";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // driverInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Controls.Add(textBox2);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "driverInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "driverInterface";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private TextBox textBox2;
        private Button button6;
        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}