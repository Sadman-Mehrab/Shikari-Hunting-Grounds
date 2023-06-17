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
using System.IO;
using System.Globalization;

namespace Shikari
{
    public partial class HuntingApproval : Form
    {
        public HuntingApproval()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void HuntingApproval_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select username from hunterinfo";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hunterComboBox.Items.Add(dt.Rows[i]["username"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again");
            }

            finally
            {
                conn.Close();
            }

            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select animalname from animalinfo";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    animalComboBox.Items.Add(dt.Rows[i]["animalname"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again");
            }

            finally
            {
                conn.Close();
            }
            //get spotters
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select username from employeeinfo where type = 'Spotter'";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    spotterIdComboBox.Items.Add(dt.Rows[i]["username"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again");
            }

            finally
            {
                conn.Close();
            }
            //
            //weaponClassComboBox.Items.Add("Bolt Action Rifle");
            //weaponClassComboBox.Items.Add("Handgun");
            //weaponClassComboBox.Items.Add("Fishing Rod");
            //weaponClassComboBox.Items.Add("Shotgun");
            //weaponClassComboBox.Items.Add("");

            //get inventory items
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select Type from Inventory where RentAvailability = 'Yes'";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    weaponClassComboBox.Items.Add(dt.Rows[i]["Type"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again");
            }

            finally
            {
                conn.Close();
            }





        }

        private void approveButton_Click(object sender, EventArgs e)
        {

            string username = hunterComboBox.Text.ToString();
            string spotter = spotterIdComboBox.Text.ToString();
            string huntName = animalComboBox.Text.ToString();
            int number;
            int payable;

            if (Int32.TryParse(approvedNumberTextBox.Text.ToString(), out number))
            {

            }
            else
            {
                MessageBox.Show("Please enter a number in the number field");
                return;
            }

            if (Int32.TryParse(amountTextBox.Text.ToString(), out payable))
            {

            }
            else
            {
                MessageBox.Show("Please enter a number in the payable amount field");
                return;
            }

            if (number > 2 && number <= 0)
            {
                MessageBox.Show("Number cannot be higher than 2");
                return;
            }
            if (payable < 1000)
            {
                MessageBox.Show("Payable cannot be less than 1000");
                return;
            }


            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();
                string query = $"select huntAvailability from animalinfo where animalname = '{huntName}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string flag = dt.Rows[0]["huntavailability"].ToString();
                if (flag == "No")
                {
                    MessageBox.Show("The animal is not avaiable for hunt at this moment");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Animal Not Found");
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();
                string query = $"insert into huntapproval (username, spotter, huntName, huntNumber, payableAmount) values ('{username}', '{spotter}', '{huntName}', {number}, {payable});";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success! Recieve The Invoice Text");

                File.WriteAllText("invoice.txt", $"\tShikari Hunting Grounds\n\nUsername        : {username}\nSpotter         : {spotter}\nHunt Name       : {huntName}\nHunt Number     : {number}\nPayable Amount  : {payable} tk\nDate            : {DateTime.Now.ToString()}\nComment         : {textBoxComment.Text}");


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                


                
                conn.Close();
            }

            int balance = 0;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            balance += payable;
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
            //hunterinfo
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();
                string query = $"select MoneySpent from HunterInfo";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                balance = Convert.ToInt32(dt.Rows[0]["MoneySpent"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            balance += payable;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();
                string query = $"update HunterInfo set MoneySpent = {balance} where Username = '{username}';";
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
