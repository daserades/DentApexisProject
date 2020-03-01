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
                foreach (var items in tr.SelectAll().Where(x => x.Doctor.ID == item.ID&&x.CreatedDate.Month<=dateTime&&x.CreatedDate.Month>=premonth))
                {
                    totalturnover += items.TotalPayment;
                }

                if (totalturnover > 24000)
                {
                    item.Salary = (totalturnover*25)/100;
                    
                    dr.Update(item);
                }
            }
        }
    }
}
