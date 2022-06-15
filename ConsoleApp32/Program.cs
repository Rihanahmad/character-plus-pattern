using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int ave;
            abc:
            Console.WriteLine("enter patten size");
            int n = int.Parse(Console.ReadLine());

            if(n<=2)
            {
                Console.Clear();
                Console.WriteLine("length must be greater than 2 for print a proper pluse patten ");
                goto abc;

            }
            else if(n%2==0)
            {
                Console.Clear();
                Console.WriteLine("enter the odd no please ");
                goto abc;

            }
            else
            {
                ave = (n/ 2)+2 ;

            }

            char f = 'A';
            char s = 'A';
            for(int i=1; i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    if(i==ave && j==ave)
                    {
                        Console.Write(f);
                        f++;
                        s++;

                    }
                    else if (i==ave)
                    {
                        Console.Write(f);
                        f++;

                    }
                    else if(j==ave)
                    {
                        Console.Write(s);
                        s++;
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }

    }
}
