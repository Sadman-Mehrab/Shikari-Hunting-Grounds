using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;

namespace Shikari
{
    public partial class HunterStatisticsUpdate : Form
    {
        string currentUser = "";
        public HunterStatisticsUpdate(string username)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelWarning.Visible = false;
            labelColon.Text = ":\n:\n:\n:\n:\n:";
            currentUser = username;
            

        }

        public void getDetails()
        {
            buttonUpdateHunter.Visible = true;
            labelWarning.Visible = false;
            string userName = textBoxUsername.Text;
            if (textBoxUsername.Text == null || userName.Length == 0)
            {
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }

            //check if found
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from HunterInfo where Username = '{userName}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                /*if (flag == null)
                {
                    labelWarning.Text = "Hunter Not Found";
                    labelWarning.Visible = true;
                    return;
                }*/
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "Hunter Not Found";
                buttonUpdateHunter.Visible = false;
                labelWarning.Visible = true;
                textBoxHours.Text = "";
                textBoxHunts.Text = "";
                textBoxKilled.Text = "";
                textBoxMoney.Text = "";
                return;
            }
            finally
            {
                conn.Close();
            }

            //get values

            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from HunterInfo where Username = '{userName}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                string hunts = dt.Rows[0]["NumberOfHunts"].ToString();
                string killed = dt.Rows[0]["AnimalsKilled"].ToString();
                string hours = dt.Rows[0]["HoursSpent"].ToString();
                string money = dt.Rows[0]["MoneySpent"].ToString();

                textBoxHunts.Text = hunts;
                textBoxKilled.Text = killed;
                textBoxHours.Text = hours;
                textBoxMoney.Text = money;




            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                
                labelWarning.Text = "Hunter Not Found";
                labelWarning.Visible = true;
            }
            finally
            {
                conn.Close();
            }
        }

        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            getDetails();
        }

        private void buttonUpdateHunter_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            labelWarning.Visible = false;

            //validate admin pass
            string inputAdminPass = textBoxAdminPass.Text;
            string adminPassword = "";
            if (inputAdminPass.Length == 0 || textBoxAdminPass.Text == null)
            {
                labelWarning.Text = "Password Required";
                labelWarning.Visible = true;
                return;
            }



            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select Password from AccessAndAuthentication where Username = '{currentUser}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                adminPassword = dt.Rows[0]["Password"].ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

                labelWarning.Text = "No Admin or Receptionists Found With Given Name";
                labelWarning.Visible = true;
            }
            finally
            {

                conn.Close();
            }


            if (adminPassword != inputAdminPass)
            {
                labelWarning.Text = "Incorrect Credentials";
                labelWarning.Visible = true;
                return;
            }
            ///




            string userName = textBoxUsername.Text;
            if (textBoxUsername == null || userName.Length == 0)
            {
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }

            int hunts = 0;
            int killed = 0;
            int hours = 0;
            int money = 0;

            if(Int32.TryParse(textBoxHunts.Text, out int a) && Int32.TryParse(textBoxKilled.Text, out int b) && Int32.TryParse(textBoxHours.Text, out int c) && Int32.TryParse(textBoxMoney.Text, out int d))
            {
                hunts = Convert.ToInt32(textBoxHunts.Text);
                killed = Convert.ToInt32(textBoxKilled.Text);
                hours = Convert.ToInt32(textBoxHours.Text);
                money = Convert.ToInt32(textBoxMoney.Text);
                try
                {

                    conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                    conn.Open();

                    string query = $"update HunterInfo set NumberOfHunts = {hunts}, AnimalsKilled = {killed}, HoursSpent = {hours}, MoneySpent = {money} where Username = '{userName}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    labelWarning.Text = "Update Successful";
                    labelWarning.Visible = true;
                    conn.Close();
                }
            }
            else
            {
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }
        }
    }
}
