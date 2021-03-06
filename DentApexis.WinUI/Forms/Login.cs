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
        private void Login_Load(object sender, EventArgs e)
        {
            
            lblHata.Visible = false;
            txtSifre.PasswordChar = '*';
            
        }       
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var a = aur.SelectAll().Any(x => x.Username == txtKullaniciAdi.Text && x.Password == txtSifre.Text);
            AppUser user = new AppUser();
            user = aur.SelectAll().Where(x => x.Username == txtKullaniciAdi.Text && x.Password == txtSifre.Text).FirstOrDefault();
            

            if (a)
            {
                DentApexisMenu menu = new DentApexisMenu(user.ID);
                menu.Show();
                this.Hide();


            }
            else
            {
                lblHata.Visible = true;

            }
    }
}                
}