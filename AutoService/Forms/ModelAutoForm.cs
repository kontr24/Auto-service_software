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
    public partial class ModelAutoForm : Form
    {
        public ModelAutoForm()
        {
            InitializeComponent();
        }


        private void ModelAutoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            DialogResult = DialogResult.Cancel;
        }
    }
}
