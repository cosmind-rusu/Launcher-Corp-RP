using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher_Corp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"FiveM://connect/f7.185.178.163.112:30120");
        }
            private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://firecorp.es");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/bdQxMzks");
        }
    }
}
