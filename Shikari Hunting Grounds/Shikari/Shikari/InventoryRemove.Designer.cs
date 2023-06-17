namespace Shikari
{
    partial class InventoryRemove
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
            this.labelRemoveInventory = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonRemoveInventory = new System.Windows.Forms.Button();
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
            // labelRemoveInventory
            // 
            this.labelRemoveInventory.AutoSize = true;
            this.labelRemoveInventory.BackColor = System.Drawing.Color.Transparent;
            this.labelRemoveInventory.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemoveInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelRemoveInventory.Location = new System.Drawing.Point(214, 36);
            this.labelRemoveInventory.Name = "labelRemoveInventory";
            this.labelRemoveInventory.Size = new System.Drawing.Size(290, 55);
            this.labelRemoveInventory.TabIndex = 32;
            this.labelRemoveInventory.Text = "[Remove Inventory]";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(189, 155);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(288, 27);
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
            // buttonRemoveInventory
            // 
            this.buttonRemoveInventory.Location = new System.Drawing.Point(483, 187);
            this.buttonRemoveInventory.Name = "buttonRemoveInventory";
            this.buttonRemoveInventory.Size = new System.Drawing.Size(98, 29);
            this.buttonRemoveInventory.TabIndex = 36;
            this.buttonRemoveInventory.Text = "Remove";
            this.buttonRemoveInventory.UseVisualStyleBackColor = true;
            this.buttonRemoveInventory.Click += new System.EventHandler(this.buttonRemoveInventory_Click);
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
            this.textBoxAdminPass.Location = new System.Drawing.Point(189, 189);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.PasswordChar = '*';
            this.textBoxAdminPass.Size = new System.Drawing.Size(288, 27);
            this.textBoxAdminPass.TabIndex = 52;
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
            this.labelAdminPass.TabIndex = 51;
            this.labelAdminPass.Text = "Confirm Password  :";
            // 
            // InventoryRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(672, 373);
            this.Controls.Add(this.textBoxAdminPass);
            this.Controls.Add(this.labelAdminPass);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonRemoveInventory);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelRemoveInventory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "InventoryRemove";
            this.Text = "Remove Inventory";
            this.Load += new System.EventHandler(this.InventoryRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelRemoveInventory;
        private TextBox textBoxModel;
        private Label labelModel;
        private Button buttonRemoveInventory;
        private Label labelWarning;
        private TextBox textBoxAdminPass;
        private Label labelAdminPass;
    }
}