using DentApexis.BLL.Repository;
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
                b.isActive = true;
                tr.Update(b);

                

                MessageBox.Show("İşlem başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem başarısız");
            }
        }
    }
}
