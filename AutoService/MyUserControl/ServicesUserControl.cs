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
    public partial class ServicesUserControl : UserControl
    {
        private Services _SC;
        public ServicesUserControl()
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
                    bsServicesView.DataSource = db.ServicesView.OrderBy(x => x.Name);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ServicesUserControl_Load(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void bsServicesView_CurrentChanged(object sender, EventArgs e)
        {
            if (bsServicesView.Count == 0) return;

            var scView = bsServicesView.Current as ServicesView;


            using (var db = new MyDataModelDataContext())
            {
                _SC = db.Services.FirstOrDefault(x => x.Id == scView.Id);

            }
        }


        private void tsbInsertServices_Click(object sender, EventArgs e)
        {
            SettingsServicesForm form = new SettingsServicesForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                LoadDataBase();
            }
        }

        private void tsbEditServices_Click(object sender, EventArgs e)
        {

            if (_SC == null) return;
            SettingsServicesForm form = new SettingsServicesForm(_SC);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    LoadDataBase();

                }
            }
        }

        private void tsbDeleteServices_Click(object sender, EventArgs e)
        {
            if (_SC == null) return;
            var msgResult = MessageBox.Show("Вы действительно хотите удалить услугу?", "Удаление услуги", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            try
            {
                if (msgResult == DialogResult.OK)
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var sc = db.Services.FirstOrDefault(x => x.Id == _SC.Id);
                        db.Services.DeleteOnSubmit(sc);
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

        private void btnSortServices_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSortServices.Text) | string.IsNullOrEmpty(cbSortModeServices.Text))
            {
                MessageBox.Show("Выберите категорию для сортировки", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbSortServices.SelectedIndex == 0 && cbSortModeServices.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ServicesView.OrderByDescending(services => services.Name);
                    bsServicesView.DataSource = t;
                }

            }
            if (cbSortServices.SelectedIndex == 0 && cbSortModeServices.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ServicesView.OrderBy(services => services.Name);
                    bsServicesView.DataSource = t;
                }
            }


            if (cbSortServices.SelectedIndex == 1 && cbSortModeServices.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ServicesView.OrderByDescending(services => services.Price);
                    bsServicesView.DataSource = t;
                }

            }
            if (cbSortServices.SelectedIndex == 1 && cbSortModeServices.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ServicesView.OrderBy(services => services.Price);
                    bsServicesView.DataSource = t;
                }
            }
        }

        private void tsbSearchServices_Click(object sender, EventArgs e)
        {
            pFunction.Visible = !pFunction.Visible;

        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* DataGridViewRow dg = dgvServices.SelectedRows[0];
             tbSearchServices.Text = dg.Cells[0].Value.ToString();*/
            tbDetails.Text = _SC.Details;

        }

        private void tsbUpdateServices_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void btnSearchServices_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchServices.Text) | string.IsNullOrEmpty(cbSearchService.Text))
            {
                MessageBox.Show("Введите данные в поле поиска или выберите категорию", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbSearchService.SelectedIndex == 0)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ServicesView.Where(x => x.Name == tbSearchServices.Text);
                    bsServicesView.DataSource = search;
                }
            }
            if (cbSearchService.SelectedIndex == 1)
            {
                try
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var search = db.ServicesView.Where(x => x.Price == Convert.ToInt32(tbSearchServices.Text));
                        bsServicesView.DataSource = search;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Цена введена неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

 
    }
}
