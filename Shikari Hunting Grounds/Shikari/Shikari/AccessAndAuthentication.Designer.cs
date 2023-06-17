namespace Shikari
{
    partial class AccessAndAuthentication
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
            this.labelAAA = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonUpdateAAA = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.comboBoxProperty = new System.Windows.Forms.ComboBox();
            this.labelProperty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewValue = new System.Windows.Forms.TextBox();
            this.dataGridViewAAA = new System.Windows.Forms.DataGridView();
            this.buttonViewAAAAll = new System.Windows.Forms.Button();
            this.buttonViewAAA = new System.Windows.Forms.Button();
            this.labelAdminPass = new System.Windows.Forms.Label();
            this.textBoxAdminPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonClose.Location = new System.Drawing.Point(630, 12);
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
            // labelAAA
            // 
            this.labelAAA.AutoSize = true;
            this.labelAAA.BackColor = System.Drawing.Color.Transparent;
            this.labelAAA.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAAA.Location = new System.Drawing.Point(166, 43);
            this.labelAAA.Name = "labelAAA";
            this.labelAAA.Size = new System.Drawing.Size(405, 55);
            this.labelAAA.TabIndex = 32;
            this.labelAAA.Text = "[Access and Authentication]";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(190, 174);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(444, 27);
            this.textBoxUsername.TabIndex = 34;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelUsername.Location = new System.Drawing.Point(12, 167);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(169, 34);
            this.labelUsername.TabIndex = 35;
            this.labelUsername.Text = "Username              :";
            // 
            // buttonUpdateAAA
            // 
            this.buttonUpdateAAA.Location = new System.Drawing.Point(548, 318);
            this.buttonUpdateAAA.Name = "buttonUpdateAAA";
            this.buttonUpdateAAA.Size = new System.Drawing.Size(86, 36);
            this.buttonUpdateAAA.TabIndex = 36;
            this.buttonUpdateAAA.Text = "Update";
            this.buttonUpdateAAA.UseVisualStyleBackColor = true;
            this.buttonUpdateAAA.Click += new System.EventHandler(this.buttonUpdateAAA_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(12, 365);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 34);
            this.labelWarning.TabIndex = 38;
            // 
            // comboBoxProperty
            // 
            this.comboBoxProperty.FormattingEnabled = true;
            this.comboBoxProperty.Items.AddRange(new object[] {
            "Password",
            "PassHint"});
            this.comboBoxProperty.Location = new System.Drawing.Point(190, 211);
            this.comboBoxProperty.Name = "comboBoxProperty";
            this.comboBoxProperty.Size = new System.Drawing.Size(444, 28);
            this.comboBoxProperty.TabIndex = 39;
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.BackColor = System.Drawing.Color.Transparent;
            this.labelProperty.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelProperty.Location = new System.Drawing.Point(12, 205);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(169, 34);
            this.labelProperty.TabIndex = 40;
            this.labelProperty.Text = "Property                :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 34);
            this.label1.TabIndex = 41;
            this.label1.Text = "New Value             :";
            // 
            // textBoxNewValue
            // 
            this.textBoxNewValue.Location = new System.Drawing.Point(190, 248);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(444, 27);
            this.textBoxNewValue.TabIndex = 42;
            // 
            // dataGridViewAAA
            // 
            this.dataGridViewAAA.AllowUserToAddRows = false;
            this.dataGridViewAAA.AllowUserToDeleteRows = false;
            this.dataGridViewAAA.AllowUserToOrderColumns = true;
            this.dataGridViewAAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAAA.Location = new System.Drawing.Point(12, 420);
            this.dataGridViewAAA.Name = "dataGridViewAAA";
            this.dataGridViewAAA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewAAA.RowHeadersWidth = 51;
            this.dataGridViewAAA.RowTemplate.Height = 29;
            this.dataGridViewAAA.Size = new System.Drawing.Size(658, 241);
            this.dataGridViewAAA.TabIndex = 43;
            // 
            // buttonViewAAAAll
            // 
            this.buttonViewAAAAll.Location = new System.Drawing.Point(366, 318);
            this.buttonViewAAAAll.Name = "buttonViewAAAAll";
            this.buttonViewAAAAll.Size = new System.Drawing.Size(98, 36);
            this.buttonViewAAAAll.TabIndex = 45;
            this.buttonViewAAAAll.Text = "View All";
            this.buttonViewAAAAll.UseVisualStyleBackColor = true;
            this.buttonViewAAAAll.Click += new System.EventHandler(this.buttonViewAAAAll_Click);
            // 
            // buttonViewAAA
            // 
            this.buttonViewAAA.Location = new System.Drawing.Point(190, 318);
            this.buttonViewAAA.Name = "buttonViewAAA";
            this.buttonViewAAA.Size = new System.Drawing.Size(98, 36);
            this.buttonViewAAA.TabIndex = 44;
            this.buttonViewAAA.Text = "View";
            this.buttonViewAAA.UseVisualStyleBackColor = true;
            this.buttonViewAAA.Click += new System.EventHandler(this.buttonViewAAA_Click);
            // 
            // labelAdminPass
            // 
            this.labelAdminPass.AutoSize = true;
            this.labelAdminPass.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminPass.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelAdminPass.Location = new System.Drawing.Point(12, 281);
            this.labelAdminPass.Name = "labelAdminPass";
            this.labelAdminPass.Size = new System.Drawing.Size(173, 34);
            this.labelAdminPass.TabIndex = 46;
            this.labelAdminPass.Text = "Admin Password    :";
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Location = new System.Drawing.Point(190, 285);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.PasswordChar = '*';
            this.textBoxAdminPass.Size = new System.Drawing.Size(444, 27);
            this.textBoxAdminPass.TabIndex = 47;
            // 
            // AccessAndAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(682, 673);
            this.Controls.Add(this.textBoxAdminPass);
            this.Controls.Add(this.labelAdminPass);
            this.Controls.Add(this.buttonViewAAAAll);
            this.Controls.Add(this.buttonViewAAA);
            this.Controls.Add(this.dataGridViewAAA);
            this.Controls.Add(this.textBoxNewValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProperty);
            this.Controls.Add(this.comboBoxProperty);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonUpdateAAA);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelAAA);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "AccessAndAuthentication";
            this.Text = "Access and Authentication";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelAAA;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Button buttonUpdateAAA;
        private Label labelWarning;
        private ComboBox comboBoxProperty;
        private Label labelProperty;
        private Label label1;
        private TextBox textBoxNewValue;
        private DataGridView dataGridViewAAA;
        private Button buttonViewAAAAll;
        private Button buttonViewAAA;
        private Label labelAdminPass;
        private TextBox textBoxAdminPass;
    }
}