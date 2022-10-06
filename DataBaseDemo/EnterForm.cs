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
    public partial class EnterForm : Form
    {

        private String username = "";

        public EnterForm(String username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            //Check for blanks.
            DemoSetTableAdapters.firearmsTableAdapter firearmsTA = new DemoSetTableAdapters.firearmsTableAdapter();

            //Check for number of records inserted.
            int recordsInserted = 0;

            recordsInserted = firearmsTA.Insert(MakeTB.Text, ModelTB.Text, TypeCMB.Text, ActionCMB.Text, ChamberingTB.Text,
                 Decimal.Parse(PriceTB.Text), PurchaseDTP.Value.Date, SerialTB.Text, username);

            if(recordsInserted == 1)
            {
                MessageBox.Show("Record saved!", "Saved");

                //Save was successful. Clear textboxes for next entry
                ClearTBS();

            }
            else if(recordsInserted > 1)
            {
                MessageBox.Show("Error. Duplicate records saved. Contact administrator.", "Duplicate Error");
            }
            else
            {
                MessageBox.Show("Record not saved. Contact administrator", "Save Error");
            }

        }
        
        private void ClearTBS()
        {
            MakeTB.Text = "";
            ModelTB.Text = "";
            TypeCMB.Text = "";
            ActionCMB.Text = "";
            ChamberingTB.Text = "";
            PriceTB.Text = "";
            SerialTB.Text = "";
        }
    }

    }

