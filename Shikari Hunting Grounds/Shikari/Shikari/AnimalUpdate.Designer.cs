namespace Shikari
{
    partial class AnimalUpdate
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
            this.labelUpdateAnimal = new System.Windows.Forms.Label();
            this.textBoxAnimalName = new System.Windows.Forms.TextBox();
            this.labelAnimalName = new System.Windows.Forms.Label();
            this.buttonUpdateAnimal = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.comboBoxProperty = new System.Windows.Forms.ComboBox();
            this.labelProperty = new System.Windows.Forms.Label();
            this.labelNewValue = new System.Windows.Forms.Label();
            this.textBoxNewValue = new System.Windows.Forms.TextBox();
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
            // labelUpdateAnimal
            // 
            this.labelUpdateAnimal.AutoSize = true;
            this.labelUpdateAnimal.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdateAnimal.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUpdateAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelUpdateAnimal.Location = new System.Drawing.Point(224, 44);
            this.labelUpdateAnimal.Name = "labelUpdateAnimal";
            this.labelUpdateAnimal.Size = new System.Drawing.Size(246, 55);
            this.labelUpdateAnimal.TabIndex = 32;
            this.labelUpdateAnimal.Text = "[Update Animal]";
            // 
            // textBoxAnimalName
            // 
            this.textBoxAnimalName.Location = new System.Drawing.Point(186, 155);
            this.textBoxAnimalName.Name = "textBoxAnimalName";
            this.textBoxAnimalName.Size = new System.Drawing.Size(284, 27);
            this.textBoxAnimalName.TabIndex = 34;
            // 
            // labelAnimalName
            // 
            this.labelAnimalName.AutoSize = true;
            this.labelAnimalName.BackColor = System.Drawing.Color.Transparent;
            this.labelAnimalName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnimalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAnimalName.Location = new System.Drawing.Point(12, 148);
            this.labelAnimalName.Name = "labelAnimalName";
            this.labelAnimalName.Size = new System.Drawing.Size(176, 34);
            this.labelAnimalName.TabIndex = 35;
            this.labelAnimalName.Text = "Animal                    :";
            // 
            // buttonUpdateAnimal
            // 
            this.buttonUpdateAnimal.Location = new System.Drawing.Point(476, 261);
            this.buttonUpdateAnimal.Name = "buttonUpdateAnimal";
            this.buttonUpdateAnimal.Size = new System.Drawing.Size(86, 31);
            this.buttonUpdateAnimal.TabIndex = 36;
            this.buttonUpdateAnimal.Text = "Update";
            this.buttonUpdateAnimal.UseVisualStyleBackColor = true;
            this.buttonUpdateAnimal.Click += new System.EventHandler(this.buttonUpdateAnimal_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(12, 293);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 34);
            this.labelWarning.TabIndex = 38;
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Items.AddRange(new object[] {
            "AnimalName",
            "ScientificName",
            "Class",
            "Amount",
            "Habitat",
            "Food",
            "HuntAvailability",
            "Description"});
            this.comboBoxProperty.Location = new System.Drawing.Point(186, 192);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(284, 28);
            this.comboBoxProperty.TabIndex = 39;
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.BackColor = System.Drawing.Color.Transparent;
            this.labelProperty.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelProperty.Location = new System.Drawing.Point(12, 186);
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
            this.labelNewValue.Location = new System.Drawing.Point(12, 225);
            this.labelNewValue.Name = "labelNewValue";
            this.labelNewValue.Size = new System.Drawing.Size(175, 34);
            this.labelNewValue.TabIndex = 41;
            this.labelNewValue.Text = "New Value              :";
            // 
            // textBoxNewValue
            // 
            this.textBoxNewValue.Location = new System.Drawing.Point(186, 229);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(284, 27);
            this.textBoxNewValue.TabIndex = 42;
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Location = new System.Drawing.Point(186, 263);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.PasswordChar = '*';
            this.textBoxAdminPass.Size = new System.Drawing.Size(284, 27);
            this.textBoxAdminPass.TabIndex = 62;
            // 
            // labelAdminPass
            // 
            this.labelAdminPass.AutoSize = true;
            this.labelAdminPass.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminPass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAdminPass.Location = new System.Drawing.Point(12, 259);
            this.labelAdminPass.Name = "labelAdminPass";
            this.labelAdminPass.Size = new System.Drawing.Size(174, 34);
            this.labelAdminPass.TabIndex = 61;
            this.labelAdminPass.Text = "Confirm Password  :";
            // 
            // AnimalUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(672, 373);
            this.Controls.Add(this.textBoxAdminPass);
            this.Controls.Add(this.labelAdminPass);
            this.Controls.Add(this.textBoxNewValue);
            this.Controls.Add(this.labelNewValue);
            this.Controls.Add(this.labelProperty);
            this.Controls.Add(this.comboBoxProperty);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonUpdateAnimal);
            this.Controls.Add(this.labelAnimalName);
            this.Controls.Add(this.textBoxAnimalName);
            this.Controls.Add(this.labelUpdateAnimal);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "AnimalUpdate";
            this.Text = "Update Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelUpdateAnimal;
        private TextBox textBoxAnimalName;
        private Label labelAnimalName;
        private Button buttonUpdateAnimal;
        private Label labelWarning;
        private ComboBox comboBoxProperty;
        private Label labelProperty;
        private Label labelNewValue;
        private TextBox textBoxNewValue;
        private TextBox textBoxAdminPass;
        private Label labelAdminPass;
    }
}