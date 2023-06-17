namespace Shikari
{
    partial class Admin
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
            this.buttonManageEmployee = new System.Windows.Forms.Button();
            this.buttonManageAnimal = new System.Windows.Forms.Button();
            this.buttonAddHunter = new System.Windows.Forms.Button();
            this.buttonRemoveHunter = new System.Windows.Forms.Button();
            this.buttonUpdateHunter = new System.Windows.Forms.Button();
            this.buttonViewHunter = new System.Windows.Forms.Button();
            this.buttonViewEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
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
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelHunterStats = new System.Windows.Forms.Label();
            this.labelEmployeeStats = new System.Windows.Forms.Label();
            this.labelAnimalStats = new System.Windows.Forms.Label();
            this.labelInventoryStats = new System.Windows.Forms.Label();
            this.pictureBoxStats = new System.Windows.Forms.PictureBox();
            this.labelOverview = new System.Windows.Forms.Label();
            this.pictureBoxIcons = new System.Windows.Forms.PictureBox();
            this.buttonAccessAndAuthentication = new System.Windows.Forms.Button();
            this.buttonMore = new System.Windows.Forms.Button();
            this.buttonIssues = new System.Windows.Forms.Button();
            this.buttonHuntApprovals = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.labelIssuesNotification = new System.Windows.Forms.Label();
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.buttonHuntApprovalView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcons)).BeginInit();
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
            this.buttonClose.Location = new System.Drawing.Point(1370, 12);
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
            this.buttonManageInventory.Location = new System.Drawing.Point(12, 371);
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
            // buttonManageEmployee
            // 
            this.buttonManageEmployee.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManageEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonManageEmployee.Location = new System.Drawing.Point(12, 225);
            this.buttonManageEmployee.Name = "buttonManageEmployee";
            this.buttonManageEmployee.Size = new System.Drawing.Size(123, 67);
            this.buttonManageEmployee.TabIndex = 11;
            this.buttonManageEmployee.Text = "Employees";
            this.buttonManageEmployee.UseVisualStyleBackColor = true;
            this.buttonManageEmployee.Click += new System.EventHandler(this.buttonManageEmployee_Click);
            this.buttonManageEmployee.MouseHover += new System.EventHandler(this.buttonManageEmployee_Click);
            // 
            // buttonManageAnimal
            // 
            this.buttonManageAnimal.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManageAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonManageAnimal.Location = new System.Drawing.Point(12, 298);
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
            this.buttonUpdateHunter.Size = new System.Drawing.Size(173, 29);
            this.buttonUpdateHunter.TabIndex = 16;
            this.buttonUpdateHunter.Text = "Update Hunter";
            this.buttonUpdateHunter.UseVisualStyleBackColor = true;
            this.buttonUpdateHunter.Click += new System.EventHandler(this.buttonUpdateHunter_Click);
            // 
            // buttonViewHunter
            // 
            this.buttonViewHunter.Location = new System.Drawing.Point(299, 187);
            this.buttonViewHunter.Name = "buttonViewHunter";
            this.buttonViewHunter.Size = new System.Drawing.Size(173, 29);
            this.buttonViewHunter.TabIndex = 17;
            this.buttonViewHunter.Text = "View Hunters";
            this.buttonViewHunter.UseVisualStyleBackColor = true;
            this.buttonViewHunter.Click += new System.EventHandler(this.buttonViewHunter_Click);
            // 
            // buttonViewEmployee
            // 
            this.buttonViewEmployee.Location = new System.Drawing.Point(299, 263);
            this.buttonViewEmployee.Name = "buttonViewEmployee";
            this.buttonViewEmployee.Size = new System.Drawing.Size(173, 29);
            this.buttonViewEmployee.TabIndex = 21;
            this.buttonViewEmployee.Text = "View Employees";
            this.buttonViewEmployee.UseVisualStyleBackColor = true;
            this.buttonViewEmployee.Click += new System.EventHandler(this.buttonViewEmployee_Click);
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(299, 225);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(173, 29);
            this.buttonUpdateEmployee.TabIndex = 20;
            this.buttonUpdateEmployee.Text = "Update Employee";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(141, 263);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(152, 29);
            this.buttonRemoveEmployee.TabIndex = 19;
            this.buttonRemoveEmployee.Text = "Remove Employee";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(141, 225);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(152, 29);
            this.buttonAddEmployee.TabIndex = 18;
            this.buttonAddEmployee.Text = "Register Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonViewAnimal
            // 
            this.buttonViewAnimal.Location = new System.Drawing.Point(299, 336);
            this.buttonViewAnimal.Name = "buttonViewAnimal";
            this.buttonViewAnimal.Size = new System.Drawing.Size(173, 29);
            this.buttonViewAnimal.TabIndex = 25;
            this.buttonViewAnimal.Text = "View Animals";
            this.buttonViewAnimal.UseVisualStyleBackColor = true;
            this.buttonViewAnimal.Click += new System.EventHandler(this.buttonViewAnimal_Click);
            // 
            // buttonUpdateAnimal
            // 
            this.buttonUpdateAnimal.Location = new System.Drawing.Point(299, 298);
            this.buttonUpdateAnimal.Name = "buttonUpdateAnimal";
            this.buttonUpdateAnimal.Size = new System.Drawing.Size(173, 29);
            this.buttonUpdateAnimal.TabIndex = 24;
            this.buttonUpdateAnimal.Text = "Update Animal";
            this.buttonUpdateAnimal.UseVisualStyleBackColor = true;
            this.buttonUpdateAnimal.Click += new System.EventHandler(this.buttonUpdateAnimal_Click);
            // 
            // buttonRemoveAnimal
            // 
            this.buttonRemoveAnimal.Location = new System.Drawing.Point(141, 336);
            this.buttonRemoveAnimal.Name = "buttonRemoveAnimal";
            this.buttonRemoveAnimal.Size = new System.Drawing.Size(152, 29);
            this.buttonRemoveAnimal.TabIndex = 23;
            this.buttonRemoveAnimal.Text = "Remove Animal";
            this.buttonRemoveAnimal.UseVisualStyleBackColor = true;
            this.buttonRemoveAnimal.Click += new System.EventHandler(this.buttonRemoveAnimal_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(141, 298);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(152, 29);
            this.buttonAddAnimal.TabIndex = 22;
            this.buttonAddAnimal.Text = "Register Animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // buttonViewInventory
            // 
            this.buttonViewInventory.Location = new System.Drawing.Point(299, 406);
            this.buttonViewInventory.Name = "buttonViewInventory";
            this.buttonViewInventory.Size = new System.Drawing.Size(173, 29);
            this.buttonViewInventory.TabIndex = 29;
            this.buttonViewInventory.Text = "View Items";
            this.buttonViewInventory.UseVisualStyleBackColor = true;
            this.buttonViewInventory.Click += new System.EventHandler(this.buttonViewInventory_Click);
            // 
            // buttonUpdateInventory
            // 
            this.buttonUpdateInventory.Location = new System.Drawing.Point(299, 371);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(173, 29);
            this.buttonUpdateInventory.TabIndex = 28;
            this.buttonUpdateInventory.Text = "Update Item";
            this.buttonUpdateInventory.UseVisualStyleBackColor = true;
            this.buttonUpdateInventory.Click += new System.EventHandler(this.buttonUpdateInventory_Click);
            // 
            // buttonRemoveInventory
            // 
            this.buttonRemoveInventory.Location = new System.Drawing.Point(141, 406);
            this.buttonRemoveInventory.Name = "buttonRemoveInventory";
            this.buttonRemoveInventory.Size = new System.Drawing.Size(152, 29);
            this.buttonRemoveInventory.TabIndex = 27;
            this.buttonRemoveInventory.Text = "Remove Item";
            this.buttonRemoveInventory.UseVisualStyleBackColor = true;
            this.buttonRemoveInventory.Click += new System.EventHandler(this.buttonRemoveInventory_Click);
            // 
            // buttonAddInventory
            // 
            this.buttonAddInventory.Location = new System.Drawing.Point(141, 371);
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
            this.labelDesignation.Size = new System.Drawing.Size(95, 39);
            this.labelDesignation.TabIndex = 30;
            this.labelDesignation.Text = "[Admin]";
            // 
            // buttonHunterStatistics
            // 
            this.buttonHunterStatistics.Location = new System.Drawing.Point(478, 152);
            this.buttonHunterStatistics.Name = "buttonHunterStatistics";
            this.buttonHunterStatistics.Size = new System.Drawing.Size(152, 64);
            this.buttonHunterStatistics.TabIndex = 31;
            this.buttonHunterStatistics.Text = "Update Hunter Statistics";
            this.buttonHunterStatistics.UseVisualStyleBackColor = true;
            this.buttonHunterStatistics.Click += new System.EventHandler(this.buttonHunterStatistics_Click);
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
            this.labelTime.TabIndex = 43;
            this.labelTime.Text = "Time";
            // 
            // labelHunterStats
            // 
            this.labelHunterStats.AutoSize = true;
            this.labelHunterStats.BackColor = System.Drawing.Color.Transparent;
            this.labelHunterStats.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHunterStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelHunterStats.Location = new System.Drawing.Point(654, 467);
            this.labelHunterStats.Name = "labelHunterStats";
            this.labelHunterStats.Size = new System.Drawing.Size(103, 25);
            this.labelHunterStats.TabIndex = 44;
            this.labelHunterStats.Text = "- Hunters";
            // 
            // labelEmployeeStats
            // 
            this.labelEmployeeStats.AutoSize = true;
            this.labelEmployeeStats.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeStats.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelEmployeeStats.Location = new System.Drawing.Point(654, 502);
            this.labelEmployeeStats.Name = "labelEmployeeStats";
            this.labelEmployeeStats.Size = new System.Drawing.Size(122, 25);
            this.labelEmployeeStats.TabIndex = 45;
            this.labelEmployeeStats.Text = "- Employees";
            // 
            // labelAnimalStats
            // 
            this.labelAnimalStats.AutoSize = true;
            this.labelAnimalStats.BackColor = System.Drawing.Color.Transparent;
            this.labelAnimalStats.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAnimalStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAnimalStats.Location = new System.Drawing.Point(654, 573);
            this.labelAnimalStats.Name = "labelAnimalStats";
            this.labelAnimalStats.Size = new System.Drawing.Size(98, 25);
            this.labelAnimalStats.TabIndex = 46;
            this.labelAnimalStats.Text = "- Animals";
            // 
            // labelInventoryStats
            // 
            this.labelInventoryStats.AutoSize = true;
            this.labelInventoryStats.BackColor = System.Drawing.Color.Transparent;
            this.labelInventoryStats.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInventoryStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelInventoryStats.Location = new System.Drawing.Point(654, 539);
            this.labelInventoryStats.Name = "labelInventoryStats";
            this.labelInventoryStats.Size = new System.Drawing.Size(123, 25);
            this.labelInventoryStats.TabIndex = 47;
            this.labelInventoryStats.Text = "- Inventory";
            // 
            // pictureBoxStats
            // 
            this.pictureBoxStats.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStats.BackgroundImage = global::Shikari.Properties.Resources.StatNonAnimated;
            this.pictureBoxStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStats.Location = new System.Drawing.Point(758, 113);
            this.pictureBoxStats.Name = "pictureBoxStats";
            this.pictureBoxStats.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxStats.TabIndex = 48;
            this.pictureBoxStats.TabStop = false;
            // 
            // labelOverview
            // 
            this.labelOverview.AutoSize = true;
            this.labelOverview.BackColor = System.Drawing.Color.Transparent;
            this.labelOverview.Font = new System.Drawing.Font("Ink Free", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelOverview.Location = new System.Drawing.Point(836, 264);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Size = new System.Drawing.Size(206, 53);
            this.labelOverview.TabIndex = 49;
            this.labelOverview.Text = "Overview";
            this.labelOverview.MouseLeave += new System.EventHandler(this.labelOverview_MouseLeave);
            this.labelOverview.MouseHover += new System.EventHandler(this.labelOverview_MouseHover);
            // 
            // pictureBoxIcons
            // 
            this.pictureBoxIcons.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcons.BackgroundImage = global::Shikari.Properties.Resources.logosOverview;
            this.pictureBoxIcons.Location = new System.Drawing.Point(654, 152);
            this.pictureBoxIcons.Name = "pictureBoxIcons";
            this.pictureBoxIcons.Size = new System.Drawing.Size(135, 275);
            this.pictureBoxIcons.TabIndex = 50;
            this.pictureBoxIcons.TabStop = false;
            // 
            // buttonAccessAndAuthentication
            // 
            this.buttonAccessAndAuthentication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAccessAndAuthentication.ForeColor = System.Drawing.Color.Black;
            this.buttonAccessAndAuthentication.Location = new System.Drawing.Point(141, 446);
            this.buttonAccessAndAuthentication.Name = "buttonAccessAndAuthentication";
            this.buttonAccessAndAuthentication.Size = new System.Drawing.Size(204, 34);
            this.buttonAccessAndAuthentication.TabIndex = 51;
            this.buttonAccessAndAuthentication.Text = "Access and Authentication";
            this.buttonAccessAndAuthentication.UseVisualStyleBackColor = true;
            this.buttonAccessAndAuthentication.Click += new System.EventHandler(this.buttonAccessAndAuthentication_Click);
            // 
            // buttonMore
            // 
            this.buttonMore.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMore.Location = new System.Drawing.Point(12, 446);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(123, 74);
            this.buttonMore.TabIndex = 52;
            this.buttonMore.Text = "More";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            this.buttonMore.MouseHover += new System.EventHandler(this.buttonMore_Click);
            // 
            // buttonIssues
            // 
            this.buttonIssues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIssues.ForeColor = System.Drawing.Color.Black;
            this.buttonIssues.Location = new System.Drawing.Point(141, 486);
            this.buttonIssues.Name = "buttonIssues";
            this.buttonIssues.Size = new System.Drawing.Size(72, 34);
            this.buttonIssues.TabIndex = 53;
            this.buttonIssues.Text = "Issues";
            this.buttonIssues.UseVisualStyleBackColor = true;
            this.buttonIssues.Click += new System.EventHandler(this.buttonIssues_Click);
            // 
            // buttonHuntApprovals
            // 
            this.buttonHuntApprovals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHuntApprovals.ForeColor = System.Drawing.Color.Black;
            this.buttonHuntApprovals.Location = new System.Drawing.Point(219, 486);
            this.buttonHuntApprovals.Name = "buttonHuntApprovals";
            this.buttonHuntApprovals.Size = new System.Drawing.Size(152, 34);
            this.buttonHuntApprovals.TabIndex = 54;
            this.buttonHuntApprovals.Text = "Hunting Approvals";
            this.buttonHuntApprovals.UseVisualStyleBackColor = true;
            this.buttonHuntApprovals.Click += new System.EventHandler(this.buttonHuntApprovals_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonResetPassword.Location = new System.Drawing.Point(12, 573);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(123, 52);
            this.buttonResetPassword.TabIndex = 57;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // labelIssuesNotification
            // 
            this.labelIssuesNotification.AutoSize = true;
            this.labelIssuesNotification.BackColor = System.Drawing.Color.Transparent;
            this.labelIssuesNotification.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIssuesNotification.ForeColor = System.Drawing.Color.Brown;
            this.labelIssuesNotification.Location = new System.Drawing.Point(12, 532);
            this.labelIssuesNotification.Name = "labelIssuesNotification";
            this.labelIssuesNotification.Size = new System.Drawing.Size(85, 25);
            this.labelIssuesNotification.TabIndex = 58;
            this.labelIssuesNotification.Text = "^ Issue";
            this.labelIssuesNotification.Click += new System.EventHandler(this.labelIssuesNotification_Click);
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAccounts.ForeColor = System.Drawing.Color.Black;
            this.buttonAccounts.Location = new System.Drawing.Point(351, 446);
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.Size = new System.Drawing.Size(121, 34);
            this.buttonAccounts.TabIndex = 59;
            this.buttonAccounts.Text = "Accounts";
            this.buttonAccounts.UseVisualStyleBackColor = true;
            this.buttonAccounts.Click += new System.EventHandler(this.buttonAccounts_Click);
            // 
            // buttonHuntApprovalView
            // 
            this.buttonHuntApprovalView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHuntApprovalView.ForeColor = System.Drawing.Color.Black;
            this.buttonHuntApprovalView.Location = new System.Drawing.Point(377, 486);
            this.buttonHuntApprovalView.Name = "buttonHuntApprovalView";
            this.buttonHuntApprovalView.Size = new System.Drawing.Size(95, 34);
            this.buttonHuntApprovalView.TabIndex = 60;
            this.buttonHuntApprovalView.Text = "<- View";
            this.buttonHuntApprovalView.UseVisualStyleBackColor = true;
            this.buttonHuntApprovalView.Click += new System.EventHandler(this.buttonHuntApprovalView_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(1422, 673);
            this.Controls.Add(this.buttonHuntApprovalView);
            this.Controls.Add(this.buttonAccounts);
            this.Controls.Add(this.labelIssuesNotification);
            this.Controls.Add(this.buttonResetPassword);
            this.Controls.Add(this.buttonHuntApprovals);
            this.Controls.Add(this.buttonIssues);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.buttonAccessAndAuthentication);
            this.Controls.Add(this.labelOverview);
            this.Controls.Add(this.pictureBoxStats);
            this.Controls.Add(this.pictureBoxIcons);
            this.Controls.Add(this.labelInventoryStats);
            this.Controls.Add(this.labelAnimalStats);
            this.Controls.Add(this.labelEmployeeStats);
            this.Controls.Add(this.labelHunterStats);
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
            this.Controls.Add(this.buttonViewEmployee);
            this.Controls.Add(this.buttonUpdateEmployee);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonViewHunter);
            this.Controls.Add(this.buttonUpdateHunter);
            this.Controls.Add(this.buttonRemoveHunter);
            this.Controls.Add(this.buttonAddHunter);
            this.Controls.Add(this.buttonManageAnimal);
            this.Controls.Add(this.buttonManageEmployee);
            this.Controls.Add(this.buttonManageHunter);
            this.Controls.Add(this.buttonManageInventory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MouseHover += new System.EventHandler(this.Admin_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWelcome;
        private PictureBox pictureBoxLogo;
        private Button buttonClose;
        private Button buttonManageInventory;
        private Button buttonManageHunter;
        private Button buttonManageEmployee;
        private Button buttonManageAnimal;
        private Button buttonAddHunter;
        private Button buttonRemoveHunter;
        private Button buttonUpdateHunter;
        private Button buttonViewHunter;
        private Button buttonViewEmployee;
        private Button buttonUpdateEmployee;
        private Button buttonRemoveEmployee;
        private Button buttonAddEmployee;
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
        private System.Windows.Forms.Timer timerClock;
        private Label labelTime;
        private Label labelHunterStats;
        private Label labelEmployeeStats;
        private Label labelAnimalStats;
        private Label labelInventoryStats;
        private PictureBox pictureBoxStats;
        private Label labelOverview;
        private PictureBox pictureBoxIcons;
        private Button buttonAccessAndAuthentication;
        private Button buttonMore;
        private Button buttonIssues;
        private Button buttonHuntApprovals;
        private Button buttonResetPassword;
        private Label labelIssuesNotification;
        private Button buttonAccounts;
        private Button buttonHuntApprovalView;
    }
}