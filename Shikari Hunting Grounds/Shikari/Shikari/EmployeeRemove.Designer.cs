namespace Shikari
{
    partial class EmployeeRemove
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
            this.labelRemoveEmployee = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
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
            this.buttonClose.Location = new System.Drawing.Point(620, 12);
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
            // labelRemoveEmployee
            // 
            this.labelRemoveEmployee.AutoSize = true;
            this.labelRemoveEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labelRemoveEmployee.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemoveEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelRemoveEmployee.Location = new System.Drawing.Point(214, 36);
            this.labelRemoveEmployee.Name = "labelRemoveEmployee";
            this.labelRemoveEmployee.Size = new System.Drawing.Size(291, 55);
            this.labelRemoveEmployee.TabIndex = 32;
            this.labelRemoveEmployee.Text = "[Remove Employee]";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(186, 156);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(201, 27);
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
            this.labelUsername.Size = new System.Drawing.Size(174, 34);
            this.labelUsername.TabIndex = 35;
            this.labelUsername.Text = "Username               :";
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(393, 187);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(98, 29);
            this.buttonRemoveEmployee.TabIndex = 36;
            this.buttonRemoveEmployee.Text = "Remove";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(12, 232);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 34);
            this.labelWarning.TabIndex = 38;
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Location = new System.Drawing.Point(186, 189);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.PasswordChar = '*';
            this.textBoxAdminPass.Size = new System.Drawing.Size(201, 27);
            this.textBoxAdminPass.TabIndex = 58;
            // 
            // labelAdminPass
            // 
            this.labelAdminPass.AutoSize = true;
            this.labelAdminPass.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminPass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAdminPass.Location = new System.Drawing.Point(12, 185);
            this.labelAdminPass.Name = "labelAdminPass";
            this.labelAdminPass.Size = new System.Drawing.Size(174, 34);
            this.labelAdminPass.TabIndex = 57;
            this.labelAdminPass.Text = "Confirm Password  :";
            // 
            // EmployeeRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(672, 373);
            this.Controls.Add(this.textBoxAdminPass);
            this.Controls.Add(this.labelAdminPass);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelRemoveEmployee);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "EmployeeRemove";
            this.Text = "Remove Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelRemoveEmployee;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Button buttonRemoveEmployee;
        private Label labelWarning;
        private TextBox textBoxAdminPass;
        private Label labelAdminPass;
    }
}