using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comoustedesquieran
{
    public partial class CannyParameters : Form
    {
        Form1 _form;
        

        public CannyParameters()
        {
            InitializeComponent();
        }

        public CannyParameters(Form1 fm)
        {
            InitializeComponent();
            _form = fm;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_form!= null)
            {
                _form.ApplyCanny((double)numericThreshhold.Value, (double)numericTreshholdlink.Value);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
