namespace Email_Service
{
    partial class FORM_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_Main));
            this.SPLIT_container = new System.Windows.Forms.SplitContainer();
            this.BTN_new_chain = new System.Windows.Forms.Button();
            this.FLOW_PANEL_chains = new System.Windows.Forms.FlowLayoutPanel();
            this.PIC_avatar = new System.Windows.Forms.PictureBox();
            this.CONTEXT_MENU_account = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MENU_ITEM_update = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_ITEM_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.LIST_appended = new System.Windows.Forms.ListBox();
            this.TEXT_message = new System.Windows.Forms.RichTextBox();
            this.STRIP_mail_line = new System.Windows.Forms.MenuStrip();
            this.MENU_ITEM_send = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_ITEM_append = new System.Windows.Forms.ToolStripMenuItem();
            this.CONTEXT_MENU_login = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MENU_ITEM_login = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_ITEM_email = new System.Windows.Forms.ToolStripTextBox();
            this.MENU_ITEM_password = new System.Windows.Forms.ToolStripTextBox();
            this.MENU_ITEM_apply = new System.Windows.Forms.ToolStripMenuItem();
            this.NOTIFY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
            this.MENU_ITEM_profile = new System.Windows.Forms.ToolStripComboBox();
            this.MENU_ITEM_remember = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL_from = new System.Windows.Forms.Label();
            this.TXT_from = new System.Windows.Forms.TextBox();
            this.TXT_to = new System.Windows.Forms.TextBox();
            this.LBL_to = new System.Windows.Forms.Label();
            this.TXT_topic = new System.Windows.Forms.TextBox();
            this.LBL_topic = new System.Windows.Forms.Label();
            this.CHECK_b = new System.Windows.Forms.CheckBox();
            this.CHECK_i = new System.Windows.Forms.CheckBox();
            this.CHECK_u = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SPLIT_container)).BeginInit();
            this.SPLIT_container.Panel1.SuspendLayout();
            this.SPLIT_container.Panel2.SuspendLayout();
            this.SPLIT_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_avatar)).BeginInit();
            this.CONTEXT_MENU_account.SuspendLayout();
            this.STRIP_mail_line.SuspendLayout();
            this.CONTEXT_MENU_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLIT_container
            // 
            this.SPLIT_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SPLIT_container.Location = new System.Drawing.Point(0, 0);
            this.SPLIT_container.Name = "SPLIT_container";
            // 
            // SPLIT_container.Panel1
            // 
            this.SPLIT_container.Panel1.Controls.Add(this.BTN_new_chain);
            this.SPLIT_container.Panel1.Controls.Add(this.FLOW_PANEL_chains);
            this.SPLIT_container.Panel1.Controls.Add(this.PIC_avatar);
            this.SPLIT_container.Panel1MinSize = 200;
            // 
            // SPLIT_container.Panel2
            // 
            this.SPLIT_container.Panel2.Controls.Add(this.CHECK_u);
            this.SPLIT_container.Panel2.Controls.Add(this.CHECK_i);
            this.SPLIT_container.Panel2.Controls.Add(this.CHECK_b);
            this.SPLIT_container.Panel2.Controls.Add(this.TXT_topic);
            this.SPLIT_container.Panel2.Controls.Add(this.LBL_topic);
            this.SPLIT_container.Panel2.Controls.Add(this.TXT_to);
            this.SPLIT_container.Panel2.Controls.Add(this.LBL_to);
            this.SPLIT_container.Panel2.Controls.Add(this.TXT_from);
            this.SPLIT_container.Panel2.Controls.Add(this.LBL_from);
            this.SPLIT_container.Panel2.Controls.Add(this.LIST_appended);
            this.SPLIT_container.Panel2.Controls.Add(this.TEXT_message);
            this.SPLIT_container.Panel2.Controls.Add(this.STRIP_mail_line);
            this.SPLIT_container.Panel2MinSize = 400;
            this.SPLIT_container.Size = new System.Drawing.Size(884, 561);
            this.SPLIT_container.SplitterDistance = 300;
            this.SPLIT_container.SplitterWidth = 1;
            this.SPLIT_container.TabIndex = 0;
            // 
            // BTN_new_chain
            // 
            this.BTN_new_chain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_new_chain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_new_chain.Image = global::Email_Service.Properties.Resources.add;
            this.BTN_new_chain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_new_chain.Location = new System.Drawing.Point(0, 96);
            this.BTN_new_chain.Name = "BTN_new_chain";
            this.BTN_new_chain.Size = new System.Drawing.Size(300, 35);
            this.BTN_new_chain.TabIndex = 2;
            this.BTN_new_chain.Text = "Новая цепочка писем";
            this.BTN_new_chain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_new_chain.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTN_new_chain.UseVisualStyleBackColor = true;
            // 
            // FLOW_PANEL_chains
            // 
            this.FLOW_PANEL_chains.AutoScroll = true;
            this.FLOW_PANEL_chains.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLOW_PANEL_chains.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FLOW_PANEL_chains.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLOW_PANEL_chains.Location = new System.Drawing.Point(0, 131);
            this.FLOW_PANEL_chains.Name = "FLOW_PANEL_chains";
            this.FLOW_PANEL_chains.Size = new System.Drawing.Size(300, 430);
            this.FLOW_PANEL_chains.TabIndex = 1;
            // 
            // PIC_avatar
            // 
            this.PIC_avatar.BackColor = System.Drawing.Color.LightCyan;
            this.PIC_avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIC_avatar.ContextMenuStrip = this.CONTEXT_MENU_account;
            this.PIC_avatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PIC_avatar.Image = global::Email_Service.Properties.Resources.user;
            this.PIC_avatar.Location = new System.Drawing.Point(0, 0);
            this.PIC_avatar.Name = "PIC_avatar";
            this.PIC_avatar.Size = new System.Drawing.Size(300, 96);
            this.PIC_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_avatar.TabIndex = 0;
            this.PIC_avatar.TabStop = false;
            this.PIC_avatar.MouseEnter += new System.EventHandler(this.PIC_avatar_MouseEnter);
            this.PIC_avatar.MouseLeave += new System.EventHandler(this.PIC_avatar_MouseLeave);
            // 
            // CONTEXT_MENU_account
            // 
            this.CONTEXT_MENU_account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_ITEM_profile,
            this.MENU_ITEM_update,
            this.MENU_ITEM_logout});
            this.CONTEXT_MENU_account.Name = "CONTEXT_MENU_account";
            this.CONTEXT_MENU_account.Size = new System.Drawing.Size(241, 75);
            // 
            // MENU_ITEM_update
            // 
            this.MENU_ITEM_update.ForeColor = System.Drawing.Color.DarkBlue;
            this.MENU_ITEM_update.Image = global::Email_Service.Properties.Resources.update;
            this.MENU_ITEM_update.Name = "MENU_ITEM_update";
            this.MENU_ITEM_update.Size = new System.Drawing.Size(240, 22);
            this.MENU_ITEM_update.Text = "Обновить почту";
            // 
            // MENU_ITEM_logout
            // 
            this.MENU_ITEM_logout.ForeColor = System.Drawing.Color.DarkRed;
            this.MENU_ITEM_logout.Image = global::Email_Service.Properties.Resources.logout;
            this.MENU_ITEM_logout.Name = "MENU_ITEM_logout";
            this.MENU_ITEM_logout.Size = new System.Drawing.Size(240, 22);
            this.MENU_ITEM_logout.Text = "Выйти из профиля";
            // 
            // LIST_appended
            // 
            this.LIST_appended.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LIST_appended.ForeColor = System.Drawing.Color.DarkBlue;
            this.LIST_appended.FormattingEnabled = true;
            this.LIST_appended.ItemHeight = 15;
            this.LIST_appended.Location = new System.Drawing.Point(3, 422);
            this.LIST_appended.Name = "LIST_appended";
            this.LIST_appended.Size = new System.Drawing.Size(577, 107);
            this.LIST_appended.TabIndex = 1;
            // 
            // TEXT_message
            // 
            this.TEXT_message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXT_message.Location = new System.Drawing.Point(3, 121);
            this.TEXT_message.Name = "TEXT_message";
            this.TEXT_message.Size = new System.Drawing.Size(577, 295);
            this.TEXT_message.TabIndex = 0;
            this.TEXT_message.Text = "";
            // 
            // STRIP_mail_line
            // 
            this.STRIP_mail_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.STRIP_mail_line.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STRIP_mail_line.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_ITEM_send,
            this.MENU_ITEM_append});
            this.STRIP_mail_line.Location = new System.Drawing.Point(0, 532);
            this.STRIP_mail_line.Name = "STRIP_mail_line";
            this.STRIP_mail_line.Size = new System.Drawing.Size(583, 29);
            this.STRIP_mail_line.TabIndex = 2;
            // 
            // MENU_ITEM_send
            // 
            this.MENU_ITEM_send.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MENU_ITEM_send.Image = global::Email_Service.Properties.Resources.mail;
            this.MENU_ITEM_send.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.MENU_ITEM_send.Name = "MENU_ITEM_send";
            this.MENU_ITEM_send.Size = new System.Drawing.Size(115, 25);
            this.MENU_ITEM_send.Text = "Отправить";
            this.MENU_ITEM_send.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // MENU_ITEM_append
            // 
            this.MENU_ITEM_append.Image = global::Email_Service.Properties.Resources.append;
            this.MENU_ITEM_append.Name = "MENU_ITEM_append";
            this.MENU_ITEM_append.Size = new System.Drawing.Size(125, 25);
            this.MENU_ITEM_append.Text = "Прикрепить";
            // 
            // CONTEXT_MENU_login
            // 
            this.CONTEXT_MENU_login.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_ITEM_login});
            this.CONTEXT_MENU_login.Name = "CONTEXT_MENU_login";
            this.CONTEXT_MENU_login.Size = new System.Drawing.Size(170, 26);
            // 
            // MENU_ITEM_login
            // 
            this.MENU_ITEM_login.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_ITEM_email,
            this.MENU_ITEM_password,
            this.MENU_ITEM_remember,
            this.MENU_ITEM_apply});
            this.MENU_ITEM_login.ForeColor = System.Drawing.Color.DarkGreen;
            this.MENU_ITEM_login.Image = global::Email_Service.Properties.Resources.login;
            this.MENU_ITEM_login.Name = "MENU_ITEM_login";
            this.MENU_ITEM_login.Size = new System.Drawing.Size(169, 22);
            this.MENU_ITEM_login.Text = "Войти в профиль";
            // 
            // MENU_ITEM_email
            // 
            this.MENU_ITEM_email.Name = "MENU_ITEM_email";
            this.MENU_ITEM_email.Size = new System.Drawing.Size(100, 23);
            // 
            // MENU_ITEM_password
            // 
            this.MENU_ITEM_password.Name = "MENU_ITEM_password";
            this.MENU_ITEM_password.Size = new System.Drawing.Size(100, 23);
            // 
            // MENU_ITEM_apply
            // 
            this.MENU_ITEM_apply.ForeColor = System.Drawing.Color.DarkGreen;
            this.MENU_ITEM_apply.Image = global::Email_Service.Properties.Resources.apply;
            this.MENU_ITEM_apply.Name = "MENU_ITEM_apply";
            this.MENU_ITEM_apply.Size = new System.Drawing.Size(180, 22);
            this.MENU_ITEM_apply.Text = "Авторизироваться";
            // 
            // NOTIFY_ICON
            // 
            this.NOTIFY_ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("NOTIFY_ICON.Icon")));
            this.NOTIFY_ICON.Text = "Email Service";
            this.NOTIFY_ICON.Visible = true;
            // 
            // MENU_ITEM_profile
            // 
            this.MENU_ITEM_profile.Name = "MENU_ITEM_profile";
            this.MENU_ITEM_profile.Size = new System.Drawing.Size(180, 23);
            this.MENU_ITEM_profile.Text = "current profile";
            // 
            // MENU_ITEM_remember
            // 
            this.MENU_ITEM_remember.CheckOnClick = true;
            this.MENU_ITEM_remember.ForeColor = System.Drawing.Color.DarkBlue;
            this.MENU_ITEM_remember.Name = "MENU_ITEM_remember";
            this.MENU_ITEM_remember.Size = new System.Drawing.Size(180, 22);
            this.MENU_ITEM_remember.Text = "Запомнить меня";
            // 
            // LBL_from
            // 
            this.LBL_from.AutoSize = true;
            this.LBL_from.Location = new System.Drawing.Point(3, 6);
            this.LBL_from.Name = "LBL_from";
            this.LBL_from.Size = new System.Drawing.Size(42, 15);
            this.LBL_from.TabIndex = 3;
            this.LBL_from.Text = "From:";
            // 
            // TXT_from
            // 
            this.TXT_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_from.Location = new System.Drawing.Point(51, 3);
            this.TXT_from.Name = "TXT_from";
            this.TXT_from.ReadOnly = true;
            this.TXT_from.Size = new System.Drawing.Size(529, 23);
            this.TXT_from.TabIndex = 4;
            // 
            // TXT_to
            // 
            this.TXT_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_to.Location = new System.Drawing.Point(51, 32);
            this.TXT_to.Name = "TXT_to";
            this.TXT_to.Size = new System.Drawing.Size(529, 23);
            this.TXT_to.TabIndex = 6;
            // 
            // LBL_to
            // 
            this.LBL_to.AutoSize = true;
            this.LBL_to.Location = new System.Drawing.Point(17, 35);
            this.LBL_to.Name = "LBL_to";
            this.LBL_to.Size = new System.Drawing.Size(28, 15);
            this.LBL_to.TabIndex = 5;
            this.LBL_to.Text = "To:";
            // 
            // TXT_topic
            // 
            this.TXT_topic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_topic.Location = new System.Drawing.Point(51, 61);
            this.TXT_topic.Name = "TXT_topic";
            this.TXT_topic.Size = new System.Drawing.Size(529, 23);
            this.TXT_topic.TabIndex = 8;
            // 
            // LBL_topic
            // 
            this.LBL_topic.AutoSize = true;
            this.LBL_topic.Location = new System.Drawing.Point(3, 64);
            this.LBL_topic.Name = "LBL_topic";
            this.LBL_topic.Size = new System.Drawing.Size(42, 15);
            this.LBL_topic.TabIndex = 7;
            this.LBL_topic.Text = "Тема:";
            // 
            // CHECK_b
            // 
            this.CHECK_b.Appearance = System.Windows.Forms.Appearance.Button;
            this.CHECK_b.AutoSize = true;
            this.CHECK_b.Location = new System.Drawing.Point(3, 90);
            this.CHECK_b.Name = "CHECK_b";
            this.CHECK_b.Size = new System.Drawing.Size(24, 25);
            this.CHECK_b.TabIndex = 10;
            this.CHECK_b.Text = "B";
            this.CHECK_b.UseVisualStyleBackColor = true;
            // 
            // CHECK_i
            // 
            this.CHECK_i.Appearance = System.Windows.Forms.Appearance.Button;
            this.CHECK_i.AutoSize = true;
            this.CHECK_i.Location = new System.Drawing.Point(33, 90);
            this.CHECK_i.Name = "CHECK_i";
            this.CHECK_i.Size = new System.Drawing.Size(24, 25);
            this.CHECK_i.TabIndex = 11;
            this.CHECK_i.Text = "i";
            this.CHECK_i.UseVisualStyleBackColor = true;
            // 
            // CHECK_u
            // 
            this.CHECK_u.Appearance = System.Windows.Forms.Appearance.Button;
            this.CHECK_u.AutoSize = true;
            this.CHECK_u.Location = new System.Drawing.Point(63, 90);
            this.CHECK_u.Name = "CHECK_u";
            this.CHECK_u.Size = new System.Drawing.Size(24, 25);
            this.CHECK_u.TabIndex = 12;
            this.CHECK_u.Text = "u";
            this.CHECK_u.UseVisualStyleBackColor = true;
            // 
            // FORM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.SPLIT_container);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.STRIP_mail_line;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FORM_Main";
            this.ShowInTaskbar = false;
            this.Text = "Email Service";
            this.SPLIT_container.Panel1.ResumeLayout(false);
            this.SPLIT_container.Panel2.ResumeLayout(false);
            this.SPLIT_container.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLIT_container)).EndInit();
            this.SPLIT_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_avatar)).EndInit();
            this.CONTEXT_MENU_account.ResumeLayout(false);
            this.STRIP_mail_line.ResumeLayout(false);
            this.STRIP_mail_line.PerformLayout();
            this.CONTEXT_MENU_login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLIT_container;
        private System.Windows.Forms.FlowLayoutPanel FLOW_PANEL_chains;
        private System.Windows.Forms.PictureBox PIC_avatar;
        private System.Windows.Forms.RichTextBox TEXT_message;
        private System.Windows.Forms.ContextMenuStrip CONTEXT_MENU_account;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_logout;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_update;
        private System.Windows.Forms.ContextMenuStrip CONTEXT_MENU_login;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_login;
        private System.Windows.Forms.ToolStripTextBox MENU_ITEM_email;
        private System.Windows.Forms.ToolStripTextBox MENU_ITEM_password;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_apply;
        private System.Windows.Forms.ListBox LIST_appended;
        private System.Windows.Forms.NotifyIcon NOTIFY_ICON;
        private System.Windows.Forms.Button BTN_new_chain;
        private System.Windows.Forms.MenuStrip STRIP_mail_line;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_send;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_append;
        private System.Windows.Forms.ToolStripComboBox MENU_ITEM_profile;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_remember;
        private System.Windows.Forms.TextBox TXT_topic;
        private System.Windows.Forms.Label LBL_topic;
        private System.Windows.Forms.TextBox TXT_to;
        private System.Windows.Forms.Label LBL_to;
        private System.Windows.Forms.TextBox TXT_from;
        private System.Windows.Forms.Label LBL_from;
        private System.Windows.Forms.CheckBox CHECK_u;
        private System.Windows.Forms.CheckBox CHECK_i;
        private System.Windows.Forms.CheckBox CHECK_b;
    }
}

