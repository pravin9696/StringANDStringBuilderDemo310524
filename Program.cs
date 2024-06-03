using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringANDStringBuilderDemo310524
{
   class xyz
    {

    }
    
  public class Program
    {
        static int ii = 1;
      
       static void Main(string[] args)
        {
            String s1 = " Pune ";  // enpu
          

           //int n= s1.CompareTo(s2);

            /*   if s2>s1  ==> +1   OR   s1<s2==-1
             *   if  s2==s1==> 0        s1==s2=0
             *   if s2<s1  ===> -1      s1>s2=+1
             */
            //Console.WriteLine(n);


            //  int nn = String.Compare(s1,s2);
            //  Console.WriteLine(nn);

            //var temp1 = String.Concat(s1, s2);
            //  Console.WriteLine(temp1);//

            //Console.WriteLine("index of mumbai"+s1.IndexOf(s2));

            //char[] ch = new char[20];
            //s1.CopyTo(0, ch, 0, 3);
            //Console.WriteLine(ch);

            //string data1 = "1 rajesh Engg a 123456789";
            //var result = data1.Split();
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            char[] ch2=s1.ToCharArray();
            //Console.WriteLine(ch2);
            //for (int i = 0; i < ch2.Length; i++)
            //{
            //    for (int j = i; j < ch2.Length; j++)
            //    {
            //        if (ch2[i] > ch2[j])
            //        {
            //            char temp = ch2[i];
            //            ch2[i] = ch2[j];
            //            ch2[j]= temp;   
            //        }
            //    }
            //}
            //Console.WriteLine(ch2);
            //for (int i = 0; i < ch2.Length; i++)
            //{
            //    if (ch2[i]>='a'&& ch2[i]<='z')
            //    {
            //        ch2[i] = (char)(ch2[i]-' ');
            //    }
            //}
            //Console.WriteLine(ch2);
            //Console.WriteLine(s1.Length);
            //Console.WriteLine("**"+s1+"**");

            //string s2= s1.Trim();
            //Console.WriteLine(s2.Length);
            //Console.WriteLine("**" + s2 + "**");
            //s1 = s1.Trim();
            //Console.WriteLine(string.Compare(s1,s2));
            stringmixDemo sd = new stringmixDemo();
            sd.method();
            Console.ReadKey();
        }
    }
}
