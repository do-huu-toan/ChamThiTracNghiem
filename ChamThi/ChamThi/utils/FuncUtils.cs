using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamThi.utils
{
    public class FuncUtils
    {
        public static int GetIntValue(object data)
        {
            try
            {
                return Int32.Parse(data.ToString());
            }catch(Exception e)
            {
                return 0;
            }
        }

        public static string GetStringValue(object data)
        {
            try
            {
                if (data != null)
                {
                    return data.ToString();
                }
            }
            catch (Exception e)
            {
                
            }
            return "";
        }
    }
}
