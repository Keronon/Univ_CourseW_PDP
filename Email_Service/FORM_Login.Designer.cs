namespace Email_Service
{
    partial class FORM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_Login));
            this.BTN_ok = new System.Windows.Forms.Button();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.TXT_email = new System.Windows.Forms.TextBox();
            this.TIP_fast = new System.Windows.Forms.ToolTip(this.components);
            this.TXT_password = new System.Windows.Forms.TextBox();
            this.CHECK_remember = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ok
            // 
            this.BTN_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ok.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_ok.Location = new System.Drawing.Point(143, 201);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.Size = new System.Drawing.Size(75, 30);
            this.BTN_ok.TabIndex = 0;
            this.BTN_ok.Text = "Войти";
            this.BTN_ok.UseVisualStyleBackColor = true;
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_cancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.BTN_cancel.Location = new System.Drawing.Point(12, 201);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(75, 30);
            this.BTN_cancel.TabIndex = 1;
            this.BTN_cancel.Text = "Отмена";
            this.BTN_cancel.UseVisualStyleBackColor = true;
            // 
            // TXT_email
            // 
            this.TXT_email.Location = new System.Drawing.Point(12, 118);
            this.TXT_email.Name = "TXT_email";
            this.TXT_email.Size = new System.Drawing.Size(206, 23);
            this.TXT_email.TabIndex = 4;
            this.TIP_fast.SetToolTip(this.TXT_email, "Почта");
            // 
            // TIP_fast
            // 
            this.TIP_fast.AutomaticDelay = 100;
            // 
            // TXT_password
            // 
            this.TXT_password.Location = new System.Drawing.Point(12, 147);
            this.TXT_password.Name = "TXT_password";
            this.TXT_password.PasswordChar = '*';
            this.TXT_password.Size = new System.Drawing.Size(206, 23);
            this.TXT_password.TabIndex = 5;
            this.TIP_fast.SetToolTip(this.TXT_password, "Пароль");
            // 
            // CHECK_remember
            // 
            this.CHECK_remember.AutoSize = true;
            this.CHECK_remember.Location = new System.Drawing.Point(12, 176);
            this.CHECK_remember.Name = "CHECK_remember";
            this.CHECK_remember.Size = new System.Drawing.Size(145, 19);
            this.CHECK_remember.TabIndex = 6;
            this.CHECK_remember.Text = "Запомнить профиль";
            this.CHECK_remember.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Email_Service.Properties.Resources.img_user;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FORM_Login
            // 
            this.AcceptButton = this.BTN_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_cancel;
            this.ClientSize = new System.Drawing.Size(230, 243);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CHECK_remember);
            this.Controls.Add(this.TXT_password);
            this.Controls.Add(this.TXT_email);
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.BTN_ok);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FORM_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вход в профиль";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ok;
        private System.Windows.Forms.Button BTN_cancel;
        private System.Windows.Forms.TextBox TXT_email;
        private System.Windows.Forms.ToolTip TIP_fast;
        private System.Windows.Forms.TextBox TXT_password;
        private System.Windows.Forms.CheckBox CHECK_remember;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}