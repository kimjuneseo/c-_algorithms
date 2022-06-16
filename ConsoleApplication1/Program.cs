using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ConsoleApplication1
{

    
    //================================== Class History Comments ==================================
    // 파  일  명 : Program.cs
    // 최초작성자 : 김준서
    // 최초작성일 : 2022.06.14
    class Parent
    {
        public virtual int sumFn(int x, int y)
        {
            return x * y;
        }
    }
    //================================== Class History Comments ==================================
    // 파  일  명 : Program.cs
    // 최초작성자 : 김준서
    // 최초작성일 : 2022.06.14
    class Childe : Parent
    {
        public override int sumFn(int x, int y)
        {
            return x * y; 

        }
    }
    //================================== Class History Comments ==================================
    // 파  일  명 : Program.cs
    // 최초작성자 : 김준서
    // 최초작성일 : 2022.06.14
    class Program
    {
        
       static void Main(string[] args)
       {
            Program pr = new Program();

            // 1. 구구단 출력
            // pr.sum(); // pr의 인스턴스 생성한다

            // 2.최대공약수,최소공배수 입력받아서 출력

            // Console.Write("첫번째 수를 입력하세요: ");
            // int x = int.Parse(Console.ReadLine());
            // Console.Write("두번째 수를 입력하세요: ");
            // int y = int.Parse(Console.ReadLine());
            // int[] returnArr = pr.gcmLcmFindFn(x, y);
            // Console.Write("최대공약수=" + returnArr[0] + "최소공배수=" +  returnArr[1]);
            
           
            // 3. 다이아몬드
            // pr.diamond();

            // 4. 오버라이딩
            //Childe Cr = new Childe();
            //Console.Write(Cr.sumFn(5, 6));
     

            // 5. 오버로딩
           // Console.Write(pr.sumFn(5, 6));
            

            // 6. dataset 출력
            // DataTable table = getData();
            // DataRow[] datas =  table.Select();
            // foreach(DataRow i in datas){
            //     Console.Write(i["index"] + " " );
            //      Console.Write(i["sex"] + " ");
            //      Console.Write(i["name"]+ "\n");     
            // }
           

            // 번외 피보나치 수열
            //pr.fibonacciSequence();

        }

       /// <summary>
       /// 2중 for문을 이용하여 구구단 구형
       /// </summary>
        public  void sum()
        {
               for (int i = 1; i <= 9; i++ )// 1부터 9까지
               {
                   Console.WriteLine(i + "단"); // 몇단인지 찍어주기
                   for (int y = 1; y <= 9; y++) { // 위에 for문이 한번 돌때 이 for문은 9번돌아 ex)i = 1 1 * 1, 1*2...1*9이런식
                        Console.WriteLine(i + "x" + y +"="+ i*y);
                   }
                   Console.WriteLine(""); // 단별로 구분
               }
        }

        /// <summary>
        /// 두 수를 입력 받아 최대공약수, 최소공배수 구하기
        /// </summary>
        /// <param name="n">첫번째 입력 숫자</param>
        /// <param name="m">두번째 입력 숫자</param>
        /// <returns>int[]</returns>
        public int[] gcmLcmFindFn(int n, int m) {
            // 작은 수와 큰 수 구할려고
            int min = n < m ? n : m; // n이 m보다 작을때 n 아니면 m
            int max = n < m ? m : n; // m이 n보다 작을때 m 아니면 m
            
            
            min = gcd(n, m); // 계속 
            max = (n * m) / min; //최소공배수 -> 두수의 곱 / 최대 공약수
            int[] returnArr = new int[2] {min,max}; // 두 숫자 같이 return해줄려고 배열 생성
            return returnArr;
    }
        /// <summary>
        /// 최대공약수 계산
        /// </summary>
        /// <param name="n">둘중 작은 수</param>
        /// <param name="m">둘중 더 큰 수</param>
        /// <returns>int</returns>
        public int gcd(int n, int m)
    {        
        if(m==0) return n; // m이 0이 되면 리턴
        else return gcd(m, n % m); //두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
    }
        /// <summary>
        /// 다이야몬드 찍기
        /// </summary>
        public void diamond()
        {
            
            int space = 0; // 공백
            int star = 0; // 별
            int lineCnt = 9; // 길이
            for (int line = 0; line < lineCnt; line++) { // lineCnt만큼 for문 돔

                // 밑으로 갈수록 작아지는 로직
                if (lineCnt / 2 >= line) star = star == 0 ? 1 : line * 2 + 1; // lineCnt의 절반보다 크면 제일 처음에 별 1개 아니면 줄은 0부터 시작이니까 *2 +1
                else star = star - (line - 1) / 2 < 0 ? 1 : star - (line - 1) / 2; // 작아질때 별에서 (line-2)/2해주고 혹시 0보다 작아지면 1


                space = lineCnt - star; // 줄 하나에 lineCnt칸이니 lineCnt-star
                for (int j = 1; j <=  lineCnt; j++) // lineCnt만큼 돈다
                { 
                    if (space / 2 >= j || lineCnt - space/2 < j) Console.Write(" ");  // space/2한게 j이상이거나 lineCnt - space/2가 j보다 클때는 공백 
                     else Console.Write("*");     // 아니면 *
                }
                Console.WriteLine(""); // 한줄
             }
        }

        /// <summary>
        /// 두 수를 입력받아 곱셈
        /// </summary>
        /// <param name="x">첫번째 숫자</param>
        /// <param name="y">두번쩨 숫자</param>
        /// <returns>int</returns>
        public  int sumFn(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// 두 수를 입력받아 곱셈
        /// </summary>
        /// <param name="x">첫번째 숫자</param>
        /// <param name="y">두번쩨 숫자</param>
        /// <returns>double</returns>
        public double sumFn(int x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// sumFn 오버로링
        /// </summary>
        /// <param name="x">첫번째 숫자</param>
        /// <param name="y">두번쩨 숫자</param>
        /// <returns>double</returns>
        public double sumFn(double x, double y)
        {    
            return x * y;
        }

        /// <summary>
        /// sumFn 오버로링, 3개의 숫자를 받아 곱셈 처리
        /// </summary>
        /// <param name="x">첫번째 숫자</param>
        /// <param name="y">두번쩨 숫자</param>
        /// <param name="z">세번쩨 숫자</param>
        /// <returns>int</returns>
        public int sumFn(int x, int y, int z)
        {
            return x * y * z;
        }

        /// <summary>
        /// datatable에 컬럼 추가 row추가
        /// </summary>
        /// <returns>DataTable</returns>
        //dataset colum추가 row추가
        static DataTable getData()
        {
            DataTable table = new DataTable(); // 테이블 인스턴스 생성
            table.Columns.Add("index", typeof(int)); // index라는 컬럼에 타입은 int
            table.Columns.Add("sex", typeof(string));// sex라는 컬럼에 타입은 string
            table.Columns.Add("name", typeof(string));// name라는 컬럼에 타입은 string

            table.Rows.Add(1, "여", "주희"); // index:1, sex:여, name:주희 
            table.Rows.Add(2, "남", "창식"); // index:2, sex:남, name:창식
            table.Rows.Add(3, "여", "명희"); // index:3, sex:여, name:명희 
            return table; // DataTable타입의 table return
        }


        /// <summary>
        /// x와 fiboCount랑 더해서 리턴
        /// </summary>
        /// <param name="x">더할 숫자</param>
        /// <returns>int</returns>
        int fiboCount = 0; // 이전 숫자
        public int fiboFn(int x)
        {
            int result = fiboCount + x; // 이전 숫자와 지금들어온 숫자의 합
            fiboCount = x; // 지금 들어본 x를 fibiCount에 재할당
            return result; // result 리턴
         
        }
        /// <summary>
        /// 피보나치 수열 출력해주기
        /// </summary>
        public void fibonacciSequence()
        {
            for (int i = 1; i < 300; i+=0) // i가 300이 될때까지 도는 for문 바꿔도 상관없음 그냥 리밋
            {
                i = fiboFn(i); // i는 fiboFn에서 이전 숫자와 지금 숫자와 더한 값
                Console.Write(i +" "); // 출력
            }
        }

  
            
            
        }
 

    }


