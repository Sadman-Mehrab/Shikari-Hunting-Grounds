namespace Shikari
{
    partial class Account
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
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelRegisterHunter = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.addToBalanceLabel = new System.Windows.Forms.Label();
            this.labelExpend = new System.Windows.Forms.Label();
            this.textBoxAddToBalance = new System.Windows.Forms.TextBox();
            this.buttonAddToBalance = new System.Windows.Forms.Button();
            this.textBoxExpend = new System.Windows.Forms.TextBox();
            this.TextBoxCurrentBalance = new System.Windows.Forms.TextBox();
            this.buttonExpend = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonClose.Location = new System.Drawing.Point(527, 15);
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(101, 100);
            this.pictureBoxLogo.TabIndex = 30;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelRegisterHunter
            // 
            this.labelRegisterHunter.AutoSize = true;
            this.labelRegisterHunter.BackColor = System.Drawing.Color.Transparent;
            this.labelRegisterHunter.Font = new System.Drawing.Font("Dubai", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegisterHunter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelRegisterHunter.Location = new System.Drawing.Point(171, 33);
            this.labelRegisterHunter.Name = "labelRegisterHunter";
            this.labelRegisterHunter.Size = new System.Drawing.Size(259, 55);
            this.labelRegisterHunter.TabIndex = 33;
            this.labelRegisterHunter.Text = "[Shikari Account]";
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentBalance.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelCurrentBalance.Location = new System.Drawing.Point(33, 181);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(238, 51);
            this.labelCurrentBalance.TabIndex = 38;
            this.labelCurrentBalance.Text = "Current Balance  :";
            // 
            // addToBalanceLabel
            // 
            this.addToBalanceLabel.AutoSize = true;
            this.addToBalanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.addToBalanceLabel.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addToBalanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.addToBalanceLabel.Location = new System.Drawing.Point(31, 255);
            this.addToBalanceLabel.Name = "addToBalanceLabel";
            this.addToBalanceLabel.Size = new System.Drawing.Size(240, 51);
            this.addToBalanceLabel.TabIndex = 39;
            this.addToBalanceLabel.Text = "Add to Balance    :";
            // 
            // labelExpend
            // 
            this.labelExpend.AutoSize = true;
            this.labelExpend.BackColor = System.Drawing.Color.Transparent;
            this.labelExpend.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExpend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelExpend.Location = new System.Drawing.Point(33, 327);
            this.labelExpend.Name = "labelExpend";
            this.labelExpend.Size = new System.Drawing.Size(242, 51);
            this.labelExpend.TabIndex = 40;
            this.labelExpend.Text = "Expend                  :";
            // 
            // textBoxAddToBalance
            // 
            this.textBoxAddToBalance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddToBalance.Location = new System.Drawing.Point(280, 260);
            this.textBoxAddToBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddToBalance.Name = "textBoxAddToBalance";
            this.textBoxAddToBalance.Size = new System.Drawing.Size(150, 42);
            this.textBoxAddToBalance.TabIndex = 41;
            this.textBoxAddToBalance.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAddToBalance
            // 
            this.buttonAddToBalance.Location = new System.Drawing.Point(453, 260);
            this.buttonAddToBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddToBalance.Name = "buttonAddToBalance";
            this.buttonAddToBalance.Size = new System.Drawing.Size(86, 42);
            this.buttonAddToBalance.TabIndex = 42;
            this.buttonAddToBalance.Text = "Select";
            this.buttonAddToBalance.UseVisualStyleBackColor = true;
            this.buttonAddToBalance.Click += new System.EventHandler(this.buttonAddToBalance_Click);
            // 
            // textBoxExpend
            // 
            this.textBoxExpend.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExpend.Location = new System.Drawing.Point(280, 329);
            this.textBoxExpend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxExpend.Name = "textBoxExpend";
            this.textBoxExpend.Size = new System.Drawing.Size(150, 42);
            this.textBoxExpend.TabIndex = 43;
            this.textBoxExpend.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBoxCurrentBalance
            // 
            this.TextBoxCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxCurrentBalance.Location = new System.Drawing.Point(280, 190);
            this.TextBoxCurrentBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxCurrentBalance.Name = "TextBoxCurrentBalance";
            this.TextBoxCurrentBalance.Size = new System.Drawing.Size(150, 42);
            this.TextBoxCurrentBalance.TabIndex = 44;
            // 
            // buttonExpend
            // 
            this.buttonExpend.Location = new System.Drawing.Point(453, 331);
            this.buttonExpend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExpend.Name = "buttonExpend";
            this.buttonExpend.Size = new System.Drawing.Size(86, 42);
            this.buttonExpend.TabIndex = 45;
            this.buttonExpend.Text = "Select";
            this.buttonExpend.UseVisualStyleBackColor = true;
            this.buttonExpend.Click += new System.EventHandler(this.buttonExpend_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Brown;
            this.labelWarning.Location = new System.Drawing.Point(14, 406);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(76, 32);
            this.labelWarning.TabIndex = 46;
            this.labelWarning.Text = "warning";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(177)))), ((int)(((byte)(120)))));
            this.labelTime.Location = new System.Drawing.Point(14, 469);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(57, 25);
            this.labelTime.TabIndex = 47;
            this.labelTime.Text = "Time - ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shikari.Properties.Resources.BackgroundFill;
            this.ClientSize = new System.Drawing.Size(581, 509);
            this.ControlBox = false;
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonExpend);
            this.Controls.Add(this.TextBoxCurrentBalance);
            this.Controls.Add(this.textBoxExpend);
            this.Controls.Add(this.buttonAddToBalance);
            this.Controls.Add(this.textBoxAddToBalance);
            this.Controls.Add(this.labelExpend);
            this.Controls.Add(this.addToBalanceLabel);
            this.Controls.Add(this.labelCurrentBalance);
            this.Controls.Add(this.labelRegisterHunter);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonClose);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private PictureBox pictureBoxLogo;
        private Label labelRegisterHunter;
        private Label labelCurrentBalance;
        private Label addToBalanceLabel;
        private Label labelExpend;
        private TextBox textBoxAddToBalance;
        private Button buttonAddToBalance;
        private TextBox textBoxExpend;
        private TextBox TextBoxCurrentBalance;
        private Button buttonExpend;
        private Label labelWarning;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}