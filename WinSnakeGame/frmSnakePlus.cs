using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSnakeGame
{
    public partial class frmSnakePlus : Form
    {
        
        #region 游戏变量

        //public static int Num = 1;
        public static int Num_food = 1;
        
        public int[] flag = new int[5]{0,0,0,0,0};

        /// <summary>
        /// 贪食蛇初始长度，设置默认值1 也可以由程序中手动修改
        /// </summary>
        private int snakeCount
        {
            get { return Convert.ToInt32(cmbSnakeCount.SelectedItem); }
        }

        /// <summary>
        /// 贪食蛇初始大小
        /// </summary>
        private int snakeSize
        {
            get { return Convert.ToInt32(cmbSnakeSize.SelectedItem); }
        }

        /// <summary>
        /// 食物数量
        /// </summary>
        private int foodCount
        {
            get { return Convert.ToInt32(cmbFoodCount.SelectedItem); }
        }

        /// <summary>
        /// 爬行速度
        /// </summary>
        private int snakeSpeed
        {
            get { return Convert.ToInt32(cmbSpeed.SelectedItem); }
        }

        /// <summary>
        /// 贪食蛇分数
        /// </summary>
        private int snakeScore = 0;

        /// <summary>
        /// 正在爬行
        /// </summary>
        private bool snakeAction = false;

        /// <summary>
        /// 爬行方向
        /// </summary>
        private Keys KeyCode = Keys.Right;

        /// <summary>
        /// 组成贪食蛇的集合
        /// </summary>
        private List<Label> snakeCells = new List<Label>();

        /// <summary>
        /// 食物集合
        /// </summary>
        private List<Label> foodCells = new List<Label>();
        #endregion

        #region 构造函数
        /// <summary>
        /// 初始化
        /// </summary>
        public frmSnakePlus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置蛇的初始参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSnakePlus_Load(object sender, EventArgs e)
        {
            cmbSnakeCount.SelectedItem = "1";
            cmbSnakeSize.SelectedItem = "15";
            cmbFoodCount.SelectedItem = "5";
            cmbSpeed.SelectedItem = "200";
            chbNodie.Checked = false;

            InitGame();//初始化游戏
        }
        #endregion

        #region 游戏控制

        /// <summary>
        /// 初始游戏
        /// </summary>
        private void InitGame()
        {
            this.SnakeTimer.Stop();
            this.snakeAction = false;
            this.KeyPreview = true;
            this.DrawPanel.Focus();
            this.KeyCode = Keys.Right;
            this.snakeScore = this.snakeCount;

            btnStart.Enabled = true;
            btnStop.Enabled = btnPause.Enabled = false;

            // 清空贪食蛇
            snakeCells.Clear();

            // 清空食物
            foodCells.Clear();

            // 清空游戏区域
            DrawPanel.Controls.Clear();

            InitSnake();

            InitFood();
        }

        /// <summary>
        /// 初始化贪食蛇
        /// </summary>
        private void InitSnake()
        {
            // 初始化贪食蛇
            for (int i = snakeScore - 1; i >= 0; i--)
            {
                // 创建方格
                Label _cell = CreateCell(new Point(i * this.snakeSize, 0));
                _cell.Text = "0";

                // 将方格添加到蛇身集合
                snakeCells.Add(_cell);

                // 绘制到游戏区域
                this.DrawPanel.Controls.Add(_cell);
            }

            // 显示信息
            SnakePoint.Text = string.Format("X:{0}    Y:{1}    snakeScore:{2}", snakeCells[0].Location.X, snakeCells[0].Location.Y, snakeScore-1);

        }

        /// <summary>
        /// 开始游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = btnStop.Enabled = true;
            btnStart.Enabled = false;

            this.snakeAction = true;
            this.SnakeTimer.Start();
        }

        /// <summary>
        /// 暂停游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = btnStop.Enabled = true;
            btnPause.Enabled = false;

            this.snakeAction = false;
            this.SnakeTimer.Stop();
        }

        /// <summary>
        /// 结束游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = btnStop.Enabled = false;

            this.InitGame();
        }

        /// <summary>
        /// 定时控件：控制贪食蛇的自动运动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SnakeTimer_Tick(object sender, EventArgs e)
        {

            int xRan = snakeCells[0].Location.X;
            int yRan = snakeCells[0].Location.Y;

            if (this.KeyCode == Keys.Up)
            {
                yRan -= this.snakeSize;   //向上移动
            }
            else if (this.KeyCode == Keys.Down)
            {
                yRan += this.snakeSize;   //向下移动
            }
            else if (this.KeyCode == Keys.Left)
            {
                xRan -= this.snakeSize;   //向左移动
            }
            else if (this.KeyCode == Keys.Right)
            {
                xRan += this.snakeSize;   //向右移动
            }

            bool isOut = (xRan < 0 || xRan > (this.DrawPanel.Width - this.snakeSize) || yRan < 0 || yRan > (this.DrawPanel.Height - this.snakeSize));

            // 检测贪食蛇是否在游戏区域中
            if (isOut && !chbNodie.Checked)//如果没有不在游戏区域中且没有选中无敌模式，则游戏结束
            {
                this.SnakeTimer.Stop();
                MessageBox.Show(string.Format("Game Over！您的得分为{0}",snakeScore-1));
                this.InitGame();
                return;
            }
            // 无敌模式：穿墙设置
            else if (isOut && chbNodie.Checked)
            {
                if (xRan > this.DrawPanel.Width)
                {
                    xRan = 0;
                }
                if (xRan < 0)
                {
                    xRan = this.DrawPanel.Width;
                }
                if (yRan > this.DrawPanel.Height)
                {
                    yRan = 0;
                }
                if (yRan < 0)
                {
                    yRan = this.DrawPanel.Height;
                }
            }
            for (int i = snakeScore - 1; i > 0; i--)
            {
                // 蛇身所有格子前进到前一个格子的位置
                snakeCells[i].Location = new Point(snakeCells[i - 1].Location.X, snakeCells[i - 1].Location.Y);
            }

            // 蛇头前进一个格子
            snakeCells[0].Location = new Point(xRan, yRan);

            List<Label> _findFoods = foodCells.Where(n => n.Location == snakeCells[0].Location).ToList<Label>();

            for (int i = 0; i < _findFoods.Count(); i++)
            {
                // 消除游戏区域中的食物
                this.DrawPanel.Controls.Remove(_findFoods[i]);
                //_findFoods[i].Text = Num_food.ToString();
                flag[i] = int.Parse(_findFoods[i].Text);

                //Num_food++;

                //消除数组中的食物
                foodCells.Remove(_findFoods[i]);

                // 蛇身变长
                Label _cell = CreateCell(snakeCells[snakeCells.Count - 1].Location, Color.Blue);
                snakeCells.Add(_cell);
                _cell.Text = snakeCells[i].Text;
                this.DrawPanel.Controls.Add(_cell);
                _cell.Text = flag[i++].ToString();
                //增加蛇身长度
                snakeScore++;
            }

            if (foodCells.Count == 0)
            {
                InitFood();
            }

            SnakePoint.Text = string.Format("X:{0}    Y:{1}    snakeScore:{2}", snakeCells[0].Location.X, snakeCells[0].Location.Y, snakeScore-1);
        }

        /// <summary>
        /// 监控方向键：改变贪食蛇的运动方向（上下左右）
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys _keyCode)
        {
            // 只对上下左右按键做出响应
            if (_keyCode == Keys.Up || _keyCode == Keys.Down || _keyCode == Keys.Left || _keyCode == Keys.Right)
            {

                // 记录按下的方向键
                this.KeyCode = _keyCode;

                if (!snakeAction)
                {
                    snakeAction = true;
                    SnakeTimer.Start();

                    btnPause.Enabled = btnStop.Enabled = true;
                    btnStart.Enabled = false;
                }

                return false;
            }
            else
            {
                return base.ProcessDialogKey(_keyCode);
            }
        }
        #endregion

        #region 生产食物
        /// <summary>
        /// 食物初始化
        /// </summary>
        private void InitFood()
        {
            CreateFood(foodCount);
        }

        /// <summary>
        ///生产食物
        /// </summary>
        /// <param name="foodCount"></param>
        public void CreateFood(int foodCount)
        {
            Random ran = new Random();//随机类
            int xRan, yRan;

            for (int i = 0; i < foodCount; i++)
            {
                // 随机生成食物放置的X、Y坐标
                xRan = ran.Next(0, this.DrawPanel.Width / this.snakeSize) * this.snakeSize;
                yRan = ran.Next(0, this.DrawPanel.Height / this.snakeSize) * this.snakeSize;

                if (xRan > this.DrawPanel.Width - 10 || xRan > this.DrawPanel.Height - 10)
                {
                    xRan = ran.Next(0, this.DrawPanel.Width / snakeSize) * snakeSize;
                    yRan = ran.Next(0, this.DrawPanel.Height / snakeSize) * snakeSize;
                }

                Point FoodPoint = new Point(xRan, yRan);

                // 检索指定坐标处的子控件
                var newFood = this.DrawPanel.GetChildAtPoint(FoodPoint);
                if (newFood == null)
                {
                    // 创建方格
                    Label food_cell = CreateCell(FoodPoint, Color.White);

                    // 将方格添加到食物集合
                    foodCells.Add(food_cell);

                    // 绘制到游戏区域
                    this.DrawPanel.Controls.Add(food_cell);
                }
            }
        }
        #endregion

        #region 通用方法
        /// <summary>
        /// 创建格子
        /// </summary>
        /// <returns></returns>
        private Label CreateCell(Point point)
        {
            Label cell = new Label();
            cell.Size = new Size(this.snakeSize, this.snakeSize);
            cell.Location = point;
            cell.BackColor = Color.Red;
            cell.BorderStyle = BorderStyle.FixedSingle;

            return cell;
        }

        /// <summary>
        /// 创建格子
        /// </summary>
        /// <returns></returns>
        private Label CreateCell(Point point, Color color)
        {
            Label food_cell = new Label();
            food_cell.Size = new Size(this.snakeSize, this.snakeSize);
            food_cell.Location = point;
            food_cell.BackColor = color;
            food_cell.Text = Num_food.ToString();
            Num_food++;
            food_cell.BorderStyle = BorderStyle.FixedSingle;
            return food_cell;
        }
        #endregion

        #region 事件

        /// <summary>
        /// 设置初始长度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSnakeCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitGame();
        }

        /// <summary>
        /// 设置初始大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSnakeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitGame();
        }

        /// <summary>
        /// 设置食物数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFoodCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitGame();
        }

        /// <summary>
        /// 开启无敌模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbNodie_CheckedChanged(object sender, EventArgs e)
        {
            //InitGame();

            this.KeyPreview = true;
            this.DrawPanel.Focus();
        }

        /// <summary>
        /// 设置爬行速度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            SnakeTimer.Interval = this.snakeSpeed;

            this.KeyPreview = true;
            this.DrawPanel.Focus();
        }

        /// <summary>
        /// 在pannel中加上背景图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(new Bitmap(Properties.Resources.bg), 0, 0);
        }


        /// <summary>
        /// 游戏的帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Directotion direction = new Directotion();
            direction.Show();

            //if (direction!=null)
            //{
            //    this.Show();
            //}

        }
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();

            setting.Show();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出F10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
