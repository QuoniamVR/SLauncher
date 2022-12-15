using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace ReshadeCraft
{
    public partial class ReshadeCraft : Form
    {
        public ReshadeCraft()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PROGRESS.Text = "Starting ReShade...";
            System.Diagnostics.Process.Start("CMD.exe", "/C cd C:/Users/%username%/Desktop/ReshadeCraft_Launcher && inject64.exe Minecraft.Windows.exe");
            System.Threading.Thread.Sleep(1000);
            PROGRESS.Text = "Ready to inject, please launch Minecraft!";
        }
     }
}
