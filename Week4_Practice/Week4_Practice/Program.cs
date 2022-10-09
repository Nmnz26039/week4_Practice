using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Week4_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse();
            //Console.WriteLine(Suite());
            //Q3a();
            //Q3();
            //Compress();
            //Amstrong();
            Q6();
            /*
            Console.WriteLine("Enter a number");
            int nb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + Facto(nb));
            //Q8();

            Person p1 = new Person("Sam");
            Person p2 = new Person("Harry");
            Person p3 = new Person("Bill");

            Console.WriteLine(p1.toString());
            Console.WriteLine(p2.toString());
            Console.WriteLine(p3.toString()); */

            Console.ReadKey();
        }

        //Q1
        static void Reverse()
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            char[] str2 = str.ToCharArray();
            str2[0] = str[str.Length-1];
            str2[str2.Length-1]= str[0];

            Console.WriteLine(str2);
        }
        //Q2
        static bool Suite()
        {
            bool answer = false;

            int[] tab = { 7, 5, 2, 3, 4, 5, 8 };
            int[] seq = { 3, 4, 5 };
            
            for(int i=0;i<tab.Length; i++)
            {
                answer = true;
                for(int j = 0; j < seq.Length; j++)
                {
                    if (tab[i + j] != seq[j])
                    {
                        answer = false;
                        break;
                    }
                }
                if (answer)
                {
                    return true;
                }
                
            } 
            return answer;
        }
        //Q3a
        static void Q3a()
        {
            Console.WriteLine("Enter a char : ");
            char cara = Convert.ToChar(Console.ReadLine());
            int value = Convert.ToInt32(cara);
            Console.WriteLine("The ASCII Value of " + cara + " is : " + value);
        }
        //Q3
        static void Q3()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            byte[] tab = new byte[str.Length];

            for(int i=0; i<str.Length; i++)
            {
                tab[i] = Convert.ToByte(str[i]);
            }

            for(int i = tab.Length-1; i>=0; i--)
            {
                for(int j = 1; j<=i; j++)
                {
                    if (tab[j - 1] < tab[j])
                    {
                        byte stock = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = stock;
                    }
                }
            }
            string s = Encoding.ASCII.GetString(tab);

            Console.WriteLine(s);

        }
        //Q4
        static void Compress()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            int count = 1;
            string res = "";

            for(int i=1; i<str.Length; i++)
            {
                if (str[i - 1] == str[i])
                {
                    count++;
                }
                else
                {
                    res += str[i - 1] + Convert.ToString(count);
                    count = 1;
                }

            }
            res += str.Last() + Convert.ToString(count);
            Console.WriteLine(res);
        }
        //Q5
        static void Amstrong()
        {
            int count = 1;
            for(int i = 0; i < 1000; i++)
            {
                int cent = i / 100;
                int dix = (i - cent * 100) / 10;
                int unity = (i - (i / 10) * 10);
                
                double res = Math.Pow(cent, 3) + Math.Pow(dix,3) + Math.Pow(unity, 3);

                if (res == i)
                {
                    Console.WriteLine("Amstrong number " + count + " : " + i);
                    count += 1;
                }
            }  
           
        }
        //Q6
        static void Q6()
        {
            int[] tab = { 5, 7, 5, 2, 2, 4, 5 };
            int count = tab.Count(c => c == 0);
            if(count != 0)
            {
                Console.WriteLine("0 is " + count + " times.");
            }

            for (int i = 0; i<tab.Length; i++)
            {
                count = tab.Count(c => c == tab[i]);
                if (tab[i] != 0)
                {
                    Console.WriteLine(tab[i] + " is " + count + " times.");
                }
                
                int a = tab[i];

                for (int j= 0; j < tab.Length; j++)
                {
                    if (tab[j] == a)
                    {
                        tab[j] = 0;
                    }
                } 
            }
        }
        //Q7
        static int Facto(int nb)
        {
            if (nb == 0) return 1;
            return nb * Facto(nb-1);
        }
        //Q8
        static void Q8()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            int cnt = 0;
            cnt = str.Count(Char.IsWhiteSpace);
            Console.WriteLine("Number of white space : " + cnt);
        } 
    }
}
