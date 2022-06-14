using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace math
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int X, Y;
            int G; //최대공약수
            int L; //최소공배수
            int MIN;
            int r;

            Console.Write("첫번째 수를 입력하세요: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("두번째 수를 입력하세요: ");
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                G = X; MIN = Y;
            }
            else
            {
                G = Y; MIN = X;
            }

            //최대 공약수
            while (true)
            {
                r = G % MIN; // ex) x=18 y=24 => g= 24 min = 18 r= 6 g= 18 min = 6 r= 0 g= 6 min = 0
                G = MIN;
                MIN = r;
                if (r == 0)
                    break;
            }
            //최소 공배수
            L = X * Y / G;


            //결과값
            Console.WriteLine("최대공약수={0}, 최소공배수={1}", G, L);
            Console.WriteLine("최대공약수 =" + G + "최소공배수=" + L);

        }

    }
}