using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace DrawNumbers
{
    public partial class Form : System.Windows.Forms.Form
    {

        [DllImport("User32.dll", EntryPoint = "MoveWindow")]//引入一个DLL使窗口位置可以改变
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool BRePaint);

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
                    if (ContinuousBox.Checked == true)//判断连续抽取是否开启
                    {
                        //连续抽取
                        Loop();
                    }
                    else
                    {
                        //普通抽取
                        Timer1.Enabled = true;
                        Startbtn.Text = "停止";
                    }
                    
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

        private void Form_SizeChanged(object sender, EventArgs e)//自动根据窗口大小改变控件大小（还没做）
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

        private void Form_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;//防卡死
            YML yml = new YML();
            yml.Load(File.ReadAllText("config.yml"));//读配置文件
            MoveWindow(this.Handle, int.Parse(yml.GetValue("LocationX")), int.Parse(yml.GetValue("LocationY")), int.Parse(yml.GetValue("Width")), int.Parse(yml.GetValue("Height")), true);//窗口位置和大小
            this.NumFrom.Text = yml.GetValue("NumFrom");//抽取号码范围从
            this.NumTo.Text = yml.GetValue("NumTo");//抽取号码范围到
            this.ContinuousBox.Checked = Convert.ToBoolean(yml.GetValue("Continuous"));//是否连续抽取
            this.ContinuousNumBox.Text = yml.GetValue("ContinuousNumBox");//连续抽取个数
            this.ContinuousIntervalBox.Checked = Convert.ToBoolean(yml.GetValue("ContinuousInterval"));//连续抽取间隔时间开关
            this.IntervalTime.Text = yml.GetValue("IntervalTime");//连续抽取间隔时间
            this.NoRep.Checked = Convert.ToBoolean(yml.GetValue("NoRep"));//抽取不重复开关
        }
        private void Loop()
        {
            BackgroundWorker thread = new BackgroundWorker();//创建一个后台线程
            thread.DoWork += (object sender, DoWorkEventArgs e) => {};
        }

        private void ExportConfigBtn_Click(object sender, EventArgs e)
        {
            YML yml = new YML();//添加配置文件
            yml.AddValue("Width", this.Width.ToString());//窗口宽度
            yml.AddValue("Height", this.Height.ToString());//窗口高度
            yml.AddValue("LocationX", this.Location.X.ToString());//窗口所在位置（X）
            yml.AddValue("LocationY", this.Location.Y.ToString());//窗口所在位置（Y）
            yml.AddValue("NumFrom", this.NumFrom.Text);//抽取号码范围从
            yml.AddValue("NumTo", this.NumTo.Text);//抽取号码范围到
            yml.AddValue("Continuous", this.ContinuousBox.Checked.ToString());//是否连续抽取
            yml.AddValue("ContinuousNumBox", this.ContinuousNumBox.Text);//连续抽取个数
            yml.AddValue("ContinuousInterval", this.ContinuousIntervalBox.Checked.ToString());//连续抽取间隔时间开关
            yml.AddValue("IntervalTime", this.IntervalTime.Text);//连续抽取间隔时间
            yml.AddValue("NoRep", this.NoRep.Checked.ToString());//抽取不重复开关
            string configuration = yml.ToString();//导出配置
            SaveFileDialog O = new SaveFileDialog//打开保存文件对话框
            {
                Filter = "|*.yml"//文件后缀为.yml
            };
            if (O.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(O.FileName, configuration);//写配置文件
                MessageBox.Show("导出配置文件完成");
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)//关闭程序时保存配置文件
        {
            if (NoSaveConfig.Checked == false)
            {
                YML yml = new YML();//添加配置文件
                yml.AddValue("Width", this.Width.ToString());//窗口宽度
                yml.AddValue("Height", this.Height.ToString());//窗口高度
                yml.AddValue("LocationX", this.Location.X.ToString());//窗口所在位置（X）
                yml.AddValue("LocationY", this.Location.Y.ToString());//窗口所在位置（Y）
                yml.AddValue("NumFrom", this.NumFrom.Text);//抽取号码范围从
                yml.AddValue("NumTo", this.NumTo.Text);//抽取号码范围到
                yml.AddValue("Continuous", this.ContinuousBox.Checked.ToString());//是否连续抽取
                yml.AddValue("ContinuousNumBox", this.ContinuousNumBox.Text);//连续抽取个数
                yml.AddValue("ContinuousInterval", this.ContinuousIntervalBox.Checked.ToString());//连续抽取间隔时间开关
                yml.AddValue("IntervalTime", this.IntervalTime.Text);//连续抽取间隔时间
                yml.AddValue("NoRep", this.NoRep.Checked.ToString());//抽取不重复开关
                string configuration = yml.ToString();//导出配置
                File.WriteAllText("config.yml", configuration);//写配置文件
            }
        }

        private void ImportConfig_Click(object sender, EventArgs e)
        {
            YML yml = new YML();//添加配置文件
            OpenFileDialog O = new OpenFileDialog//打开打开文件对话框
            {
                Filter = "|*.yml"//文件后缀为.yml
            };
            if (O.ShowDialog() == DialogResult.OK)
            {
                yml.Load(File.ReadAllText(O.FileName));//读配置文件
                MoveWindow(this.Handle, int.Parse(yml.GetValue("LocationX")), int.Parse(yml.GetValue("LocationY")), int.Parse(yml.GetValue("Width")), int.Parse(yml.GetValue("Height")), true);//窗口位置和大小
                this.NumFrom.Text = yml.GetValue("NumFrom");//抽取号码范围从
                this.NumTo.Text = yml.GetValue("NumTo");//抽取号码范围到
                this.ContinuousBox.Checked = Convert.ToBoolean(yml.GetValue("Continuous"));//是否连续抽取
                this.ContinuousNumBox.Text = yml.GetValue("ContinuousNumBox");//连续抽取个数
                this.ContinuousIntervalBox.Checked = Convert.ToBoolean(yml.GetValue("ContinuousInterval"));//连续抽取间隔时间开关
                this.IntervalTime.Text = yml.GetValue("IntervalTime");//连续抽取间隔时间
                this.NoRep.Checked = Convert.ToBoolean(yml.GetValue("NoRep"));//抽取不重复开关
                MessageBox.Show("读取配置文件完成");
            }
            
        }
    }


    class YML//YML配置文件读写
    {
        private string Ymlvalue = "";
        public override string ToString()
        {
            return Ymlvalue;
        }
        public void AddValue(string key, string value)//添加一个项目和它的值
        {
            Ymlvalue += "\n" + key + ": " + value;
        }

        public string GetValue(string key)
        {
            string[] ymls = Ymlvalue.Split('\n');
            bool isfound = false;
            string ymla = "";
            foreach (string yml in ymls)
            {
                if (yml.Trim().StartsWith(key))
                {
                    
                    isfound = true;
                    ymla = yml.Trim();
                    
                    break;
                }
                
            }
            if (!isfound)
                {
                    return null;
                }
            else
                {
                    return ymla.Split(':')[1].Trim();
                }
        }
        public void Load(string yml)
        {
            Ymlvalue = yml;
        }
    }

}
