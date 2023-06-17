namespace Shikari
{
    partial class InventoryView
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
            this.labelViewInventory = new System.Windows.Forms.Label();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonViewInventory = new System.Windows.Forms.Button();
            this.buttonViewInventoryAll = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
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
            // labelViewInventory
            // 
            this.labelViewInventory.AutoSize = true;
            this.labelViewInventory.BackColor = System.Drawing.Color.Transparent;
            this.labelViewInventory.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelViewInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelViewInventory.Location = new System.Drawing.Point(179, 34);
            this.labelViewInventory.Name = "labelViewInventory";
            this.labelViewInventory.Size = new System.Drawing.Size(249, 55);
            this.labelViewInventory.TabIndex = 32;
            this.labelViewInventory.Text = "[View Inventory]";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.AllowUserToOrderColumns = true;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(12, 201);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 29;
            this.dataGridViewInventory.Size = new System.Drawing.Size(1158, 336);
            this.dataGridViewInventory.TabIndex = 33;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(92, 155);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(177, 27);
            this.textBoxModel.TabIndex = 34;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelModel.Location = new System.Drawing.Point(12, 151);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(74, 34);
            this.labelModel.TabIndex = 35;
            this.labelModel.Text = "Model :";
            // 
            // buttonViewInventory
            // 
            this.buttonViewInventory.Location = new System.Drawing.Point(275, 154);
            this.buttonViewInventory.Name = "buttonViewInventory";
            this.buttonViewInventory.Size = new System.Drawing.Size(98, 29);
            this.buttonViewInventory.TabIndex = 36;
            this.buttonViewInventory.Text = "View";
            this.buttonViewInventory.UseVisualStyleBackColor = true;
            this.buttonViewInventory.Click += new System.EventHandler(this.buttonViewInventory_Click);
            // 
            // buttonViewInventoryAll
            // 
            this.buttonViewInventoryAll.Location = new System.Drawing.Point(379, 153);
            this.buttonViewInventoryAll.Name = "buttonViewInventoryAll";
            this.buttonViewInventoryAll.Size = new System.Drawing.Size(98, 30);
            this.buttonViewInventoryAll.TabIndex = 37;
            this.buttonViewInventoryAll.Text = "View All";
            this.buttonViewInventoryAll.UseVisualStyleBackColor = true;
            this.buttonViewInventoryAll.Click += new System.EventHandler(this.buttonViewInventoryAll_Click);
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
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonViewInventoryAll);
            this.Controls.Add(this.buttonViewInventory);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelViewInventory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.dataGridViewInventory);
            this.Name = "InventoryView";
            this.Text = "View Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelViewInventory;
        private DataGridView dataGridViewInventory;
        private TextBox textBoxModel;
        private Label labelModel;
        private Button buttonViewInventory;
        private Button buttonViewInventoryAll;
        private Label labelWarning;
    }
}