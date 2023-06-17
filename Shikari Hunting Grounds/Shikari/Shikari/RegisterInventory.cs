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
using Microsoft.Win32;

namespace Shikari
{
    public partial class RegisterInventory : Form
    {
        public RegisterInventory()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelColon.Text = ":\n:\n:\n:\n:\n:\n:";
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
            string type = textBoxType.Text;
            string model = textBoxModel.Text;
            string useCase = textBoxUseCase.Text;
            int price = 0;
            string description = textBoxDescription.Text;
            string rentAvailability = textBoxRent.Text;
            int amount = 0;


            if (type.Length != 0 && model.Length != 0
                && useCase.Length != 0 && price >= 0
                && description.Length != 0 && rentAvailability.Length != 0
                && amount >= 0)
            {
                if (Int32.TryParse(textBoxPrice.Text, out int a))
                {
                    price = Convert.ToInt32(textBoxPrice.Text);
                }
                else
                {
                    //MessageBox.Show("Price Needs To Be A Number");
                    labelWarning.Text = "Price Needs To Be A Number";
                    labelWarning.Visible = true;
                    return;
                }



                if (Int32.TryParse(textBoxAmount.Text, out int b))
                {
                    amount = Convert.ToInt32(textBoxAmount.Text);
                }
                else
                {
                    //MessageBox.Show("Amount Needs To Be A Number");
                    labelWarning.Text = "Amount Needs To Be A Number";
                    labelWarning.Visible = true;
                    return;
                }

                canRegister = true;
            }
            else
            {
                MessageBox.Show("Please Check Your Input");
            }
            //check for duplicate
             
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select Model from Inventory where Model = '{model}';";
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
                    //MessageBox.Show("Model Already Exists!");

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

                    string query = $"insert into Inventory (Type, Model, UseCase, Price, Description, RentAvailability, Amount) VALUES ('{type}','{model}','{useCase}',{price},'{description}','{rentAvailability}',{amount});";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Inventory Registration Success");
                    labelWarning.Text = "Inventory Registration Success";
                    labelWarning.Visible = true;

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





        }

        

        
    }
}
