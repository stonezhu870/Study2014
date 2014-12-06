namespace ATMSolution
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.开户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开户ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.开卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开卡ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.交易ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.交易查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开户ToolStripMenuItem,
            this.开卡ToolStripMenuItem,
            this.交易ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(968, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // 开户ToolStripMenuItem
            // 
            this.开户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户信息列表ToolStripMenuItem,
            this.开户ToolStripMenuItem1});
            this.开户ToolStripMenuItem.Name = "开户ToolStripMenuItem";
            this.开户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开户ToolStripMenuItem.Text = "开户";
            // 
            // 用户信息列表ToolStripMenuItem
            // 
            this.用户信息列表ToolStripMenuItem.Name = "用户信息列表ToolStripMenuItem";
            this.用户信息列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.用户信息列表ToolStripMenuItem.Text = "用户信息列表";
            this.用户信息列表ToolStripMenuItem.Click += new System.EventHandler(this.用户信息列表ToolStripMenuItem_Click);
            // 
            // 开户ToolStripMenuItem1
            // 
            this.开户ToolStripMenuItem1.Name = "开户ToolStripMenuItem1";
            this.开户ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.开户ToolStripMenuItem1.Text = "开户";
            this.开户ToolStripMenuItem1.Click += new System.EventHandler(this.开户ToolStripMenuItem1_Click);
            // 
            // 开卡ToolStripMenuItem
            // 
            this.开卡ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开卡ToolStripMenuItem1});
            this.开卡ToolStripMenuItem.Name = "开卡ToolStripMenuItem";
            this.开卡ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开卡ToolStripMenuItem.Text = "开卡";
            // 
            // 开卡ToolStripMenuItem1
            // 
            this.开卡ToolStripMenuItem1.Name = "开卡ToolStripMenuItem1";
            this.开卡ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.开卡ToolStripMenuItem1.Text = "开卡";
            this.开卡ToolStripMenuItem1.Click += new System.EventHandler(this.开卡ToolStripMenuItem1_Click);
            // 
            // 交易ToolStripMenuItem
            // 
            this.交易ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.支出ToolStripMenuItem,
            this.存入ToolStripMenuItem,
            this.交易查询ToolStripMenuItem});
            this.交易ToolStripMenuItem.Name = "交易ToolStripMenuItem";
            this.交易ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.交易ToolStripMenuItem.Text = "交易";
            // 
            // 支出ToolStripMenuItem
            // 
            this.支出ToolStripMenuItem.Name = "支出ToolStripMenuItem";
            this.支出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.支出ToolStripMenuItem.Text = "支出";
            this.支出ToolStripMenuItem.Click += new System.EventHandler(this.支出ToolStripMenuItem_Click);
            // 
            // 存入ToolStripMenuItem
            // 
            this.存入ToolStripMenuItem.Name = "存入ToolStripMenuItem";
            this.存入ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.存入ToolStripMenuItem.Text = "存入";
            this.存入ToolStripMenuItem.Click += new System.EventHandler(this.存入ToolStripMenuItem_Click);
            // 
            // 交易查询ToolStripMenuItem
            // 
            this.交易查询ToolStripMenuItem.Name = "交易查询ToolStripMenuItem";
            this.交易查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.交易查询ToolStripMenuItem.Text = "交易查询";
            this.交易查询ToolStripMenuItem.Click += new System.EventHandler(this.交易查询ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(968, 549);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem 开户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开户ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 开卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开卡ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 交易ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 交易查询ToolStripMenuItem;

    }
}

