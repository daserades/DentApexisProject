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
    public partial class Rapor : Form
    {
        AppUserRepository aur = new AppUserRepository();
        TreatmentRepository tr = new TreatmentRepository();
        DoctorRepository dr = new DoctorRepository();
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            DateTime dtm = DateTime.Now;
            if (dtm.Day != 1)
            {
                button1.Enabled = false;
            }


            nupMal.Maximum = 2131312;
            mupFat.Maximum = 2131312;
            var result = aur.SelectAll();
            dataGridView1.DataSource = result;
            decimal totalMaas = 0;
            
            foreach (var item in result)
            {
                totalMaas += item.Salary;
            }
            lblTotalMaas.Text = totalMaas.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal asist = 6150;
            decimal sigorta = 11600;
            decimal totalmaas = Decimal.Parse(lblTotalMaas.Text);
            decimal malz = nupMal.Value;
            decimal fatura = mupFat.Value;
            decimal TotalPara = asist + sigorta + totalmaas + malz + fatura;
            lblTotal.Text = TotalPara.ToString();

            int dateTime = DateTime.Now.Month;
            int premonth = DateTime.Now.AddMonths(-1).Month;
            var lisofDoctor = dr.SelectAll();
            decimal totalturnover = 0;
            foreach (var item in lisofDoctor)
            {



                if (item.AmountOfTurnover > 24000)
                {

                    item.Salary = ((item.AmountOfTurnover  * 25) / 100);
                    MessageBox.Show(item.Salary.ToString());

                    dr.Update(item);
                }
                //foreach (var items in tr.SelectAll().Where(x => x.Doctor.ID == item.ID&&x.isActive==true&&x.CreatedDate.Month<=dateTime&&x.CreatedDate.Month>=premonth))
                //{
                //    totalturnover += items.TotalPayment;
                //}

                //if (totalturnover > 24000||item.AmountOfTurnover>24000)
                //{

                //    item.Salary= item.Salary+((totalturnover*25)/100);
                //    MessageBox.Show(item.Salary.ToString());

                //    dr.Update(item);
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Muhasebe frm2 = new Muhasebe();
            frm2.Show();
            this.Hide();
        }
    }
}
