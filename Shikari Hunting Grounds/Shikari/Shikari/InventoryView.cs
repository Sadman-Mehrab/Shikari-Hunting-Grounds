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
    public partial class InventoryView : Form
    {
        public InventoryView()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridViewInventory.Visible = false;
            labelWarning.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void buttonViewInventory_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            string model = textBoxModel.Text;
            if (textBoxModel.Text == null || model.Length == 0)
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

                string query = $"select * from Inventory where model = '{model}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["model"].ToString();
                if (flag != null)
                {
                    dataGridViewInventory.DataSource = dt;
                    dataGridViewInventory.Refresh();
                    dataGridViewInventory.Visible = true;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "Item Not Found";
                labelWarning.Visible = true;
                dataGridViewInventory.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonViewInventoryAll_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from Inventory;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["model"].ToString();
                if (flag != null)
                {
                    dataGridViewInventory.DataSource = dt;
                    dataGridViewInventory.Refresh();
                    dataGridViewInventory.Visible = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "No Item To View";
                labelWarning.Visible = true;
                dataGridViewInventory.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
