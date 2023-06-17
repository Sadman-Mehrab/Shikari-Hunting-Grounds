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
    public partial class PasswordReset : Form
    {
        string currentUser = "";
        public PasswordReset(string username)
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

        

        

        

        

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            SqlConnection conn = null;
            string inputUsername = textBoxUsername.Text;
            
            string oldPassword = textBoxOldPassword.Text;
            string passwordDB = "";
            if(inputUsername.Length == 0 || textBoxUsername.Text == null || oldPassword.Length == 0 || textBoxOldPassword.Text == null)
            {
                
                labelWarning.Text = "Username and Old Password is Required";
                labelWarning.Visible = true;
                return;
                
            }
            if(currentUser != inputUsername)
            {
                labelWarning.Text = "Username Incorrect";
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
                passwordDB = dt.Rows[0]["Password"].ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

                labelWarning.Text = "No User Found With Given Name";
                labelWarning.Visible = true;
            }
            finally
            {

                conn.Close();
            }
            if(passwordDB != oldPassword)
            {
                labelWarning.Text = "Incorrect Old Password";
                labelWarning.Visible = true;
                return;
            }

            string newPassword = textBoxNewPassword.Text;
            if(newPassword.Length == 0 || textBoxNewPassword.Text == null)
            {
                labelWarning.Text = "Input New Password First";
                labelWarning.Visible = true;
                return;
            }

            try
            {

                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"update AccessAndAuthentication set Password = '{newPassword}' where Username = '{currentUser}';";
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
}
