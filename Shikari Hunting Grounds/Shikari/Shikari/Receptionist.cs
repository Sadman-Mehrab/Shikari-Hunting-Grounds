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
    public partial class Receptionist : Form
    {
        string currentUser = "";
        public Receptionist()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            
        }
        public Receptionist(string userName)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelWelcome.Text = (labelWelcome.Text + userName + ",");
            currentUser = userName;
            labelColon.Text = ":\n:\n:\n:\n:\n:\n:\n:\n:\n:\n:";

            buttonAddHunter.Visible = false;
            buttonRemoveHunter.Visible = false;
            buttonUpdateHunter.Visible = false;
            buttonViewHunter.Visible = false;
            buttonHunterStatistics.Visible = false;

            buttonAddAnimal.Visible = false;
            buttonUpdateAnimal.Visible = false;
            buttonRemoveAnimal.Visible = false;
            buttonViewAnimal.Visible = false;

            

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;

            timerClock.Enabled = true;
            timerClock.Interval = 1000;
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

            

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;

        }

        private void buttonManageEmployee_Click(object sender, EventArgs e)
        {
            buttonAddHunter.Visible = false;
            buttonRemoveHunter.Visible = false;
            buttonUpdateHunter.Visible = false;
            buttonViewHunter.Visible = false;
            buttonHunterStatistics.Visible = true;

            buttonAddAnimal.Visible = false;
            buttonUpdateAnimal.Visible = false;
            buttonRemoveAnimal.Visible = false;
            buttonViewAnimal.Visible = false;

            

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;
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

            

            buttonAddInventory.Visible = false;
            buttonUpdateInventory.Visible = false;
            buttonRemoveInventory.Visible = false;
            buttonViewInventory.Visible = false;
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

            

            buttonAddInventory.Visible = true;
            buttonUpdateInventory.Visible = true;
            buttonRemoveInventory.Visible = true;
            buttonViewInventory.Visible = true;
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

        private void buttonRemoveInventory_Click(object sender, EventArgs e)
        {
            InventoryRemove ir = new InventoryRemove(currentUser);
            ir.Show();
        }

        private void buttonViewInventory_Click(object sender, EventArgs e)
        {
            InventoryView iv = new InventoryView();
            iv.Show();
        }

        private void buttonUpdateInventory_Click(object sender, EventArgs e)
        {
            InventoryUpdate iu = new InventoryUpdate(currentUser);
            iu.Show();
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

        private void buttonUpdateAnimal_Click(object sender, EventArgs e)
        {
            AnimalUpdate au = new AnimalUpdate(currentUser);
            au.Show();
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

        private void Receptionist_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                conn.Open();

                string query = $"select * from EmployeeInfo where Username = '{currentUser}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                string firstName = dt.Rows[0]["FirstName"].ToString();
                string lastName = dt.Rows[0]["LastName"].ToString();
                string userName = dt.Rows[0]["Username"].ToString();
                string email = dt.Rows[0]["Email"].ToString();
                string gender = dt.Rows[0]["Gender"].ToString();
                string phoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
                string DOB = dt.Rows[0]["DateOfBirth"].ToString();
                string state = dt.Rows[0]["State"].ToString();
                string address = dt.Rows[0]["Address"].ToString();
                string salary = dt.Rows[0]["Salary"].ToString();
                string joiningDate = dt.Rows[0]["JoiningDate"].ToString();


                string modDate = "";

                for (int i = 0; i < DOB.Length; i++)
                {
                    if (DOB[i] == ' ') break;
                    else modDate += DOB[i];
                }
                DOB = modDate;

                modDate = "";

                for (int i = 0; i < joiningDate.Length; i++)
                {
                    if (joiningDate[i] == ' ') break;
                    else modDate += joiningDate[i];
                }
                joiningDate = modDate;

                labelDetail.Text = $"First Name \nLast Name \nUsername \nEmail \nGender \nPhone Number \nDate Of Birth \nState \nAddress\nJoining Date\nSalary";
                labelInfo.Text = $"{firstName}\n{lastName}\n{userName}\n{email}\n{gender}\n{phoneNumber}\n{DOB}\n{state}\n{address}\n{joiningDate}\n{salary} tk";
                
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

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void buttonSubmitIssue_Click(object sender, EventArgs e)
        {
            RegisterIssue ri = new RegisterIssue(currentUser);
            ri.Show();
        }

        private void buttonHuntApprovals_Click(object sender, EventArgs e)
        {
            HuntingApproval ha = new HuntingApproval();
            ha.Show();
        }

        private void buttonResetPass_Click(object sender, EventArgs e)
        {
            PasswordReset pr = new PasswordReset(currentUser);
            pr.Show();
        }
    }
}
