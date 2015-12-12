using QuaySoLoto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuaySoLoto
{
    public partial class Form1 : Form
    {
        int thoiGianQuay;
        int interCount = 0;
        public Form1()
        {
            InitializeComponent();
            thoiGianQuay = int.Parse(ConfigurationManager.AppSettings["ThoiGianQuay"]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //while (sw.ElapsedMilliseconds < thoiGianQuay*1000)
            //{
            //    tryMethod();
            //}
            //sw.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (interCount > thoiGianQuay * 10000) {
                timer1.Stop();
                return;
            }
            lblSo.Text = QuaySo.Quay();
            interCount += timer1.Interval;
        }

        bool tryMethod()
        {
            String s = QuaySo.Quay();
            lblSo.Text = s;
            return true;
        }
    }
}
