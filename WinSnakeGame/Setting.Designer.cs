namespace WinSnakeGame
{
    partial class Setting
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(90, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(202, 256);
            this.groupBox1.TabIndex = 8;
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
            "1",
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(120, 33);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 29);
            this.btnStart.TabIndex = 5;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "开始游戏";
            this.btnStart.UseMnemonic = false;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(120, 141);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 29);
            this.btnStop.TabIndex = 6;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "结束游戏";
            this.btnStop.UseMnemonic = false;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(120, 86);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 29);
            this.btnPause.TabIndex = 7;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "暂停游戏";
            this.btnPause.UseMnemonic = false;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Name = "Setting";
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbNodie;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Label labSpeed;
        private System.Windows.Forms.ComboBox cmbFoodCount;
        private System.Windows.Forms.Label labFoodCount;
        private System.Windows.Forms.ComboBox cmbSnakeSize;
        private System.Windows.Forms.Label labSnakeSize;
        private System.Windows.Forms.ComboBox cmbSnakeCount;
        private System.Windows.Forms.Label labSnakeCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
    }
}