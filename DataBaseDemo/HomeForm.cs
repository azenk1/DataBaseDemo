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
    public partial class HomeForm : Form
    {
        private String username = "";

        public HomeForm(String username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void EnterBTN_Click(object sender, EventArgs e)
        {
            EnterForm enterForm = new EnterForm(username);
            enterForm.Show();
            
        }

        private void ViewBTN_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm(username);
            viewForm.Show();
        }
    }
}
