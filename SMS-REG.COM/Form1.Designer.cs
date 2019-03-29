namespace SMS_REG.COM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Countrys = new System.Windows.Forms.ComboBox();
            this.Apps = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetNumber = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TZID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoopUp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setReadyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BalanceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ApiKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            this.PoopUp.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country:";
            // 
            // Countrys
            // 
            this.Countrys.FormattingEnabled = true;
            this.Countrys.Items.AddRange(new object[] {
            "All",
            "Russia",
            "Ukraine",
            "Kazakhstan",
            "China"});
            this.Countrys.Location = new System.Drawing.Point(118, 23);
            this.Countrys.Name = "Countrys";
            this.Countrys.Size = new System.Drawing.Size(121, 21);
            this.Countrys.TabIndex = 1;
            this.Countrys.Text = "All";
            // 
            // Apps
            // 
            this.Apps.FormattingEnabled = true;
            this.Apps.Items.AddRange(new object[] {
            "Other",
            "Aol.com",
            "Gmail.com",
            "Facebook.com",
            "Mail.ru",
            "Vk.com",
            "Ok.ru",
            "Twitter",
            "Mamba",
            "Uber",
            "Telegram",
            "Badoo",
            "Drugvokrug",
            "Avito",
            "OLX",
            "Steam",
            "Fotostrana.ru",
            "Microsoft",
            "Viber",
            "WhatsApp",
            "WeChat",
            "SEOsprint",
            "Instagram",
            "Yahoo",
            "Line Messanger",
            "KakaoTalk",
            "MeetMe",
            "Tinder",
            "Nimses",
            "Youla.ru",
            "5ka.ru"});
            this.Apps.Location = new System.Drawing.Point(245, 23);
            this.Apps.Name = "Apps";
            this.Apps.Size = new System.Drawing.Size(121, 21);
            this.Apps.TabIndex = 3;
            this.Apps.Text = "Other";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "App:";
            // 
            // GetNumber
            // 
            this.GetNumber.Location = new System.Drawing.Point(372, 21);
            this.GetNumber.Name = "GetNumber";
            this.GetNumber.Size = new System.Drawing.Size(75, 23);
            this.GetNumber.TabIndex = 4;
            this.GetNumber.Text = "Get Number";
            this.GetNumber.UseVisualStyleBackColor = true;
            this.GetNumber.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // Main
            // 
            this.Main.AllowUserToAddRows = false;
            this.Main.AllowUserToDeleteRows = false;
            this.Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Country,
            this.Code,
            this.Comment,
            this.TZID});
            this.Main.ContextMenuStrip = this.PoopUp;
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 50);
            this.Main.Name = "Main";
            this.Main.RowHeadersVisible = false;
            this.Main.Size = new System.Drawing.Size(732, 274);
            this.Main.TabIndex = 5;
            this.Main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_PoopUp);
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TZID
            // 
            this.TZID.HeaderText = "TZID";
            this.TZID.Name = "TZID";
            this.TZID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TZID.Visible = false;
            // 
            // PoopUp
            // 
            this.PoopUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setReadyToolStripMenuItem,
            this.setUsedToolStripMenuItem});
            this.PoopUp.Name = "contextMenuStrip1";
            this.PoopUp.Size = new System.Drawing.Size(124, 48);
            // 
            // setReadyToolStripMenuItem
            // 
            this.setReadyToolStripMenuItem.Name = "setReadyToolStripMenuItem";
            this.setReadyToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.setReadyToolStripMenuItem.Text = "Get Code";
            this.setReadyToolStripMenuItem.Click += new System.EventHandler(this.setReadyToolStripMenuItem_Click);
            // 
            // setUsedToolStripMenuItem
            // 
            this.setUsedToolStripMenuItem.Name = "setUsedToolStripMenuItem";
            this.setUsedToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.setUsedToolStripMenuItem.Text = "Set Used";
            this.setUsedToolStripMenuItem.Click += new System.EventHandler(this.setUsedToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(732, 50);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BalanceLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(54, 17);
            this.BalanceLabel.Text = "Balance: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ApiKey:";
            // 
            // ApiKey
            // 
            this.ApiKey.Location = new System.Drawing.Point(12, 24);
            this.ApiKey.Name = "ApiKey";
            this.ApiKey.Size = new System.Drawing.Size(100, 20);
            this.ApiKey.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ApiKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GetNumber);
            this.Controls.Add(this.Apps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Countrys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SMS-REG.COM";
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            this.PoopUp.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Countrys;
        private System.Windows.Forms.ComboBox Apps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetNumber;
        private System.Windows.Forms.DataGridView Main;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TZID;
        private System.Windows.Forms.ContextMenuStrip PoopUp;
        private System.Windows.Forms.ToolStripMenuItem setReadyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUsedToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel BalanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApiKey;
        private System.Windows.Forms.Button button1;
    }
}

