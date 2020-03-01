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
    public partial class Randevu : Form
    {
        DoctorRepository dr = new DoctorRepository();
        AppointmentRepository ar = new AppointmentRepository();
        PatientRepository pr = new PatientRepository();
        public Randevu()
        {
            InitializeComponent();
        }

        private void Randevu_Load(object sender, EventArgs e)
        {

            //Doctor doctor = new Doctor();
            //doctor.AmountOfTurnover = 1;
            //doctor.Name = "Berk";
            //doctor.Surname = "Çöven";
            //doctor.Salary = 4000;

            //Doctor doctors = new Doctor();
            //doctors.AmountOfTurnover = 1;
            //doctors.Name = "Oğuz";
            //doctors.Surname = "Köse";
            //doctors.Salary = 4000;

            //dr.Insert(doctor);
            //dr.Insert(doctors);

            var result2 = pr.SelectAll();
            foreach (var item in result2)
            {
                listBox1.Items.Add(item.FullName);
            }
            #region DoktorListesi
            var result = dr.SelectAll();
            List<string> dlist = new List<string>();
            foreach (var item in result)
            {
                dlist.Add(item.FullName);

            }
            cmbDoctorList.DataSource = dlist;

            #endregion
            #region GünlerinListesi

            //List<string> dts = new List<string>();
            //DateTime now = DateTime.Now;
            //for (int i = 0; i < 5; i++)
            //{
            //    dts.Add(now.AddDays(i).ToString("dd,MM,yyyy"));
            //}
            //cmbAppDate.DataSource = dts;
            #endregion
            formYenile();
            

        }

        private void cmbAppDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //formYenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] name = listBox1.SelectedItem.ToString().Split(' ');
                string appName =name[0];
                string appSurName =name[1];
                Appointment newApp = new Appointment();
                newApp.Doctor = dr.SelectAll().Where(x => x.FullName == cmbDoctorList.SelectedItem.ToString()).FirstOrDefault();
                newApp.PatientName = appName;
                newApp.PatientSurname = appSurName;
                newApp.TreatingDoctor = cmbDoctorList.SelectedItem.ToString();
                newApp.AppointmentDay = dateTimePicker1.Value.ToString("dd,MM,yyyy");
                newApp.AppointmentHour = cmbHourlist.SelectedItem.ToString();
                newApp.Patient = pr.SelectAll().Where(x => x.FullName == newApp.PatientName+" "+ newApp.PatientSurname).FirstOrDefault();
                ar.Insert(newApp);
                MessageBox.Show("İşlem Başarılı");
                formYenile();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz");
            }
           

        }

        public void formYenile()
        {

            #region SaatList
            List<string> saatliste = new List<string>();
            var applist = ar.SelectAll().Where(x => x.AppointmentDay == dateTimePicker1.Value.ToString("dd,MM,yyyy")).ToList();
            for (int i = 9; i < 19; i++)
            {
                if (applist.Where(x => x.AppointmentHour == i.ToString()).FirstOrDefault() == null)
                {
                    saatliste.Add(i.ToString());
                }
            }
            cmbHourlist.DataSource = saatliste;
            #endregion
            if (cmbHourlist.Items.Count == 0)
            {
                MessageBox.Show("Bu Güne Uygun Saat Kalmamıştır.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString("dd,MM,yyyy"));
            formYenile();
        }

        private void txtHastaAd_TextChanged(object sender, EventArgs e)
        {
            
            var result = pr.SelectAll().Where(x => x.FullName.Contains(txtHastaAd.Text));
            listBox1.Items.Clear();
            foreach (var item in result)
            {
                listBox1.Items.Add(item.FullName);
            }
        }
    }
}
