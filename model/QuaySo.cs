using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace QuaySoLoto.model
{
    class QuaySo
    {
        public static string  Quay()
        {
            int soMax =int.Parse( ConfigurationManager.AppSettings["SoMax"]);
            int r = getRanDom(soMax);
            String s = r.ToString();
            int leng = soMax.ToString().Length;
            if(s.Length < leng)
            {
                for(int i = 0; i< leng - s.Length; i++)
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
    }
}
