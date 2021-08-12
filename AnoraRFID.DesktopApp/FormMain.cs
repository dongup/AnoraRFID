using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnoraRFID.DesktopApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormProductIn formProductIn = new FormProductIn();
            formProductIn.TopLevel = false;
            formProductIn.Dock = DockStyle.Fill;
            formProductIn.Show();
            tabProductIn.Controls.Add(formProductIn);
        }
    }
}
