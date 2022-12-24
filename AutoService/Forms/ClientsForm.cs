using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AutoService.Models;


namespace AutoService
{
    public partial class ClientsForm1 : Form
    {
   
        public ClientsForm1()
        {
            InitializeComponent();
        }

        private void ClientsForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            DialogResult = DialogResult.Cancel;
        }


    }
}
