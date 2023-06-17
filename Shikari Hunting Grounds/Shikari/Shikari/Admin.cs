using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shikari
{
    public partial class Admin : Form
    {
        string currentUser = "";
        
        public Admin()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

           
        }
        public Admin(string username)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelWelcome.Text = (labelWelcome.Text + username + ",");
            currentUser = username;
            


            buttonAddHunter.Visible = false;
            buttonRemoveHunter.Visible = false;
            buttonUpdateHunter.Visible = false;
            buttonViewHunter.Visible = false;
            buttonHunterStatistics.Visible = false;

            buttonAddAnimal.Visible = false;
            buttonUpdateAnimal.Visible = false;
            buttonRemoveAnimal.Visible = false;
            buttonViewAnimal.Visible = false;

            buttonAddEmployee.Visible = false;
            buttonUpdateEmployee.Visible = false;
            buttonRemoveEmployee.Visible = false;
            buttonViewEmployee.Visible = false;

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;

            pictureBoxIcons.Visible = false;
            labelAnimalStats.Visible = false;
            labelInventoryStats.Visible = false;
            labelHunterStats.Visible = false;
            labelEmployeeStats.Visible = false;

            buttonAccessAndAuthentication.Visible = false;
            buttonIssues.Visible = false;
            buttonHuntApprovals.Visible = false;
            buttonAccounts.Visible = false;
            buttonHuntApprovalView.Visible = false;


            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            labelIssuesNotification.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void buttonManageHunter_Click(object sender, EventArgs e)
        {
            buttonAddHunter.Visible = true;
            buttonRemoveHunter.Visible = true;
            buttonUpdateHunter.Visible = true;
            buttonViewHunter.Visible = true;
            buttonHunterStatistics.Visible = true;

            buttonAddAnimal.Visible = false;
            buttonUpdateAnimal.Visible = false;
            buttonRemoveAnimal.Visible = false;
            buttonViewAnimal.Visible = false;

            buttonAddEmployee.Visible = false;
            buttonUpdateEmployee.Visible = false;
            buttonRemoveEmployee.Visible = false;
            buttonViewEmployee.Visible = false;

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;

            buttonAccessAndAuthentication.Visible = false;
            buttonIssues.Visible = false;
            buttonHuntApprovals.Visible = false;
            buttonAccounts.Visible = false;
            buttonHuntApprovalView.Visible = false;



        }

        private void buttonManageEmployee_Click(object sender, EventArgs e)
        {
            buttonAddHunter.Visible = false;
            buttonRemoveHunter.Visible = false;
            buttonUpdateHunter.Visible = false;
            buttonViewHunter.Visible = false;
            buttonHunterStatistics.Visible = false;

            buttonAddAnimal.Visible = false;
            buttonUpdateAnimal.Visible = false;
            buttonRemoveAnimal.Visible = false;
            buttonViewAnimal.Visible = false;

            buttonAddEmployee.Visible = true;
            buttonUpdateEmployee.Visible = true;
            buttonRemoveEmployee.Visible = true;
            buttonViewEmployee.Visible = true;

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;

            buttonAccessAndAuthentication.Visible = false;
            buttonIssues.Visible = false;
            buttonHuntApprovals.Visible = false;
            buttonAccounts.Visible = false;
            buttonHuntApprovalView.Visible = false;


        }

        private void buttonManageAnimal_Click(object sender, EventArgs e)
        {
            buttonAddHunter.Visible = false;
            buttonRemoveHunter.Visible = false;
            buttonUpdateHunter.Visible = false;
            buttonViewHunter.Visible = false;
            buttonHunterStatistics.Visible = false;

            buttonAddAnimal.Visible = true;
            buttonUpdateAnimal.Visible = true;
            buttonRemoveAnimal.Visible = true;
            buttonViewAnimal.Visible = true;

            buttonAddEmployee.Visible = false;
            buttonUpdateEmployee.Visible = false;
            buttonRemoveEmployee.Visible = false;
            buttonViewEmployee.Visible = false;

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;

            buttonAccessAndAuthentication.Visible = false;
            buttonIssues.Visible = false;
            buttonHuntApprovals.Visible = false;
            buttonAccounts.Visible = false;
            buttonHuntApprovalView.Visible = false;


        }

        private void buttonManageInventory_Click(object sender, EventArgs e)
        {
            buttonAddHunter.Visible = false;
            buttonRemoveHunter.Visible = false;
            buttonUpdateHunter.Visible = false;
            buttonViewHunter.Visible = false;
            buttonHunterStatistics.Visible = false;

            buttonAddAnimal.Visible = false;
            buttonUpdateAnimal.Visible = false;
            buttonRemoveAnimal.Visible = false;
            buttonViewAnimal.Visible = false;

            buttonAddEmployee.Visible = false;
            buttonUpdateEmployee.Visible = false;
            buttonRemoveEmployee.Visible = false;
            buttonViewEmployee.Visible = false;

            buttonAddInventory.Visible = true;
            buttonUpdateInventory.Visible = true;
            buttonRemoveInventory.Visible = true;
            buttonViewInventory.Visible = true;

            buttonAccessAndAuthentication.Visible = false;
            buttonIssues.Visible = false;
            buttonHuntApprovals.Visible = false;
            buttonAccounts.Visible = false;
            buttonHuntApprovalView.Visible = false;

        }

        private void buttonAddHunter_Click(object sender, EventArgs e)
        {
            RegisterHunter rh = new RegisterHunter();
            rh.Show();
        }

        private void buttonViewHunter_Click(object sender, EventArgs e)
        {
            HunterView hv = new HunterView();
            hv.Show();
        }

        private void buttonRemoveHunter_Click(object sender, EventArgs e)
        {
            HunterRemove hr = new HunterRemove(currentUser);
            hr.Show();
        }

        private void buttonUpdateHunter_Click(object sender, EventArgs e)
        {
            HunterUpdate hu = new HunterUpdate(currentUser);
            hu.Show();
        }

        private void buttonAddInventory_Click(object sender, EventArgs e)
        {
            RegisterInventory ri = new RegisterInventory();
            ri.Show();
        }

        private void buttonUpdateInventory_Click(object sender, EventArgs e)
        {
            InventoryUpdate iu = new InventoryUpdate(currentUser);
            iu.Show();
        }

        private void buttonViewInventory_Click(object sender, EventArgs e)
        {
            InventoryView iv = new InventoryView();
            iv.Show();
        }

        private void buttonRemoveInventory_Click(object sender, EventArgs e)
        {
            InventoryRemove ir = new InventoryRemove(currentUser);
            ir.Show();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            RegisterEmployee re = new RegisterEmployee();
            re.Show();
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeRemove er = new EmployeeRemove(currentUser);
            er.Show();
        }

        private void buttonViewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeView ev = new EmployeeView();
            ev.Show();
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            EmployeeUpdate eu = new EmployeeUpdate(currentUser);
            eu.Show();
        }

        private void buttonHunterStatistics_Click(object sender, EventArgs e)
        {
            HunterStatisticsUpdate hsu = new HunterStatisticsUpdate(currentUser);
            hsu.Show();
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            RegisterAnimal ra = new RegisterAnimal();
            ra.Show();
        }

        private void buttonRemoveAnimal_Click(object sender, EventArgs e)
        {
            AnimalRemove ar = new AnimalRemove(currentUser);
            ar.Show();
        }

        private void buttonViewAnimal_Click(object sender, EventArgs e)
        {
            AnimalView av = new AnimalView();
            av.Show();
        }

        private void buttonUpdateAnimal_Click(object sender, EventArgs e)
        {
            AnimalUpdate au = new AnimalUpdate(currentUser);
            au.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string issues = "";
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select COUNT(IssueID) as IssueCount from Issues;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                issues = dt.Rows[0]["IssueCount"].ToString();
                if (issues != "0")
                {
                    labelIssuesNotification.Text = $"^ {issues} new issues ^";
                    labelIssuesNotification.Visible = true;
                }
                else
                {
                    labelIssuesNotification.Visible = false;
                }



            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

        }

        private void labelOverview_MouseHover(object sender, EventArgs e)
        {
            pictureBoxIcons.Visible = true;
            labelAnimalStats.Visible = true;
            labelInventoryStats.Visible = true;
            labelHunterStats.Visible = true;
            labelEmployeeStats.Visible = true;
            ////////get info/////////

            SqlConnection conn = null;
            //get hunter stats
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select COUNT(Username) as TotalHunters, SUM(MoneySPent) as TotalMoney from HunterInfo;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string totalHunters = dt.Rows[0]["TotalHunters"].ToString();
                string totalMoney = dt.Rows[0]["TotalMoney"].ToString();
                labelHunterStats.Text = $"- {totalHunters} hunters | {totalMoney} tk spent in total";


            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            //get employee stats
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select COUNT(Username) as TotalEmployees, SUM(Salary) as TotalSalary from EmployeeInfo;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string totalEmployees = dt.Rows[0]["TotalEmployees"].ToString();
                string totalSalary = dt.Rows[0]["TotalSalary"].ToString();

                labelEmployeeStats.Text = $"- {totalEmployees} employees | {totalSalary} tk total salary";

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            //get inventory stats
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select COUNT(Model) TotalType , SUM(Amount) as TotalItems, SUM(Amount * Price) as TotalCost from Inventory;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string totalType = dt.Rows[0]["TotalType"].ToString();
                string totalItems = dt.Rows[0]["TotalItems"].ToString();
                string totalCost = dt.Rows[0]["TotalCost"].ToString();

                labelInventoryStats.Text = $"- {totalType} type of items | {totalItems} total items | {totalCost} tk cost total";

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            //get animal stats
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select COUNT(AnimalName) as TotalType, SUM(Amount) as TotalAnimals from AnimalInfo;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string totalType = dt.Rows[0]["TotalType"].ToString();
                string totalAnimals = dt.Rows[0]["TotalAnimals"].ToString();
                labelAnimalStats.Text = $"- {totalType} type of animals | {totalAnimals} total animals";


            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

        private void labelOverview_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxIcons.Visible = false;
            labelAnimalStats.Visible = false;
            labelInventoryStats.Visible = false;
            labelHunterStats.Visible = false;
            labelEmployeeStats.Visible = false;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            buttonAddHunter.Visible = false;
            buttonRemoveHunter.Visible = false;
            buttonUpdateHunter.Visible = false;
            buttonViewHunter.Visible = false;
            buttonHunterStatistics.Visible = false;

            buttonAddAnimal.Visible = false;
            buttonUpdateAnimal.Visible = false;
            buttonRemoveAnimal.Visible = false;
            buttonViewAnimal.Visible = false;

            buttonAddEmployee.Visible = false;
            buttonUpdateEmployee.Visible = false;
            buttonRemoveEmployee.Visible = false;
            buttonViewEmployee.Visible = false;

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;

            buttonAccessAndAuthentication.Visible = true;
            buttonIssues.Visible = true;
            buttonHuntApprovals.Visible = true;
            buttonAccounts.Visible = true;
            buttonHuntApprovalView.Visible = true;

        }

        private void buttonAccessAndAuthentication_Click(object sender, EventArgs e)
        {
            AccessAndAuthentication aaa = new AccessAndAuthentication(currentUser);
            aaa.Show();
        }

        private void buttonIssues_Click(object sender, EventArgs e)
        {
            Issues iss = new Issues(currentUser);
            iss.Show();
        }

        private void buttonHuntApprovals_Click(object sender, EventArgs e)
        {
            HuntingApproval ha = new HuntingApproval();
            ha.Show();
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            PasswordReset pr = new PasswordReset(currentUser);
            pr.Show();
        }

        private void labelIssuesNotification_Click(object sender, EventArgs e)
        {
            labelIssuesNotification.Visible = false;
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
        }

        private void buttonHuntApprovalView_Click(object sender, EventArgs e)
        {
            HuntApprovedView hav = new HuntApprovedView();
            hav.Show();
        }

        private void Admin_MouseHover(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string issues = "";
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select COUNT(IssueID) as IssueCount from Issues;";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                issues = dt.Rows[0]["IssueCount"].ToString();
                if (issues != "0")
                {
                    labelIssuesNotification.Text = $"^ {issues} new issues ^";
                    labelIssuesNotification.Visible = true;
                }
                else
                {
                    labelIssuesNotification.Visible = false;
                }



            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
