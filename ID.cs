using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Agenstvo
{
    class ID
    {
        public static int id_vlad = 0;
        public static int id_pas = 0;
        public static int id_ank = 0;
        public static string hash (string s)
        {
            MD5 md5 = MD5.Create();
            byte[] b = Encoding.ASCII.GetBytes(s);
            byte[] hash_ = md5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            foreach (var a in hash_) sb.Append(a.ToString("X2"));
            return Convert.ToString(sb);
        }
    }
}
