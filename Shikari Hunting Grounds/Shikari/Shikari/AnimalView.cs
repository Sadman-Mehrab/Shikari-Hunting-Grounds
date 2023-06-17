using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shikari
{
    public partial class AnimalView : Form
    {
        public AnimalView()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridViewAnimal.Visible = false;
            labelWarning.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void buttonViewAnimalAll_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from AnimalInfo;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["animalName"].ToString();
                if (flag != null)
                {
                    dataGridViewAnimal.DataSource = dt;
                    dataGridViewAnimal.Refresh();
                    dataGridViewAnimal.Visible = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "No Animal To View";
                labelWarning.Visible = true;
                dataGridViewAnimal.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonViewAnimal_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            string animalName = textBoxAnimalName.Text;
            if (textBoxAnimalName.Text == null || animalName.Length == 0)
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

                string query = $"select * from AnimalInfo where animalName = '{animalName}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["animalName"].ToString();
                if (flag != null)
                {
                    dataGridViewAnimal.DataSource = dt;
                    dataGridViewAnimal.Refresh();
                    dataGridViewAnimal.Visible = true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "Animal Not Found";
                labelWarning.Visible = true;
                dataGridViewAnimal.Visible = false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
