using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shikari
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            TextBoxCurrentBalance.Enabled = false;
            labelWarning.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public static int balance = 0;

        private void Account_Load(object sender, EventArgs e)
        {
            labelWarning.Visible = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();
                string query = $"select balance from account";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                balance = Convert.ToInt32(dt.Rows[0]["balance"]);
                TextBoxCurrentBalance.Text = balance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonAddToBalance_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;

            int add;
            if (Int32.TryParse(textBoxAddToBalance.Text, out add))
            {
                balance += add;
                TextBoxCurrentBalance.Text = balance.ToString();
            }
            else
            {
                labelWarning.Text = "Please Enter an amount";
                labelWarning.Visible = true;

            }

        }

        private void buttonExpend_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            int sub;
            if (Int32.TryParse(textBoxExpend.Text, out sub))
            {
                if (sub > balance)
                {
                    labelWarning.Text = "Not Enough Money";
                    labelWarning.Visible = true;

                    return;
                }
                balance -= sub;
                TextBoxCurrentBalance.Text = balance.ToString();
            }
            else
            {
                labelWarning.Text = "Please Enter an amount";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();
                string query = $"update account set balance = {balance};";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                balance = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {


                conn.Close();
                this.Close();
            }

        }
    }
}
