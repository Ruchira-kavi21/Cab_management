namespace CabRental
{
    partial class addCars
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
            Cavailabl = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            textBox2 = new TextBox();
            button6 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Cid = new TextBox();
            label1 = new Label();
            Cplate = new TextBox();
            Cmodel = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Cavailabl
            // 
            Cavailabl.BackColor = Color.White;
            Cavailabl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cavailabl.Location = new Point(195, 281);
            Cavailabl.Name = "Cavailabl";
            Cavailabl.Size = new Size(225, 29);
            Cavailabl.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 285);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 53;
            label5.Text = "Availability";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(511, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(260, 235);
            dataGridView1.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(583, 106);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 51;
            label4.Text = "Car List";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(225, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 43);
            textBox2.TabIndex = 50;
            textBox2.Text = "CAR MENAGEMENT SCREEN";
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(764, -4);
            button6.Name = "button6";
            button6.Size = new Size(35, 37);
            button6.TabIndex = 49;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1, -4);
            button2.Name = "button2";
            button2.Size = new Size(49, 37);
            button2.TabIndex = 48;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1, -4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(798, 93);
            textBox1.TabIndex = 47;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Location = new Point(263, 340);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 46;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.Location = new Point(358, 340);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 45;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(163, 340);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 44;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Cid
            // 
            Cid.BackColor = Color.White;
            Cid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cid.Location = new Point(195, 147);
            Cid.Name = "Cid";
            Cid.Size = new Size(225, 29);
            Cid.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 147);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 42;
            label1.Text = "Car Id";
            // 
            // Cplate
            // 
            Cplate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cplate.Location = new Point(195, 240);
            Cplate.Name = "Cplate";
            Cplate.Size = new Size(225, 29);
            Cplate.TabIndex = 41;
            // 
            // Cmodel
            // 
            Cmodel.BackColor = Color.White;
            Cmodel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cmodel.Location = new Point(195, 196);
            Cmodel.Name = "Cmodel";
            Cmodel.Size = new Size(225, 29);
            Cmodel.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 240);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 39;
            label3.Text = "Plate Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 196);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 38;
            label2.Text = "Model";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(597, 388);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 55;
            button1.Text = "click here";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(669, 1);
            button7.Name = "button7";
            button7.Size = new Size(89, 32);
            button7.TabIndex = 56;
            button7.Text = "Log out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // addCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(Cavailabl);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(Cid);
            Controls.Add(label1);
            Controls.Add(Cplate);
            Controls.Add(Cmodel);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addCars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addCars";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Cavailabl;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBox2;
        private Button button6;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox Cid;
        private Label label1;
        private TextBox Cplate;
        private TextBox Cmodel;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button7;
    }
}