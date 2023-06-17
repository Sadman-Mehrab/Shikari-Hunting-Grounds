using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shikari
{
    public partial class Hunter : Form
    {
        string currentUser = "";
        public Hunter()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            
        }
        public Hunter(string userName)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelWelcome.Text = (labelWelcome.Text + userName + ",");
            currentUser = userName;
            labelColon.Text = ":\n:\n:\n:\n:\n:\n:\n:\n:\n:";
            labelHoursSpent.Visible = false;
            labelKilled.Visible = false;
            labelMoney.Visible = false;
            labelNumberOfHunts.Visible = false;

            timerClock.Enabled = true;
            timerClock.Interval = 1000;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Hunter_Load(object sender, EventArgs e)
        {

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from HunterInfo where Username = '{currentUser}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                
                string firstName = dt.Rows[0]["FirstName"].ToString();
                string lastName = dt.Rows[0]["LastName"].ToString(); 
                string userName = dt.Rows[0]["Username"].ToString(); 
                string email = dt.Rows[0]["Email"].ToString(); 
                string gender = dt.Rows[0]["Gender"].ToString(); 
                string phoneNumber = dt.Rows[0]["PhoneNumber"].ToString(); 
                string DOB = dt.Rows[0]["DateOfBirth"].ToString(); 
                string state = dt.Rows[0]["State"].ToString(); 
                string address = dt.Rows[0]["Address"].ToString();
                string joiningDate = dt.Rows[0]["JoiningDate"].ToString();

                string getHunts = dt.Rows[0]["NumberOfHunts"].ToString();
                string getKilled = dt.Rows[0]["AnimalsKilled"].ToString();
                string getHours = dt.Rows[0]["HoursSpent"].ToString();
                string getMoney = dt.Rows[0]["MoneySpent"].ToString();


                string modDate = "";

                for (int i = 0; i < DOB.Length; i++)
                {
                    if (DOB[i] == ' ') break;
                    else modDate += DOB[i];
                }
                DOB = modDate;

                modDate = "";

                for (int i = 0; i < joiningDate.Length; i++)
                {
                    if (joiningDate[i] == ' ') break;
                    else modDate += joiningDate[i];
                }
                joiningDate = modDate;

                labelDetail.Text = $"First Name \nLast Name \nUsername \nEmail \nGender \nPhone Number \nDate Of Birth \nState \nAddress\nJoining Date";
                labelInfo.Text = $"{firstName}\n{lastName}\n{userName}\n{email}\n{gender}\n{phoneNumber}\n{DOB}\n{state}\n{address}\n{joiningDate}";
                labelNumberOfHunts.Text = $"- went on {getHunts} hunts";
                labelHoursSpent.Text = $"- {getHours} hours spent hunting";
                labelKilled.Text = $"- {getKilled} animals killed";
                labelMoney.Text = $"- {getMoney} tk spent";
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                MessageBox.Show("Hunter Not Found");
                //labelWarning.Text = "Hunter Not Found";
                // labelWarning.Visible = true;
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            labelHoursSpent.Visible = true;
            labelKilled.Visible = true;
            labelMoney.Visible = true;
            labelNumberOfHunts.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            labelHoursSpent.Visible = false;
            labelKilled.Visible = false;
            labelMoney.Visible = false;
            labelNumberOfHunts.Visible = false;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void buttonSubmitIssue_Click(object sender, EventArgs e)
        {
            RegisterIssue ri = new RegisterIssue(currentUser);
            ri.Show();
        }

        private void buttonResetPass_Click(object sender, EventArgs e)
        {
            PasswordReset pr = new PasswordReset(currentUser);
            pr.Show();
        }
    }
}
