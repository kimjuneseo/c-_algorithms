﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ConsoleApplication1
{

    class Parent
    {
        public virtual int sumFn(int x, int y)
        {
            return x * y;
        }
    }

    class Childe : Parent
    {
        public override int sumFn(int x, int y)
        {
            return x * y; 

        }
    }
    class Program
    {
        
       static void Main(string[] args)
       {
            Program pr = new Program();
           // 오버라이딩
            Childe Cr = new Childe();
            DataTable table = getData();
           // dataset 출력
           // DataRow[] datas =  table.Select();
           // foreach(DataRow i in datas){
           //     Console.Write(i["index"] + " " );
           //      Console.Write(i["sex"] + " ");
           //      Console.Write(i["name"]+ "\n");     
           // }

            // 오버로딩
            //Console.Write(Cr.sumFn(5, 6));
            //pr.gcmLcmFindFn(10, 15);
            // 다이아몬드
            //pr.diamond();
            // 피보나치 수열
            //pr.fibonacciSequence();

        }
        // 구구단 메소드
        public  void sum()
        {
               for (int i = 1; i <= 9; i++)
               {
                   Console.WriteLine(i + "단");
                   for (int y = 1; y <= 9; y++) {
                        Console.WriteLine(i + "x" + y +"="+ i*y);
                   }
               }
        }

        // 두 수를 입력 받아 최대공약수, 최소공배수 구하기
        public void gcmLcmFindFn(int firstNum, int lastNum)
        {
            firstNum /= 2;
            lastNum  /= 2;
            
            Console.Write(firstNum + " " + lastNum);
            

        }
        // 다이아몬드 
        public void diamond()
        {
            int space = 0;
            int star = 0;
            int lineCnt = 9;
            for (int line = 0; line < lineCnt; line++) {
                if (lineCnt / 2 >= line) star = star == 0 ? 1 : line * 2 + 1;
                else star = star - (line - 1) / 2 < 0 ? 1 : star - (line - 1) / 2;
                space = lineCnt - star;
                for (int j = 1; j <=  lineCnt; j++)
                { 
                    if (space / 2 >= j || lineCnt - space/2 < j)
                    {
                        Console.Write(" ");
                     }
                     else
                     {
                         Console.Write("*");
                     }
                }
                Console.WriteLine("");
             }
            //for()
        }

        // 두 수를 입력받아 곱셈
        public  int sumFn(int x, int y)
        {
            return x * y;
        }
        // sumFn 오버로링
        public double sumFn(int x, double y)
        {
            return x * y;
        }
        // sumFn 오버로링
        public double sumFn(double x, double y)
        {    
            return x * y;
        }
        // sumFn 오버로링
        public int sumFn(int x, int y, int z)
        {
            return x * y * z;
        }


        // 피보나치 수열
        int fiboCount = 0;
        public int fiboFn(int x)
        {
            int result = fiboCount + x;
            fiboCount = x;
            return result;
         
        }
        public void fibonacciSequence()
        {
            for (int i = 1; i < 300; i+=0)
            {
                i = fiboFn(i);
                Console.Write(i +" ");
            }
        }
        //dataset colum추가 row추가
        static DataTable getData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("index", typeof(int));
            table.Columns.Add("sex", typeof(string));
            table.Columns.Add("name", typeof(string));

            table.Rows.Add(1, "여", "주희");
            table.Rows.Add(2, "남", "창식");
            table.Rows.Add(3, "여", "명희");
            return table;
        }
            
            
        }
 

    }

