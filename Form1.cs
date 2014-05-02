using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitivesFillingCG
{
    public partial class FormInit : Form
    {
        public FormInit()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CanvasForm cf = new CanvasForm(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            cf.Show();
        }
    }
}
