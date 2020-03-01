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
    public partial class OnlineApp : Form
    {
        OnlineAppointmentRepository oar = new OnlineAppointmentRepository();
        public OnlineApp()
        {
            InitializeComponent();
        }

        private void OnlineApp_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oar.SelectAll();
        }
    }
}
