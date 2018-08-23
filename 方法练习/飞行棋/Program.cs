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
        //声明一个静态数组用来存储玩家A和玩家B的坐标
        static int[] PlayPos = new int[2];
        static void Main(string[] args)
        {
           
            GameShow();
            InitailMap();
            DrawMap();
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


        public static void DrawMap()
        {
            #region //第一横行
            for (int i = 0; i < 30; i++)
            {
                
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();
            #region //第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("　");

                }
                Console.Write(DrawStringMap(i));
                //DrawStringMap(i);
                Console.WriteLine();
            }
            #endregion

            //第二横行
            for (int i = 35; i < 65; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            //第二竖行
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            //第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }

        }//DrawMap方法的结尾

        /// <summary>
        /// 从画地图的方法中抽象出来的一个方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            #region 主要绘制方法
            if (PlayPos[0] == PlayPos[1] && PlayPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                str = "<>";
                //Console.Write("<>");
            }
            else if (PlayPos[0] == i)
            {
                str = "A";
                //Console.Write("A");

            }
            else if (PlayPos[1] == i)
            {
                str = "B";
                //Console.Write("B");
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "□";
                        //Console.Write("□");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "◎";
                        //Console.Write("◎");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "☆";     
                        //Console.Write("☆");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "▲";
                       
                        //Console.Write("▲");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        str = "¤";                        
                        //Console.Write("¤");
                        break;
                }
            }
            #endregion
            return str;
        }
    }
}
