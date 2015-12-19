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
        int soChuSo;

        int interCount = 0;
        List<KetQua> li;
        String text = "000";

        public Form1()
        {
            InitializeComponent();
            thoiGianQuay = int.Parse(ConfigurationManager.AppSettings["ThoiGianQuay"]);
            
            initLable();
            loadFile();
        }

        private void initLable()
        {
            int soMax = int.Parse(ConfigurationManager.AppSettings["SoMax"]);
            soChuSo = soMax.ToString().Length;
            text = "0";
            for(int i = 0; i< soChuSo-1; i++)
            {
                text += "0";
            }
            lblSo.Text = text;
        }

        void loadFile()
        {
            li = QuaySo.ReadFile();
            bindingSource1.DataSource = li;
            dgrSo.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            lblSo.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long t = (thoiGianQuay * 1000) / 2;
            if (interCount > t)
            {
                var trung = li.FirstOrDefault(s => s.So.Equals(t.ToString()));
                //Nếu trùng rồi thì quay tiếp
                if (trung == null)
                {
                    timer1.Stop();
                    addKQ();
                    QuaySo.updateFile(li);
                    resetClock();
                    lblSo.ForeColor = Color.Red;
                }
            }
            else
            {
                text = QuaySo.Quay();
                lblSo.Text = text;
                interCount += timer1.Interval;
            }
            //Text = interCount.ToString() + "/" + t.ToString();
        }

        private void resetClock()
        {
            interCount = 0;
        }

        void addKQ() {
            KetQua kq = new KetQua() { So = text, ThoiGian = DateTime.Now };
            li.Add(kq);
            bindingSource1.DataSource = li;
            dgrSo.DataSource = null;
            dgrSo.DataSource = bindingSource1;
        }

        bool tryMethod()
        {
            String s = QuaySo.Quay();
            lblSo.Text = s;
            return true;
        }
    }
}
