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
using System.Reflection;

namespace Shikari
{
    public partial class Issues : Form
    {
        string currentUser = "";
        public Issues(string username)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelWarning.Visible = false;
            dataGridViewIssues.Visible = false;
            currentUser = username;
            
        }

        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void buttonViewAAAAll_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from Issues where Designation != 'Admin';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                if (flag != null)
                {
                    dataGridViewIssues.DataSource = dt;
                    dataGridViewIssues.Refresh();
                    dataGridViewIssues.Visible = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "No User To View";
                labelWarning.Visible = true;
                dataGridViewIssues.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

   
        private void buttonViewIssue_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = null;
            labelWarning.Visible = false;
            string issueID = textBoxIssueID.Text;
            if (textBoxIssueID.Text == null || issueID.Length == 0)
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

                string query = $"remove from Issues where IssueID = '{issueID}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["IssueID"].ToString();
                if (flag != null)
                {
                    dataGridViewIssues.DataSource = dt;
                    dataGridViewIssues.Refresh();
                    dataGridViewIssues.Visible = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "No Issues To View";
                labelWarning.Visible = true;
                dataGridViewIssues.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonViewIssuesAll_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            labelWarning.Visible = false;
            
            
            //
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from Issues;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["IssueID"].ToString();
                if (flag != null)
                {
                    dataGridViewIssues.DataSource = dt;
                    dataGridViewIssues.Refresh();
                    dataGridViewIssues.Visible = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "No Issues To View";
                labelWarning.Visible = true;
                dataGridViewIssues.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonResolveIssue_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            labelWarning.Visible = false;
            string issueID = textBoxIssueID.Text;
            if (textBoxIssueID.Text == null || issueID.Length == 0)
            {
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }
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

            //remove

            try
            {

                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"delete from Issues where IssueID = '{issueID}';";
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
                labelWarning.Text = $"Resolved Issue with ID: {issueID}";
                dataGridViewIssues.Visible = false;
                labelWarning.Visible = true;
                conn.Close();
            }
        }

        private void buttonResolveAll_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            labelWarning.Visible = false;
            string issueID = textBoxIssueID.Text;
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

            //remove

            try
            {

                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"delete from Issues;";
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
                labelWarning.Text = $"Resolved All Issues";
                dataGridViewIssues.Visible = false;
                labelWarning.Visible = true;
                conn.Close();
            }
        }
    }
}
