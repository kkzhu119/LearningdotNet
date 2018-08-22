using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋
{
    class Program
    {
        //我们用静态字段来模拟全局变量
        static int[] Maps = new int[100];
        static void Main(string[] args)
        {
           
            GameShow();
            Console.ReadKey();
        }





        /// <summary>
        /// 用于绘制游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("********王的飞行棋********");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************");
        }

        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            for (int i = 0; i < luckyturn.Length; i++)
            {
                int n = luckyturn[i];
                Maps[n] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                int n = landMine[i];
                Maps[n] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                int n = pause[i];
                Maps[n] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 }; //时空隧道¤
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                int n = timeTunnel[i];
                Maps[n] = 4;
            }
        }
    }
}
