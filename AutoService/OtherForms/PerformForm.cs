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
    public partial class PerformForm : Form
    {
        private Applications _App;
        private string _Msg;
      
        public PerformForm() 
        {
            InitializeComponent();
           
        }

       public PerformForm(Applications app) : this()
        {
            _App = app;
        }

        private void PerformForm_Load(object sender, EventArgs e)
        {
            if (_App == null)
            {

                Text = "Добавление";
                _Msg = "Данные успешно добавлены!";
                _App = new Applications();
            }
            else
            {
                Text = "Изменение";
                _Msg = "Заявка выполнена!";

            }
           
        }

        private void btnDateReady_Click(object sender, EventArgs e)
        {
           
            _App.DateVisit = dtpDateReady.Value;

            try
            {
                using (var db = new MyDataModelDataContext())
                {

                    if (_App.Id == 0)
                    {
                        db.Applications.InsertOnSubmit(_App);

                    }
                    else
                    {
                        var app = db.Applications.FirstOrDefault(w => w.Id == _App.Id);
                            app.DateReady = dtpDateReady.Value;
                            app.Done = 1;

                    }
                    db.SubmitChanges();
                   
                }
                MessageBox.Show(_Msg, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.OK;
           /* MainForm update = this.Owner as MainForm;
            update.LoadDataBase();*/
            Close();
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
