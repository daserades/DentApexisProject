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
    public partial class AddTreatmenplan : Form
    {
        TreatmentPlanRepository tpr = new TreatmentPlanRepository();

        public AddTreatmenplan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                TreatmentPlan tp = new TreatmentPlan();
                tp.Name = textBox1.Text;
                tp.TedaviUcret = numericUpDown1.Value;
                tpr.Insert(tp);
            }
            catch (Exception)
            {

                MessageBox.Show("Alanları Eksiksiz Doldurun.");
            }
        }
    }
}
