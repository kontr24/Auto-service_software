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
    public partial class SettingsMastersForm : Form
    {
        private Masters _MS;
        private string _Msg;
        public SettingsMastersForm()
        {
            InitializeComponent();
        }
        public SettingsMastersForm(Masters ms) : this()
        {
            _MS = ms;

        }
        private void SettingsMastersForm_Load(object sender, EventArgs e)
        {
            try
            {

                if (_MS == null)
                {
                    Text = "Добавление";
                    _Msg = "Данные успешно добавлены!";
                    _MS = new Masters();

                }
                else
                {
                    Text = "Изменение";
                    _Msg = "Данные успешно обновлены!";
                    tbMasterSurName.Text = _MS.Surname;
                    tbMasterName.Text = _MS.Name;
                    tbMasterPatronomic.Text = _MS.Patronymic;
                    dtpMasterBirthday.Value = _MS.Birthday;
                    tbMasterPhone.Text = _MS.Phone;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertClientOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMasterSurName.Text))
            {
                MessageBox.Show("Введите 'Фамилию'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbMasterName.Text))
            {
                MessageBox.Show("Введите 'Имя'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbMasterPatronomic.Text))
            {
                MessageBox.Show("Введите 'Отчество'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbMasterPhone.Text))
            {
                MessageBox.Show("Введите 'Телефон'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _MS.Surname = tbMasterSurName.Text;
            _MS.Name = tbMasterName.Text;
            _MS.Patronymic = tbMasterPatronomic.Text;
            _MS.Birthday = dtpMasterBirthday.Value;
            _MS.Phone = tbMasterPhone.Text;


            try
            {
                using (var db = new MyDataModelDataContext())
                {

                    if (_MS.Id == 0)
                    {
                        db.Masters.InsertOnSubmit(_MS);


                    }
                    else
                    {
                        var ms = db.Masters.FirstOrDefault(w => w.Id == _MS.Id);
                     
                        ms.Surname = tbMasterSurName.Text;
                        ms.Name = tbMasterName.Text;
                        ms.Patronymic = tbMasterPatronomic.Text;
                        ms.Birthday = dtpMasterBirthday.Value;
                        ms.Phone = tbMasterPhone.Text;

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

        private void tbMasterPhone_KeyPress(object sender, KeyPressEventArgs e)
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

