using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace QuaySoLoto.model
{
    class QuaySo
    {
        static String fileName = "data.xml";

        public static string Quay()
        {
            int soMax = int.Parse(ConfigurationManager.AppSettings["SoMax"]);
            int r = getRanDom(soMax);
            String s = r.ToString();
            int leng = soMax.ToString().Length;
            if (s.Length < leng)
            {
                for (int i = 0; i < leng - s.Length; i++)
                {
                    s = "0" + s;
                }
            }
            return s;
        }

        public static int getRanDom(int soMax)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            return r.Next(soMax);
        }

        public static List<KetQua> ReadFile()
        {
            List<KetQua> li = new List<KetQua>();
            
            XmlDocument doc = new XmlDocument();
            try
            {
                
                doc.Load(fileName);
                XmlNode all = doc.ChildNodes[1];
                var tatCaKetQua = all.ChildNodes;
                var kq = tatCaKetQua[0];
                while (true) {
                    if(kq == null)
                    {
                        break;
                    }
                    var ketQua = new KetQua() {
                        So = kq.ChildNodes[0].InnerText,
                        ThoiGian = DateTime.Parse(kq.ChildNodes[1].InnerText)
                    };
                    li.Add(ketQua);
                    kq = kq.NextSibling;
                };
            }
            catch (Exception ex)
            {
                
            }
            
            return li;
        }

        public static void updateFile(List<KetQua> li) {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            var root = doc.ChildNodes[1];
            root.RemoveAll();
            foreach(var kq in li)
            {
                XmlElement e = doc.CreateElement("KetQua");
                var nSo = doc.CreateElement("So");
                nSo.InnerText = kq.So;
                var nThoiGian = doc.CreateElement("ThoiGian");
                nThoiGian.InnerText = kq.ThoiGian.ToShortTimeString();

                e.AppendChild(nSo);
                e.AppendChild(nThoiGian);
                root.AppendChild(e);
            }
            doc.Save(fileName);
        }
    }
}
