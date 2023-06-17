namespace Shikari
{
    partial class EmployeeUpdate
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
            this.labelRemoveUpdateEmployee = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.comboBoxProperty = new System.Windows.Forms.ComboBox();
            this.labelProperty = new System.Windows.Forms.Label();
            this.labelNewValue = new System.Windows.Forms.Label();
            this.textBoxNewValue = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdminPass = new System.Windows.Forms.TextBox();
            this.labelAdminPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonClose.Location = new System.Drawing.Point(650, 12);
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
            // labelRemoveUpdateEmployee
            // 
            this.labelRemoveUpdateEmployee.AutoSize = true;
            this.labelRemoveUpdateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labelRemoveUpdateEmployee.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemoveUpdateEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelRemoveUpdateEmployee.Location = new System.Drawing.Point(214, 36);
            this.labelRemoveUpdateEmployee.Name = "labelRemoveUpdateEmployee";
            this.labelRemoveUpdateEmployee.Size = new System.Drawing.Size(283, 55);
            this.labelRemoveUpdateEmployee.TabIndex = 32;
            this.labelRemoveUpdateEmployee.Text = "[Update Employee]";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(186, 160);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(242, 27);
            this.textBoxUsername.TabIndex = 34;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelUsername.Location = new System.Drawing.Point(12, 156);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(174, 34);
            this.labelUsername.TabIndex = 35;
            this.labelUsername.Text = "Username               :";
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(434, 268);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(86, 30);
            this.buttonUpdateEmployee.TabIndex = 36;
            this.buttonUpdateEmployee.Text = "Update";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(12, 312);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 34);
            this.labelWarning.TabIndex = 38;
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Items.AddRange(new object[] {
            "FirstName",
            "LastName",
            "Username",
            "Email",
            "Gender",
            "DateOfBirth",
            "PhoneNumber",
            "State",
            "Address",
            "Type",
            "Salary",
            "JoiningDate"});
            this.comboBoxProperty.Location = new System.Drawing.Point(186, 197);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(242, 28);
            this.comboBoxProperty.TabIndex = 39;
            this.comboBoxProperty.SelectedIndexChanged += new System.EventHandler(this.comboBoxProperty_SelectedIndexChanged);
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.BackColor = System.Drawing.Color.Transparent;
            this.labelProperty.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelProperty.Location = new System.Drawing.Point(12, 194);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(174, 34);
            this.labelProperty.TabIndex = 40;
            this.labelProperty.Text = "Property                 :";
            // 
            // labelNewValue
            // 
            this.labelNewValue.AutoSize = true;
            this.labelNewValue.BackColor = System.Drawing.Color.Transparent;
            this.labelNewValue.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelNewValue.Location = new System.Drawing.Point(12, 233);
            this.labelNewValue.Name = "labelNewValue";
            this.labelNewValue.Size = new System.Drawing.Size(175, 34);
            this.labelNewValue.TabIndex = 41;
            this.labelNewValue.Text = "New Value              :";
            // 
            // textBoxNewValue
            // 
            this.textBoxNewValue.Location = new System.Drawing.Point(186, 234);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(242, 27);
            this.textBoxNewValue.TabIndex = 42;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(434, 235);
            this.dateTimePickerDOB.MaxDate = new System.DateTime(2022, 12, 26, 0, 0, 0, 0);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(243, 27);
            this.dateTimePickerDOB.TabIndex = 44;
            this.dateTimePickerDOB.ValueChanged += new System.EventHandler(this.dateTimePickerDOB_ValueChanged);
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Location = new System.Drawing.Point(186, 268);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.PasswordChar = '*';
            this.textBoxAdminPass.Size = new System.Drawing.Size(242, 27);
            this.textBoxAdminPass.TabIndex = 58;
            // 
            // labelAdminPass
            // 
            this.labelAdminPass.AutoSize = true;
            this.labelAdminPass.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminPass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAdminPass.Location = new System.Drawing.Point(12, 264);
            this.labelAdminPass.Name = "labelAdminPass";
            this.labelAdminPass.Size = new System.Drawing.Size(174, 34);
            this.labelAdminPass.TabIndex = 57;
            this.labelAdminPass.Text = "Confirm Password  :";
            // 
            // EmployeeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(702, 373);
            this.Controls.Add(this.textBoxAdminPass);
            this.Controls.Add(this.labelAdminPass);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxNewValue);
            this.Controls.Add(this.labelNewValue);
            this.Controls.Add(this.labelProperty);
            this.Controls.Add(this.comboBoxProperty);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonUpdateEmployee);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelRemoveUpdateEmployee);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "EmployeeUpdate";
            this.Text = "Update Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelRemoveUpdateEmployee;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Button buttonUpdateEmployee;
        private Label labelWarning;
        private ComboBox comboBoxProperty;
        private Label labelProperty;
        private Label labelNewValue;
        private TextBox textBoxNewValue;
        private DateTimePicker dateTimePickerDOB;
        private TextBox textBoxAdminPass;
        private Label labelAdminPass;
    }
}