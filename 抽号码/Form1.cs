using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 抽号码
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void Startbtn_Click(object sender, EventArgs e)
        {
            if (Isinteger.Visible == true)
            {
                MessageBox.Show("你输入的抽取范围不是整数！请改正！");
            }
            else
            {
                if (Timer1.Enabled == false)//通过抽号码的计时器是否开启判断是否在抽取
                {
                    Timer1.Enabled = true;
                    Startbtn.Text = "停止";
                }
                else
                {
                    Timer1.Enabled = false;
                    Startbtn.Text = "开始";
                }
            }
            
        }

        private void NumFrom_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(NumFrom.Text, out _))//判断抽取范围“从”是否能转化为int
            {
                Isinteger.Visible = false;
            }
            else 
            {
                Isinteger.Visible = true;
            }
        }

        private void NumTo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(NumTo.Text, out _))//判断抽取范围“到”是否能转化为int
            {
                Isinteger.Visible = false;
            }
            else
            {
                Isinteger.Visible = true;
            }
        }

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            int Startbtonx = Startbtn.Location.X;
            int Startbtony = Startbtn.Location.Y;

            Startbtn.Location = new Point(Startbtonx, Startbtony);
        }

        private void Timer1_Tick(object sender, EventArgs e)//抽取号码的计时器
        {
            Random rm = new Random();
            int sample = rm.Next(int.Parse(NumFrom.Text), int.Parse(NumTo.Text));//将随机数输出到sample
            this.Result.Text = sample.ToString();//将sample显示在“结果”
        }
    }
}
