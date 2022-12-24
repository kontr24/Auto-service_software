using AutoService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AutoService.Class;

namespace AutoService
{
    public partial class Authorization : Form
    {
        Thread th;
        public Authorization()
        {
            InitializeComponent();
            this.tbPassword.AutoSize = false;
            this.tbPassword.Size = new Size(this.tbPassword.Size.Width, 56);
        }


        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Введите 'Логин'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Введите 'Пароль'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (tbLogin.Text.Trim() != "" && tbPassword.Text.Trim() != "")
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    string pass = tbPassword.Text.Trim();
                    byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
                    string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                    MyDataModelDataContext db = new MyDataModelDataContext();
                    GeneralClass.mode = db.Users.Where(x => x.Login == tbLogin.Text.Trim() && x.Password == tbPassword.Text.Trim()).Select(t => t.StatusID).FirstOrDefault();

                    if (GeneralClass.mode == 1 || GeneralClass.mode == 2)
                    {
                        this.Visible = false;
                        GeneralClass.nickname = tbLogin.Text.Trim();
                        tbLogin.Text = "";
                        tbPassword.Text = "";
                        this.Close();
                        th = new Thread(open);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        try
                        {
                            this.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных! Обратитесь к администратору", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void open(object obj)
        {
            Application.Run(new MainForm());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
