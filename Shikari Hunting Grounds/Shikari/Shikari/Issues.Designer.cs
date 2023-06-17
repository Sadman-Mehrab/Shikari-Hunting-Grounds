namespace Shikari
{
    partial class Issues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelIssues = new System.Windows.Forms.Label();
            this.buttonResolveAll = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelIssueID = new System.Windows.Forms.Label();
            this.dataGridViewIssues = new System.Windows.Forms.DataGridView();
            this.buttonViewIssuesAll = new System.Windows.Forms.Button();
            this.buttonViewIssue = new System.Windows.Forms.Button();
            this.labelAdminPass = new System.Windows.Forms.Label();
            this.textBoxAdminPass = new System.Windows.Forms.TextBox();
            this.buttonResolveIssue = new System.Windows.Forms.Button();
            this.textBoxIssueID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonClose.Location = new System.Drawing.Point(680, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "❌";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::Shikari.Properties.Resources.LogoTrans;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.BackColor = System.Drawing.Color.Transparent;
            this.labelIssues.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIssues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelIssues.Location = new System.Drawing.Point(288, 57);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(146, 55);
            this.labelIssues.TabIndex = 32;
            this.labelIssues.Text = "[ Issues ]";
            // 
            // buttonResolveAll
            // 
            this.buttonResolveAll.Location = new System.Drawing.Point(514, 277);
            this.buttonResolveAll.Name = "buttonResolveAll";
            this.buttonResolveAll.Size = new System.Drawing.Size(132, 36);
            this.buttonResolveAll.TabIndex = 36;
            this.buttonResolveAll.Text = "Resolve All";
            this.buttonResolveAll.UseVisualStyleBackColor = true;
            this.buttonResolveAll.Click += new System.EventHandler(this.buttonResolveAll_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(12, 337);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 34);
            this.labelWarning.TabIndex = 38;
            // 
            // labelIssueID
            // 
            this.labelIssueID.AutoSize = true;
            this.labelIssueID.BackColor = System.Drawing.Color.Transparent;
            this.labelIssueID.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIssueID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelIssueID.Location = new System.Drawing.Point(12, 203);
            this.labelIssueID.Name = "labelIssueID";
            this.labelIssueID.Size = new System.Drawing.Size(172, 34);
            this.labelIssueID.TabIndex = 40;
            this.labelIssueID.Text = "Issue ID                  :";
            // 
            // dataGridViewIssues
            // 
            this.dataGridViewIssues.AllowUserToAddRows = false;
            this.dataGridViewIssues.AllowUserToDeleteRows = false;
            this.dataGridViewIssues.AllowUserToOrderColumns = true;
            this.dataGridViewIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssues.Location = new System.Drawing.Point(12, 387);
            this.dataGridViewIssues.Name = "dataGridViewIssues";
            this.dataGridViewIssues.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewIssues.RowHeadersWidth = 51;
            this.dataGridViewIssues.RowTemplate.Height = 29;
            this.dataGridViewIssues.Size = new System.Drawing.Size(708, 304);
            this.dataGridViewIssues.TabIndex = 43;
            // 
            // buttonViewIssuesAll
            // 
            this.buttonViewIssuesAll.Location = new System.Drawing.Point(298, 277);
            this.buttonViewIssuesAll.Name = "buttonViewIssuesAll";
            this.buttonViewIssuesAll.Size = new System.Drawing.Size(102, 36);
            this.buttonViewIssuesAll.TabIndex = 45;
            this.buttonViewIssuesAll.Text = "View All";
            this.buttonViewIssuesAll.UseVisualStyleBackColor = true;
            this.buttonViewIssuesAll.Click += new System.EventHandler(this.buttonViewIssuesAll_Click);
            // 
            // buttonViewIssue
            // 
            this.buttonViewIssue.Location = new System.Drawing.Point(190, 277);
            this.buttonViewIssue.Name = "buttonViewIssue";
            this.buttonViewIssue.Size = new System.Drawing.Size(102, 36);
            this.buttonViewIssue.TabIndex = 44;
            this.buttonViewIssue.Text = "View";
            this.buttonViewIssue.UseVisualStyleBackColor = true;
            this.buttonViewIssue.Click += new System.EventHandler(this.buttonViewIssue_Click);
            // 
            // labelAdminPass
            // 
            this.labelAdminPass.AutoSize = true;
            this.labelAdminPass.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminPass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAdminPass.Location = new System.Drawing.Point(11, 237);
            this.labelAdminPass.Name = "labelAdminPass";
            this.labelAdminPass.Size = new System.Drawing.Size(173, 34);
            this.labelAdminPass.TabIndex = 46;
            this.labelAdminPass.Text = "Admin Password    :";
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Location = new System.Drawing.Point(190, 244);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.PasswordChar = '*';
            this.textBoxAdminPass.Size = new System.Drawing.Size(456, 27);
            this.textBoxAdminPass.TabIndex = 47;
            // 
            // buttonResolveIssue
            // 
            this.buttonResolveIssue.Location = new System.Drawing.Point(406, 277);
            this.buttonResolveIssue.Name = "buttonResolveIssue";
            this.buttonResolveIssue.Size = new System.Drawing.Size(102, 36);
            this.buttonResolveIssue.TabIndex = 48;
            this.buttonResolveIssue.Text = "Resolve";
            this.buttonResolveIssue.UseVisualStyleBackColor = true;
            this.buttonResolveIssue.Click += new System.EventHandler(this.buttonResolveIssue_Click);
            // 
            // textBoxIssueID
            // 
            this.textBoxIssueID.Location = new System.Drawing.Point(190, 207);
            this.textBoxIssueID.Name = "textBoxIssueID";
            this.textBoxIssueID.Size = new System.Drawing.Size(456, 27);
            this.textBoxIssueID.TabIndex = 49;
            // 
            // Issues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.textBoxIssueID);
            this.Controls.Add(this.buttonResolveIssue);
            this.Controls.Add(this.textBoxAdminPass);
            this.Controls.Add(this.labelAdminPass);
            this.Controls.Add(this.buttonViewIssuesAll);
            this.Controls.Add(this.buttonViewIssue);
            this.Controls.Add(this.dataGridViewIssues);
            this.Controls.Add(this.labelIssueID);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonResolveAll);
            this.Controls.Add(this.labelIssues);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Issues";
            this.Text = "Issues";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelIssues;
        private Button buttonResolveAll;
        private Label labelWarning;
        private Label labelIssueID;
        private DataGridView dataGridViewIssues;
        private Button buttonViewIssuesAll;
        private Button buttonViewIssue;
        private Label labelAdminPass;
        private TextBox textBoxAdminPass;
        private Button buttonResolveIssue;
        private TextBox textBoxIssueID;
    }
}