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
using System.Diagnostics;

namespace Shikari
{
    public partial class InventoryUpdate : Form
    {

        string currentUser = "";
        public InventoryUpdate(string username)
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

        

        private void buttonUpdateInventory_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            SqlConnection conn = null;
            

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


            
            string model = textBoxModel.Text;
            if (textBoxModel.Text == null || model.Length == 0)
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

                string query = $"select model from Inventory where model = '{model}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["Model"].ToString();
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                labelWarning.Text = "Item Not Found";
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

            if (toUpdate == "Amount" || toUpdate == "Price")
            {
                if (Int32.TryParse(textBoxNewValue.Text, out int a))
                {
                    newValue = $"{textBoxNewValue.Text}";
                    if (Convert.ToInt32(newValue) < 0)
                    {
                        labelWarning.Text = "Price or Amount Must Be Greater or Equal To 0";
                        labelWarning.Visible = true;
                        return;
                    }
                }
                else
                {
                    labelWarning.Text = "Price or Amount Must Be A Number";
                    labelWarning.Visible = true;
                    return;
                }
            }




            if (textBoxNewValue.Text == null || newValue.Length == 0)
            {
                labelWarning.Text = "New Value Cannot Be Empty";
                labelWarning.Visible = true;
                return;
            }
            //check for duplicates
            if (toUpdate == "Model")
            {

                try
                {
                    conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                    conn.Open();

                    string query = $"select Model from Inventory where Model = {newValue};";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string flag = dt.Rows[0]["Model"].ToString();
                    if (flag != null)
                    {
                        labelWarning.Text = "Model Already Exists!";
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


            //update

            try
            {

                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"update Inventory set {toUpdate} = {newValue} where model = '{model}';";
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
