using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoService.Models;

namespace AutoService
{
    public partial class SettingsUpdateApplicationServiceForm : Form
    {
        private Applications _App;

        private string _Msg;

        public SettingsUpdateApplicationServiceForm()
        {
            InitializeComponent();
        }


        public SettingsUpdateApplicationServiceForm(Applications app) : this()
        {
            _App = app;
        }

        private void SettingsUpdateApplicationServiceForm_Load(object sender, EventArgs e)
        {
            if (_App == null)
            {
                Text = "Добавление";
                _Msg = "Данные успешно добавлены!";
                _App = new Applications();
                using (var db = new MyDataModelDataContext())
                {
                    cbMasters.DataSource = db.MasterView;
                    cbServices.DataSource = db.ServicesView;
                    cbClientSurName.DataSource = db.ClientJoinView;
                    cbMasters.SelectedValue = _App.MasterID;
                    cbServices.SelectedValue = _App.ServiceID;
                    cbClientSurName.SelectedValue = _App.ClientID;
                }
            }
            else
            {
                Text = "Редактировние";
                _Msg = "Данные успешно обновлены!";

                using (var db = new MyDataModelDataContext())
                {
                    cbMasters.DataSource = db.MasterView;
                    cbServices.DataSource = db.ServicesView;
                    cbClientSurName.DataSource = db.ClientJoinView;
                    cbMasters.SelectedValue = _App.MasterID;
                    cbServices.SelectedValue = _App.ServiceID;
                    cbClientSurName.SelectedValue = _App.ClientID;
                }

            }
        }

        private void btnUpdeteServiceOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbClientSurName.Text))
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cbMasters.Text))
            {
                MessageBox.Show("Выберите мастера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cbServices.Text))
            {
                MessageBox.Show("Выберите услугу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _App.ClientID = (int)cbClientSurName.SelectedValue;
            _App.MasterID = (int)cbMasters.SelectedValue;
            _App.ServiceID = (int)cbServices.SelectedValue;
            _App.DateVisit = dtpDataVisit.Value;
            _App.Done = 2;

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
                        app.MasterID = (int)cbMasters.SelectedValue;
                        app.ServiceID = (int)cbServices.SelectedValue;
                        app.ClientID = (int)cbClientSurName.SelectedValue;
                        app.DateVisit = dtpDataVisit.Value;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

