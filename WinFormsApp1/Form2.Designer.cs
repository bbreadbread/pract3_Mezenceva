namespace WinFormsApp1
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox5 = new TextBox();
            comboBox2 = new ComboBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(369, 461);
            dataGridView1.TabIndex = 42;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.Location = new Point(429, 330);
            button3.Name = "button3";
            button3.Size = new Size(227, 40);
            button3.TabIndex = 41;
            button3.Text = "Подтвердить";
            button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.Location = new Point(429, 251);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 40;
            label8.Text = "Статус комнаты";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.Location = new Point(429, 190);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 39;
            label9.Text = "Цена за сутки";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.Location = new Point(429, 127);
            label10.Name = "label10";
            label10.Size = new Size(156, 20);
            label10.TabIndex = 38;
            label10.Text = "Количество мест";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.Location = new Point(429, 68);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 37;
            label11.Text = "Тип комнаты";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBox5.Location = new Point(429, 91);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(227, 26);
            textBox5.TabIndex = 36;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(429, 274);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 28);
            comboBox2.TabIndex = 35;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBox6.Location = new Point(429, 150);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(227, 26);
            textBox6.TabIndex = 34;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBox7.Location = new Point(429, 213);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(227, 26);
            textBox7.TabIndex = 33;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 461);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(textBox5);
            Controls.Add(comboBox2);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox5;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}