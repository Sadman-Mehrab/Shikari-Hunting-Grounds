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
    public partial class RegisterHunter : Form
    {
        public RegisterHunter()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelColon.Text += "\n:\n:\n:\n:\n:\n:\n:\n:\n:\n:\n:";

            labelWarning.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            labelWarning.Visible = false;
            SqlConnection conn = null;
            bool canRegister = false;
            string firstName = textBoxFirstName.Text; //
            string lastName = textBoxLastName.Text; //
            string username = textBoxUsername.Text; //
            string password = textBoxPassword.Text; 
            string confirmPassword = textBoxConfirmPassword.Text; 
            string passwordHint = textBoxPasswordHint.Text; 
            string email = textBoxEmail.Text; //

            string gender; //
            if (radioButtonFemale.Checked) gender = "Female";
            else if (radioButtonMale.Checked) gender = "Male";
            else if (radioButtonOther.Checked) gender = "Other";
            else gender = "";

            string phoneNumber = textBoxPhoneNumber.Text; //
            string state = comboBoxState.Text; //
            string address = textBoxAddress.Text; // 
            string DOB = dateTimePickerDOB.Value.Date.ToString("d"); //
            string joiningDate = DateTime.Now.Date.ToString("d");
            

            if (firstName.Length != 0 && lastName.Length != 0 
                && username.Length != 0 && password.Length != 0
                && confirmPassword.Length != 0 && passwordHint.Length != 0
                && email.Length != 0 && phoneNumber.Length != 0
                && gender.Length != 0 && state.Length != 0
                && address.Length != 0 && DOB.Length != 0
                && confirmPassword == password && password.Length >= 8
                && email.Contains('@') && email.Contains('.')
                && phoneNumber.Length == 11 && comboBoxState.SelectedItem != null )
            {
                canRegister = true;
            }
            else
            {
                //MessageBox.Show("Please Check Your Input");
                labelWarning.Text = "Please Check Your Input";
                labelWarning.Visible = true;
            }
            //check for duplicate username
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select Username from AccessAndAuthentication where Username = '{username}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                if (flag != null)
                {
                    //MessageBox.Show("Username Already Exists!");
                    labelWarning.Text = "Username Already Exists!";
                    labelWarning.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

            if (canRegister)
            {
                try
                {
                    conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                    conn.Open();

                    string query = $"insert into HunterInfo (Firstname, Lastname, Username, Email, Gender, DateOfBirth, JoiningDate, PhoneNumber, State, Address, NumberOfHunts, AnimalsKilled, HoursSpent, MoneySpent) VALUES ('{firstName}','{lastName}','{username}','{email}','{gender}','{DOB}','{joiningDate}','{phoneNumber}','{state}','{address}',0,0,0,0);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //MessageBox.Show("Info Success");
                    conn.Close();
                }
                //accessandauthentication
                try
                {
                    conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                    conn.Open();

                    string query = $"insert into AccessAndAuthentication (Username, Password, PassHint, Designation) VALUES ('{username}','{password}','{passwordHint}','Hunter');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //MessageBox.Show("Success");
                    labelWarning.Text = "Success";
                    labelWarning.Visible = true;
                    conn.Close();
                }
               
            }





        }

        

        
    }
}
