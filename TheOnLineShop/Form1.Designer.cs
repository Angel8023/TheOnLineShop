namespace TheOnLineShop
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titlePict = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.pleaseLogin = new System.Windows.Forms.LinkLabel();
            this.register = new System.Windows.Forms.LinkLabel();
            this.MyMessage = new System.Windows.Forms.LinkLabel();
            this.Mycenter = new System.Windows.Forms.LinkLabel();
            this.SellerCenter = new System.Windows.Forms.LinkLabel();
            this.manager = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchbox = new System.Windows.Forms.RichTextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titlePict)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePict
            // 
            this.titlePict.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePict.Image = ((System.Drawing.Image)(resources.GetObject("titlePict.Image")));
            this.titlePict.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titlePict.Location = new System.Drawing.Point(0, 0);
            this.titlePict.Name = "titlePict";
            this.titlePict.Size = new System.Drawing.Size(922, 90);
            this.titlePict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlePict.TabIndex = 22;
            this.titlePict.TabStop = false;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("楷体", 24.75F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(-6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(253, 54);
            this.title.TabIndex = 23;
            this.title.Text = "CCNU 网上书店";
            // 
            // pleaseLogin
            // 
            this.pleaseLogin.AutoSize = true;
            this.pleaseLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pleaseLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pleaseLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.pleaseLogin.LinkColor = System.Drawing.Color.Black;
            this.pleaseLogin.Location = new System.Drawing.Point(63, 78);
            this.pleaseLogin.Name = "pleaseLogin";
            this.pleaseLogin.Size = new System.Drawing.Size(77, 12);
            this.pleaseLogin.TabIndex = 24;
            this.pleaseLogin.TabStop = true;
            this.pleaseLogin.Text = "您好，请登录";
            this.pleaseLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pleaseLogin_LinkClicked);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.register.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.register.LinkColor = System.Drawing.Color.Black;
            this.register.Location = new System.Drawing.Point(218, 78);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(53, 12);
            this.register.TabIndex = 25;
            this.register.TabStop = true;
            this.register.Text = "免费注册";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // MyMessage
            // 
            this.MyMessage.AutoSize = true;
            this.MyMessage.BackColor = System.Drawing.Color.Transparent;
            this.MyMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MyMessage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MyMessage.LinkColor = System.Drawing.Color.Black;
            this.MyMessage.Location = new System.Drawing.Point(335, 78);
            this.MyMessage.Name = "MyMessage";
            this.MyMessage.Size = new System.Drawing.Size(53, 12);
            this.MyMessage.TabIndex = 26;
            this.MyMessage.TabStop = true;
            this.MyMessage.Text = "我的消息";
            // 
            // Mycenter
            // 
            this.Mycenter.AutoSize = true;
            this.Mycenter.BackColor = System.Drawing.Color.Transparent;
            this.Mycenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mycenter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Mycenter.LinkColor = System.Drawing.Color.Black;
            this.Mycenter.Location = new System.Drawing.Point(458, 78);
            this.Mycenter.Name = "Mycenter";
            this.Mycenter.Size = new System.Drawing.Size(53, 12);
            this.Mycenter.TabIndex = 47;
            this.Mycenter.TabStop = true;
            this.Mycenter.Text = "个人中心";
            // 
            // SellerCenter
            // 
            this.SellerCenter.AutoSize = true;
            this.SellerCenter.BackColor = System.Drawing.Color.Transparent;
            this.SellerCenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SellerCenter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SellerCenter.LinkColor = System.Drawing.Color.Black;
            this.SellerCenter.Location = new System.Drawing.Point(572, 78);
            this.SellerCenter.Name = "SellerCenter";
            this.SellerCenter.Size = new System.Drawing.Size(53, 12);
            this.SellerCenter.TabIndex = 48;
            this.SellerCenter.TabStop = true;
            this.SellerCenter.Text = "卖家中心";
            // 
            // manager
            // 
            this.manager.AutoSize = true;
            this.manager.BackColor = System.Drawing.Color.Transparent;
            this.manager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.manager.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.manager.LinkColor = System.Drawing.Color.Black;
            this.manager.Location = new System.Drawing.Point(683, 78);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(65, 12);
            this.manager.TabIndex = 49;
            this.manager.TabStop = true;
            this.manager.Text = "管理员选项";
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(822, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 51;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(144, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "类别：";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "期刊",
            "小说",
            "文学",
            "历史",
            "地理",
            "法律",
            "军事",
            "经济",
            "管理",
            "艺术",
            "生活",
            "少儿",
            "社会文化",
            "教育",
            "语言文学",
            "哲学心理",
            "宗教",
            "政治",
            "体育",
            "工程技术",
            "自然科学",
            "医药卫生",
            "计算机类",
            "数学类",
            "其他",
            "工具书"});
            this.comboBox1.Location = new System.Drawing.Point(191, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 53;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(359, 122);
            this.searchbox.Multiline = false;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(231, 27);
            this.searchbox.TabIndex = 54;
            this.searchbox.Text = "";
            // 
            // searchbutton
            // 
            this.searchbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchbutton.Location = new System.Drawing.Point(610, 122);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 27);
            this.searchbutton.TabIndex = 55;
            this.searchbutton.Text = "搜索";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 482);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.SellerCenter);
            this.Controls.Add(this.Mycenter);
            this.Controls.Add(this.MyMessage);
            this.Controls.Add(this.register);
            this.Controls.Add(this.pleaseLogin);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titlePict);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.titlePict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titlePict;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel pleaseLogin;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.LinkLabel MyMessage;
        private System.Windows.Forms.LinkLabel Mycenter;
        private System.Windows.Forms.LinkLabel SellerCenter;
        private System.Windows.Forms.LinkLabel manager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox searchbox;
        private System.Windows.Forms.Button searchbutton;

    }
}

