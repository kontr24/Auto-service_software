using AutoService.Models;
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
    public partial class SettingsServicesForm : Form
    {
        private Services _SC;
        private string _Msg;
        public SettingsServicesForm()
        {
            InitializeComponent();
        }

        public SettingsServicesForm(Services sc) : this()
        {
            _SC = sc;
        }

        private void SettingsServicesForm_Load(object sender, EventArgs e)
        {
            try
            {

                if (_SC == null)
                {
                    Text = "Добавление";
                    _Msg = "Данные успешно добавлены!";
                    _SC = new Services();

                }
                else
                {
                    Text = "Изменение";
                    _Msg = "Данные успешно обновлены!";
                    tbNameService.Text = _SC.Name;
                    tbDetailsService.Text = _SC.Details;
                    tbPriceServices.Text = _SC.Price.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInsertClientOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameService.Text))
            {
                MessageBox.Show("Введите 'Услугу'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbDetailsService.Text))
            {
                MessageBox.Show("Введите 'Описание'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbPriceServices.Text))
            {
                MessageBox.Show("Введите 'Цену'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _SC.Name = tbNameService.Text;
            _SC.Details = tbDetailsService.Text;
            _SC.Price = Convert.ToInt32(tbPriceServices.Text);

            try
            {
                using (var db = new MyDataModelDataContext())
                {

                    if (_SC.Id == 0)
                    {
                        db.Services.InsertOnSubmit(_SC);


                    }
                    else
                    {
                        var sc = db.Services.FirstOrDefault(w => w.Id == _SC.Id);
                        sc.Name = tbNameService.Text;
                        sc.Details = tbDetailsService.Text;
                        sc.Price = Convert.ToInt32(tbPriceServices.Text);


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

        private void tbPriceServices_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
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

