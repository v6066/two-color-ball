using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 双色球
{
    public partial class Form1 : Form
    {//定义全局变量
        Random myrd = new Random();
        ArrayList redBalls = new ArrayList();
        ArrayList blueBalls = new ArrayList();
        int[] gLuckBalls = new int[7];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //随机产生红球
            for (int i=0;i<=5 ;i++ )
            {
                int rdIndex = myrd.Next(0, 33-i);

                gLuckBalls[i] = Convert.ToInt32(redBalls[rdIndex]);
                redBalls.RemoveAt(rdIndex);

                this.rtx_redBall.Clear();
                foreach (object redB in redBalls)
                {
                    this.rtx_redBall.Text += redB + " ";
                    }
                         }
            //随机产生蓝球
                int blIndex = myrd.Next(0, 16);
                gLuckBalls[6] = Convert.ToInt32(blueBalls[blIndex]);
                blueBalls.RemoveAt(blIndex);

                this.rtx_blueBall.Clear();
                foreach (object blueB in blueBalls)
                {
                    this.rtx_blueBall.Text += blueB + " ";
                }
                //显示中奖号
                foreach(int glb in gLuckBalls)
            {
                this.rtx_gLuckBall.Text += glb + " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化动态数组蓝球池和红球池数组（红：1-33，蓝：1-16）
            for(int i=1;i<=33 ;i++ )
            {
                redBalls.Add(i);
            }
            for (int j= 1; j <= 16; j++)
            {
                blueBalls.Add(j);
            }
            //显示红球池和蓝球池到窗体所对应的多行文本框中
            foreach(object redB in redBalls)
            {
                this.rtx_redBall.Text += redB + " ";
            }
            foreach (object blueB in blueBalls)
            {
                this.rtx_blueBall.Text += blueB + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rtx_redBall.Text = "";
            this.rtx_blueBall.Text = "";
            this.rtx_gLuckBall.Text = "";
            blueBalls.Clear();
            redBalls.Clear();
            Form1_Load(null, null);
        }
    }
}
