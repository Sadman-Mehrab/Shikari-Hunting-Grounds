namespace Shikari
{
    partial class InventoryUpdate
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
            this.labelRemoveUpdateHunter = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonUpdateInventory = new System.Windows.Forms.Button();
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
            // labelRemoveUpdateHunter
            // 
            this.labelRemoveUpdateHunter.AutoSize = true;
            this.labelRemoveUpdateHunter.BackColor = System.Drawing.Color.Transparent;
            this.labelRemoveUpdateHunter.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemoveUpdateHunter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelRemoveUpdateHunter.Location = new System.Drawing.Point(214, 36);
            this.labelRemoveUpdateHunter.Name = "labelRemoveUpdateHunter";
            this.labelRemoveUpdateHunter.Size = new System.Drawing.Size(282, 55);
            this.labelRemoveUpdateHunter.TabIndex = 32;
            this.labelRemoveUpdateHunter.Text = "[Update Inventory]";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(189, 155);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(377, 27);
            this.textBoxModel.TabIndex = 34;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelModel.Location = new System.Drawing.Point(12, 148);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(174, 34);
            this.labelModel.TabIndex = 35;
            this.labelModel.Text = "Model                     :";
            // 
            // buttonUpdateInventory
            // 
            this.buttonUpdateInventory.Location = new System.Drawing.Point(480, 268);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(86, 31);
            this.buttonUpdateInventory.TabIndex = 36;
            this.buttonUpdateInventory.Text = "Update";
            this.buttonUpdateInventory.UseVisualStyleBackColor = true;
            this.buttonUpdateInventory.Click += new System.EventHandler(this.buttonUpdateInventory_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(12, 319);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 34);
            this.labelWarning.TabIndex = 38;
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Items.AddRange(new object[] {
            "Type",
            "Model",
            "UseCase",
            "Price",
            "Description",
            "Amount"});
            this.comboBoxProperty.Location = new System.Drawing.Point(189, 192);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(377, 28);
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
            this.textBoxNewValue.Location = new System.Drawing.Point(189, 229);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(377, 27);
            this.textBoxNewValue.TabIndex = 42;
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Location = new System.Drawing.Point(189, 270);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.PasswordChar = '*';
            this.textBoxAdminPass.Size = new System.Drawing.Size(285, 27);
            this.textBoxAdminPass.TabIndex = 49;
            // 
            // labelAdminPass
            // 
            this.labelAdminPass.AutoSize = true;
            this.labelAdminPass.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminPass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAdminPass.Location = new System.Drawing.Point(12, 266);
            this.labelAdminPass.Name = "labelAdminPass";
            this.labelAdminPass.Size = new System.Drawing.Size(174, 34);
            this.labelAdminPass.TabIndex = 48;
            this.labelAdminPass.Text = "Confirm Password  :";
            // 
            // InventoryUpdate
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
            this.Controls.Add(this.buttonUpdateInventory);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelRemoveUpdateHunter);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "InventoryUpdate";
            this.Text = "Update Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelRemoveUpdateHunter;
        private TextBox textBoxModel;
        private Label labelModel;
        private Button buttonUpdateInventory;
        private Label labelWarning;
        private ComboBox comboBoxProperty;
        private Label labelProperty;
        private Label labelNewValue;
        private TextBox textBoxNewValue;
        private TextBox textBoxAdminPass;
        private Label labelAdminPass;
    }
}