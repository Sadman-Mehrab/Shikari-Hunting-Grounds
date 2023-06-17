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
using System.Diagnostics;
using System.Reflection;

namespace Shikari
{
    public partial class RegisterIssue : Form
    {
        string currentUser = "";
        public RegisterIssue(string username)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            labelColon.Text = ":\n:";
            currentUser = username;
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
            string username = currentUser;
            string topic = textBoxTopic.Text;
            string description = textBoxDescription.Text;
            //generate random issue ID
            string issueID = "";
            string sourceId = "aabcdeabcde123fghijkl456mnopqrst789uvw0xyz123fghijkl456abcde123fghijkl456mnopqrst789uvw0xyzmnopqrst789uvw0xyzbcdeabcde123fghijkl456mnopqrst789uvw0xyz123fghijkl456abcde123fghijkl456mnopqrst789uvw0xyzmnopqrst789uvw0xyz";
            Random rn = new Random();

            for(int i = 0; i < 10; i++)
            {
                issueID += sourceId[rn.Next(sourceId.Length)];
            }



            if (topic.Length != 0 && description.Length != 0)
            {
                canRegister = true;

            } 
            else
            {
                //MessageBox.Show("Please Check Your Input");
                labelWarning.Text = "Please Check Your Input";
                labelWarning.Visible = true;
            }

            if (canRegister)
            {
                try
                {
                    conn = new SqlConnection(@"Data Source=LAPTOP-HO106BJ0\SQLEXPRESS;Initial Catalog=Shikari;Integrated Security=True");
                    conn.Open();

                    string query = $"insert into Issues (Username, IssueID, Topic, Description) VALUES ('{currentUser}','{issueID}','{topic}','{description}');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Issue Submitted");
                    labelWarning.Text = "Issue Submitted";
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

