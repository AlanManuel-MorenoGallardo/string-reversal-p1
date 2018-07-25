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
            
            for(int i = input.Length - 1; i >= 0; i--)
            {
                char get = input[i];
                chars.Add(get.ToString());
            }

            return string.Join("", chars);
        }





    }
}
