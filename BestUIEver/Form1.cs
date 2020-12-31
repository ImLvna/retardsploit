using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;

namespace BestUIEver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Module api = new Module();

        private void button1_Click(object sender, EventArgs e)
        {
            // Enjekte code
            api.LaunchExploit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exec code
            api.ExecuteScript(fastColoredTextBox1.Text);
        }
    }
}
