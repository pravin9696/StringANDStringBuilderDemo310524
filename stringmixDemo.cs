using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringANDStringBuilderDemo310524
{
     /* str1= hello
      * str2=world
      * str3=hweolrllod
      * */


    internal class stringmixDemo
    {
        public void method()
        {
            string str1 = "Hello";
            String str2 = "world";

            char[] ch1 = str1.ToCharArray();//5
            char[] ch2 = str2.ToCharArray();//5
            char[] ch3 = new char[ch1.Length+ch2.Length];//10

            for (int i = 0, j = 0 ; i < ch3.Length-1; i++,j++)
            {
                if (j < ch1.Length) //5               
                {
                    ch3[i] = ch1[j];
                    i++;
                }
                if (j < ch2.Length)
                {
                    ch3[i] = ch2[j];
                }
                
            }
            string finaloutput = new string(ch3);
            Console.WriteLine(finaloutput);
        }
    }
}
