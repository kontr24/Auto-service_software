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
    public partial class ClientsUserControl : UserControl
    {
        private Clients _Cln;
        public ClientsUserControl()
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
                    bsClientView.DataSource = db.ClientView.OrderBy(x => x.SurName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientsUserControl_Load(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void bsClientView_CurrentChanged(object sender, EventArgs e)
        {
            if (bsClientView.Count == 0) return;

            var clnView = bsClientView.Current as ClientView;


            using (var db = new MyDataModelDataContext())
            {
                _Cln = db.Clients.FirstOrDefault(x => x.Id == clnView.Id);

            }
        }


        private void tsbSearchClient_Click(object sender, EventArgs e) //раскрыть панель поиска и сортировки
        {
            pFunction.Visible = !pFunction.Visible;

        }

        private void tsbDeleteClient_Click(object sender, EventArgs e) //удаление
        {
            if (_Cln == null) return;
            var msgResult = MessageBox.Show("Вы действительно хотите удалить клиента?", "Удаление клиента", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            try
            {
                if (msgResult == DialogResult.OK)
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var cln = db.Clients.FirstOrDefault(x => x.Id == _Cln.Id);
                        db.Clients.DeleteOnSubmit(cln);
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

        private void tsbEditClient_Click(object sender, EventArgs e)
        {
            if (_Cln == null) return;
            SettingsClient_Auto form = new SettingsClient_Auto(_Cln);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                LoadDataBase();
            }
        }

        private void tsbInsertClient_Click(object sender, EventArgs e)
        {
            SettingsClient_Auto form = new SettingsClient_Auto();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                LoadDataBase();
            }
        }

        private void btnSortClients_Click(object sender, EventArgs e)//сортировка
        {
            if (string.IsNullOrEmpty(cbSortModeClients.Text) | string.IsNullOrEmpty(cbSortClients.Text))
            {
                MessageBox.Show("Выберите категорию для сортировки", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbSortClients.SelectedIndex == 0 && cbSortModeClients.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderByDescending(clients => clients.SurName);
                    bsClientView.DataSource = t;
                }

            }
            if (cbSortClients.SelectedIndex == 0 && cbSortModeClients.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderBy(clients => clients.SurName);
                    bsClientView.DataSource = t;
                }
            }
            if (cbSortClients.SelectedIndex == 1 && cbSortModeClients.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderByDescending(clients => clients.Name);
                    bsClientView.DataSource = t;
                }

            }
            if (cbSortClients.SelectedIndex == 1 && cbSortModeClients.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderBy(clients => clients.Name);
                    bsClientView.DataSource = t;
                }
            }
            if (cbSortClients.SelectedIndex == 2 && cbSortModeClients.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderByDescending(clients => clients.Patronymic);
                    bsClientView.DataSource = t;
                }

            }

            if (cbSortClients.SelectedIndex == 2 && cbSortModeClients.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderBy(clients => clients.Patronymic);
                    bsClientView.DataSource = t;
                }
            }
            if (cbSortClients.SelectedIndex == 3 && cbSortModeClients.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderByDescending(clients => clients.Birthday);
                    bsClientView.DataSource = t;
                }

            }

            if (cbSortClients.SelectedIndex == 3 && cbSortModeClients.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderBy(clients => clients.Birthday);
                    bsClientView.DataSource = t;
                }
            }
            if (cbSortClients.SelectedIndex == 4 && cbSortModeClients.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderByDescending(clients => clients.Phone);
                    bsClientView.DataSource = t;
                }

            }

            if (cbSortClients.SelectedIndex == 4 && cbSortModeClients.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderBy(clients => clients.Phone);
                    bsClientView.DataSource = t;
                }
            }
            if (cbSortClients.SelectedIndex == 5 && cbSortModeClients.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderByDescending(clients => clients.ModelAuto);
                    bsClientView.DataSource = t;
                }

            }

            if (cbSortClients.SelectedIndex == 5 && cbSortModeClients.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderBy(clients => clients.ModelAuto);
                    bsClientView.DataSource = t;
                }
            }
            if (cbSortClients.SelectedIndex == 6 && cbSortModeClients.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderByDescending(clients => clients.AutoRegisterSign);
                    bsClientView.DataSource = t;
                }

            }
            if (cbSortClients.SelectedIndex == 6 && cbSortModeClients.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.ClientView.OrderBy(clients => clients.AutoRegisterSign);
                    bsClientView.DataSource = t;
                }
            }
        }

        private void tsbUpdateClients_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {

            if (cbSearchClients.SelectedIndex == 0 ||
                cbSearchClients.SelectedIndex == 1 ||
                cbSearchClients.SelectedIndex == 2 ||
                cbSearchClients.SelectedIndex == 4 ||
                cbSearchClients.SelectedIndex == 5 ||
                cbSearchClients.SelectedIndex == 6 |
                string.IsNullOrEmpty(cbSearchClients.Text))
            {
                if (string.IsNullOrEmpty(tbSearchClient.Text) | string.IsNullOrEmpty(cbSearchClients.Text))
                {
                    MessageBox.Show("Введите данные в поле поиска или выберите категорию", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (cbSearchClients.SelectedIndex == 0)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ClientView.Where(x => x.SurName == tbSearchClient.Text);
                    bsClientView.DataSource = search;
                }
            }
            if (cbSearchClients.SelectedIndex == 1)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ClientView.Where(x => x.Name == tbSearchClient.Text);
                    bsClientView.DataSource = search;
                }
            }
            if (cbSearchClients.SelectedIndex == 2)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ClientView.Where(x => x.Patronymic == tbSearchClient.Text);
                    bsClientView.DataSource = search;
                }
            }
            if (cbSearchClients.SelectedIndex == 3)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ClientView.Where(x => x.Birthday == dtpSearchClients.Value);
                    bsClientView.DataSource = search;
                }
            }
            if (cbSearchClients.SelectedIndex == 4)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ClientView.Where(x => x.Phone == tbSearchClient.Text);
                    bsClientView.DataSource = search;
                }
            }
            if (cbSearchClients.SelectedIndex == 5)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ClientView.Where(x => x.ModelAuto == tbSearchClient.Text);
                    bsClientView.DataSource = search;
                }
            }
            if (cbSearchClients.SelectedIndex == 6)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.ClientView.Where(x => x.AutoRegisterSign == tbSearchClient.Text);
                    bsClientView.DataSource = search;
                }
            }
        }
    }
}
