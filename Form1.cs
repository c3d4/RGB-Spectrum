using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2.Properties; 

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            richTextBox1.AppendText("Debug Log Start: \r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Value = Settings.Default.R;
            trackBar2.Value = Settings.Default.G;
            trackBar3.Value = Settings.Default.B;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value);
            textBox2.Text = Convert.ToString(trackBar2.Value);
            textBox3.Text = Convert.ToString(trackBar3.Value);
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);

            label1.Text = textBox1.Text + ", " + textBox2.Text + ", " + textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("---------------------------------------\r\n");
            richTextBox1.AppendText("Saving...\r\n");

            Settings.Default.R = trackBar1.Value;
            Settings.Default.G = trackBar2.Value;
            Settings.Default.B = trackBar3.Value;

            Settings.Default.Save();
            richTextBox1.AppendText("Save Complete!\r\n");
            richTextBox1.AppendText("---------------------------------------\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("----------------------------------------\r\n");
            richTextBox1.AppendText("Processing...\r\n");
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;

            Settings.Default.R = trackBar1.Value;
            Settings.Default.G = trackBar2.Value;
            Settings.Default.B = trackBar3.Value;

            Settings.Default.Save();
            richTextBox1.Clear();
            richTextBox1.AppendText("Reset Complete!\r\n");
            richTextBox1.AppendText("---------------------------------------\r\n");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            richTextBox1.AppendText("R: " + trackBar1.Value + "\r\n");
            richTextBox1.AppendText("G: " + trackBar2.Value + "\r\n");
            richTextBox1.AppendText("B: " + trackBar3.Value + "\r\n");
            richTextBox1.AppendText("---------------------------------------\r\n");

        }
    }
}
