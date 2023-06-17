namespace Shikari
{
    partial class HuntApprovedView
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
            this.labelApprovedHunter = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewHunter = new System.Windows.Forms.DataGridView();
            this.buttonViewHunterAll = new System.Windows.Forms.Button();
            this.buttonViewHunter = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHunter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonClose.Location = new System.Drawing.Point(663, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "❌";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelApprovedHunter
            // 
            this.labelApprovedHunter.AutoSize = true;
            this.labelApprovedHunter.BackColor = System.Drawing.Color.Transparent;
            this.labelApprovedHunter.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelApprovedHunter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelApprovedHunter.Location = new System.Drawing.Point(240, 29);
            this.labelApprovedHunter.Name = "labelApprovedHunter";
            this.labelApprovedHunter.Size = new System.Drawing.Size(270, 55);
            this.labelApprovedHunter.TabIndex = 34;
            this.labelApprovedHunter.Text = "[Approved Hunts]";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::Shikari.Properties.Resources.LogoTrans;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(101, 100);
            this.pictureBoxLogo.TabIndex = 35;
            this.pictureBoxLogo.TabStop = false;
            // 
            // dataGridViewHunter
            // 
            this.dataGridViewHunter.AllowUserToAddRows = false;
            this.dataGridViewHunter.AllowUserToDeleteRows = false;
            this.dataGridViewHunter.AllowUserToOrderColumns = true;
            this.dataGridViewHunter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHunter.Location = new System.Drawing.Point(26, 205);
            this.dataGridViewHunter.Name = "dataGridViewHunter";
            this.dataGridViewHunter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewHunter.RowHeadersWidth = 51;
            this.dataGridViewHunter.RowTemplate.Height = 29;
            this.dataGridViewHunter.Size = new System.Drawing.Size(658, 363);
            this.dataGridViewHunter.TabIndex = 44;
            // 
            // buttonViewHunterAll
            // 
            this.buttonViewHunterAll.Location = new System.Drawing.Point(393, 156);
            this.buttonViewHunterAll.Name = "buttonViewHunterAll";
            this.buttonViewHunterAll.Size = new System.Drawing.Size(98, 29);
            this.buttonViewHunterAll.TabIndex = 48;
            this.buttonViewHunterAll.Text = "View All";
            this.buttonViewHunterAll.UseVisualStyleBackColor = true;
            this.buttonViewHunterAll.Click += new System.EventHandler(this.buttonViewHunterAll_Click);
            // 
            // buttonViewHunter
            // 
            this.buttonViewHunter.Location = new System.Drawing.Point(289, 156);
            this.buttonViewHunter.Name = "buttonViewHunter";
            this.buttonViewHunter.Size = new System.Drawing.Size(98, 29);
            this.buttonViewHunter.TabIndex = 47;
            this.buttonViewHunter.Text = "View";
            this.buttonViewHunter.UseVisualStyleBackColor = true;
            this.buttonViewHunter.Click += new System.EventHandler(this.buttonViewHunter_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelUsername.Location = new System.Drawing.Point(25, 149);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(104, 34);
            this.labelUsername.TabIndex = 46;
            this.labelUsername.Text = "Username :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(136, 156);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(147, 27);
            this.textBoxUsername.TabIndex = 45;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(25, 581);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 34);
            this.labelWarning.TabIndex = 49;
            // 
            // HuntApprovedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(717, 636);
            this.ControlBox = false;
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonViewHunterAll);
            this.Controls.Add(this.buttonViewHunter);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.dataGridViewHunter);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelApprovedHunter);
            this.Controls.Add(this.buttonClose);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HuntApprovedView";
            this.Text = "Hunt Approved View";
            this.Load += new System.EventHandler(this.HuntApprovedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHunter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private Label labelApprovedHunter;
        private PictureBox pictureBoxLogo;
        private DataGridView dataGridViewHunter;
        private Button buttonViewHunterAll;
        private Button buttonViewHunter;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label labelWarning;
    }
}