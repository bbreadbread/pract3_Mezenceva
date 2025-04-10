namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnHum = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            menuConteiner = new FlowLayoutPanel();
            panel3 = new Panel();
            menu = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button6 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            menuConteiner.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHum);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 59);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(718, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(108, 21);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 2;
            label1.Text = "ЙЦУКЕНГ";
            // 
            // btnHum
            // 
            btnHum.Image = (Image)resources.GetObject("btnHum.Image");
            btnHum.Location = new Point(12, 3);
            btnHum.Name = "btnHum";
            btnHum.Size = new Size(56, 50);
            btnHum.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHum.TabIndex = 1;
            btnHum.TabStop = false;
            btnHum.Click += btnHum_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Tomato;
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(menuConteiner);
            sidebar.Controls.Add(button7);
            sidebar.Controls.Add(button8);
            sidebar.Controls.Add(button6);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 59);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(52, 466);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 48);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(256, 48);
            button1.TabIndex = 2;
            button1.TabStop = false;
            button1.Text = "Сотрудники";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuConteiner
            // 
            menuConteiner.Controls.Add(panel3);
            menuConteiner.Controls.Add(panel4);
            menuConteiner.Controls.Add(panel5);
            menuConteiner.Controls.Add(panel6);
            menuConteiner.Location = new Point(3, 57);
            menuConteiner.Name = "menuConteiner";
            menuConteiner.Size = new Size(256, 48);
            menuConteiner.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(menu);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 48);
            panel3.TabIndex = 4;
            // 
            // menu
            // 
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(256, 48);
            menu.TabIndex = 2;
            menu.TabStop = false;
            menu.Text = "button2";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 48);
            panel4.TabIndex = 4;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Image = Properties.Resources._default;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(256, 48);
            button3.TabIndex = 2;
            button3.TabStop = false;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(256, 48);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Image = Properties.Resources._default;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(256, 48);
            button4.TabIndex = 2;
            button4.TabStop = false;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 165);
            panel6.Name = "panel6";
            panel6.Size = new Size(256, 48);
            panel6.TabIndex = 4;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Image = Properties.Resources._default;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(256, 48);
            button5.TabIndex = 2;
            button5.TabStop = false;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(3, 111);
            button7.Name = "button7";
            button7.Size = new Size(256, 48);
            button7.TabIndex = 4;
            button7.TabStop = false;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(3, 165);
            button8.Name = "button8";
            button8.Size = new Size(256, 48);
            button8.TabIndex = 5;
            button8.TabStop = false;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(3, 219);
            button6.Name = "button6";
            button6.Size = new Size(256, 48);
            button6.TabIndex = 3;
            button6.TabStop = false;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(777, 525);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            menuConteiner.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnHum;
        private FlowLayoutPanel sidebar;
        private Button button1;
        private Panel panel2;
        private System.Windows.Forms.Timer menuTransition;
        private FlowLayoutPanel menuConteiner;
        private Panel panel3;
        private Panel panel5;
        private Button button4;
        private Panel panel4;
        private Button button3;
        private Panel panel6;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button menu;
        private PictureBox pictureBox1;
    }
}
