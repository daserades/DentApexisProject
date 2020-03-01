using DentApexis.BLL.Repository;
using DentApexis.BLL.Singleton;
using DentApexis.DAL.Context;
using DentApexis.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentApexis.WinUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AppUserRepository aur = new AppUserRepository();
        //DentApexisDBContext db = DbTool.Instance;

        private void Login_Load(object sender, EventArgs e)
        {
            
            lblHata.Visible = false;
            txtSifre.PasswordChar = '*';
            //todo başlangıçta veritabanına kaydedilecek bilgileri kodla!!
            AppUser au = new AppUser();
            

            //if (aur.SelectAll()==null)
            //{
            //    au.Username = "duru";
            //    au.Password = "yıldız";
            //    aur.Insert(au);

            //    au.Username = "ayşe";
            //    au.Password = "yılmaz";
            //    aur.Insert(au);

            //    au.Username = "fatma";
            //    au.Password = "solmaz";
            //    aur.Insert(au);

            //    au.Username = "merve";
            //    au.Password = "durmaz";
            //    aur.Insert(au);

            //    au.Username = "aytaç";
            //    au.Password = "mutlu";
            //    aur.Insert(au);
            //}





        }
        //DentApexisDBContext db = new DentApexisDBContext();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var a = aur.SelectAll().Any(x => x.Username == txtKullaniciAdi.Text && x.Password == txtSifre.Text);
            AppUser user = new AppUser();
            user = aur.SelectAll().Where(x => x.Username == txtKullaniciAdi.Text && x.Password == txtSifre.Text).FirstOrDefault();
            

            if (a)
            {
                DentApexisMenu menu = new DentApexisMenu(user.ID);
                menu.Show();
                Hide();


            }
            else
            {
                lblHata.Visible = true;

            }
    }
}                
}