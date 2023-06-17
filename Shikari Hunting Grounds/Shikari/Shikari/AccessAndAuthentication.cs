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

namespace Shikari
{
    public partial class AccessAndAuthentication : Form
    {
        string currentUser = "";
        public AccessAndAuthentication(string username)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridViewAAA.Visible = false;
            labelWarning.Visible = false;
            currentUser = username;
            
        }

        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void buttonViewAAA_Click(object sender, EventArgs e)
        {

            labelWarning.Visible = false;
            SqlConnection conn = null;


            //validate admin pass
            string inputAdminPass = textBoxAdminPass.Text;
            string adminPassword = "";
            if (inputAdminPass.Length == 0 || textBoxAdminPass.Text == null)
            {
                labelWarning.Text = "Admin Password Required";
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

                labelWarning.Text = "No Admin Found With Given Name";
                labelWarning.Visible = true;
            }
            finally
            {

                conn.Close();
            }


            if (adminPassword != inputAdminPass)
            {
                labelWarning.Text = "Incorrect Admin Credentials";
                labelWarning.Visible = true;
                return;
            }
            ///

            labelWarning.Visible = false;
            string userName = textBoxUsername.Text;
            if (textBoxUsername.Text == null || userName.Length == 0)
            {
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }
            //
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from AccessAndAuthentication where Username = '{userName}' and Designation != 'Admin';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                if (flag != null)
                {
                    dataGridViewAAA.DataSource = dt;
                    dataGridViewAAA.Refresh();
                    dataGridViewAAA.Visible = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "No User To View";
                labelWarning.Visible = true;
                dataGridViewAAA.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonViewAAAAll_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            SqlConnection conn = null;
            //validate admin pass
            string inputAdminPass = textBoxAdminPass.Text;
            string adminPassword = "";
            if (inputAdminPass.Length == 0 || textBoxAdminPass.Text == null)
            {
                labelWarning.Text = "Admin Password Required";
                labelWarning.Visible = true;
                return;
            }

            //validate admin password


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

                labelWarning.Text = "No Admin Found With Given Name";
                labelWarning.Visible = true;
            }
            finally
            {

                conn.Close();
            }


            if (adminPassword != inputAdminPass)
            {
                labelWarning.Text = "Incorrect Admin Credentials";
                labelWarning.Visible = true;
                return;
            }


            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from AccessAndAuthentication where Designation != 'Admin';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                if (flag != null)
                {
                    dataGridViewAAA.DataSource = dt;
                    dataGridViewAAA.Refresh();
                    dataGridViewAAA.Visible = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "No User To View";
                labelWarning.Visible = true;
                dataGridViewAAA.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonUpdateAAA_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            SqlConnection conn = null;
            string inputAdminPass = textBoxAdminPass.Text;
            string adminPassword = "";
            if (inputAdminPass.Length == 0 || textBoxAdminPass.Text == null)
            {
                labelWarning.Text = "Admin Password Required";
                labelWarning.Visible = true;
                dataGridViewAAA.Visible = false;
                return;
            }

            //validate admin password


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
                
                labelWarning.Text = "No Admin Found With Given Name";
                labelWarning.Visible = true;
            }
            finally
            {

                conn.Close();
            }


            if(adminPassword != inputAdminPass)
            {
                labelWarning.Text = "Incorrect Admin Credentials";
                labelWarning.Visible = true;
                dataGridViewAAA.Visible = false;
                return;
            }



            //check if found

            
            string userName = textBoxUsername.Text;
            if (textBoxUsername.Text == null || userName.Length == 0)
            {
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select Username from AccessAndAuthentication where Username = '{userName}' and Designation != 'Admin';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                if (flag == null)
                {
                    labelWarning.Text = "User Not Found";
                    labelWarning.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "User Not Found";
                labelWarning.Visible = true;
                return;
            }
            finally
            {
                conn.Close();
            }
            //update part
            string toUpdate = comboBoxProperty.Text;
            if (comboBoxProperty.Text == null || toUpdate.Length == 0 || comboBoxProperty.SelectedItem == null)
            {
                labelWarning.Text = "Invalid Property Name";
                labelWarning.Visible = true;
                return;
            }

            string newValue = textBoxNewValue.Text;


            if (textBoxNewValue.Text == null || newValue.Length == 0)
            {
                labelWarning.Text = "New Value Cannot Be Empty";
                labelWarning.Visible = true;
                return;
            }
            //
            

            //
            try
            {

                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"update AccessAndAuthentication set {toUpdate} = '{newValue}' where Username = '{userName}' and Designation != 'Admin';";
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

            

            dataGridViewAAA.Visible = false;
        }
    }
}
