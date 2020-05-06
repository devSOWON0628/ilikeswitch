using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilikeswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학년을 입력하세요 : ");
            int level = int.Parse(Console.ReadLine());
            Console.Write("수강해야 하는 전공 학점 : ");
            switch (level)
            {
                case 1:
                    Console.Write("12");
                    break;

                case 2:
                    Console.Write("18");
                    break;

                case 3:
                    Console.Write("10");
                    break;

                case 4:
                    Console.Write("18");
                    break;

                default:
                    Console.WriteLine("잘못 입력하셨습니다");
                    break;
            }
            Console.WriteLine("학점");
        }
    }
}
