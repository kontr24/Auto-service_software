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
    public partial class SettingsModelAutoForm : Form
    {
        private ModelCars _MC;
        private string _Msg;
        public SettingsModelAutoForm()
        {
            InitializeComponent();
        }

        public SettingsModelAutoForm(ModelCars mc) : this()
        {
            _MC = mc;

        }

        private void SettingsModelAutoForm_Load(object sender, EventArgs e)
        {
            try
            {

                if (_MC == null)
                {
                    Text = "Добавление";
                    _Msg = "Данные успешно добавлены!";
                    _MC = new ModelCars();

                }
                else
                {
                    Text = "Изменение";
                    _Msg = "Данные успешно обновлены!";
                    tbModelAuto.Text = _MC.Name;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnInsertClientOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbModelAuto.Text))
            {
                MessageBox.Show("Введите 'Марку авто'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _MC.Name = tbModelAuto.Text;

            try
            {
                using (var db = new MyDataModelDataContext())
                {

                    if (_MC.Id == 0)
                    {
                        db.ModelCars.InsertOnSubmit(_MC);


                    }
                    else
                    {
                        var mc = db.ModelCars.FirstOrDefault(w => w.Id == _MC.Id);
                        mc.Name = tbModelAuto.Text;

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
