using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;

        public Form1()
        {
            InitializeComponent();
        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuConteiner.Height += 10;
                if (menuConteiner.Height >= 176)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuConteiner.Height -= 10;
                if (menuConteiner.Height <= 48)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 52)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 258)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    button1.Width = sidebar.Width;
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnHum_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2();
                form2.FormClosed += Form2_FormClosed;
                form2.MdiParent = this;
                form2.Dock = DockStyle.Fill;
                form2.Show();
            }
            else
            {
                form2.Activate();
            }
        }

        private void Form2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            form2 = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form3 == null)
            {
                form3 = new Form3();
                form3.FormClosed += Form3_FormClosed;
                form3.MdiParent = this;
                form3.Dock = DockStyle.Fill;
                form3.Show();
            }
            else
            {
                form3.Activate();
            }
        }

        private void Form3_FormClosed(object? sender, FormClosedEventArgs e)
        {
            form3 = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}