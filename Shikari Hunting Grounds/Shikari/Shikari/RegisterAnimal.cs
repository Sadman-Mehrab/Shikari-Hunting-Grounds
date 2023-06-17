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
using System.Reflection;

namespace Shikari
{
    public partial class RegisterAnimal : Form
    {
        public RegisterAnimal()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelColon.Text = ":\n:\n:\n:\n:\n:\n:\n:";
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
            string animalName = textBoxAnimalName.Text;
            string scientificName = textScientificName.Text;
            string animalClass = textBoxClass.Text;
            string food = textBoxFood.Text;
            string description = textBoxDescription.Text;
            string huntAvailability = textBoxHuntAvailability.Text;
            string habitat = textBoxHabitat.Text;

            int amount = 0;


            if (animalName.Length != 0 && scientificName.Length != 0 
                && animalClass.Length !=0 && food.Length != 0
                && description.Length != 0 && huntAvailability.Length != 0
                && habitat.Length != 0 && amount >= 0)
            {
                if (Int32.TryParse(textBoxAmount.Text, out int a))
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
               // MessageBox.Show("Please Check Your Input");
                labelWarning.Text = "Please Check Your Input";
                labelWarning.Visible = true;
            }

            //check for duplicates

            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select AnimalName from AnimalInfo where AnimalName = '{animalName}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["AnimalName"].ToString();
                if (flag != null)
                {
                    labelWarning.Text = "Animal Already Exists!";
                    labelWarning.Visible = true;
                    //MessageBox.Show("Animal Already Exists!");
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

                    string query = $"insert into AnimalInfo (AnimalName, ScientificName, Class, Habitat, Food, HuntAvailability, Amount, Description) VALUES ('{animalName}','{scientificName}','{animalClass}','{habitat}','{food}','{huntAvailability}',{amount},'{description}');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Animal Registration Success");
                    labelWarning.Text = "Animal Registration Success";
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
