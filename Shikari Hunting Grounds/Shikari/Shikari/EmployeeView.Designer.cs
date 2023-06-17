namespace Shikari
{
    partial class EmployeeView
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
            this.labelViewEmployee = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonViewEmployee = new System.Windows.Forms.Button();
            this.buttonViewEmployeeAll = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonClose.Location = new System.Drawing.Point(1130, 12);
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
            // labelViewEmployee
            // 
            this.labelViewEmployee.AutoSize = true;
            this.labelViewEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labelViewEmployee.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelViewEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelViewEmployee.Location = new System.Drawing.Point(179, 34);
            this.labelViewEmployee.Name = "labelViewEmployee";
            this.labelViewEmployee.Size = new System.Drawing.Size(250, 55);
            this.labelViewEmployee.TabIndex = 32;
            this.labelViewEmployee.Text = "[View Employee]";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AllowUserToOrderColumns = true;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(12, 201);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 29;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1158, 336);
            this.dataGridViewEmployee.TabIndex = 33;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(122, 155);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(147, 27);
            this.textBoxUsername.TabIndex = 34;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelUsername.Location = new System.Drawing.Point(12, 148);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(104, 34);
            this.labelUsername.TabIndex = 35;
            this.labelUsername.Text = "Username :";
            // 
            // buttonViewEmployee
            // 
            this.buttonViewEmployee.Location = new System.Drawing.Point(275, 154);
            this.buttonViewEmployee.Name = "buttonViewEmployee";
            this.buttonViewEmployee.Size = new System.Drawing.Size(98, 29);
            this.buttonViewEmployee.TabIndex = 36;
            this.buttonViewEmployee.Text = "View";
            this.buttonViewEmployee.UseVisualStyleBackColor = true;
            this.buttonViewEmployee.Click += new System.EventHandler(this.buttonViewEmployee_Click);
            // 
            // buttonViewEmployeeAll
            // 
            this.buttonViewEmployeeAll.Location = new System.Drawing.Point(379, 153);
            this.buttonViewEmployeeAll.Name = "buttonViewEmployeeAll";
            this.buttonViewEmployeeAll.Size = new System.Drawing.Size(98, 30);
            this.buttonViewEmployeeAll.TabIndex = 37;
            this.buttonViewEmployeeAll.Text = "View All";
            this.buttonViewEmployeeAll.UseVisualStyleBackColor = true;
            this.buttonViewEmployeeAll.Click += new System.EventHandler(this.buttonViewEmployeeAll_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(483, 151);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 34);
            this.labelWarning.TabIndex = 38;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonViewEmployeeAll);
            this.Controls.Add(this.buttonViewEmployee);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelViewEmployee);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Name = "EmployeeView";
            this.Text = "View Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelViewEmployee;
        private DataGridView dataGridViewEmployee;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Button buttonViewEmployee;
        private Button buttonViewEmployeeAll;
        private Label labelWarning;
    }
}