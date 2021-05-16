using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bramerto_rob
{
    public partial class Img : Form
    {
        public Img()
        {
            InitializeComponent();
        }

        private void ImageClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("ニャンパス");
        }
    }
}
