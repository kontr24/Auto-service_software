using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AutoService.Models;
using System.Threading;
using AutoService.Class;


namespace AutoService.MyUserControl
{
    public partial class MainUserControl : UserControl
    {
        Thread th;
        private Applications _App;
        private Clients _Cln;
        private string _Msg;
        public MainUserControl()
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
                    bsApplicationsViewTest.DataSource = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(x => x.Client);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MainUserControl_Load(object sender, EventArgs e)
        {
            if (GeneralClass.mode == (int)GeneralClass.Status.User)
            {
                /*tsmiUsers.Enabled = false;
                tsmiClients.Enabled = false;
                tsmiMasters.Enabled = false;
                tsmiModelAuto.Enabled = false;
                tsmiService.Enabled = false;
                */
                //tsmiAdmin.Enabled = false;
                tsmiAdmin.Visible = false;
            }
           tslUser.Text = GeneralClass.nickname;

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


      

       

        private void btnDelete_Click(object sender, EventArgs e)
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
                        bsApplicationsViewTest.DataSource = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(x => x.Client);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (_App == null) return;
            PerformForm form = new PerformForm(_App);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    bsApplicationsViewTest.DataSource = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(x => x.Client);

                }
            }

        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, "Help.chm");
            /*string commandText = @"Help\Help.chm";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();*/
            //Help.ShowHelp(this, @"Help\Help.chm");
            /*MessageBox.Show("Вы находитесь в окне просмотра/редактирования заявок." +
              " При добавлении нового клиента необходимо заполнить данные о владельце авто и выбрать мастера для ремонта." +
              " При добавлении существующего клиента, необходимо ввести данные существующего в БД человека и выбрать мастера для ремонта", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }

        private void tsmiClients_Click(object sender, EventArgs e)
        {

            ClientsForm1 form = new ClientsForm1();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {

                LoadDataBase();
            }
        }


        private void tsmiModelAuto_Click(object sender, EventArgs e)
        {
            ModelAutoForm form = new ModelAutoForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {

                LoadDataBase();
            }
        }

        private void tsmiMasters_Click(object sender, EventArgs e)
        {
            MastersForm form = new MastersForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {

                LoadDataBase();
            }
        }

        private void tsmiService_Click(object sender, EventArgs e)
        {
            ServicesForm form = new ServicesForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {

                LoadDataBase();
            }
        }

        private void tsmiApplication_Click(object sender, EventArgs e)
        {
            ApplicationsForm form = new ApplicationsForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.Cancel)
            {

                LoadDataBase();
            }
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {

                LoadDataBase();
            }
        }

        private void btnUpdateApplication_Click(object sender, EventArgs e)
        {

            if (_App == null) return;
            SettingsUpdateApplicationServiceForm form = new SettingsUpdateApplicationServiceForm(_App);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    bsApplicationsViewTest.DataSource = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(x => x.Client);

                }
            }
        }


        private void btnSearchApp_Click(object sender, EventArgs e)
        {
            pFilters.Visible = !pFilters.Visible;

        }


        private void tsbFunction_Click(object sender, EventArgs e)
        {
            pFilters.Visible = !pFilters.Visible;
        }



        private void btnSortApplications_Click(object sender, EventArgs e) //Сортировка
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
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderByDescending(applications => applications.Price);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 0 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(applications => applications.Price);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 1 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderByDescending(applications => applications.Client);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 1 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(applications => applications.Client);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 2 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderByDescending(applications => applications.Car);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 2 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(applications => applications.Car);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 3 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderByDescending(applications => applications.Birthday);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 3 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(applications => applications.Birthday);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 4 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderByDescending(applications => applications.Master);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 4 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(applications => applications.Master);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 5 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderByDescending(applications => applications.DateVisit);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 5 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(applications => applications.DateVisit);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

            if (cbSortApplications.SelectedIndex == 6 && cbSortModeApplications.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderByDescending(applications => applications.ServiceName);
                    bsApplicationsViewTest.DataSource = t;
                }

            }
            if (cbSortApplications.SelectedIndex == 6 && cbSortModeApplications.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(applications => applications.ServiceName);
                    bsApplicationsViewTest.DataSource = t;
                }
            }

        }



        private void tsmiUserClose_Click(object sender, EventArgs e)
        {

            Form form = this.FindForm();
            form.Close();
            form.Dispose();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Authorization());
        }

        private void tbClientPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 43 && number != 40 && number != 41 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            form.Close();
            form.Dispose();
        }





        private void btnSearchApplications_Click(object sender, EventArgs e)
        {

            if (cbSearchApplications.SelectedIndex == 0 ||
                cbSearchApplications.SelectedIndex == 1 ||
                cbSearchApplications.SelectedIndex == 3 ||
                cbSearchApplications.SelectedIndex == 5 ||
                cbSearchApplications.SelectedIndex == 6 ||
                cbSearchApplications.SelectedIndex == 7 |
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
                    var search = db.ApplicationView.Where(x => x.Client == tbSearchApplications.Text & x.Done == "В процессе");
                    bsApplicationsViewTest.DataSource = search;
                }
            }

            if (cbSearchApplications.SelectedIndex == 1)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Car == tbSearchApplications.Text & x.Done == "В процессе");
                    bsApplicationsViewTest.DataSource = search;
                }
            }

            if (cbSearchApplications.SelectedIndex == 2)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Birthday == dtpSearchApplications.Value & x.Done == "В процессе");
                    bsApplicationsViewTest.DataSource = search;
                }
            }

            if (cbSearchApplications.SelectedIndex == 3)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Master == tbSearchApplications.Text & x.Done == "В процессе");
                    bsApplicationsViewTest.DataSource = search;
                }
            }
            if (cbSearchApplications.SelectedIndex == 4)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.DateVisit == dtpSearchApplications.Value & x.Done == "В процессе");
                    bsApplicationsViewTest.DataSource = search;
                }
            }

            if (cbSearchApplications.SelectedIndex == 5)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.ServiceName == tbSearchApplications.Text & x.Done == "В процессе");
                    bsApplicationsViewTest.DataSource = search;
                }
            }
            if (cbSearchApplications.SelectedIndex == 6)
            {
                try
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var search = db.ApplicationView.Where(x => x.Price == Convert.ToInt32(tbSearchApplications.Text) & x.Done == "В процессе");
                        bsApplicationsViewTest.DataSource = search;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Цена введена неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (cbSearchApplications.SelectedIndex == 7)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ApplicationView.Where(x => x.Done == tbSearchApplications.Text & x.Done == "В процессе");
                    bsApplicationsViewTest.DataSource = search;
                }
            }

        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            report.Load(@"Reports\ServiceReport.frx"); 
            report.Show();
        }

        private void tsbPerformApplications_Click(object sender, EventArgs e)
        {
            if (_App == null) return;
            PerformForm form = new PerformForm(_App);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    bsApplicationsViewTest.DataSource = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(x => x.Client);

                }
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
                        bsApplicationsViewTest.DataSource = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(x => x.Client);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    bsApplicationsViewTest.DataSource = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(x => x.Client);

                }
            }
        }

        private void tsbInsertApplications_Click(object sender, EventArgs e)
        {
            SettingsUpdateApplicationServiceForm form = new SettingsUpdateApplicationServiceForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new MyDataModelDataContext())
                {
                    bsApplicationsViewTest.DataSource = db.ApplicationView.Where(x => x.Done == "В процессе").OrderBy(x => x.Client);

                }
            }
        }
    }
}
