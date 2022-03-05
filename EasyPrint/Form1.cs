using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPrint
{

    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        IntPtr thisWindow;


        public Form1()
        {
            InitializeComponent();
            thisWindow = FindWindow(null, "EasySnap");
            RegisterHotKey(this.Handle, 1, 0x0000, (int)Keys.F8);
        }

        private void Form1_load(object sender, EventArgs e)
        {
            
        }

        protected override void WndProc(ref Message keyPressed)
        {
            base.WndProc(ref keyPressed);
            if (keyPressed.Msg == 0x0312)
            {
                printNow();
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(thisWindow, 1);
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(600);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized && minimizeCB.Checked != false)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to close this window?", "Close Window", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                    //Closes the window
                }
                else
                {
                    e.Cancel = true;  
                    //keeps us going
                }
            }
        }

        public void printNow()
        {
            if (dirlabel.Text != "")
            {
                ImageHandler p = new ImageHandler();
                p.PrintScreen(dirlabel.Text + @"\print.jpg");
                p.PrintReg(dirlabel.Text + @"\regprint.jpg", 0, 0, 800, 800);
            }
            else
            {
                MessageBox.Show("Please select savepath!");
            }
        }


        private void Button(object sender, EventArgs e)
        {
            printNow();
        }
       

        private void notifyIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void minimizeCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(fbd.SelectedPath);
                dirlabel.Text = fbd.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dirlabel_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                xlabel.Text = "X = 0";
                ylabel.Text = "Y = 0";
                hlabel.Text = "Height = " + Convert.ToString(Screen.PrimaryScreen.Bounds.Height);
                wlabel.Text = "Width = " + Convert.ToString(Screen.PrimaryScreen.Bounds.Width);
            }
            

        }
    }
}
