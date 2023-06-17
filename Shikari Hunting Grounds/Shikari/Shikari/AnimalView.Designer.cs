namespace Shikari
{
    partial class AnimalView
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
            this.labelViewAnimal = new System.Windows.Forms.Label();
            this.dataGridViewAnimal = new System.Windows.Forms.DataGridView();
            this.textBoxAnimalName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonViewAnimal = new System.Windows.Forms.Button();
            this.buttonViewAnimalAll = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).BeginInit();
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
            // labelViewAnimal
            // 
            this.labelViewAnimal.AutoSize = true;
            this.labelViewAnimal.BackColor = System.Drawing.Color.Transparent;
            this.labelViewAnimal.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelViewAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelViewAnimal.Location = new System.Drawing.Point(179, 34);
            this.labelViewAnimal.Name = "labelViewAnimal";
            this.labelViewAnimal.Size = new System.Drawing.Size(213, 55);
            this.labelViewAnimal.TabIndex = 32;
            this.labelViewAnimal.Text = "[View Animal]";
            // 
            // dataGridViewAnimal
            // 
            this.dataGridViewAnimal.AllowUserToAddRows = false;
            this.dataGridViewAnimal.AllowUserToDeleteRows = false;
            this.dataGridViewAnimal.AllowUserToOrderColumns = true;
            this.dataGridViewAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimal.Location = new System.Drawing.Point(12, 201);
            this.dataGridViewAnimal.Name = "dataGridViewAnimal";
            this.dataGridViewAnimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewAnimal.RowHeadersWidth = 51;
            this.dataGridViewAnimal.RowTemplate.Height = 29;
            this.dataGridViewAnimal.Size = new System.Drawing.Size(1158, 336);
            this.dataGridViewAnimal.TabIndex = 33;
            // 
            // textBoxAnimalName
            // 
            this.textBoxAnimalName.Location = new System.Drawing.Point(92, 155);
            this.textBoxAnimalName.Name = "textBoxAnimalName";
            this.textBoxAnimalName.Size = new System.Drawing.Size(177, 27);
            this.textBoxAnimalName.TabIndex = 34;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelName.Location = new System.Drawing.Point(12, 151);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 34);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Name :";
            // 
            // buttonViewAnimal
            // 
            this.buttonViewAnimal.Location = new System.Drawing.Point(275, 154);
            this.buttonViewAnimal.Name = "buttonViewAnimal";
            this.buttonViewAnimal.Size = new System.Drawing.Size(98, 29);
            this.buttonViewAnimal.TabIndex = 36;
            this.buttonViewAnimal.Text = "View";
            this.buttonViewAnimal.UseVisualStyleBackColor = true;
            this.buttonViewAnimal.Click += new System.EventHandler(this.buttonViewAnimal_Click);
            // 
            // buttonViewAnimalAll
            // 
            this.buttonViewAnimalAll.Location = new System.Drawing.Point(379, 153);
            this.buttonViewAnimalAll.Name = "buttonViewAnimalAll";
            this.buttonViewAnimalAll.Size = new System.Drawing.Size(98, 30);
            this.buttonViewAnimalAll.TabIndex = 37;
            this.buttonViewAnimalAll.Text = "View All";
            this.buttonViewAnimalAll.UseVisualStyleBackColor = true;
            this.buttonViewAnimalAll.Click += new System.EventHandler(this.buttonViewAnimalAll_Click);
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
            // AnimalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonViewAnimalAll);
            this.Controls.Add(this.buttonViewAnimal);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAnimalName);
            this.Controls.Add(this.labelViewAnimal);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.dataGridViewAnimal);
            this.Name = "AnimalView";
            this.Text = "View Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelViewAnimal;
        private DataGridView dataGridViewAnimal;
        private TextBox textBoxAnimalName;
        private Label labelName;
        private Button buttonViewAnimal;
        private Button buttonViewAnimalAll;
        private Label labelWarning;
    }
}