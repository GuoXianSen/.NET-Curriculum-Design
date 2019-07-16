namespace WinSnakeGame
{
    partial class frmSnakePlus
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnakePlus));
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.SnakeTimer = new System.Windows.Forms.Timer(this.components);
            this.SnakePoint = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbNodie = new System.Windows.Forms.CheckBox();
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.labSpeed = new System.Windows.Forms.Label();
            this.cmbFoodCount = new System.Windows.Forms.ComboBox();
            this.labFoodCount = new System.Windows.Forms.Label();
            this.cmbSnakeSize = new System.Windows.Forms.ComboBox();
            this.labSnakeSize = new System.Windows.Forms.Label();
            this.cmbSnakeCount = new System.Windows.Forms.ComboBox();
            this.labSnakeCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结束游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.分数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出F10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Location = new System.Drawing.Point(9, 40);
            this.DrawPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(667, 625);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // SnakeTimer
            // 
            this.SnakeTimer.Tick += new System.EventHandler(this.SnakeTimer_Tick);
            // 
            // SnakePoint
            // 
            this.SnakePoint.AutoSize = true;
            this.SnakePoint.Location = new System.Drawing.Point(690, 56);
            this.SnakePoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SnakePoint.Name = "SnakePoint";
            this.SnakePoint.Size = new System.Drawing.Size(215, 15);
            this.SnakePoint.TabIndex = 1;
            this.SnakePoint.Text = "X:0    Y:0    SnakeCount:0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(753, 102);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "开始游戏";
            this.btnStart.UseMnemonic = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(753, 210);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 29);
            this.btnStop.TabIndex = 1;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "结束游戏";
            this.btnStop.UseMnemonic = false;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(753, 155);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 29);
            this.btnPause.TabIndex = 1;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "暂停游戏";
            this.btnPause.UseMnemonic = false;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbNodie);
            this.groupBox1.Controls.Add(this.cmbSpeed);
            this.groupBox1.Controls.Add(this.labSpeed);
            this.groupBox1.Controls.Add(this.cmbFoodCount);
            this.groupBox1.Controls.Add(this.labFoodCount);
            this.groupBox1.Controls.Add(this.cmbSnakeSize);
            this.groupBox1.Controls.Add(this.labSnakeSize);
            this.groupBox1.Controls.Add(this.cmbSnakeCount);
            this.groupBox1.Controls.Add(this.labSnakeCount);
            this.groupBox1.Location = new System.Drawing.Point(723, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(202, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "游戏设置";
            // 
            // chbNodie
            // 
            this.chbNodie.AutoSize = true;
            this.chbNodie.Location = new System.Drawing.Point(60, 209);
            this.chbNodie.Margin = new System.Windows.Forms.Padding(4);
            this.chbNodie.Name = "chbNodie";
            this.chbNodie.Size = new System.Drawing.Size(89, 19);
            this.chbNodie.TabIndex = 2;
            this.chbNodie.TabStop = false;
            this.chbNodie.Text = "无敌模式";
            this.chbNodie.UseVisualStyleBackColor = true;
            this.chbNodie.CheckedChanged += new System.EventHandler(this.chbNodie_CheckedChanged);
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.AutoCompleteCustomSource.AddRange(new string[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.cmbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "80",
            "100",
            "200",
            "300",
            "500",
            "1000",
            "1200",
            "1500",
            "1800"});
            this.cmbSpeed.Location = new System.Drawing.Point(69, 161);
            this.cmbSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(80, 23);
            this.cmbSpeed.TabIndex = 1;
            this.cmbSpeed.TabStop = false;
            this.cmbSpeed.SelectedIndexChanged += new System.EventHandler(this.cmbSpeed_SelectedIndexChanged);
            // 
            // labSpeed
            // 
            this.labSpeed.AutoSize = true;
            this.labSpeed.Location = new System.Drawing.Point(27, 165);
            this.labSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSpeed.Name = "labSpeed";
            this.labSpeed.Size = new System.Drawing.Size(37, 15);
            this.labSpeed.TabIndex = 0;
            this.labSpeed.Text = "速度";
            // 
            // cmbFoodCount
            // 
            this.cmbFoodCount.AutoCompleteCustomSource.AddRange(new string[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.cmbFoodCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodCount.FormattingEnabled = true;
            this.cmbFoodCount.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100",
            "200",
            "300",
            "500",
            "600",
            "700"});
            this.cmbFoodCount.Location = new System.Drawing.Point(69, 121);
            this.cmbFoodCount.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFoodCount.Name = "cmbFoodCount";
            this.cmbFoodCount.Size = new System.Drawing.Size(80, 23);
            this.cmbFoodCount.TabIndex = 1;
            this.cmbFoodCount.TabStop = false;
            this.cmbFoodCount.SelectedIndexChanged += new System.EventHandler(this.cmbFoodCount_SelectedIndexChanged);
            // 
            // labFoodCount
            // 
            this.labFoodCount.AutoSize = true;
            this.labFoodCount.Location = new System.Drawing.Point(27, 126);
            this.labFoodCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFoodCount.Name = "labFoodCount";
            this.labFoodCount.Size = new System.Drawing.Size(37, 15);
            this.labFoodCount.TabIndex = 0;
            this.labFoodCount.Text = "食物";
            // 
            // cmbSnakeSize
            // 
            this.cmbSnakeSize.AutoCompleteCustomSource.AddRange(new string[] {
            "10",
            "20",
            "30"});
            this.cmbSnakeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSnakeSize.FormattingEnabled = true;
            this.cmbSnakeSize.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.cmbSnakeSize.Location = new System.Drawing.Point(69, 78);
            this.cmbSnakeSize.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSnakeSize.Name = "cmbSnakeSize";
            this.cmbSnakeSize.Size = new System.Drawing.Size(80, 23);
            this.cmbSnakeSize.TabIndex = 1;
            this.cmbSnakeSize.TabStop = false;
            this.cmbSnakeSize.SelectedIndexChanged += new System.EventHandler(this.cmbSnakeSize_SelectedIndexChanged);
            // 
            // labSnakeSize
            // 
            this.labSnakeSize.AutoSize = true;
            this.labSnakeSize.Location = new System.Drawing.Point(12, 83);
            this.labSnakeSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSnakeSize.Name = "labSnakeSize";
            this.labSnakeSize.Size = new System.Drawing.Size(52, 15);
            this.labSnakeSize.TabIndex = 0;
            this.labSnakeSize.Text = "蛇大小";
            // 
            // cmbSnakeCount
            // 
            this.cmbSnakeCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSnakeCount.FormattingEnabled = true;
            this.cmbSnakeCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbSnakeCount.Location = new System.Drawing.Point(69, 36);
            this.cmbSnakeCount.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSnakeCount.Name = "cmbSnakeCount";
            this.cmbSnakeCount.Size = new System.Drawing.Size(80, 23);
            this.cmbSnakeCount.TabIndex = 1;
            this.cmbSnakeCount.TabStop = false;
            this.cmbSnakeCount.SelectedIndexChanged += new System.EventHandler(this.cmbSnakeCount_SelectedIndexChanged);
            // 
            // labSnakeCount
            // 
            this.labSnakeCount.AutoSize = true;
            this.labSnakeCount.Location = new System.Drawing.Point(11, 41);
            this.labSnakeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSnakeCount.Name = "labSnakeCount";
            this.labSnakeCount.Size = new System.Drawing.Size(52, 15);
            this.labSnakeCount.TabIndex = 0;
            this.labSnakeCount.Text = "蛇长度";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.选项ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始游戏ToolStripMenuItem,
            this.暂停游戏ToolStripMenuItem,
            this.结束游戏ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.分数ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出F10ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.开始ToolStripMenuItem.Text = "开始(&M)";
            // 
            // 开始游戏ToolStripMenuItem
            // 
            this.开始游戏ToolStripMenuItem.Name = "开始游戏ToolStripMenuItem";
            this.开始游戏ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.开始游戏ToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.开始游戏ToolStripMenuItem.Text = "开始游戏(&F1)";
            this.开始游戏ToolStripMenuItem.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // 暂停游戏ToolStripMenuItem
            // 
            this.暂停游戏ToolStripMenuItem.Name = "暂停游戏ToolStripMenuItem";
            this.暂停游戏ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.暂停游戏ToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.暂停游戏ToolStripMenuItem.Text = "暂停游戏(&F2)";
            this.暂停游戏ToolStripMenuItem.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // 结束游戏ToolStripMenuItem
            // 
            this.结束游戏ToolStripMenuItem.Name = "结束游戏ToolStripMenuItem";
            this.结束游戏ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.结束游戏ToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.结束游戏ToolStripMenuItem.Text = "结束游戏(&F3)";
            this.结束游戏ToolStripMenuItem.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // 分数ToolStripMenuItem
            // 
            this.分数ToolStripMenuItem.Name = "分数ToolStripMenuItem";
            this.分数ToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.分数ToolStripMenuItem.Text = "分数";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.选项ToolStripMenuItem.Text = "选项(&S)";
            this.选项ToolStripMenuItem.Click += new System.EventHandler(this.选项ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.说明ToolStripMenuItem.Text = "说明";
            this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // 退出F10ToolStripMenuItem
            // 
            this.退出F10ToolStripMenuItem.Name = "退出F10ToolStripMenuItem";
            this.退出F10ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.退出F10ToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.退出F10ToolStripMenuItem.Text = "退出(&F10)";
            this.退出F10ToolStripMenuItem.Click += new System.EventHandler(this.退出F10ToolStripMenuItem_Click);
            // 
            // frmSnakePlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 691);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.SnakePoint);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSnakePlus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "贪食蛇";
            this.Load += new System.EventHandler(this.frmSnakePlus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Timer SnakeTimer;
        private System.Windows.Forms.Label SnakePoint;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labSnakeCount;
        private System.Windows.Forms.ComboBox cmbSnakeCount;
        private System.Windows.Forms.ComboBox cmbSnakeSize;
        private System.Windows.Forms.Label labSnakeSize;
        private System.Windows.Forms.ComboBox cmbFoodCount;
        private System.Windows.Forms.Label labFoodCount;
        private System.Windows.Forms.CheckBox chbNodie;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Label labSpeed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结束游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 分数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出F10ToolStripMenuItem;
    }
}

