using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\nLinea1");
            Thread.Sleep(500);
            richTextBox1.AppendText("\nLinea2");
            Thread.Sleep(500);
            richTextBox1.AppendText("\nLinea3");
            Thread.Sleep(500);
        }
    }
}
