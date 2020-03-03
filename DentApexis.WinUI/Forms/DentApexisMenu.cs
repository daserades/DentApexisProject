using DentApexis.BLL.Repository;
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
using DentApexis.DAL;
using DentApexis.WinUI.Forms;

namespace DentApexis.WinUI
{
    public partial class DentApexisMenu : Form
    {
        PatientRepository pr = new PatientRepository();
        DoctorRepository dr = new DoctorRepository();
        AppUserRepository aur = new AppUserRepository();

        public DentApexisMenu(int userid)
        {
            InitializeComponent();
            lblDok.Text = aur.SelectById(userid).Name+" "+ aur.SelectById(userid).LastName;

        }
        //DentApexisDBContext db = Tool.Instance;
        

        private void DentApexisMenu_Load(object sender, EventArgs e)
        {
            AppUser ap = new AppUser();
            ap = aur.SelectByFullName(lblDok.Text);
            if (ap.Pozisyon == "Doktor")
            {
                DoktorTedavi doktorTedavi = new DoktorTedavi(lblDok.Text);
                doktorTedavi.Show();
                this.Hide();
            }
            if (ap.Pozisyon == "Muhasebe")
            {
                Muhasebe frm2 = new Muhasebe();
                frm2.Show();
            }
            if (ap.Pozisyon == "Personel")
            {
                btnDoktor.Enabled = false;
                btnMuh.Enabled = false;
                btnPersonelKayit.Enabled = false;
                btnRapor.Enabled = false;
                
            }
            #region PictureBox'a gelecek resimleri belirle
            //if (lblDok.Text == "Duru Yıldız")
            //{
            //    pictureBox1.Image = Properties.Resources.t2;
            //}
            //else if (lblDok.Text == "Ayşe Yılmaz")
            //{

            //}
            //else if (lblDok.Text == "Fatma Solmaz")
            //{

            //}
            //else if (lblDok.Text == "Merve Durmaz")
            //{

            //}
            //else if (lblDok.Text == "Aytaç Mutlu")
            //{

            //}
            //else
            //{
            //    pictureBox1.Image = null;
            //}
            #endregion






            //Isım soyisim -> bütün doktorlar
            var result = dr.SelectAll();
            List<string> dlist = new List<string>();
            foreach (var item in result)
            {
                dlist.Add(item.FullName);
                
            }


            cmbTedaviEdenDoktor.DataSource = dlist;


        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Doctor drs = dr.SelectAll().Where(x => x.FullName == cmbTedaviEdenDoktor.Text).FirstOrDefault();


            Patient p = new Patient();


            p.FullName = txtAd.Text + " " + txtSoyad.Text;
            p.IdentityNumber = txtTcKimlikNo.Text;            
            p.Gender = cmbCinsiyet.Text;
            p.BloodGroup = cmbKanGrubu.Text;
            p.PhoneNumber = txtTelefonNumarasi.Text;
            p.EMailAddress = txtEmailAdresi.Text;
            p.Birthdate = (dtpDogumTarihi.Value.ToString("dd-MM-yyyy"));


            if (rbUSABank.Checked)
            {
                p.ContractWorkplace = rbUSABank.Text;

            }
            else if (rbMoneyBank.Checked)
            {
                p.ContractWorkplace = rbMoneyBank.Text;
            }
            else if (rbDemirIns.Checked)
            {
                p.ContractWorkplace = rbDemirIns.Text;
            }
            else
            {
                p.ContractWorkplace = rbYok.Text;
            }
           
            p.InfectiousDisease = txtBulasiciHastalik.Text;
            p.TreatingDoctor = drs.FullName;
            p.Doctor = dr.SelectByFullName(drs.FullName);
            p.Reference = txtReferans.Text;          
            p.Description = txtAciklama.Text;
            p.Adress = txtAdres.Text;
            p.isActive = true;



            pr.Insert(p);
            MessageBox.Show("İşlem Başarıyla Tamamlanmıştır.");

            dataGridViewHastalar.DataSource = pr.SelectAll();
        
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewHastalar.DataSource = pr.SelectAll();
            
            //ToDo:jjhg
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Muhasebe frm2 = new Muhasebe();
            frm2.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoktorHasta doktorHasta = new DoktorHasta();
            doktorHasta.Show();
        }

        private void btnPersonelKayit_Click(object sender, EventArgs e)
        {
            AddStaff frm2 = new AddStaff();
            frm2.Show();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            
            DoktorTedavi doktorTedavi = new DoktorTedavi(lblDok.Text);
            doktorTedavi.Show();
            
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rapor frm2 = new Rapor();
            frm2.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OnlineApp frm2 = new OnlineApp();
            frm2.Show();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            Randevu frm2 = new Randevu();
            frm2.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHesapDegistir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pbKullaniciResmi_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if(item is TextBox||item is RichTextBox)
                {
                    item.Text = string.Empty;
                }
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddTreatmenplan atp = new AddTreatmenplan();
            atp.Show();
        }
    }
}
