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
            List<string> chars = new List<string>();
            
            for(int i = 0; i <= input.Length - 1; i++)
            {
                string get = input.Substring(i, i - 1);
                chars.Add(get);
            }

            return string.Join("", chars);
        }





    }
}
