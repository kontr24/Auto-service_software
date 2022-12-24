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
    public partial class ApplicationsUserControl : UserControl
    {
        private Applications _App;
        private Clients _Cln;
        private string _Msg;
        public ApplicationsUserControl()
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
                    bsApplicationsViewTest.DataSource = db.ApplicationView.OrderBy(x => x.Client);

             
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplicationsUserControl_Load(object sender, EventArgs e)
        {
            LoadDataBase();
        }


        private void bsApplicationsViewTest_CurrentChanged(object sender, EventArgs e)
        {
            if (bsApplicationsViewTest.Count == 0) return;

            var appView = bsApplicationsViewTest.Current as ApplicationView;

            using (var db = new MyDataModelDataContext())
            {
                _App = db.Applications.FirstOrDefault(x => x.Id == appView.Id);

            }
        }

        private void tsbDeleteApplications_Click(object sender, EventArgs e)
        {
            if (_App == null) return;
            var msgResult = MessageBox.Show("Вы действительно хотите удалить заявку?", "Удаление заявки", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            try
            {
                if (msgResult == DialogResult.OK)
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var app = db.Applications.FirstOrDefault(x => x.Id == _App.Id);
                        db.Applications.DeleteOnSubmit(app);
                        db.SubmitChanges();
                        bsApplicationsViewTest.DataSource = db.ApplicationView.OrderBy(x => x.Client);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbPerformApplications_Click(object sender, EventArgs e)
        {
            if (_App == null) return;

            if (_App.Done == 1)
            {
                MessageBox.Show("Заявка уже выполнена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PerformForm form = new PerformForm(_App);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    bsApplicationsViewTest.DataSource = db.ApplicationView.OrderBy(x => x.Client);

                }
            }
        }

        private void tsbUpdateApplications_Click(object sender, EventArgs e)
        {
            if (_App == null) return;
            SettingsUpdateApplicationServiceForm form = new SettingsUpdateApplicationServiceForm(_App);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    bsApplicationsViewTest.DataSource = db.ApplicationView.OrderBy(x => x.Client);

                }
            }
        }

        private void btnSortApplications_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSortApplications.Text) | string.IsNullOrEmpty(cbSortModeApplications.Text))
            {
                MessageBox.Show("Выберите категорию для сортировки", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (cbSortApplications.SelectedIndex == 0 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.Price);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 0 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.Price);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 1 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.Client);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 1 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.Client);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 2 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.Car);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 2 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.Car);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 3 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.Birthday);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 3 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.Birthday);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 4 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.Master);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 4 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.Master);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 5 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.DateVisit);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 5 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.DateVisit);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 6 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.DateReady);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 6 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.DateReady);
                    bsApplicationsViewTest.DataSource = t;
                }
            }


            if (cbSortApplications.SelectedIndex == 7 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.ServiceName);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 7 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.ServiceName);
                    bsApplicationsViewTest.DataSource = t;
                }
            }
            if (cbSortApplications.SelectedIndex == 8 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderByDescending(applications => applications.Done);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 8 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.OrderBy(applications => applications.Done);
                    bsApplicationsViewTest.DataSource = t;
                }
            }
        }

        private void btnSearchApplications_Click(object sender, EventArgs e)
        {

            if (cbSearchApplications.SelectedIndex == 0 ||
                cbSearchApplications.SelectedIndex == 1 ||
                cbSearchApplications.SelectedIndex == 3 ||
                cbSearchApplications.SelectedIndex == 6 ||
                cbSearchApplications.SelectedIndex == 7 ||
                cbSearchApplications.SelectedIndex == 8 |
                string.IsNullOrEmpty(cbSearchApplications.Text))
            {
                if (string.IsNullOrEmpty(tbSearchApplications.Text) | string.IsNullOrEmpty(cbSearchApplications.Text))
                {
                    MessageBox.Show("Введите данные в поле поиска или выберите категорию", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (cbSearchApplications.SelectedIndex == 0)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Client == tbSearchApplications.Text);
                    bsApplicationsViewTest.DataSource = search;
                }
            }

            if (cbSearchApplications.SelectedIndex == 1)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Car == tbSearchApplications.Text);
                    bsApplicationsViewTest.DataSource = search;
                }
            }

            if (cbSearchApplications.SelectedIndex == 2)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Birthday == dtpSearchApplications.Value);
                    bsApplicationsViewTest.DataSource = search;
                }
            }

            if (cbSearchApplications.SelectedIndex == 3)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Master == tbSearchApplications.Text);
                    bsApplicationsViewTest.DataSource = search;
                }
            }
            if (cbSearchApplications.SelectedIndex == 4)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.DateVisit == dtpSearchApplications.Value);
                    bsApplicationsViewTest.DataSource = search;
                }
            }
            if (cbSearchApplications.SelectedIndex == 5)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.DateReady == dtpSearchApplications.Value);
                    bsApplicationsViewTest.DataSource = search;
                }
            }
            if (cbSearchApplications.SelectedIndex == 6)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.ServiceName == tbSearchApplications.Text);
                    bsApplicationsViewTest.DataSource = search;
                }
            }
            if (cbSearchApplications.SelectedIndex == 7)
            {
                try
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var search = db.ApplicationView.Where(x => x.Price == Convert.ToInt32(tbSearchApplications.Text));
                        bsApplicationsViewTest.DataSource = search;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Цена введена неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (cbSearchApplications.SelectedIndex == 8)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Done == tbSearchApplications.Text);
                    bsApplicationsViewTest.DataSource = search;
                }
            }
        }

        private void tsbFunction_Click(object sender, EventArgs e)
        {
            pFilters.Visible = !pFilters.Visible;
        }

        private void tsbInsertApplications_Click(object sender, EventArgs e)
        {
            SettingsUpdateApplicationServiceForm form = new SettingsUpdateApplicationServiceForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    bsApplicationsViewTest.DataSource = db.ApplicationView.OrderBy(x => x.Client);

                }
            }
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void tsbReport_Click(object sender, EventArgs e)
        { 
            report.Load(@"Reports\ServiceReportAll.frx");
            report.Show();
        }

        private void tbClientPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 43 && number != 40 && number != 41 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
