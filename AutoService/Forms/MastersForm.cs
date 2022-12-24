using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class MastersForm : Form
    {
        public MastersForm()
        {
            InitializeComponent();
        }


        private void MastersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            DialogResult = DialogResult.Cancel;
        }
    }
}
