using AutoService.Models;
using AutoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.MyUserControl
{
    public partial class ModelAutoControl : UserControl
    {
        private ModelCars _MC;
        public ModelAutoControl()
        {
            InitializeComponent();
            LoadDataBase();
        }

        public void LoadDataBase()
        {
            try
            {
                using (MyDataModelDataContext db = new MyDataModelDataContext())
                {
                    bsModelCarView.DataSource = db.ModelCarView;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ModelAutoControl_Load(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void bsModelCarView_CurrentChanged(object sender, EventArgs e)
        {
            if (bsModelCarView.Count == 0) return;

            var mcView = bsModelCarView.Current as ModelCarView;


            using (var db = new MyDataModelDataContext())
            {
                _MC = db.ModelCars.FirstOrDefault(x => x.Id == mcView.Id);

            }
        }

        private void tsbInsertModelAuto_Click(object sender, EventArgs e)
        {
            SettingsModelAutoForm form = new SettingsModelAutoForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                LoadDataBase();
            }
        }

        private void tsbEditModelAuto_Click(object sender, EventArgs e)
        {
            if (_MC == null) return;
            SettingsModelAutoForm form = new SettingsModelAutoForm(_MC);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    LoadDataBase();

                }
            }
        }

        private void tsbDeleteModelAuto_Click(object sender, EventArgs e)
        {
            if (_MC == null) return;
            var msgResult = MessageBox.Show("Вы действительно хотите удалить марку авто?", "Удаление марки авто", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            try
            {
                if (msgResult == DialogResult.OK)
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var mc = db.ModelCars.FirstOrDefault(x => x.Id == _MC.Id);
                        db.ModelCars.DeleteOnSubmit(mc);
                        db.SubmitChanges();
                        LoadDataBase();

                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Для начала необходимо удалить все зависимые записи в других таблицах!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbSearchModelAuto_Click(object sender, EventArgs e)
        {
            pFunction.Visible = !pFunction.Visible;
        }

        private void btnSortModelAuto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSortModelAuto.Text) | string.IsNullOrEmpty(cbSortModeModelAuto.Text))
            {
                MessageBox.Show("Выберите категорию для сортировки", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbSortModelAuto.SelectedIndex == 0 && cbSortModeModelAuto.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ModelCarView.OrderByDescending(auto => auto.Name);
                    bsModelCarView.DataSource = t;
                }

            }
            if (cbSortModelAuto.SelectedIndex == 0 && cbSortModeModelAuto.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ModelCarView.OrderBy(auto => auto.Name);
                    bsModelCarView.DataSource = t;
                }
            }
        }

        private void tsbUpdateModelAuto_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void btnSearchModelAuto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchModelAuto.Text))
            {
                MessageBox.Show("Введите данные в поле поиска", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var db = new MyDataModelDataContext())
            {
                var search = db.ModelCarView.Where(x => x.Name == tbSearchModelAuto.Text);
                bsModelCarView.DataSource = search;
            }
        }
    }
}

