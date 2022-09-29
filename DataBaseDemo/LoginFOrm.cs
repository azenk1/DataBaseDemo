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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /**
            DataSet fireArmDS = new DataSet();
            DemoSetTableAdapters.firearmsTableAdapter firearmsTA = new DemoSetTableAdapters.firearmsTableAdapter();
            String DateStr = "2018-08-30";
            DateTime insertDate = DateTime.Parse(DateStr);
            firearmsTA.Insert("Remington", "870 Express", "Shotgun", "Pump", "20 Gauge", 300, insertDate, "CC81282D");
        
            **/
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {

            if(CheckInput())
            {
                String userName = UsernameTB.Text;
                String password = PasswordTB.Text;

                if(CheckPassword(userName, password))
                {
                    MessageBox.Show("Login succesful!", "Login Successful");
                    HomeForm home = new HomeForm();
                    home.Show();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect password. Login failed.", "Login Failed");
                }
            }
            
        }

        private Boolean CheckPassword(String userName, String password)
        {
            Boolean match = false;

            if(password == GetPassword(userName))
            {
                match = true;
            }

            return match;
        }

        private String GetPassword(String userName)
        {
            String password = "";

            DemoSetTableAdapters.UsersTableAdapter usersTA = new DemoSetTableAdapters.UsersTableAdapter();
            DemoSet.UsersDataTable usersDT = new DemoSet.UsersDataTable();

            usersTA.FillByUserName(usersDT, userName);



            if(usersDT.Rows.Count == 1)
            {
                password = usersDT.Rows[0]["Password"].ToString();
            }
            
            else if(usersDT.Rows.Count > 1)
            {
                MessageBox.Show("Duplicate records for username. Contact system administrator.");
            }

            else if(usersDT.Rows.Count < 1)
            {
                MessageBox.Show("Username not found. Contact system administrator.");
            }

            return password;
        }

        private Boolean CheckInput()
        {

            Boolean input = true;

            //Check for input
            if (UsernameTB.Text == "")
            {
                MessageBox.Show("Please enter a username.");
                input = false;
            }

            if(PasswordTB.Text == "")
            {

                MessageBox.Show("Please enter a password.");
                input = false;
            }

            return input;
        }
    }
}
