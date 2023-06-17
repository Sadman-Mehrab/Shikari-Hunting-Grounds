using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Shikari
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelPassHint.Visible = false;
            textBoxPassHint.Visible = false;
            buttonGetPass.Visible = false;
            labelWarning.Visible = false;

            timerClock.Enabled = true;
            timerClock.Interval = 1000;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string inputUserName = "";
            inputUserName = textBoxUname.Text;
            string inputPassword = "";
            inputPassword = textBoxPass.Text;

            if (inputUserName.Length == 0 || inputPassword.Length == 0 || inputPassword == null || inputUserName == null)
            {
                //MessageBox.Show("Invalid Input. Please Check Again");
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select Password, Designation from AccessAndAuthentication where Username = '{inputUserName}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string passwordDB = dt.Rows[0]["Password"].ToString();
                string designationDB = dt.Rows[0]["Designation"].ToString();

                if (passwordDB == inputPassword)
                {
                     
                     if(designationDB == "Admin")
                     {

                        //MessageBox.Show("Login Successful! Taking You To Admin Form");
                        labelWarning.Text = "Login Successful!";
                        labelWarning.Visible = true;
                        Admin a1 = new Admin(inputUserName); 
                        a1.Show();
                        textBoxPass.Text = "";
                     }
                     else if (designationDB == "Receptionist")
                     {
                        // MessageBox.Show("Login Successful! Taking You To Receptionist Form");
                        labelWarning.Text = "Login Successful!";
                        labelWarning.Visible = true;
                        Receptionist r1 = new Receptionist(inputUserName);
                        r1.Show();
                        textBoxPass.Text = "";
                    }
                    else if (designationDB == "Hunter")
                     {
                        //MessageBox.Show("Login Successful! Taking You To Hunter Form");
                        
                        labelWarning.Text = "Login Successful!";
                        labelWarning.Visible = true;
                        Hunter h = new Hunter(inputUserName);
                        h.Show();
                        textBoxPass.Text = "";
                    }
                     else if (designationDB == "Spotter")
                    {
                        labelWarning.Text = "Spotter Access Is Prohibited! Contact An Admin";
                        labelWarning.Visible = true;
                        textBoxPass.Text = "";
                    }
                }
                else
                {
                    //MessageBox.Show("Incorrect Password");
                    labelWarning.Text = "Incorrect Password";
                    labelWarning.Visible = true;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show("No User Found With Given Name");
                labelWarning.Text = "No User Found With Given Name";
                labelWarning.Visible = true;
            }
            finally
            {
                
                conn.Close();
            }
            
        }

        private void buttonForgot_Click(object sender, EventArgs e)
        {
            string inputUserName = "";
            inputUserName = textBoxUname.Text;
            if(inputUserName.Length == 0 || inputUserName == null)
            {
                //MessageBox.Show("Input Your Username First");
                labelWarning.Text = "Input Your Username First";
                labelWarning.Visible = true;
                return;
            }
            labelPassHint.Visible = true;
            textBoxPassHint.Visible = true;
            buttonGetPass.Visible = true;
        }

        private void buttonGetPass_Click(object sender, EventArgs e)
        {
            string inputUserName = "";
            inputUserName = textBoxUname.Text;
            string inputPassHint = "";
            inputPassHint = textBoxPassHint.Text;

            if (inputUserName.Length == 0 || inputPassHint.Length == 0 || inputPassHint == null || inputUserName == null)
            {
                //MessageBox.Show("Invalid Input. Please Check Again");
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select Password from AccessAndAuthentication where PassHint = '{inputPassHint}' and Username = '{inputUserName}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string passwordDB = dt.Rows[0]["Password"].ToString();

                //MessageBox.Show($"Restored Password: {passwordDB}\nYou May Login With The Given Password");

                textBoxPass.Text = passwordDB;
                labelWarning.Text = $"Restored Password : {passwordDB}";
                labelWarning.Visible = true;

                textBoxPassHint.Text = "";
                textBoxPassHint.Visible = false;
                labelPassHint.Visible = false;
                buttonGetPass.Visible = false;
               

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show("Invalid Username and/or Password Hint");
                labelWarning.Text = "Invalid Username and/or Password Hint";
                labelWarning.Visible = true;
            }
            finally
            {

                conn.Close();
            }
        }

        private void textBoxPass_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) buttonLogin_Click(sender, e);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }
    }
}
