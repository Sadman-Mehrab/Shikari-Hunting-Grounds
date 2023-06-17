namespace Shikari
{
    partial class Hunter
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
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelDetail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelColon = new System.Windows.Forms.Label();
            this.labelNumberOfHunts = new System.Windows.Forms.Label();
            this.labelHoursSpent = new System.Windows.Forms.Label();
            this.labelKilled = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonSubmitIssue = new System.Windows.Forms.Button();
            this.buttonResetPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelWelcome.Location = new System.Drawing.Point(208, 45);
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
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.BackColor = System.Drawing.Color.Transparent;
            this.labelDesignation.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDesignation.ForeColor = System.Drawing.Color.Brown;
            this.labelDesignation.Location = new System.Drawing.Point(118, 45);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(100, 39);
            this.labelDesignation.TabIndex = 30;
            this.labelDesignation.Text = "[Hunter]";
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.BackColor = System.Drawing.Color.Transparent;
            this.labelDetail.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelDetail.Location = new System.Drawing.Point(49, 174);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(63, 34);
            this.labelDetail.TabIndex = 33;
            this.labelDetail.Text = "Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Shikari.Properties.Resources.kangaroo;
            this.pictureBox1.InitialImage = global::Shikari.Properties.Resources.kangaroostatic;
            this.pictureBox1.Location = new System.Drawing.Point(460, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 491);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(208, 174);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(46, 34);
            this.labelInfo.TabIndex = 35;
            this.labelInfo.Text = "Info";
            // 
            // labelColon
            // 
            this.labelColon.AutoSize = true;
            this.labelColon.BackColor = System.Drawing.Color.Transparent;
            this.labelColon.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelColon.Location = new System.Drawing.Point(183, 174);
            this.labelColon.Name = "labelColon";
            this.labelColon.Size = new System.Drawing.Size(19, 34);
            this.labelColon.TabIndex = 39;
            this.labelColon.Text = ":";
            // 
            // labelNumberOfHunts
            // 
            this.labelNumberOfHunts.AutoSize = true;
            this.labelNumberOfHunts.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberOfHunts.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberOfHunts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelNumberOfHunts.Location = new System.Drawing.Point(916, 183);
            this.labelNumberOfHunts.Name = "labelNumberOfHunts";
            this.labelNumberOfHunts.Size = new System.Drawing.Size(183, 25);
            this.labelNumberOfHunts.TabIndex = 40;
            this.labelNumberOfHunts.Text = "- went on 4 hunts";
            // 
            // labelHoursSpent
            // 
            this.labelHoursSpent.AutoSize = true;
            this.labelHoursSpent.BackColor = System.Drawing.Color.Transparent;
            this.labelHoursSpent.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHoursSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelHoursSpent.Location = new System.Drawing.Point(916, 258);
            this.labelHoursSpent.Name = "labelHoursSpent";
            this.labelHoursSpent.Size = new System.Drawing.Size(250, 25);
            this.labelHoursSpent.TabIndex = 41;
            this.labelHoursSpent.Text = "- 25 hours spent hunting";
            // 
            // labelKilled
            // 
            this.labelKilled.AutoSize = true;
            this.labelKilled.BackColor = System.Drawing.Color.Transparent;
            this.labelKilled.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKilled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelKilled.Location = new System.Drawing.Point(870, 333);
            this.labelKilled.Name = "labelKilled";
            this.labelKilled.Size = new System.Drawing.Size(183, 25);
            this.labelKilled.TabIndex = 42;
            this.labelKilled.Text = "- 56 animals killed";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelMoney.Location = new System.Drawing.Point(817, 396);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(153, 25);
            this.labelMoney.TabIndex = 43;
            this.labelMoney.Text = "- 960 tk spent";
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
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
            this.labelTime.TabIndex = 44;
            this.labelTime.Text = "Time";
            // 
            // buttonSubmitIssue
            // 
            this.buttonSubmitIssue.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmitIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonSubmitIssue.Location = new System.Drawing.Point(49, 539);
            this.buttonSubmitIssue.Name = "buttonSubmitIssue";
            this.buttonSubmitIssue.Size = new System.Drawing.Size(153, 50);
            this.buttonSubmitIssue.TabIndex = 45;
            this.buttonSubmitIssue.Text = "Submit Issue";
            this.buttonSubmitIssue.UseVisualStyleBackColor = true;
            this.buttonSubmitIssue.Click += new System.EventHandler(this.buttonSubmitIssue_Click);
            // 
            // buttonResetPass
            // 
            this.buttonResetPass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonResetPass.Location = new System.Drawing.Point(208, 539);
            this.buttonResetPass.Name = "buttonResetPass";
            this.buttonResetPass.Size = new System.Drawing.Size(153, 52);
            this.buttonResetPass.TabIndex = 56;
            this.buttonResetPass.Text = "Reset Password";
            this.buttonResetPass.UseVisualStyleBackColor = true;
            this.buttonResetPass.Click += new System.EventHandler(this.buttonResetPass_Click);
            // 
            // Hunter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonResetPass);
            this.Controls.Add(this.buttonSubmitIssue);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelKilled);
            this.Controls.Add(this.labelHoursSpent);
            this.Controls.Add(this.labelNumberOfHunts);
            this.Controls.Add(this.labelColon);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Hunter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hunter";
            this.Load += new System.EventHandler(this.Hunter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWelcome;
        private PictureBox pictureBoxLogo;
        private Button buttonClose;
        private Label labelDesignation;
        private Label labelDetail;
        private PictureBox pictureBox1;
        private Label labelInfo;
        private Label labelColon;
        private Label labelNumberOfHunts;
        private Label labelHoursSpent;
        private Label labelKilled;
        private Label labelMoney;
        private System.Windows.Forms.Timer timerClock;
        private Label labelTime;
        private Button buttonSubmitIssue;
        private Button buttonResetPass;
    }
}