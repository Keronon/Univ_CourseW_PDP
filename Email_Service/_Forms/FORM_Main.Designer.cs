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
            this.PIC_loading = new System.Windows.Forms.PictureBox();
            this.LIST_mails = new System.Windows.Forms.ListBox();
            this.FLOW_PANEL_mail_folders = new System.Windows.Forms.FlowLayoutPanel();
            this.RADIO_mail_all = new System.Windows.Forms.RadioButton();
            this.RADIO_mail_sent = new System.Windows.Forms.RadioButton();
            this.RADIO_mail_receive = new System.Windows.Forms.RadioButton();
            this.RADIO_mail_important = new System.Windows.Forms.RadioButton();
            this.RADIO_mail_drafts = new System.Windows.Forms.RadioButton();
            this.RADIO_mail_spam = new System.Windows.Forms.RadioButton();
            this.RADIO_mail_trash = new System.Windows.Forms.RadioButton();
            this.BTN_new_mail = new System.Windows.Forms.Button();
            this.PIC_avatar = new System.Windows.Forms.PictureBox();
            this.CONTEXT_MENU_profile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MENU_ITEM_profile = new System.Windows.Forms.ToolStripComboBox();
            this.MENU_ITEM_add = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_ITEM_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_ITEM_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.PIC_signed = new System.Windows.Forms.PictureBox();
            this.PIC_encrypted = new System.Windows.Forms.PictureBox();
            this.CHECK_encrypt = new System.Windows.Forms.CheckBox();
            this.CHECK_sign = new System.Windows.Forms.CheckBox();
            this.TXT_time = new System.Windows.Forms.TextBox();
            this.LBL_time = new System.Windows.Forms.Label();
            this.BTN_send = new System.Windows.Forms.Button();
            this.BTN_attach = new System.Windows.Forms.Button();
            this.CHECK_u = new System.Windows.Forms.CheckBox();
            this.CHECK_i = new System.Windows.Forms.CheckBox();
            this.CHECK_b = new System.Windows.Forms.CheckBox();
            this.TXT_topic = new System.Windows.Forms.TextBox();
            this.LBL_topic = new System.Windows.Forms.Label();
            this.TXT_to = new System.Windows.Forms.TextBox();
            this.LBL_to = new System.Windows.Forms.Label();
            this.TXT_from = new System.Windows.Forms.TextBox();
            this.LBL_from = new System.Windows.Forms.Label();
            this.LIST_attached = new System.Windows.Forms.ListBox();
            this.CONTEXT_MENU_attached = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MENU_ITEM_detach = new System.Windows.Forms.ToolStripMenuItem();
            this.BROWSER_mail = new System.Windows.Forms.WebBrowser();
            this.TEXT_mail = new System.Windows.Forms.RichTextBox();
            this.NOTIFY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
            this.TIP_fast = new System.Windows.Forms.ToolTip(this.components);
            this.DIALOG_append = new System.Windows.Forms.OpenFileDialog();
            this.TIMER_refresher = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SPLIT_container)).BeginInit();
            this.SPLIT_container.Panel1.SuspendLayout();
            this.SPLIT_container.Panel2.SuspendLayout();
            this.SPLIT_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_loading)).BeginInit();
            this.FLOW_PANEL_mail_folders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_avatar)).BeginInit();
            this.CONTEXT_MENU_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_signed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_encrypted)).BeginInit();
            this.CONTEXT_MENU_attached.SuspendLayout();
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
            this.SPLIT_container.Panel1.Controls.Add(this.PIC_loading);
            this.SPLIT_container.Panel1.Controls.Add(this.LIST_mails);
            this.SPLIT_container.Panel1.Controls.Add(this.FLOW_PANEL_mail_folders);
            this.SPLIT_container.Panel1.Controls.Add(this.BTN_new_mail);
            this.SPLIT_container.Panel1.Controls.Add(this.PIC_avatar);
            this.SPLIT_container.Panel1MinSize = 200;
            // 
            // SPLIT_container.Panel2
            // 
            this.SPLIT_container.Panel2.Controls.Add(this.PIC_signed);
            this.SPLIT_container.Panel2.Controls.Add(this.PIC_encrypted);
            this.SPLIT_container.Panel2.Controls.Add(this.CHECK_encrypt);
            this.SPLIT_container.Panel2.Controls.Add(this.CHECK_sign);
            this.SPLIT_container.Panel2.Controls.Add(this.TXT_time);
            this.SPLIT_container.Panel2.Controls.Add(this.LBL_time);
            this.SPLIT_container.Panel2.Controls.Add(this.BTN_send);
            this.SPLIT_container.Panel2.Controls.Add(this.BTN_attach);
            this.SPLIT_container.Panel2.Controls.Add(this.CHECK_u);
            this.SPLIT_container.Panel2.Controls.Add(this.CHECK_i);
            this.SPLIT_container.Panel2.Controls.Add(this.CHECK_b);
            this.SPLIT_container.Panel2.Controls.Add(this.TXT_topic);
            this.SPLIT_container.Panel2.Controls.Add(this.LBL_topic);
            this.SPLIT_container.Panel2.Controls.Add(this.TXT_to);
            this.SPLIT_container.Panel2.Controls.Add(this.LBL_to);
            this.SPLIT_container.Panel2.Controls.Add(this.TXT_from);
            this.SPLIT_container.Panel2.Controls.Add(this.LBL_from);
            this.SPLIT_container.Panel2.Controls.Add(this.LIST_attached);
            this.SPLIT_container.Panel2.Controls.Add(this.BROWSER_mail);
            this.SPLIT_container.Panel2.Controls.Add(this.TEXT_mail);
            this.SPLIT_container.Panel2.Enabled = false;
            this.SPLIT_container.Panel2MinSize = 400;
            this.SPLIT_container.Size = new System.Drawing.Size(884, 561);
            this.SPLIT_container.SplitterDistance = 300;
            this.SPLIT_container.SplitterWidth = 3;
            this.SPLIT_container.TabIndex = 0;
            // 
            // PIC_loading
            // 
            this.PIC_loading.BackColor = System.Drawing.Color.Transparent;
            this.PIC_loading.Image = global::Email_Service.Properties.Resources.gif_loading;
            this.PIC_loading.Location = new System.Drawing.Point(3, 508);
            this.PIC_loading.Name = "PIC_loading";
            this.PIC_loading.Size = new System.Drawing.Size(50, 50);
            this.PIC_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_loading.TabIndex = 14;
            this.PIC_loading.TabStop = false;
            this.PIC_loading.Visible = false;
            // 
            // LIST_mails
            // 
            this.LIST_mails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LIST_mails.FormattingEnabled = true;
            this.LIST_mails.HorizontalScrollbar = true;
            this.LIST_mails.ItemHeight = 15;
            this.LIST_mails.Location = new System.Drawing.Point(0, 197);
            this.LIST_mails.Name = "LIST_mails";
            this.LIST_mails.Size = new System.Drawing.Size(300, 364);
            this.LIST_mails.Sorted = true;
            this.LIST_mails.TabIndex = 13;
            this.LIST_mails.SelectedIndexChanged += new System.EventHandler(this.LIST_mails_SelectedIndexChanged);
            // 
            // FLOW_PANEL_mail_folders
            // 
            this.FLOW_PANEL_mail_folders.AutoScroll = true;
            this.FLOW_PANEL_mail_folders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLOW_PANEL_mail_folders.Controls.Add(this.RADIO_mail_all);
            this.FLOW_PANEL_mail_folders.Controls.Add(this.RADIO_mail_sent);
            this.FLOW_PANEL_mail_folders.Controls.Add(this.RADIO_mail_receive);
            this.FLOW_PANEL_mail_folders.Controls.Add(this.RADIO_mail_important);
            this.FLOW_PANEL_mail_folders.Controls.Add(this.RADIO_mail_drafts);
            this.FLOW_PANEL_mail_folders.Controls.Add(this.RADIO_mail_spam);
            this.FLOW_PANEL_mail_folders.Controls.Add(this.RADIO_mail_trash);
            this.FLOW_PANEL_mail_folders.Dock = System.Windows.Forms.DockStyle.Top;
            this.FLOW_PANEL_mail_folders.Enabled = false;
            this.FLOW_PANEL_mail_folders.Location = new System.Drawing.Point(0, 136);
            this.FLOW_PANEL_mail_folders.Name = "FLOW_PANEL_mail_folders";
            this.FLOW_PANEL_mail_folders.Size = new System.Drawing.Size(300, 62);
            this.FLOW_PANEL_mail_folders.TabIndex = 12;
            this.FLOW_PANEL_mail_folders.WrapContents = false;
            // 
            // RADIO_mail_all
            // 
            this.RADIO_mail_all.Appearance = System.Windows.Forms.Appearance.Button;
            this.RADIO_mail_all.BackgroundImage = global::Email_Service.Properties.Resources.mail_all;
            this.RADIO_mail_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RADIO_mail_all.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RADIO_mail_all.Location = new System.Drawing.Point(3, 3);
            this.RADIO_mail_all.Name = "RADIO_mail_all";
            this.RADIO_mail_all.Size = new System.Drawing.Size(36, 36);
            this.RADIO_mail_all.TabIndex = 3;
            this.RADIO_mail_all.TabStop = true;
            this.TIP_fast.SetToolTip(this.RADIO_mail_all, "Все");
            this.RADIO_mail_all.UseVisualStyleBackColor = true;
            this.RADIO_mail_all.CheckedChanged += new System.EventHandler(this.RADIO_mail_all_CheckedChanged);
            // 
            // RADIO_mail_sent
            // 
            this.RADIO_mail_sent.Appearance = System.Windows.Forms.Appearance.Button;
            this.RADIO_mail_sent.BackgroundImage = global::Email_Service.Properties.Resources.mail_sent;
            this.RADIO_mail_sent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RADIO_mail_sent.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RADIO_mail_sent.Location = new System.Drawing.Point(45, 3);
            this.RADIO_mail_sent.Name = "RADIO_mail_sent";
            this.RADIO_mail_sent.Size = new System.Drawing.Size(36, 36);
            this.RADIO_mail_sent.TabIndex = 4;
            this.RADIO_mail_sent.TabStop = true;
            this.TIP_fast.SetToolTip(this.RADIO_mail_sent, "Отправленные");
            this.RADIO_mail_sent.UseVisualStyleBackColor = true;
            this.RADIO_mail_sent.CheckedChanged += new System.EventHandler(this.RADIO_mail_sent_CheckedChanged);
            // 
            // RADIO_mail_receive
            // 
            this.RADIO_mail_receive.Appearance = System.Windows.Forms.Appearance.Button;
            this.RADIO_mail_receive.BackgroundImage = global::Email_Service.Properties.Resources.mail_receive;
            this.RADIO_mail_receive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RADIO_mail_receive.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RADIO_mail_receive.Location = new System.Drawing.Point(87, 3);
            this.RADIO_mail_receive.Name = "RADIO_mail_receive";
            this.RADIO_mail_receive.Size = new System.Drawing.Size(36, 36);
            this.RADIO_mail_receive.TabIndex = 5;
            this.RADIO_mail_receive.TabStop = true;
            this.TIP_fast.SetToolTip(this.RADIO_mail_receive, "Входящие");
            this.RADIO_mail_receive.UseVisualStyleBackColor = true;
            this.RADIO_mail_receive.CheckedChanged += new System.EventHandler(this.RADIO_mail_receive_CheckedChanged);
            // 
            // RADIO_mail_important
            // 
            this.RADIO_mail_important.Appearance = System.Windows.Forms.Appearance.Button;
            this.RADIO_mail_important.BackgroundImage = global::Email_Service.Properties.Resources.mail_important;
            this.RADIO_mail_important.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RADIO_mail_important.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RADIO_mail_important.Location = new System.Drawing.Point(129, 3);
            this.RADIO_mail_important.Name = "RADIO_mail_important";
            this.RADIO_mail_important.Size = new System.Drawing.Size(36, 36);
            this.RADIO_mail_important.TabIndex = 6;
            this.RADIO_mail_important.TabStop = true;
            this.TIP_fast.SetToolTip(this.RADIO_mail_important, "Важные");
            this.RADIO_mail_important.UseVisualStyleBackColor = true;
            this.RADIO_mail_important.CheckedChanged += new System.EventHandler(this.RADIO_mail_important_CheckedChanged);
            // 
            // RADIO_mail_drafts
            // 
            this.RADIO_mail_drafts.Appearance = System.Windows.Forms.Appearance.Button;
            this.RADIO_mail_drafts.BackgroundImage = global::Email_Service.Properties.Resources.mail_drafts;
            this.RADIO_mail_drafts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RADIO_mail_drafts.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RADIO_mail_drafts.Location = new System.Drawing.Point(171, 3);
            this.RADIO_mail_drafts.Name = "RADIO_mail_drafts";
            this.RADIO_mail_drafts.Size = new System.Drawing.Size(36, 36);
            this.RADIO_mail_drafts.TabIndex = 7;
            this.RADIO_mail_drafts.TabStop = true;
            this.TIP_fast.SetToolTip(this.RADIO_mail_drafts, "Черновики");
            this.RADIO_mail_drafts.UseVisualStyleBackColor = true;
            this.RADIO_mail_drafts.CheckedChanged += new System.EventHandler(this.RADIO_mail_drafts_CheckedChanged);
            // 
            // RADIO_mail_spam
            // 
            this.RADIO_mail_spam.Appearance = System.Windows.Forms.Appearance.Button;
            this.RADIO_mail_spam.BackgroundImage = global::Email_Service.Properties.Resources.mail_spam;
            this.RADIO_mail_spam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RADIO_mail_spam.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RADIO_mail_spam.Location = new System.Drawing.Point(213, 3);
            this.RADIO_mail_spam.Name = "RADIO_mail_spam";
            this.RADIO_mail_spam.Size = new System.Drawing.Size(36, 36);
            this.RADIO_mail_spam.TabIndex = 8;
            this.RADIO_mail_spam.TabStop = true;
            this.TIP_fast.SetToolTip(this.RADIO_mail_spam, "Спам");
            this.RADIO_mail_spam.UseVisualStyleBackColor = true;
            this.RADIO_mail_spam.CheckedChanged += new System.EventHandler(this.RADIO_mail_spam_CheckedChanged);
            // 
            // RADIO_mail_trash
            // 
            this.RADIO_mail_trash.Appearance = System.Windows.Forms.Appearance.Button;
            this.RADIO_mail_trash.BackgroundImage = global::Email_Service.Properties.Resources.mail_trash;
            this.RADIO_mail_trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RADIO_mail_trash.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RADIO_mail_trash.Location = new System.Drawing.Point(255, 3);
            this.RADIO_mail_trash.Name = "RADIO_mail_trash";
            this.RADIO_mail_trash.Size = new System.Drawing.Size(36, 36);
            this.RADIO_mail_trash.TabIndex = 9;
            this.RADIO_mail_trash.TabStop = true;
            this.TIP_fast.SetToolTip(this.RADIO_mail_trash, "Удалённые");
            this.RADIO_mail_trash.UseVisualStyleBackColor = true;
            this.RADIO_mail_trash.CheckedChanged += new System.EventHandler(this.RADIO_mail_trash_CheckedChanged);
            // 
            // BTN_new_mail
            // 
            this.BTN_new_mail.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_new_mail.Enabled = false;
            this.BTN_new_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_new_mail.Image = global::Email_Service.Properties.Resources.btn_add;
            this.BTN_new_mail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_new_mail.Location = new System.Drawing.Point(0, 96);
            this.BTN_new_mail.Name = "BTN_new_mail";
            this.BTN_new_mail.Size = new System.Drawing.Size(300, 40);
            this.BTN_new_mail.TabIndex = 2;
            this.BTN_new_mail.Text = "Новое письмо";
            this.BTN_new_mail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_new_mail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTN_new_mail.UseVisualStyleBackColor = true;
            this.BTN_new_mail.Click += new System.EventHandler(this.BTN_new_mail_Click);
            // 
            // PIC_avatar
            // 
            this.PIC_avatar.BackColor = System.Drawing.Color.LightCyan;
            this.PIC_avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIC_avatar.ContextMenuStrip = this.CONTEXT_MENU_profile;
            this.PIC_avatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PIC_avatar.Image = global::Email_Service.Properties.Resources.img_user;
            this.PIC_avatar.Location = new System.Drawing.Point(0, 0);
            this.PIC_avatar.Name = "PIC_avatar";
            this.PIC_avatar.Size = new System.Drawing.Size(300, 96);
            this.PIC_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_avatar.TabIndex = 0;
            this.PIC_avatar.TabStop = false;
            this.PIC_avatar.MouseEnter += new System.EventHandler(this.PIC_avatar_MouseEnter);
            this.PIC_avatar.MouseLeave += new System.EventHandler(this.PIC_avatar_MouseLeave);
            // 
            // CONTEXT_MENU_profile
            // 
            this.CONTEXT_MENU_profile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_ITEM_profile,
            this.MENU_ITEM_add,
            this.MENU_ITEM_refresh,
            this.MENU_ITEM_logout});
            this.CONTEXT_MENU_profile.Name = "CONTEXT_MENU_account";
            this.CONTEXT_MENU_profile.Size = new System.Drawing.Size(241, 97);
            // 
            // MENU_ITEM_profile
            // 
            this.MENU_ITEM_profile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.MENU_ITEM_profile.Name = "MENU_ITEM_profile";
            this.MENU_ITEM_profile.Size = new System.Drawing.Size(180, 23);
            this.MENU_ITEM_profile.Text = "профиль не выбран";
            this.MENU_ITEM_profile.SelectedIndexChanged += new System.EventHandler(this.MENU_ITEM_profile_SelectedIndexChanged);
            // 
            // MENU_ITEM_add
            // 
            this.MENU_ITEM_add.ForeColor = System.Drawing.Color.DarkBlue;
            this.MENU_ITEM_add.Image = global::Email_Service.Properties.Resources.btn_add;
            this.MENU_ITEM_add.Name = "MENU_ITEM_add";
            this.MENU_ITEM_add.Size = new System.Drawing.Size(240, 22);
            this.MENU_ITEM_add.Text = "Добавить профиль";
            this.MENU_ITEM_add.Click += new System.EventHandler(this.MENU_ITEM_add_Click);
            // 
            // MENU_ITEM_refresh
            // 
            this.MENU_ITEM_refresh.Enabled = false;
            this.MENU_ITEM_refresh.ForeColor = System.Drawing.Color.DarkBlue;
            this.MENU_ITEM_refresh.Image = global::Email_Service.Properties.Resources.btn_update;
            this.MENU_ITEM_refresh.Name = "MENU_ITEM_refresh";
            this.MENU_ITEM_refresh.Size = new System.Drawing.Size(240, 22);
            this.MENU_ITEM_refresh.Text = "Обновить почту";
            this.MENU_ITEM_refresh.Click += new System.EventHandler(this.MENU_ITEM_refresh_Click);
            // 
            // MENU_ITEM_logout
            // 
            this.MENU_ITEM_logout.Enabled = false;
            this.MENU_ITEM_logout.ForeColor = System.Drawing.Color.DarkRed;
            this.MENU_ITEM_logout.Image = global::Email_Service.Properties.Resources.btn_logout;
            this.MENU_ITEM_logout.Name = "MENU_ITEM_logout";
            this.MENU_ITEM_logout.Size = new System.Drawing.Size(240, 22);
            this.MENU_ITEM_logout.Text = "Выйти из профиля";
            this.MENU_ITEM_logout.Click += new System.EventHandler(this.MENU_ITEM_logout_Click);
            // 
            // PIC_signed
            // 
            this.PIC_signed.Image = global::Email_Service.Properties.Resources.img_sign;
            this.PIC_signed.Location = new System.Drawing.Point(512, 121);
            this.PIC_signed.Name = "PIC_signed";
            this.PIC_signed.Size = new System.Drawing.Size(30, 30);
            this.PIC_signed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_signed.TabIndex = 18;
            this.PIC_signed.TabStop = false;
            this.PIC_signed.Visible = false;
            // 
            // PIC_encrypted
            // 
            this.PIC_encrypted.Image = global::Email_Service.Properties.Resources.img_encrypt;
            this.PIC_encrypted.Location = new System.Drawing.Point(548, 121);
            this.PIC_encrypted.Name = "PIC_encrypted";
            this.PIC_encrypted.Size = new System.Drawing.Size(30, 30);
            this.PIC_encrypted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_encrypted.TabIndex = 17;
            this.PIC_encrypted.TabStop = false;
            this.PIC_encrypted.Visible = false;
            // 
            // CHECK_encrypt
            // 
            this.CHECK_encrypt.Appearance = System.Windows.Forms.Appearance.Button;
            this.CHECK_encrypt.AutoSize = true;
            this.CHECK_encrypt.Location = new System.Drawing.Point(297, 531);
            this.CHECK_encrypt.Name = "CHECK_encrypt";
            this.CHECK_encrypt.Size = new System.Drawing.Size(80, 25);
            this.CHECK_encrypt.TabIndex = 11;
            this.CHECK_encrypt.Text = "Шифровать";
            this.CHECK_encrypt.UseVisualStyleBackColor = true;
            // 
            // CHECK_sign
            // 
            this.CHECK_sign.Appearance = System.Windows.Forms.Appearance.Button;
            this.CHECK_sign.AutoSize = true;
            this.CHECK_sign.Location = new System.Drawing.Point(383, 531);
            this.CHECK_sign.Name = "CHECK_sign";
            this.CHECK_sign.Size = new System.Drawing.Size(80, 25);
            this.CHECK_sign.TabIndex = 12;
            this.CHECK_sign.Text = "Подписать";
            this.CHECK_sign.UseVisualStyleBackColor = true;
            // 
            // TXT_time
            // 
            this.TXT_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_time.Location = new System.Drawing.Point(378, 90);
            this.TXT_time.Name = "TXT_time";
            this.TXT_time.ReadOnly = true;
            this.TXT_time.Size = new System.Drawing.Size(200, 23);
            this.TXT_time.TabIndex = 16;
            // 
            // LBL_time
            // 
            this.LBL_time.AutoSize = true;
            this.LBL_time.Location = new System.Drawing.Point(323, 93);
            this.LBL_time.Name = "LBL_time";
            this.LBL_time.Size = new System.Drawing.Size(49, 15);
            this.LBL_time.TabIndex = 15;
            this.LBL_time.Text = "Время:";
            // 
            // BTN_send
            // 
            this.BTN_send.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_send.Image = global::Email_Service.Properties.Resources.btn_send_mail;
            this.BTN_send.Location = new System.Drawing.Point(469, 528);
            this.BTN_send.Name = "BTN_send";
            this.BTN_send.Size = new System.Drawing.Size(109, 30);
            this.BTN_send.TabIndex = 14;
            this.BTN_send.Text = "Отправить";
            this.BTN_send.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTN_send.UseVisualStyleBackColor = true;
            this.BTN_send.Click += new System.EventHandler(this.BTN_send_Click);
            // 
            // BTN_attach
            // 
            this.BTN_attach.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_attach.Image = global::Email_Service.Properties.Resources.btn_append;
            this.BTN_attach.Location = new System.Drawing.Point(3, 528);
            this.BTN_attach.Name = "BTN_attach";
            this.BTN_attach.Size = new System.Drawing.Size(109, 30);
            this.BTN_attach.TabIndex = 13;
            this.BTN_attach.Text = "Прикрепить";
            this.BTN_attach.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTN_attach.UseVisualStyleBackColor = true;
            this.BTN_attach.Click += new System.EventHandler(this.BTN_attach_Click);
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
            this.CHECK_u.CheckedChanged += new System.EventHandler(this.CHECK_u_CheckedChanged);
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
            this.CHECK_i.CheckedChanged += new System.EventHandler(this.CHECK_i_CheckedChanged);
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
            this.CHECK_b.CheckedChanged += new System.EventHandler(this.CHECK_b_CheckedChanged);
            // 
            // TXT_topic
            // 
            this.TXT_topic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_topic.Location = new System.Drawing.Point(51, 61);
            this.TXT_topic.Name = "TXT_topic";
            this.TXT_topic.Size = new System.Drawing.Size(527, 23);
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
            // TXT_to
            // 
            this.TXT_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_to.Location = new System.Drawing.Point(51, 32);
            this.TXT_to.Name = "TXT_to";
            this.TXT_to.Size = new System.Drawing.Size(527, 23);
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
            // TXT_from
            // 
            this.TXT_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_from.Location = new System.Drawing.Point(51, 3);
            this.TXT_from.Name = "TXT_from";
            this.TXT_from.ReadOnly = true;
            this.TXT_from.Size = new System.Drawing.Size(527, 23);
            this.TXT_from.TabIndex = 4;
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
            // LIST_attached
            // 
            this.LIST_attached.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LIST_attached.ContextMenuStrip = this.CONTEXT_MENU_attached;
            this.LIST_attached.ForeColor = System.Drawing.Color.DarkBlue;
            this.LIST_attached.FormattingEnabled = true;
            this.LIST_attached.ItemHeight = 15;
            this.LIST_attached.Location = new System.Drawing.Point(3, 415);
            this.LIST_attached.Name = "LIST_attached";
            this.LIST_attached.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LIST_attached.Size = new System.Drawing.Size(575, 107);
            this.LIST_attached.TabIndex = 1;
            this.LIST_attached.DoubleClick += new System.EventHandler(this.LIST_attached_DoubleClick);
            // 
            // CONTEXT_MENU_attached
            // 
            this.CONTEXT_MENU_attached.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_ITEM_detach});
            this.CONTEXT_MENU_attached.Name = "CONTEXT_MENU_appended";
            this.CONTEXT_MENU_attached.Size = new System.Drawing.Size(133, 26);
            // 
            // MENU_ITEM_detach
            // 
            this.MENU_ITEM_detach.ForeColor = System.Drawing.Color.DarkRed;
            this.MENU_ITEM_detach.Name = "MENU_ITEM_detach";
            this.MENU_ITEM_detach.Size = new System.Drawing.Size(132, 22);
            this.MENU_ITEM_detach.Text = "Открепить";
            this.MENU_ITEM_detach.Click += new System.EventHandler(this.MENU_ITEM_detach_Click);
            // 
            // BROWSER_mail
            // 
            this.BROWSER_mail.Location = new System.Drawing.Point(3, 121);
            this.BROWSER_mail.MinimumSize = new System.Drawing.Size(20, 20);
            this.BROWSER_mail.Name = "BROWSER_mail";
            this.BROWSER_mail.Size = new System.Drawing.Size(573, 288);
            this.BROWSER_mail.TabIndex = 19;
            this.BROWSER_mail.Visible = false;
            // 
            // TEXT_mail
            // 
            this.TEXT_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXT_mail.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TEXT_mail.Location = new System.Drawing.Point(3, 121);
            this.TEXT_mail.Name = "TEXT_mail";
            this.TEXT_mail.Size = new System.Drawing.Size(577, 288);
            this.TEXT_mail.TabIndex = 0;
            this.TEXT_mail.Text = "";
            this.TEXT_mail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TEXT_mail_MouseDown);
            // 
            // NOTIFY_ICON
            // 
            this.NOTIFY_ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("NOTIFY_ICON.Icon")));
            this.NOTIFY_ICON.Text = "Email Service";
            this.NOTIFY_ICON.Visible = true;
            this.NOTIFY_ICON.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NOTIFY_ICON_MouseDoubleClick);
            // 
            // TIP_fast
            // 
            this.TIP_fast.AutomaticDelay = 100;
            // 
            // DIALOG_append
            // 
            this.DIALOG_append.InitialDirectory = "D:\\";
            this.DIALOG_append.Multiselect = true;
            this.DIALOG_append.RestoreDirectory = true;
            // 
            // TIMER_refresher
            // 
            this.TIMER_refresher.Interval = 300000;
            this.TIMER_refresher.Tick += new System.EventHandler(this.TIMER_refresher_Tick);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_Main_FormClosing);
            this.SPLIT_container.Panel1.ResumeLayout(false);
            this.SPLIT_container.Panel2.ResumeLayout(false);
            this.SPLIT_container.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLIT_container)).EndInit();
            this.SPLIT_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_loading)).EndInit();
            this.FLOW_PANEL_mail_folders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_avatar)).EndInit();
            this.CONTEXT_MENU_profile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_signed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_encrypted)).EndInit();
            this.CONTEXT_MENU_attached.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NOTIFY_ICON;
        private System.Windows.Forms.ToolTip TIP_fast;
        private System.Windows.Forms.SplitContainer SPLIT_container;
        private System.Windows.Forms.PictureBox PIC_avatar;
        private System.Windows.Forms.RichTextBox TEXT_mail;
        private System.Windows.Forms.ContextMenuStrip CONTEXT_MENU_profile;
        private System.Windows.Forms.ToolStripComboBox MENU_ITEM_profile;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_add;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_refresh;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_logout;
        private System.Windows.Forms.FlowLayoutPanel FLOW_PANEL_mail_folders;
        private System.Windows.Forms.RadioButton RADIO_mail_all;
        private System.Windows.Forms.RadioButton RADIO_mail_sent;
        private System.Windows.Forms.RadioButton RADIO_mail_trash;
        private System.Windows.Forms.RadioButton RADIO_mail_spam;
        private System.Windows.Forms.RadioButton RADIO_mail_drafts;
        private System.Windows.Forms.RadioButton RADIO_mail_important;
        private System.Windows.Forms.RadioButton RADIO_mail_receive;
        private System.Windows.Forms.Button BTN_new_mail;
        private System.Windows.Forms.CheckBox CHECK_u;
        private System.Windows.Forms.CheckBox CHECK_i;
        private System.Windows.Forms.CheckBox CHECK_b;
        private System.Windows.Forms.TextBox TXT_topic;
        private System.Windows.Forms.TextBox TXT_to;
        private System.Windows.Forms.TextBox TXT_from;
        private System.Windows.Forms.Label LBL_topic;
        private System.Windows.Forms.Label LBL_to;
        private System.Windows.Forms.Label LBL_from;
        private System.Windows.Forms.ListBox LIST_attached;
        private System.Windows.Forms.Button BTN_send;
        private System.Windows.Forms.Button BTN_attach;
        private System.Windows.Forms.OpenFileDialog DIALOG_append;
        private System.Windows.Forms.ContextMenuStrip CONTEXT_MENU_attached;
        private System.Windows.Forms.ToolStripMenuItem MENU_ITEM_detach;
        private System.Windows.Forms.Timer TIMER_refresher;
        private System.Windows.Forms.TextBox TXT_time;
        private System.Windows.Forms.Label LBL_time;
        private System.Windows.Forms.ListBox LIST_mails;
        private System.Windows.Forms.PictureBox PIC_loading;
        private System.Windows.Forms.PictureBox PIC_encrypted;
        private System.Windows.Forms.CheckBox CHECK_encrypt;
        private System.Windows.Forms.CheckBox CHECK_sign;
        private System.Windows.Forms.PictureBox PIC_signed;
        private System.Windows.Forms.WebBrowser BROWSER_mail;
    }
}

