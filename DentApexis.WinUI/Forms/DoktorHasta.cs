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
    public partial class DoktorHasta : Form
    {
        AppointmentRepository ar = new AppointmentRepository();
        DoctorRepository dr = new DoctorRepository();
        public DoktorHasta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text != null)
            {
                dataGridView1.DataSource = ar.SelectAll().Where(x => x.TreatingDoctor == comboBox1.SelectedItem.ToString() && x.PatientName.Contains(textBox1.Text)).ToList();

            }
            else
            {
                dataGridView1.DataSource = ar.SelectAll().Where(x => x.PatientName.Contains(textBox1.Text)).ToList();

            }
        }

        private void DoktorHasta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ar.SelectAll();


            var result = dr.SelectAll();
            List<string> dlist = new List<string>();
            foreach (var item in result)
            {
                comboBox1.Items.Add(item.FullName);

            }


            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ar.SelectAll().Where(x => x.TreatingDoctor==comboBox1.SelectedItem.ToString()&& x.PatientName.Contains(textBox1.Text)).ToList();

        }
    }
}
