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
using AutoService.Models;

namespace AutoService.MyUserControl
{
    public partial class MastersUserControl : UserControl
    {
        private Masters _MS;
        public MastersUserControl()
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
                   bsMasterSeparatelyView.DataSource = db.MasterSeparatelyView;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MastersUserControl_Load(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void bsMasterSeparatelyView_CurrentChanged(object sender, EventArgs e)
        {
            if (bsMasterSeparatelyView.Count == 0) return;

            var msView = bsMasterSeparatelyView.Current as MasterSeparatelyView;


            using (var db = new MyDataModelDataContext())
            {
                _MS = db.Masters.FirstOrDefault(x => x.Id == msView.Id);

            }
        }

        private void tsbEditMasters_Click(object sender, EventArgs e)
        {
            if (_MS == null) return;
            SettingsMastersForm form = new SettingsMastersForm(_MS);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    LoadDataBase();

                }
            }
        }

        private void tsbInsertMasters_Click(object sender, EventArgs e)
        {
            SettingsMastersForm form = new SettingsMastersForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                LoadDataBase();
            }
        }

        private void tsbDeleteMasters_Click(object sender, EventArgs e)
        {
            if (_MS == null) return;
            var msgResult = MessageBox.Show("Вы действительно хотите удалить мастера?", "Удаление мастера", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            try
            {
                if (msgResult == DialogResult.OK)
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var mc = db.Masters.FirstOrDefault(x => x.Id == _MS.Id);
                        db.Masters.DeleteOnSubmit(mc);
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

        private void btnSortMasters_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSortModeMasters.Text) | string.IsNullOrEmpty(cbSortMasters.Text))
            {
                MessageBox.Show("Выберите категорию для сортировки", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbSortMasters.SelectedIndex == 0 && cbSortModeMasters.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderByDescending(masters => masters.Surname);
                    bsMasterSeparatelyView.DataSource = t;
                }

            }
            if (cbSortMasters.SelectedIndex == 0 && cbSortModeMasters.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderBy(masters => masters.Surname);
                    bsMasterSeparatelyView.DataSource = t;
                }
            }

            if (cbSortMasters.SelectedIndex == 1 && cbSortModeMasters.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderByDescending(masters => masters.Name);
                    bsMasterSeparatelyView.DataSource = t;
                }

            }
            if (cbSortMasters.SelectedIndex == 1 && cbSortModeMasters.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderBy(masters => masters.Name);
                    bsMasterSeparatelyView.DataSource = t;
                }
            }


            if (cbSortMasters.SelectedIndex == 2 && cbSortModeMasters.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderByDescending(masters => masters.Patronymic);
                    bsMasterSeparatelyView.DataSource = t;
                }

            }
            if (cbSortMasters.SelectedIndex == 2 && cbSortModeMasters.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderBy(masters => masters.Patronymic);
                    bsMasterSeparatelyView.DataSource = t;
                }
            }
            if (cbSortMasters.SelectedIndex == 3 && cbSortModeMasters.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderByDescending(masters => masters.Birthday);
                    bsMasterSeparatelyView.DataSource = t;
                }

            }
            if (cbSortMasters.SelectedIndex == 3 && cbSortModeMasters.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderBy(masters => masters.Birthday);
                    bsMasterSeparatelyView.DataSource = t;
                }
            }
            if (cbSortMasters.SelectedIndex == 4 && cbSortModeMasters.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderByDescending(masters => masters.Phone);
                    bsMasterSeparatelyView.DataSource = t;
                }

            }
            if (cbSortMasters.SelectedIndex == 4 && cbSortModeMasters.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.MasterSeparatelyView.OrderBy(masters => masters.Phone);
                    bsMasterSeparatelyView.DataSource = t;
                }
            }

        }

        private void tsbSearchMasters_Click(object sender, EventArgs e)
        {
            pFunction.Visible = !pFunction.Visible;
        }

        private void tsbUpdateMasters_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void btnSearchMasters_Click(object sender, EventArgs e)
        {
            if (cbSearchMasters.SelectedIndex == 0 ||
              cbSearchMasters.SelectedIndex == 1 ||
              cbSearchMasters.SelectedIndex == 2 ||
              cbSearchMasters.SelectedIndex == 4 |
              string.IsNullOrEmpty(cbSearchMasters.Text))
            {

                if (string.IsNullOrEmpty(tbSearchMasters.Text) | string.IsNullOrEmpty(cbSearchMasters.Text))
                {
                    MessageBox.Show("Введите данные в поле поиска или выберите категорию", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (cbSearchMasters.SelectedIndex == 0)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.MasterSeparatelyView.Where(x => x.Surname == tbSearchMasters.Text);
                    bsMasterSeparatelyView.DataSource = search;
                }
            }
            if (cbSearchMasters.SelectedIndex == 1)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.MasterSeparatelyView.Where(x => x.Name == tbSearchMasters.Text);
                    bsMasterSeparatelyView.DataSource = search;
                }
            }
            if (cbSearchMasters.SelectedIndex == 2)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.MasterSeparatelyView.Where(x => x.Patronymic == tbSearchMasters.Text);
                    bsMasterSeparatelyView.DataSource = search;
                }
            }
            if (cbSearchMasters.SelectedIndex == 3)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.MasterSeparatelyView.Where(x => x.Birthday == dtpSearchMasters.Value);
                    bsMasterSeparatelyView.DataSource = search;
                }
            }
            if (cbSearchMasters.SelectedIndex == 4)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.MasterSeparatelyView.Where(x => x.Phone == tbSearchMasters.Text);
                    bsMasterSeparatelyView.DataSource = search;
                }
            }

        }
    }
}
