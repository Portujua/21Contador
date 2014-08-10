using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21Contador
{
    public partial class changelog : Form
    {
        public changelog()
        {
            InitializeComponent();
        }

        private void changelog_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.FromKnownColor(KnownColor.Black);
        }
    }
}
