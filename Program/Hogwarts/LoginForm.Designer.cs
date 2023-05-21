namespace Hogwarts
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.IntroTimer = new System.Timers.Timer();
            this.LoadingFormPanel = new System.Windows.Forms.Panel();
            this.NotFoundLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ESCNotify = new System.Windows.Forms.Label();
            this.ESCNotifyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IntroTimer)).BeginInit();
            this.LoadingFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntroTimer
            // 
            this.IntroTimer.Interval = 10D;
            this.IntroTimer.SynchronizingObject = this;
            this.IntroTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // LoadingFormPanel
            // 
            this.LoadingFormPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingFormPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadingFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoadingFormPanel.Controls.Add(this.NotFoundLabel);
            this.LoadingFormPanel.Controls.Add(this.LoginBtn);
            this.LoadingFormPanel.Controls.Add(this.PasswordTextBox);
            this.LoadingFormPanel.Controls.Add(this.PasswordLabel);
            this.LoadingFormPanel.Controls.Add(this.UserNameTextBox);
            this.LoadingFormPanel.Controls.Add(this.UserNameLabel);
            this.LoadingFormPanel.Location = new System.Drawing.Point(323, 86);
            this.LoadingFormPanel.Name = "LoadingFormPanel";
            this.LoadingFormPanel.Size = new System.Drawing.Size(332, 362);
            this.LoadingFormPanel.TabIndex = 0;
            // 
            // NotFoundLabel
            // 
            this.NotFoundLabel.AutoSize = true;
            this.NotFoundLabel.Location = new System.Drawing.Point(37, 210);
            this.NotFoundLabel.Name = "NotFoundLabel";
            this.NotFoundLabel.Size = new System.Drawing.Size(0, 20);
            this.NotFoundLabel.TabIndex = 5;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.LoginBtn.Location = new System.Drawing.Point(37, 245);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(258, 43);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.PasswordTextBox.Location = new System.Drawing.Point(37, 166);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(259, 25);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.PasswordLabel.Location = new System.Drawing.Point(36, 135);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(259, 28);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTextBox.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserNameTextBox.Location = new System.Drawing.Point(37, 93);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(259, 25);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.UserNameLabel.Location = new System.Drawing.Point(37, 65);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(260, 25);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "UserName";
            // 
            // ESCNotify
            // 
            this.ESCNotify.AutoSize = true;
            this.ESCNotify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ESCNotify.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.ESCNotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ESCNotify.Location = new System.Drawing.Point(11, 11);
            this.ESCNotify.Name = "ESCNotify";
            this.ESCNotify.Size = new System.Drawing.Size(129, 17);
            this.ESCNotify.TabIndex = 1;
            this.ESCNotify.Text = "Press ESC to Exit";
            // 
            // ESCNotifyTimer
            // 
            this.ESCNotifyTimer.Interval = 2;
            this.ESCNotifyTimer.Tick += new System.EventHandler(this.ESCNotifyTimer_Tick);
            // 
            // LoginForm
            // 
            this.AccessibleName = "Hogwarts";
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(990, 567);
            this.ControlBox = false;
            this.Controls.Add(this.ESCNotify);
            this.Controls.Add(this.LoadingFormPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "LoginForm";
            this.Opacity = 0D;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.IntroTimer)).EndInit();
            this.LoadingFormPanel.ResumeLayout(false);
            this.LoadingFormPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button LoginBtn;

        private System.Windows.Forms.Label PasswordLabel;

        private System.Windows.Forms.TextBox PasswordTextBox;

        private System.Windows.Forms.Panel LoadingFormPanel;

        public System.Timers.Timer IntroTimer;

        #endregion

        public System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label NotFoundLabel;
        private System.Windows.Forms.Label ESCNotify;
        private System.Windows.Forms.Timer ESCNotifyTimer;
    }
}