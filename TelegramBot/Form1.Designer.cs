namespace TelegramBot
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputApiToken = new System.Windows.Forms.TextBox();
            this.inputUserId = new System.Windows.Forms.TextBox();
            this.inputBotName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.appLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bot name:";
            // 
            // inputApiToken
            // 
            this.inputApiToken.Location = new System.Drawing.Point(96, 10);
            this.inputApiToken.Name = "inputApiToken";
            this.inputApiToken.Size = new System.Drawing.Size(176, 20);
            this.inputApiToken.TabIndex = 3;
            // 
            // inputUserId
            // 
            this.inputUserId.Location = new System.Drawing.Point(96, 36);
            this.inputUserId.Name = "inputUserId";
            this.inputUserId.Size = new System.Drawing.Size(176, 20);
            this.inputUserId.TabIndex = 4;
            // 
            // inputBotName
            // 
            this.inputBotName.Location = new System.Drawing.Point(96, 62);
            this.inputBotName.Name = "inputBotName";
            this.inputBotName.ReadOnly = true;
            this.inputBotName.Size = new System.Drawing.Size(176, 20);
            this.inputBotName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // appLog
            // 
            this.appLog.FormattingEnabled = true;
            this.appLog.Location = new System.Drawing.Point(19, 119);
            this.appLog.Name = "appLog";
            this.appLog.Size = new System.Drawing.Size(241, 264);
            this.appLog.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.appLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputBotName);
            this.Controls.Add(this.inputUserId);
            this.Controls.Add(this.inputApiToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputApiToken;
        private System.Windows.Forms.TextBox inputUserId;
        private System.Windows.Forms.TextBox inputBotName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox appLog;
    }
}

