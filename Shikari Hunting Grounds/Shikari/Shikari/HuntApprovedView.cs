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
    public partial class HuntApprovedView : Form
    {
        public HuntApprovedView()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewHunter_Click(object sender, EventArgs e)
        {

            string userName = textBoxUsername.Text;
            if (textBoxUsername.Text == null || userName.Length == 0)
            {
                labelWarning.Text = "Invalid Input";
                labelWarning.Visible = true;
                return;
            }

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from huntapproval where Username = '{userName}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                if (flag != null)
                {
                    dataGridViewHunter.DataSource = dt;
                    dataGridViewHunter.Refresh();
                    dataGridViewHunter.Visible = true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "Hunter Not Found";
                labelWarning.Visible = true;
                dataGridViewHunter.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonViewHunterAll_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from huntapproval;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Username"].ToString();
                if (flag != null)
                {
                    dataGridViewHunter.DataSource = dt;
                    dataGridViewHunter.Refresh();
                    dataGridViewHunter.Visible = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "No Hunter To View";
                labelWarning.Visible = true;
                dataGridViewHunter.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void HuntApprovedView_Load(object sender, EventArgs e)
        {

        }
    }
}
