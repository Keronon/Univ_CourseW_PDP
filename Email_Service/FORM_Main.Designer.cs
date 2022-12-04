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
            this.FLOW_PANEL_chains = new System.Windows.Forms.FlowLayoutPanel();
            this.CONTEXT_MENU_account = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MENU_ITEM_name = new System.Windows.Forms.ToolStripMenuItem();
            this.TEXT_message = new System.Windows.Forms.RichTextBox();
            this.CONTEXT_MENU_login = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MENU_ITEM_login = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_ITEM_email = new System.Windows.Forms.ToolStripTextBox();
            this.MENU_ITEM_password = new System.Windows.Forms.ToolStripTextBox();
            this.MENU_ITEM_apply = new System.Windows.Forms.ToolStripMenuItem();
            this.PIC_avatar = new System.Windows.Forms.PictureBox();
            this.MENU_ITEM_update = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_ITEM_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.LIST_appended = new System.Windows.Forms.ListBox();
            this.NOTIFY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SPLIT_container)).BeginInit();
            this.SPLIT_container.Panel1.SuspendLayout();
            this.SPLIT_container.Panel2.SuspendLayout();
            this.SPLIT_container.SuspendLayout();
            this.CONTEXT_MENU_account.SuspendLayout();
            this.CONTEXT_MENU_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_avatar)).BeginInit();
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
            this.SPLIT_container.Panel1.Controls.Add(this.FLOW_PANEL_chains);
            this.SPLIT_container.Panel1.Controls.Add(this.PIC_avatar);
            // 
            // SPLIT_container.Panel2
            // 
            this.SPLIT_container.Panel2.Controls.Add(this.LIST_appended);
            this.SPLIT_container.Panel2.Controls.Add(this.TEXT_message);
            this.SPLIT_container.Size = new System.Drawing.Size(884, 561);
            this.SPLIT_container.SplitterDistance = 294;
            this.SPLIT_container.TabIndex = 0;
            // 
            // FLOW_PANEL_chains
            // 
            this.FLOW_PANEL_chains.AutoScroll = true;
            this.FLOW_PANEL_chains.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLOW_PANEL_chains.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FLOW_PANEL_chains.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLOW_PANEL_chains.Location = new System.Drawing.Point(0, 102);
            this.FLOW_PANEL_chains.Name = "FLOW_PANEL_chains";
            this.FLOW_PANEL_chains.Size = new System.Drawing.Size(294, 459);
            this.FLOW_PANEL_chains.TabIndex = 1;
            // 
            // CONTEXT_MENU_account
            // 
            this.CONTEXT_MENU_account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_ITEM_name,
            this.MENU_ITEM_update,
            this.MENU_ITEM_logout});
            this.CONTEXT_MENU_account.Name = "CONTEXT_MENU_account";
            this.CONTEXT_MENU_account.Size = new System.Drawing.Size(178, 70);
            // 
            // MENU_ITEM_name
            // 
            this.MENU_ITEM_name.Name = "MENU_ITEM_name";
            this.MENU_ITEM_name.Size = new System.Drawing.Size(177, 22);
            this.MENU_ITEM_name.Text = "account_name";
            // 
            // TEXT_message
            // 
            this.TEXT_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXT_message.Dock = System.Windows.Forms.DockStyle.Top;
            this.TEXT_message.Location = new System.Drawing.Point(0, 0);
            this.TEXT_message.Name = "TEXT_message";
            this.TEXT_message.Size = new System.Drawing.Size(586, 418);
            this.TEXT_message.TabIndex = 0;
            this.TEXT_message.Text = "";
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
            // PIC_avatar
            // 
            this.PIC_avatar.BackColor = System.Drawing.Color.LightCyan;
            this.PIC_avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIC_avatar.ContextMenuStrip = this.CONTEXT_MENU_account;
            this.PIC_avatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PIC_avatar.Location = new System.Drawing.Point(0, 0);
            this.PIC_avatar.Name = "PIC_avatar";
            this.PIC_avatar.Size = new System.Drawing.Size(294, 96);
            this.PIC_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_avatar.TabIndex = 0;
            this.PIC_avatar.TabStop = false;
            this.PIC_avatar.MouseEnter += new System.EventHandler(this.PIC_avatar_MouseEnter);
            this.PIC_avatar.MouseLeave += new System.EventHandler(this.PIC_avatar_MouseLeave);
            // 
            // MENU_ITEM_update
            // 
            this.MENU_ITEM_update.ForeColor = System.Drawing.Color.DarkBlue;
            this.MENU_ITEM_update.Image = global::Email_Service.Properties.Resources.update;
            this.MENU_ITEM_update.Name = "MENU_ITEM_update";
            this.MENU_ITEM_update.Size = new System.Drawing.Size(177, 22);
            this.MENU_ITEM_update.Text = "Обновить почту";
            // 
            // MENU_ITEM_logout
            // 
            this.MENU_ITEM_logout.ForeColor = System.Drawing.Color.DarkRed;
            this.MENU_ITEM_logout.Image = global::Email_Service.Properties.Resources.logout;
            this.MENU_ITEM_logout.Name = "MENU_ITEM_logout";
            this.MENU_ITEM_logout.Size = new System.Drawing.Size(177, 22);
            this.MENU_ITEM_logout.Text = "Выйти из профиля";
            // 
            // LIST_appended
            // 
            this.LIST_appended.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LIST_appended.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LIST_appended.ForeColor = System.Drawing.Color.DarkBlue;
            this.LIST_appended.FormattingEnabled = true;
            this.LIST_appended.ItemHeight = 15;
            this.LIST_appended.Location = new System.Drawing.Point(0, 424);
            this.LIST_appended.Name = "LIST_appended";
            this.LIST_appended.Size = new System.Drawing.Size(586, 137);
            this.LIST_appended.TabIndex = 1;
            // 
            // NOTIFY_ICON
            // 
            this.NOTIFY_ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("NOTIFY_ICON.Icon")));
            this.NOTIFY_ICON.Text = "Email Service";
            this.NOTIFY_ICON.Visible = true;
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FORM_Main";
            this.ShowInTaskbar = false;
            this.Text = "Email Service";
            this.SPLIT_container.Panel1.ResumeLayout(false);
            this.SPLIT_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLIT_container)).EndInit();
            this.SPLIT_container.ResumeLayout(false);
            this.CONTEXT_MENU_account.ResumeLayout(false);
            this.CONTEXT_MENU_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLIT_container;
        private System.Windows.Forms.FlowLayoutPanel FLOW_PANEL_chains;
        private System.Windows.Forms.PictureBox PIC_avatar;
        private System.Windows.Forms.RichTextBox TEXT_message;
        private System.Windows.Forms.ContextMenuStrip CONTEXT_MENU_account;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_name;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_logout;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_update;
        private System.Windows.Forms.ContextMenuStrip CONTEXT_MENU_login;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_login;
        private System.Windows.Forms.ToolStripTextBox MENU_ITEM_email;
        private System.Windows.Forms.ToolStripTextBox MENU_ITEM_password;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_apply;
        private System.Windows.Forms.ListBox LIST_appended;
        private System.Windows.Forms.NotifyIcon NOTIFY_ICON;
    }
}

