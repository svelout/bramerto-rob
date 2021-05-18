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

namespace bramerto_rob
{
    public partial class Img : Form
    {
        public Img()
        {
            InitializeComponent();
        }

        public partial class NativeMethods
        {

            /// Return Type: BOOL->int
            ///fBlockIt: BOOL->int
            [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool BlockInput([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool fBlockIt);

        }

        private void Image_Load(object sender, EventArgs e)
        {

        }
        private void ImageClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("ニャンパス");
        }
    }
}
