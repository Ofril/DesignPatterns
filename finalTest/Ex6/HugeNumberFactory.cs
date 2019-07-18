using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    public static class HugeNumberFactory
    {
        private static Dictionary<string, HugeNumber> numbers = new Dictionary<string, HugeNumber>();
        
        public static HugeNumber GetHugeNumber(string key)
        {
            if (numbers.TryGetValue(key, out HugeNumber result))
            {
                return result;
            }
            else
            {
                string[] HugeNumberComp = key.Split(',');
                numbers.Add(key, new HugeNumber(Convert.ToInt32(HugeNumberComp[0]), Convert.ToInt32(HugeNumberComp[1])));

                return numbers[key];
            }
        }

    }
}
