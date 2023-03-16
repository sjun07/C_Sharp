using System;

namespace _10415이승준2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 복습
            string[] str = Console.ReadLine().Split(" ");

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            #endregion
            #region 데이터형식
            /*
            {
                int a=10
            }
            Console.WriteLine(a);// a값이 사라짐
            */
            #endregion
            #region 숫자 자료형
            /*
            bit 0~255
            byte -128~127
            short -32768~32767
            unsighned short0~65535
            long -2147483648~2147483647
            unsigned long 0~4294967295
            -922336203685477508~922336203685477507
             0~18446744073709551615
            */
            short aa = -2345;
            byte ba = 127;
            ushort ca = 64890;
            long da = -2147483649;
            int ea = -32890;
            uint fa = 3456789123;
            char ga = 'a';
            Console.WriteLine(aa);
            Console.WriteLine(ba);
            Console.WriteLine(ca);
            Console.WriteLine(da);
            Console.WriteLine(ea);
            Console.WriteLine(fa);
            Console.WriteLine(ga);
            #endregion
            #region 진수 리터널표현
            float f1 = 3.14f;
            Console.WriteLine($"{f1:F3}");
            Console.WriteLine($"{ba:X}");

            //2진수,10진수, 16진수 리터널 표현
            byte a = 0b1111_1101; //이진수 리터럴
            byte b = 127; //십진수 리터럴
            byte c = 0xF0; //십육진수 리터럴
            uint d = 0x1234_abcd; //십육진수 리터럴
            #endregion

            int z = int.MaxValue;
            int zm = int.MaxValue;
            z += 1;
            Console.WriteLine(z);
        }

    }
}
