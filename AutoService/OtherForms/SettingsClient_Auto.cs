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
    public partial class SettingsClient_Auto : Form
    {
        private Clients _Cln;

        private string _Msg;

        public SettingsClient_Auto()
        {
            InitializeComponent();
        }
        public SettingsClient_Auto(Clients cln) : this()
        {
            _Cln = cln;
 
        }

        private void SettingsClient_Auto_Load(object sender, EventArgs e)
        {
            try
            {
                using (MyDataModelDataContext db = new MyDataModelDataContext())
                {
                    cbClientModelCar.DataSource = db.ModelCarView;

                }
                if (_Cln == null)
                {
                    Text = "Добавление";
                    _Msg = "Данные успешно добавлены!";
                    _Cln = new Clients();

                }
                else
                {
                    Text = "Изменение";
                    _Msg = "Данные успешно обновлены!";

                    tbClientSurName.Text = _Cln.SurName;
                    tbClientName.Text = _Cln.Name;
                    tbClientPatronomic.Text = _Cln.Patronymic;
                    dtpClientBirthday.Value = _Cln.Birthday;
                    tbClientPhone.Text = _Cln.Phone;
                    cbClientModelCar.SelectedValue = _Cln.ModelCarID;
                    tbClientRegisterSignCar.Text = _Cln.AutoRegisterSign;
                }
            }
                  catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbClientSurName.Text))
            {
                MessageBox.Show("Введите 'Фамилию'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbClientName.Text))
            {
                MessageBox.Show("Введите 'Имя'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbClientPatronomic.Text))
            {
                MessageBox.Show("Введите 'Отчество'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbClientPhone.Text))
            {
                MessageBox.Show("Введите 'Телефон'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbClientRegisterSignCar.Text))
            {
                MessageBox.Show("Введите 'ГРЗ'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _Cln.SurName = tbClientSurName.Text;
            _Cln.Name = tbClientName.Text;
            _Cln.Patronymic = tbClientPatronomic.Text;
            _Cln.Birthday = dtpClientBirthday.Value;
            _Cln.Phone = tbClientPhone.Text;
            _Cln.ModelCarID = (int)cbClientModelCar.SelectedValue;
            _Cln.AutoRegisterSign = tbClientRegisterSignCar.Text;

            try
            {
                using (var db = new MyDataModelDataContext())
                {

                    if (_Cln.Id == 0)
                    {
                        db.Clients.InsertOnSubmit(_Cln);


                    }
                    else
                    {
                        var cln = db.Clients.FirstOrDefault(w => w.Id == _Cln.Id);
                        cln.SurName = tbClientSurName.Text;
                        cln.Name = tbClientName.Text;
                        cln.Patronymic = tbClientPatronomic.Text;
                        cln.Birthday = dtpClientBirthday.Value;
                        cln.Phone = tbClientPhone.Text;
                        cln.ModelCarID = (int)cbClientModelCar.SelectedValue;
                        cln.AutoRegisterSign = tbClientRegisterSignCar.Text;

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

        private void tbClientPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 43 && number != 40 && number != 41 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
