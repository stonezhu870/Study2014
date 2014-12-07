using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Common
    {
        public static int SafeInt(object str, int defaultValue = 0)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
