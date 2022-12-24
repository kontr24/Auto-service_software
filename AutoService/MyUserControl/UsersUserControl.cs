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
    public partial class UsersUserControl : UserControl
    {
        private Users _Us;
        private string _Msg;

        public UsersUserControl()
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
                    bsUsersView.DataSource = db.UserView.OrderBy(x => x.Login);
                    cbMode.DataSource = db.Status;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersUserControl_Load(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void bsUsersView_CurrentChanged(object sender, EventArgs e)
        {
            if (bsUsersView.Count == 0) return;

            var usView = bsUsersView.Current as UserView;

            using (var db = new MyDataModelDataContext())
            {
                _Us = db.Users.FirstOrDefault(x => x.Id == usView.Id);

            }
        }


        private void tsbInsertUsers_Click(object sender, EventArgs e)
        {
            pNewUsers.Visible = !pNewUsers.Visible;
            if (pFunction.Visible)
            {
                pNewUsers.Visible = false;
            }
        }

        private void tsbSearchModelAuto_Click(object sender, EventArgs e)
        {
           
            pFunction.Visible = !pFunction.Visible;
            if (pFunction.Visible)
            {
                pNewUsers.Visible = false;
            }
        }

        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            _Msg = "Данные успешно добавлены!";
            if (string.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Введите 'Логин'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Введите 'Пароль'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var db = new MyDataModelDataContext())
                {
                    _Us = new Users();
                    _Us.Login = tbLogin.Text;
                    _Us.Password = tbPassword.Text;
                    _Us.StatusID = (int)cbMode.SelectedValue;
                    db.Users.InsertOnSubmit(_Us);
                    db.SubmitChanges();
                    LoadDataBase();
                }
                MessageBox.Show(_Msg, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pNewUsers.Visible = !pNewUsers.Visible;
                tbLogin.Clear();
                tbPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbDeleteUsers_Click(object sender, EventArgs e)
        {
            if (_Us == null) return;
            var msgResult = MessageBox.Show("Вы действительно хотите удалить пользователя?", "Удаление пользователя", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            try
            {
                if (msgResult == DialogResult.OK)
                {
                    using (var db = new MyDataModelDataContext())
                    {
                        var us = db.Users.FirstOrDefault(x => x.Id == _Us.Id);
                        db.Users.DeleteOnSubmit(us);
                        db.SubmitChanges();
                        LoadDataBase();

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSortUsers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSortModeUsers.Text) | string.IsNullOrEmpty(cbSearchUsers.Text))
            {
                MessageBox.Show("Выберите категорию для сортировки", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbSortUsers.SelectedIndex == 0 && cbSortModeUsers.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.UserView.OrderByDescending(user => user.Login);
                    bsUsersView.DataSource = t;
                }

            }
            if (cbSortUsers.SelectedIndex == 0 && cbSortModeUsers.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.UserView.OrderBy(user => user.Login);
                    bsUsersView.DataSource = t;
                }
            }
            if (cbSortUsers.SelectedIndex == 1 && cbSortModeUsers.SelectedIndex == 0)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.UserView.OrderByDescending(user => user.Users);
                    bsUsersView.DataSource = t;
                }

            }
            if (cbSortUsers.SelectedIndex == 1 && cbSortModeUsers.SelectedIndex == 1)
            {

                using (var db = new MyDataModelDataContext())
                {
                    var t = db.UserView.OrderBy(user => user.Users);
                    bsUsersView.DataSource = t;
                }
            }
        }

        private void tsbUpdateUsers_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchUsers.Text) | string.IsNullOrEmpty(cbSearchUsers.Text))
            {
                MessageBox.Show("Введите данные в поле поиска или выберите категорию", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbSearchUsers.SelectedIndex == 0)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.UserView.Where(x => x.Login == tbSearchUsers.Text);
                    bsUsersView.DataSource = search;
                }
            }
            if (cbSearchUsers.SelectedIndex == 1)
            {
                using (var db = new MyDataModelDataContext())
                {
                    var search = db.UserView.Where(x => x.Users == tbSearchUsers.Text);
                    bsUsersView.DataSource = search;
                }
            }

        }
    }
}
