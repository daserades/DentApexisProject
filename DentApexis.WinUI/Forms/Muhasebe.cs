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
    public partial class Muhasebe : Form
    {
        TreatmentRepository tr = new TreatmentRepository();
        DoctorRepository dr = new DoctorRepository();
        PatientRepository pr = new PatientRepository();

        public Muhasebe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Muhasebe_Load(object sender, EventArgs e)
        {
            var result = tr.SelectAll().Where(x=>x.isActive==false);
            foreach (var item in result)
            {
                listBox1.Items.Add(item.PatientFullName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var result = tr.SelectAll().Where(x => x.PatientFullName.Contains(textBox1.Text)&& x.isActive == false);
            foreach (var item in result)
            {
                listBox1.Items.Add(item.PatientFullName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblHastaAd.Text = listBox1.SelectedItem.ToString();
                var a = tr.SelectAll().Where(x => x.PatientFullName == lblHastaAd.Text).FirstOrDefault().TotalPayment;
                

                lblSigortaAd.Text = pr.SelectAll().Where(x => x.FullName == lblHastaAd.Text).FirstOrDefault().ContractWorkplace;
                switch (lblSigortaAd.Text)
                {
                    case "USA Bank":
                        lblSigorta.Text = "10";
                        a = (a *90)/100;
                        break;
                    case "Money Bank":
                        lblSigorta.Text = "15";
                        a = (a * 85) / 100;
                        break;
                    case "Demir İnşaat":
                        lblSigorta.Text = "12.5";
                        a = (a * (875/10)) / 100;
                        break;
                    default:
                        lblSigorta.Text ="Yok";
                        break;

                }

                

                lblOdenecek.Text = a.ToString();

            }
            catch (Exception)
            {

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var b = tr.SelectAll().Where(x => x.PatientFullName == lblHastaAd.Text).FirstOrDefault();
                var patient = pr.SelectAll().Where(x => x.FullName == lblHastaAd.Text).FirstOrDefault();

                b.isActive = true;
                tr.Update(b);

                

                
                Doctor drss = new Doctor();
                drss = dr.SelectByFullName(patient.TreatingDoctor);
                drss.AmountOfTurnover += b.TotalPayment;
                dr.Update(drss);

                MessageBox.Show("İşlem başarılı");


            }
            catch (Exception)
            {

                MessageBox.Show("İşlem başarısız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rapor frm2 = new Rapor();
            frm2.Show();
        }
    }
}
