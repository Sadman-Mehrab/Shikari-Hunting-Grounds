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

namespace Shikari
{
    public partial class EmployeeUpdate : Form
    {
        string currentUser = "";
        public EmployeeUpdate(string username)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelWarning.Visible = false;
            currentUser = username;
            
        }

        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {
            textBoxNewValue.Text = dateTimePickerDOB.Value.Date.ToString("d");
            
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
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
            if (textBoxUsername.Text == null || userName.Length == 0)
            {
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }

            //check if found
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select Username from EmployeeInfo where Username = '{userName}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "Employee Not Found";
                labelWarning.Visible = true;
                return;
            }
            finally
            {
                conn.Close();
            }

            //update 

            string toUpdate = comboBoxProperty.Text;
            if (comboBoxProperty.Text == null || toUpdate.Length == 0 || comboBoxProperty.SelectedItem == null)
            {
                labelWarning.Text = "Invalid Property Name";
                labelWarning.Visible = true;
                return;
            }

            string newValue = $"'{textBoxNewValue.Text}'";

            if (toUpdate == "Salary")
            {
                if (Int32.TryParse(textBoxNewValue.Text, out int a))
                {
                    newValue = $"{textBoxNewValue.Text}";
                    if (Convert.ToInt32(newValue) <= 0)
                    {
                        labelWarning.Text = "Salary Must Be Greater Than 0";
                        labelWarning.Visible = true;
                        return;
                    }
                }
                else
                {
                    labelWarning.Text = "Salary Must Be A Number";
                    labelWarning.Visible = true;
                    return;
                }
            }


            if (toUpdate == "DateOfBirth" || toUpdate == "JoiningDate")
            {
                newValue = $"'{dateTimePickerDOB.Value.Date.ToString("d")}'";
                

            }



            if (textBoxNewValue.Text == null || newValue.Length == 0)
            {
                labelWarning.Text = "New Value Cannot Be Empty";
                labelWarning.Visible = true;
                return;
            }

            if (toUpdate == "Username")
            {
                try
                {
                    conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                    conn.Open();

                    string query = $"select Username from AccessAndAuthentication where Username = '{newValue}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string flag = dt.Rows[0]["Username"].ToString();
                    if (flag != null)
                    {
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
            }

            try
            {

                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"update EmployeeInfo set {toUpdate} = {newValue} where Username = '{userName}';";
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

            if(toUpdate == "Username")
            {
                try
                {

                    conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                    conn.Open();

                    string query = $"update AccessAndAuthentication set {toUpdate} = {newValue} where Username = '{userName}';";
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
            
        }

        private void comboBoxProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProperty.Text == "JoiningDate" || comboBoxProperty.Text == "DateOfBirth")
            {
                textBoxNewValue.ReadOnly = true;
            }
            else
            {
                textBoxNewValue.ReadOnly = false;
            }
        }
    }
}
