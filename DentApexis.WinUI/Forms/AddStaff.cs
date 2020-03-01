using DentApexis.BLL.Repository;
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

namespace DentApexis.WinUI.Forms
{
    public partial class AddStaff : Form
    
    {

        
        public AddStaff()
        {
            InitializeComponent();
        }

        AppUserRepository aur = new AppUserRepository();
        DoctorRepository dr = new DoctorRepository();


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AppUser appUser = new AppUser();
                appUser.Name = txtName.Text;
                appUser.LastName = txtSurname.Text;
                appUser.Username = appUser.Name.ToLower() + "." + appUser.LastName.ToLower();
                appUser.Password = txtPassword.Text;
                
                if (rdbDoctor.Checked)
                {
                    appUser.Pozisyon = rdbDoctor.Text;
                    appUser.Salary = 6000;
                    Doctor d = new Doctor();
                    d.Name = appUser.Name;
                    d.Surname = appUser.LastName;
                    d.Salary = 6000;
                    d.AmountOfTurnover = 0;
                    dr.Insert(d);
                    
                }
                if (rdbMuh.Checked)
                {
                    appUser.Pozisyon = rdbMuh.Text;
                    appUser.Salary = 3000;
                }
                if (rdbStaff.Checked)
                {
                    appUser.Pozisyon = rdbStaff.Text;
                    appUser.Salary = 2800;
                }
                aur.Insert(appUser);
                MessageBox.Show("Kayıt Başarıyla Sonuçlanmıştır.");

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bilgileri Doğru ve Eksiksiz Giriniz.");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
