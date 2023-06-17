namespace Shikari
{
    partial class Receptionist
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
            this.components = new System.ComponentModel.Container();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonManageInventory = new System.Windows.Forms.Button();
            this.buttonManageHunter = new System.Windows.Forms.Button();
            this.buttonManageAnimal = new System.Windows.Forms.Button();
            this.buttonAddHunter = new System.Windows.Forms.Button();
            this.buttonRemoveHunter = new System.Windows.Forms.Button();
            this.buttonUpdateHunter = new System.Windows.Forms.Button();
            this.buttonViewHunter = new System.Windows.Forms.Button();
            this.buttonViewAnimal = new System.Windows.Forms.Button();
            this.buttonUpdateAnimal = new System.Windows.Forms.Button();
            this.buttonRemoveAnimal = new System.Windows.Forms.Button();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.buttonViewInventory = new System.Windows.Forms.Button();
            this.buttonUpdateInventory = new System.Windows.Forms.Button();
            this.buttonRemoveInventory = new System.Windows.Forms.Button();
            this.buttonAddInventory = new System.Windows.Forms.Button();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.buttonHunterStatistics = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelColon = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelDetail = new System.Windows.Forms.Label();
            this.labelEmployeeInfo = new System.Windows.Forms.Label();
            this.buttonSubmitIssue = new System.Windows.Forms.Button();
            this.buttonHuntApprovals = new System.Windows.Forms.Button();
            this.buttonResetPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelWelcome.Location = new System.Drawing.Point(262, 45);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(137, 39);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Signed in as ";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::Shikari.Properties.Resources.LogoTrans;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonClose.Location = new System.Drawing.Point(1210, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "❌";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonManageInventory
            // 
            this.buttonManageInventory.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManageInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonManageInventory.Location = new System.Drawing.Point(12, 298);
            this.buttonManageInventory.Name = "buttonManageInventory";
            this.buttonManageInventory.Size = new System.Drawing.Size(123, 67);
            this.buttonManageInventory.TabIndex = 9;
            this.buttonManageInventory.Text = "Inventory";
            this.buttonManageInventory.UseVisualStyleBackColor = true;
            this.buttonManageInventory.Click += new System.EventHandler(this.buttonManageInventory_Click);
            this.buttonManageInventory.MouseHover += new System.EventHandler(this.buttonManageInventory_Click);
            // 
            // buttonManageHunter
            // 
            this.buttonManageHunter.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManageHunter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonManageHunter.Location = new System.Drawing.Point(12, 152);
            this.buttonManageHunter.Name = "buttonManageHunter";
            this.buttonManageHunter.Size = new System.Drawing.Size(123, 67);
            this.buttonManageHunter.TabIndex = 10;
            this.buttonManageHunter.Text = "Hunters";
            this.buttonManageHunter.UseVisualStyleBackColor = true;
            this.buttonManageHunter.Click += new System.EventHandler(this.buttonManageHunter_Click);
            this.buttonManageHunter.MouseHover += new System.EventHandler(this.buttonManageHunter_Click);
            // 
            // buttonManageAnimal
            // 
            this.buttonManageAnimal.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManageAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonManageAnimal.Location = new System.Drawing.Point(12, 225);
            this.buttonManageAnimal.Name = "buttonManageAnimal";
            this.buttonManageAnimal.Size = new System.Drawing.Size(123, 67);
            this.buttonManageAnimal.TabIndex = 12;
            this.buttonManageAnimal.Text = "Animals";
            this.buttonManageAnimal.UseVisualStyleBackColor = true;
            this.buttonManageAnimal.Click += new System.EventHandler(this.buttonManageAnimal_Click);
            this.buttonManageAnimal.MouseHover += new System.EventHandler(this.buttonManageAnimal_Click);
            // 
            // buttonAddHunter
            // 
            this.buttonAddHunter.Location = new System.Drawing.Point(141, 152);
            this.buttonAddHunter.Name = "buttonAddHunter";
            this.buttonAddHunter.Size = new System.Drawing.Size(152, 29);
            this.buttonAddHunter.TabIndex = 14;
            this.buttonAddHunter.Text = "Register Hunter";
            this.buttonAddHunter.UseVisualStyleBackColor = true;
            this.buttonAddHunter.Click += new System.EventHandler(this.buttonAddHunter_Click);
            // 
            // buttonRemoveHunter
            // 
            this.buttonRemoveHunter.Location = new System.Drawing.Point(141, 187);
            this.buttonRemoveHunter.Name = "buttonRemoveHunter";
            this.buttonRemoveHunter.Size = new System.Drawing.Size(152, 29);
            this.buttonRemoveHunter.TabIndex = 15;
            this.buttonRemoveHunter.Text = "Remove Hunter";
            this.buttonRemoveHunter.UseVisualStyleBackColor = true;
            this.buttonRemoveHunter.Click += new System.EventHandler(this.buttonRemoveHunter_Click);
            // 
            // buttonUpdateHunter
            // 
            this.buttonUpdateHunter.Location = new System.Drawing.Point(299, 152);
            this.buttonUpdateHunter.Name = "buttonUpdateHunter";
            this.buttonUpdateHunter.Size = new System.Drawing.Size(152, 29);
            this.buttonUpdateHunter.TabIndex = 16;
            this.buttonUpdateHunter.Text = "Update Hunter";
            this.buttonUpdateHunter.UseVisualStyleBackColor = true;
            this.buttonUpdateHunter.Click += new System.EventHandler(this.buttonUpdateHunter_Click);
            // 
            // buttonViewHunter
            // 
            this.buttonViewHunter.Location = new System.Drawing.Point(299, 187);
            this.buttonViewHunter.Name = "buttonViewHunter";
            this.buttonViewHunter.Size = new System.Drawing.Size(152, 29);
            this.buttonViewHunter.TabIndex = 17;
            this.buttonViewHunter.Text = "View Hunters";
            this.buttonViewHunter.UseVisualStyleBackColor = true;
            this.buttonViewHunter.Click += new System.EventHandler(this.buttonViewHunter_Click);
            // 
            // buttonViewAnimal
            // 
            this.buttonViewAnimal.Location = new System.Drawing.Point(299, 263);
            this.buttonViewAnimal.Name = "buttonViewAnimal";
            this.buttonViewAnimal.Size = new System.Drawing.Size(152, 29);
            this.buttonViewAnimal.TabIndex = 25;
            this.buttonViewAnimal.Text = "View Animal";
            this.buttonViewAnimal.UseVisualStyleBackColor = true;
            this.buttonViewAnimal.Click += new System.EventHandler(this.buttonViewAnimal_Click);
            // 
            // buttonUpdateAnimal
            // 
            this.buttonUpdateAnimal.Location = new System.Drawing.Point(299, 225);
            this.buttonUpdateAnimal.Name = "buttonUpdateAnimal";
            this.buttonUpdateAnimal.Size = new System.Drawing.Size(152, 29);
            this.buttonUpdateAnimal.TabIndex = 24;
            this.buttonUpdateAnimal.Text = "Update Animal";
            this.buttonUpdateAnimal.UseVisualStyleBackColor = true;
            this.buttonUpdateAnimal.Click += new System.EventHandler(this.buttonUpdateAnimal_Click);
            // 
            // buttonRemoveAnimal
            // 
            this.buttonRemoveAnimal.Location = new System.Drawing.Point(141, 263);
            this.buttonRemoveAnimal.Name = "buttonRemoveAnimal";
            this.buttonRemoveAnimal.Size = new System.Drawing.Size(152, 29);
            this.buttonRemoveAnimal.TabIndex = 23;
            this.buttonRemoveAnimal.Text = "Remove Animal";
            this.buttonRemoveAnimal.UseVisualStyleBackColor = true;
            this.buttonRemoveAnimal.Click += new System.EventHandler(this.buttonRemoveAnimal_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(141, 225);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(152, 29);
            this.buttonAddAnimal.TabIndex = 22;
            this.buttonAddAnimal.Text = "Register Animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // buttonViewInventory
            // 
            this.buttonViewInventory.Location = new System.Drawing.Point(299, 336);
            this.buttonViewInventory.Name = "buttonViewInventory";
            this.buttonViewInventory.Size = new System.Drawing.Size(152, 29);
            this.buttonViewInventory.TabIndex = 29;
            this.buttonViewInventory.Text = "View Items";
            this.buttonViewInventory.UseVisualStyleBackColor = true;
            this.buttonViewInventory.Click += new System.EventHandler(this.buttonViewInventory_Click);
            // 
            // buttonUpdateInventory
            // 
            this.buttonUpdateInventory.Location = new System.Drawing.Point(299, 298);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(152, 29);
            this.buttonUpdateInventory.TabIndex = 28;
            this.buttonUpdateInventory.Text = "Update Item";
            this.buttonUpdateInventory.UseVisualStyleBackColor = true;
            this.buttonUpdateInventory.Click += new System.EventHandler(this.buttonUpdateInventory_Click);
            // 
            // buttonRemoveInventory
            // 
            this.buttonRemoveInventory.Location = new System.Drawing.Point(141, 336);
            this.buttonRemoveInventory.Name = "buttonRemoveInventory";
            this.buttonRemoveInventory.Size = new System.Drawing.Size(152, 29);
            this.buttonRemoveInventory.TabIndex = 27;
            this.buttonRemoveInventory.Text = "Remove Item";
            this.buttonRemoveInventory.UseVisualStyleBackColor = true;
            this.buttonRemoveInventory.Click += new System.EventHandler(this.buttonRemoveInventory_Click);
            // 
            // buttonAddInventory
            // 
            this.buttonAddInventory.Location = new System.Drawing.Point(141, 298);
            this.buttonAddInventory.Name = "buttonAddInventory";
            this.buttonAddInventory.Size = new System.Drawing.Size(152, 29);
            this.buttonAddInventory.TabIndex = 26;
            this.buttonAddInventory.Text = "Register Item";
            this.buttonAddInventory.UseVisualStyleBackColor = true;
            this.buttonAddInventory.Click += new System.EventHandler(this.buttonAddInventory_Click);
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.BackColor = System.Drawing.Color.Transparent;
            this.labelDesignation.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDesignation.ForeColor = System.Drawing.Color.Brown;
            this.labelDesignation.Location = new System.Drawing.Point(118, 45);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(150, 39);
            this.labelDesignation.TabIndex = 30;
            this.labelDesignation.Text = "[Receptionist]";
            // 
            // buttonHunterStatistics
            // 
            this.buttonHunterStatistics.Location = new System.Drawing.Point(457, 152);
            this.buttonHunterStatistics.Name = "buttonHunterStatistics";
            this.buttonHunterStatistics.Size = new System.Drawing.Size(152, 64);
            this.buttonHunterStatistics.TabIndex = 32;
            this.buttonHunterStatistics.Text = "Update Hunter Statistics";
            this.buttonHunterStatistics.UseVisualStyleBackColor = true;
            this.buttonHunterStatistics.Click += new System.EventHandler(this.buttonHunterStatistics_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelTime.Location = new System.Drawing.Point(12, 647);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 17);
            this.labelTime.TabIndex = 43;
            this.labelTime.Text = "Time";
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // labelColon
            // 
            this.labelColon.AutoSize = true;
            this.labelColon.BackColor = System.Drawing.Color.Transparent;
            this.labelColon.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelColon.Location = new System.Drawing.Point(879, 149);
            this.labelColon.Name = "labelColon";
            this.labelColon.Size = new System.Drawing.Size(19, 34);
            this.labelColon.TabIndex = 46;
            this.labelColon.Text = ":";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(904, 149);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(46, 34);
            this.labelInfo.TabIndex = 45;
            this.labelInfo.Text = "Info";
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.BackColor = System.Drawing.Color.Transparent;
            this.labelDetail.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelDetail.Location = new System.Drawing.Point(745, 149);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(63, 34);
            this.labelDetail.TabIndex = 44;
            this.labelDetail.Text = "Detail";
            // 
            // labelEmployeeInfo
            // 
            this.labelEmployeeInfo.AutoSize = true;
            this.labelEmployeeInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeInfo.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeInfo.ForeColor = System.Drawing.Color.Brown;
            this.labelEmployeeInfo.Location = new System.Drawing.Point(745, 111);
            this.labelEmployeeInfo.Name = "labelEmployeeInfo";
            this.labelEmployeeInfo.Size = new System.Drawing.Size(222, 39);
            this.labelEmployeeInfo.TabIndex = 47;
            this.labelEmployeeInfo.Text = "Personal Information ";
            // 
            // buttonSubmitIssue
            // 
            this.buttonSubmitIssue.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmitIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonSubmitIssue.Location = new System.Drawing.Point(745, 549);
            this.buttonSubmitIssue.Name = "buttonSubmitIssue";
            this.buttonSubmitIssue.Size = new System.Drawing.Size(153, 50);
            this.buttonSubmitIssue.TabIndex = 48;
            this.buttonSubmitIssue.Text = "Submit Issue";
            this.buttonSubmitIssue.UseVisualStyleBackColor = true;
            this.buttonSubmitIssue.Click += new System.EventHandler(this.buttonSubmitIssue_Click);
            // 
            // buttonHuntApprovals
            // 
            this.buttonHuntApprovals.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHuntApprovals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonHuntApprovals.Location = new System.Drawing.Point(12, 371);
            this.buttonHuntApprovals.Name = "buttonHuntApprovals";
            this.buttonHuntApprovals.Size = new System.Drawing.Size(123, 74);
            this.buttonHuntApprovals.TabIndex = 49;
            this.buttonHuntApprovals.Text = "Hunting Approvals";
            this.buttonHuntApprovals.UseVisualStyleBackColor = true;
            this.buttonHuntApprovals.Click += new System.EventHandler(this.buttonHuntApprovals_Click);
            // 
            // buttonResetPass
            // 
            this.buttonResetPass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonResetPass.Location = new System.Drawing.Point(904, 547);
            this.buttonResetPass.Name = "buttonResetPass";
            this.buttonResetPass.Size = new System.Drawing.Size(153, 52);
            this.buttonResetPass.TabIndex = 57;
            this.buttonResetPass.Text = "Reset Password";
            this.buttonResetPass.UseVisualStyleBackColor = true;
            this.buttonResetPass.Click += new System.EventHandler(this.buttonResetPass_Click);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonResetPass);
            this.Controls.Add(this.buttonHuntApprovals);
            this.Controls.Add(this.buttonSubmitIssue);
            this.Controls.Add(this.labelEmployeeInfo);
            this.Controls.Add(this.labelColon);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonHunterStatistics);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.buttonViewInventory);
            this.Controls.Add(this.buttonUpdateInventory);
            this.Controls.Add(this.buttonRemoveInventory);
            this.Controls.Add(this.buttonAddInventory);
            this.Controls.Add(this.buttonViewAnimal);
            this.Controls.Add(this.buttonUpdateAnimal);
            this.Controls.Add(this.buttonRemoveAnimal);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.buttonViewHunter);
            this.Controls.Add(this.buttonUpdateHunter);
            this.Controls.Add(this.buttonRemoveHunter);
            this.Controls.Add(this.buttonAddHunter);
            this.Controls.Add(this.buttonManageAnimal);
            this.Controls.Add(this.buttonManageHunter);
            this.Controls.Add(this.buttonManageInventory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Receptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.Receptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWelcome;
        private PictureBox pictureBoxLogo;
        private Button buttonClose;
        private Button buttonManageInventory;
        private Button buttonManageHunter;
        private Button buttonManageAnimal;
        private Button buttonAddHunter;
        private Button buttonRemoveHunter;
        private Button buttonUpdateHunter;
        private Button buttonViewHunter;
        private Button buttonViewAnimal;
        private Button buttonUpdateAnimal;
        private Button buttonRemoveAnimal;
        private Button buttonAddAnimal;
        private Button buttonViewInventory;
        private Button buttonUpdateInventory;
        private Button buttonRemoveInventory;
        private Button buttonAddInventory;
        private Label labelDesignation;
        private Button buttonHunterStatistics;
        private Label labelTime;
        private System.Windows.Forms.Timer timerClock;
        private Label labelColon;
        private Label labelInfo;
        private Label labelDetail;
        private Label labelEmployeeInfo;
        private Button buttonSubmitIssue;
        private Button buttonHuntApprovals;
        private Button buttonResetPass;
    }
}