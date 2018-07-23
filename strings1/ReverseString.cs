using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings1
{
    class ReverseString
    {
        public string reverse(string input)
        {
            int strLength = input.Length - 1;
            List<string> stringtoreverse = new List<string>();
            while (strLength >= 0)
            {
                stringtoreverse.Add(input.Substring(strLength - 1, strLength));
                strLength--;
            }
            string final = string.Join(",", stringtoreverse.ToArray());

            return final;
        }





    }
}
