namespace Hogwarts
{
    partial class ChooseRoleMsgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseRoleMsgForm));
            this.OkRoleButton = new System.Windows.Forms.Button();
            this.WhoLabel = new System.Windows.Forms.Label();
            this.StudentRadio = new System.Windows.Forms.RadioButton();
            this.TeacherRadio = new System.Windows.Forms.RadioButton();
            this.DumbledoreRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OkRoleButton
            // 
            this.OkRoleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.OkRoleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OkRoleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkRoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkRoleButton.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkRoleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(166)))), ((int)(((byte)(37)))));
            this.OkRoleButton.Location = new System.Drawing.Point(119, 109);
            this.OkRoleButton.Name = "OkRoleButton";
            this.OkRoleButton.Size = new System.Drawing.Size(83, 39);
            this.OkRoleButton.TabIndex = 0;
            this.OkRoleButton.Text = "Ok";
            this.OkRoleButton.UseVisualStyleBackColor = false;
            this.OkRoleButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // WhoLabel
            // 
            this.WhoLabel.AutoSize = true;
            this.WhoLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoLabel.Location = new System.Drawing.Point(82, 9);
            this.WhoLabel.Name = "WhoLabel";
            this.WhoLabel.Size = new System.Drawing.Size(149, 24);
            this.WhoLabel.TabIndex = 1;
            this.WhoLabel.Text = "Who You Are?";
            // 
            // StudentRadio
            // 
            this.StudentRadio.AutoSize = true;
            this.StudentRadio.Font = new System.Drawing.Font("Lucida Sans", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRadio.Location = new System.Drawing.Point(24, 72);
            this.StudentRadio.Name = "StudentRadio";
            this.StudentRadio.Size = new System.Drawing.Size(76, 19);
            this.StudentRadio.TabIndex = 2;
            this.StudentRadio.TabStop = true;
            this.StudentRadio.Text = "Student";
            this.StudentRadio.UseVisualStyleBackColor = true;
            // 
            // TeacherRadio
            // 
            this.TeacherRadio.AutoSize = true;
            this.TeacherRadio.Font = new System.Drawing.Font("Lucida Sans", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherRadio.Location = new System.Drawing.Point(117, 72);
            this.TeacherRadio.Name = "TeacherRadio";
            this.TeacherRadio.Size = new System.Drawing.Size(78, 19);
            this.TeacherRadio.TabIndex = 3;
            this.TeacherRadio.TabStop = true;
            this.TeacherRadio.Text = "Teacher";
            this.TeacherRadio.UseVisualStyleBackColor = true;
            // 
            // DumbledoreRadio
            // 
            this.DumbledoreRadio.AutoSize = true;
            this.DumbledoreRadio.Font = new System.Drawing.Font("Lucida Sans", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DumbledoreRadio.Location = new System.Drawing.Point(204, 72);
            this.DumbledoreRadio.Name = "DumbledoreRadio";
            this.DumbledoreRadio.Size = new System.Drawing.Size(104, 19);
            this.DumbledoreRadio.TabIndex = 4;
            this.DumbledoreRadio.TabStop = true;
            this.DumbledoreRadio.Text = "Dumbledore";
            this.DumbledoreRadio.UseVisualStyleBackColor = true;
            // 
            // ChooseRoleMsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(320, 160);
            this.Controls.Add(this.DumbledoreRadio);
            this.Controls.Add(this.TeacherRadio);
            this.Controls.Add(this.StudentRadio);
            this.Controls.Add(this.WhoLabel);
            this.Controls.Add(this.OkRoleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseRoleMsgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WhoLabel;
        private System.Windows.Forms.RadioButton StudentRadio;
        private System.Windows.Forms.RadioButton TeacherRadio;
        private System.Windows.Forms.RadioButton DumbledoreRadio;
        public System.Windows.Forms.Button OkRoleButton;
    }
}