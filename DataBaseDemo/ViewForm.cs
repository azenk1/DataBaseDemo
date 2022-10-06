using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseDemo
{
    public partial class ViewForm : Form
    {

        private String username = "";

        public ViewForm(String username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            DemoSetTableAdapters.firearmsTableAdapter firearmsTA = new DemoSetTableAdapters.firearmsTableAdapter();
            DemoSet.firearmsDataTable fireArmsDT = new DemoSet.firearmsDataTable();
            firearmsTA.FillByUsername(fireArmsDT, username);
            dataGridView1.DataSource = fireArmsDT;
            dataGridView1.Columns.Remove("FirearmID");
            dataGridView1.Columns.Remove("Username");

        }
    }
}
