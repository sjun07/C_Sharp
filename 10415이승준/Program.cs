using System;

namespace _10415이승준 
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 출력연습
            //int age;
            //string name;
            
            //    age = int.Parse(Console.ReadLine());
            //    name = Console.ReadLine();
            
        
           
            //    //age = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"제가 좋아하는 연예인 는 {name}님이고 나이는 {age} 입니다.\n");

            //    Console.WriteLine("제가 좋아하는 연예인 는 " + name + "님이고 나이는 " + age + " 입니다.\n");

            //    Console.WriteLine("제가 좋아하는 연예인 는 {0}님이고 나이는 {1} 입니다.\n", name, age);
            
            #endregion

            #region 입력연습
            //try
            //{
            //    age = int.Parse(Console.ReadLine());
            //    name = Console.ReadLine();
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("형식이 이상합니다.");
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    //age = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"제가 좋아하는 연예인 는 {name}님이고 나이는 {age} 입니다.\n");

            //    Console.WriteLine("제가 좋아하는 연예인 는 " + name + "님이고 나이는 " + age + " 입니다.\n");

            //    Console.WriteLine("제가 좋아하는 연예인 는 {0}님이고 나이는 {1} 입니다.\n", name, age);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("오류발생");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region 배열, split
            string[] str = Console.ReadLine().Split("?");

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine("Hello\r world"); //커서를 해당줄의 맨 앞으로 이동
            Console.WriteLine("Hello\t world"); //텝키
            Console.WriteLine("Hello\b world"); //엑스페이스
            Console.WriteLine("Hello\n world"); //엔터
            Console.WriteLine("\u0056"); //유니코드 값출력
            //ctrl d
            //ctrl x
            //alt 방향키
            #endregion

        }
    }
}
