namespace PurgeMyDiscord
{
    partial class MainForm
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
            this.tokenTbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userCbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messagesNum = new System.Windows.Forms.NumericUpDown();
            this.purgeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.messagesNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tokenTbox
            // 
            this.tokenTbox.Location = new System.Drawing.Point(76, 12);
            this.tokenTbox.Name = "tokenTbox";
            this.tokenTbox.Size = new System.Drawing.Size(250, 20);
            this.tokenTbox.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(332, 11);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 22);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Token:";
            // 
            // userCbox
            // 
            this.userCbox.FormattingEnabled = true;
            this.userCbox.Location = new System.Drawing.Point(76, 38);
            this.userCbox.Name = "userCbox";
            this.userCbox.Size = new System.Drawing.Size(250, 21);
            this.userCbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // messagesNum
            // 
            this.messagesNum.Location = new System.Drawing.Point(76, 65);
            this.messagesNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.messagesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.messagesNum.Name = "messagesNum";
            this.messagesNum.Size = new System.Drawing.Size(250, 20);
            this.messagesNum.TabIndex = 5;
            this.messagesNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // purgeBtn
            // 
            this.purgeBtn.Location = new System.Drawing.Point(332, 64);
            this.purgeBtn.Name = "purgeBtn";
            this.purgeBtn.Size = new System.Drawing.Size(75, 22);
            this.purgeBtn.TabIndex = 6;
            this.purgeBtn.Text = "Purge";
            this.purgeBtn.UseVisualStyleBackColor = true;
            this.purgeBtn.Click += new System.EventHandler(this.purgeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Messages:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(76, 91);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(250, 12);
            this.progressBar.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 115);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purgeBtn);
            this.Controls.Add(this.messagesNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userCbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.tokenTbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurgeMyDiscord by Zaczero";
            ((System.ComponentModel.ISupportInitialize)(this.messagesNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tokenTbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userCbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown messagesNum;
        private System.Windows.Forms.Button purgeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

