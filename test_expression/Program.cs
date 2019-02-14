using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_expression
{
    public class Parent
    {
        protected virtual int Calculate(int a,int b=8)
        {
            return a+b;
        }
        protected virtual int Calculate(int a, int b ,int c)
        {
            return a + b+c;
        }
    }
    public class Child:Parent
    {
        protected override int Calculate(int a, int b = 7)
        {
            return a * b;
        }
        protected override int Calculate(int a, int b ,int c)
        {
            return a * b*c;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 19, 7, 16, 5, 7, 15 };
            int[] b = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int i = 0, j = a.Length - 1;
            while ((a[i] + b[j]) < 20 || (20 - a[i]) < 20)
            {
                i++;
                j--;

            }
            Console.WriteLine(i + "= " + j);
          

            /*
            int a = 5;
            while (!(a < 5 || a > 5))
            {
                Console.Write("HCL ");
                a--;
            }
            Console.Write("America");
            */

            //int x = 3, y = 5;
            //x = x+++y++;
            //int t= sizeof(int);
            //Console.Write(x+"  "+y);
            //Console.Write(x+++ y);
            //string s1 = "America ";
            //string s2 = s1.Insert(3, "n");
            //string s3 = s2.Insert(5, "tar");
            //for (int i = 0; i < s3.Length; i++)
            //    Console.Write(s3[i]);
            //Console.ReadLine();
            //Single k= 2.5f;
            //Console.WriteLine("Size of long: {0}", sizeof(long));

            //int val=System.Runtime.InteropServices.Marshal.SizeOf(k);
            //Console.WriteLine("value of k =" + k);
            //int[] a = new int[] { 2, 4, 5, 6, 3, -1, 0, 1, 8, 7, -2 };
            //Stack s = new Stack();
            //s.Push(a);
            //a[a.Length - 1] = Convert.ToInt32(s.Pop());
            //Console.Write("value =" + (a.Length - 1));
            //int a = 5, b = 2, result;
            //result = a / b * 25 + a / 3;
            //Console.Write(a + " " + b + " " + result + "\n");
            //a = 4; b = 7;int c = 8;
            //result = b++ / a--;
            //int result2 = result+c / b;
            //Console.Write( a+" "+ b+" "+ result+" "+ result2);

            //int[] a = new int[] { 2, 4, 5, 6, 3, -1, 0, 1, 8, 7, -2 };
            //Stack s = new Stack();
            //for (int i = 0; i < a.Length / 2; i++)
            //    s.Push(a[i]);
            //int val = (int)s.Pop()+ a[a.Length-1];
            //Console.Write("value =" + (val));

            //int a = 4, b = 7; int c = 8;
            //int result = b++ / a--; // result =1  , a= 3 , b=8
            //int result2 = result + c / b; // 1+ 8/8  = 2
            //Console.Write(a + " " + b + " " + result +" "+ result2); // 3  8  1  2

            /*
                int[] a = { 2, 10,6, 8, 1,4, 2, 7,6,-4,7,12,5 }; // find pairs wich gives the sum = 8
            Hashtable ht = new Hashtable();
            ht.Add(a[0], 0);
            Console.WriteLine("The pairs which gives the sum =8");
            for (int i=1;i<a.Length;i++)  // biju Joseph
            {
                if(ht.ContainsKey(8-a[i]))
                {
                    Console.Write("("+ (8 - a[i]) + " " + a[i]+")");
                }
                else
                    if(!ht.ContainsKey(a[i]))  // if already exists, not allowed to add duplicate
                      ht.Add(a[i], i);
            }
            Console.ReadLine();
            // another approach
            Console.WriteLine("again, pairs which gives the sum =8");
            for (int i = 0; i < a.Length; i++)
                ht.Add(i, 8 - a[i]);


            for (int i = 0; i < a.Length; i++)
            {
                if (ht.ContainsValue(8-a[i]))
                Console.WriteLine(ht[8-a[i]]+" "+i);
            }
            */
            Console.ReadLine();


        }
    }
}
