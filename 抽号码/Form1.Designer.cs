namespace 抽号码
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.NoRep = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumFrom = new System.Windows.Forms.TextBox();
            this.NumTo = new System.Windows.Forms.TextBox();
            this.Continuous = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IntervalTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Continuously = new System.Windows.Forms.CheckBox();
            this.Startbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Isinteger = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NoRep
            // 
            this.NoRep.AutoSize = true;
            this.NoRep.Location = new System.Drawing.Point(476, 330);
            this.NoRep.Name = "NoRep";
            this.NoRep.Size = new System.Drawing.Size(87, 21);
            this.NoRep.TabIndex = 0;
            this.NoRep.Text = "抽取不重复";
            this.NoRep.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "抽取范围：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "至";
            // 
            // NumFrom
            // 
            this.NumFrom.Location = new System.Drawing.Point(87, 10);
            this.NumFrom.Name = "NumFrom";
            this.NumFrom.Size = new System.Drawing.Size(100, 23);
            this.NumFrom.TabIndex = 3;
            this.NumFrom.Text = "1";
            this.NumFrom.TextChanged += new System.EventHandler(this.NumFrom_TextChanged);
            // 
            // NumTo
            // 
            this.NumTo.Location = new System.Drawing.Point(219, 10);
            this.NumTo.Name = "NumTo";
            this.NumTo.Size = new System.Drawing.Size(100, 23);
            this.NumTo.TabIndex = 4;
            this.NumTo.Text = "50";
            this.NumTo.TextChanged += new System.EventHandler(this.NumTo_TextChanged);
            // 
            // Continuous
            // 
            this.Continuous.AutoSize = true;
            this.Continuous.Location = new System.Drawing.Point(16, 330);
            this.Continuous.Name = "Continuous";
            this.Continuous.Size = new System.Drawing.Size(75, 21);
            this.Continuous.TabIndex = 5;
            this.Continuous.Text = "连续抽取";
            this.Continuous.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "个";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "20";
            // 
            // IntervalTime
            // 
            this.IntervalTime.Location = new System.Drawing.Point(276, 328);
            this.IntervalTime.Name = "IntervalTime";
            this.IntervalTime.Size = new System.Drawing.Size(100, 23);
            this.IntervalTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "秒";
            // 
            // Continuously
            // 
            this.Continuously.AutoSize = true;
            this.Continuously.Location = new System.Drawing.Point(219, 330);
            this.Continuously.Name = "Continuously";
            this.Continuously.Size = new System.Drawing.Size(51, 21);
            this.Continuously.TabIndex = 10;
            this.Continuously.Text = "间隔";
            this.Continuously.UseVisualStyleBackColor = true;
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(325, 10);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(238, 97);
            this.Startbtn.TabIndex = 11;
            this.Startbtn.Text = "开始";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "结果：";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Result.Location = new System.Drawing.Point(66, 102);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(108, 124);
            this.Result.TabIndex = 13;
            this.Result.Text = "0";
            // 
            // Isinteger
            // 
            this.Isinteger.AutoSize = true;
            this.Isinteger.Location = new System.Drawing.Point(130, 36);
            this.Isinteger.Name = "Isinteger";
            this.Isinteger.Size = new System.Drawing.Size(140, 17);
            this.Isinteger.TabIndex = 14;
            this.Isinteger.Text = "请确定你输入的是整数！";
            this.Isinteger.Visible = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 50;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 363);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.Isinteger);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Continuously);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IntervalTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Continuous);
            this.Controls.Add(this.NumTo);
            this.Controls.Add(this.NumFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoRep);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽号码";
            this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NoRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumFrom;
        private System.Windows.Forms.TextBox NumTo;
        private System.Windows.Forms.CheckBox Continuous;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IntervalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Continuously;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Isinteger;
        private System.Windows.Forms.Timer Timer1;
    }
}

