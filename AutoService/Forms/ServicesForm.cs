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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void ServicesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            DialogResult = DialogResult.Cancel;
        }
    }
}
