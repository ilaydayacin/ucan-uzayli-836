using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_oynatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnİlerle_Click(object sender, EventArgs e)
        {
            pbUzayli.Left = pbUzayli.Left + 10;
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            pbUzayli.Height = pbUzayli.Height + 10;
        }
    }
}
