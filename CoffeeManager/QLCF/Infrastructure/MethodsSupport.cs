using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace QLCF.Infrastructure
{
    public static class MethodsSupport 
    {
        public static void DynamicUsing(object resource, Action action)
        {
            try
            {
                action();
            }
            finally
            {
                IDisposable d = resource as IDisposable;
                if (d != null)
                    d.Dispose();
            }
        }
        public static int Count(this IEnumerable source)
        {
            var col = source as ICollection;
            if (col != null)
                return col.Count;

            int c = 0;
            var e = source.GetEnumerator();
            DynamicUsing(e, () =>
            {
                while (e.MoveNext())
                    c++;
            });

            return c;
        }

        public static string HasPass(string str)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(str);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string result = "";
            foreach(var item in hasData)
            {
                result += item;
            }
            return result;
        }
        
    }
}
