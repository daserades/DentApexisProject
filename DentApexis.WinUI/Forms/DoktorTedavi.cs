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
    public partial class DoktorTedavi : Form
    {
        AppUserRepository aur = new AppUserRepository();
        DoctorRepository dr = new DoctorRepository();
        AppointmentRepository ar = new AppointmentRepository();
        TreatmentPlanRepository tpr = new TreatmentPlanRepository();
        TreatmentRepository trs = new TreatmentRepository();
        PatientRepository pr = new PatientRepository();

        public DoktorTedavi(string fullname)
        {
            InitializeComponent();
            label14.Text = aur.SelectByFullName(fullname).FullName;
        }

        private void DoktorTedavi_Load(object sender, EventArgs e)
        {



            var result = ar.SelectAll().Where(x => x.Doctor.ID == dr.SelectByFullName(label14.Text).ID).ToList();
            var liste = from item in result
                        select new
                        {
                            HastaAdveSoyad = item.FullName,
                            RandevuGün = item.AppointmentDay,
                            RandevuSaat = item.AppointmentHour


                        };
            dataGridView1.DataSource = liste.ToList(); 





            foreach (var item in result)
            {
                listBox3.Items.Add(item.FullName);
            }

            var listoftp = tpr.SelectAll();
            foreach (var item in listoftp)
            {
                listBox1.Items.Add(item);
                
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                //listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bir Tedavi Seçiniz");
            }

            decimal total = 0;
            char c = '-';
            foreach (var item in listBox2.Items)
            {
                string[] name = item.ToString().Split(c);
                string itemname = name[0];
                total += tpr.SelectAll().Where(x => x.Name == itemname).FirstOrDefault().TedaviUcret;
            }
            lbltotal.Text = total.ToString();
           
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Bir Tedavi Seçiniz");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var listss = ar.SelectAll().Where(x => x.Doctor.ID == dr.SelectByFullName(label14.Text).ID).ToList();
            
            var ap = listss.Where(x => x.FullName.Contains(textBox1.Text)).ToList();
            listBox3.Items.Clear();
            foreach (var item in ap)
            {
                listBox3.Items.Add(item.FullName);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Appointment ap = ar.SelectAll().Where(x => x.FullName == listBox3.SelectedItem.ToString()).FirstOrDefault();

                lblHastaAd.Text = ap.FullName;
                bool isAct = trs.SelectAll().Where(x => x.PatientFullName == ap.FullName).FirstOrDefault().isActive;
                if (isAct)
                {
                    lblOdenme.Text = "Ödendi";
                }
                else
                {
                    lblOdenme.Text = "Ödenmedi";
                }
            }
            catch (Exception)
            {

                
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string listmiz = "";
                Treatment tr = new Treatment();
                tr.PatientFullName = lblHastaAd.Text;
                tr.TotalPayment = Decimal.Parse(lbltotal.Text);
                foreach (var item in listBox2.Items)
                {
                    listmiz += item.ToString() + ",";
                }

                tr.ListOfTreatments = listmiz;
                tr.Patient = pr.SelectAll().Where(x => x.FullName == lblHastaAd.Text).FirstOrDefault();
                tr.Description = richTextBox1.Text;

                tr.isActive = false;
                tr.Doctor = dr.SelectByFullName(label14.Text);
                trs.Insert(tr);
                MessageBox.Show("İşlem Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show("İşlem Başarısız"+ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
