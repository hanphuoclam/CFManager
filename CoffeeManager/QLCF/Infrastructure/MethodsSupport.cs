using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
        
    }
}
