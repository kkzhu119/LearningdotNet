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
        //存储两个玩家的姓名
        static string[] PlayerNames = new string[2];
        //两个玩家的标记 默认都是false
        static bool[] Flags = new bool[2];//Flags[0]与Flags[1]默认为false
        static void Main(string[] args)
        {
           
            GameShow();
            #region  玩家输入姓名部分
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0]=="")
            {
                Console.WriteLine("玩家A的姓名不能为空!请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1]==""||PlayerNames[1]==PlayerNames[0])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空!请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                if (PlayerNames[1] == PlayerNames[0])
                {
                    Console.WriteLine("玩家B的姓名不能与玩家A的姓名重复！请重新输入!");
                    PlayerNames[1] = Console.ReadLine();
                }
            }
            #endregion //玩家姓名输入部分结束


            //玩家姓名输入完毕后 首先应该清屏
            Console.Clear();
            GameShow();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}的姓名用A表示",PlayerNames[0]);
            Console.WriteLine("{0}的姓名用B表示", PlayerNames[1]);
            InitailMap();
            DrawMap();
            //当玩家A和玩家B没有一个人在终点的时候 两个玩家不停的去玩游戏
            while (PlayPos[0]<99 &&PlayPos[1]<99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if(PlayPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了玩家{1}", PlayerNames[0], PlayerNames[1]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了玩家{1}", PlayerNames[1], PlayerNames[0]);
                    break;
                }
                //int count = 0;
                //count++;
                //if(count == 2)
                //{
                //    count 
                //}

            }//while
            Win();

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

        /// <summary>
        /// 画地图用的主要函数
        /// </summary>
        public static void DrawMap()
        {
            Console.WriteLine("图例：幸运轮盘:◎    地雷:☆    暂停:▲    时空隧道:¤");
            #region //第一横行
            for (int i = 0; i < 30; i++)
            {
                
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion
            #region //第一竖行
            for (int i = 30; i <= 34; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");

                }
                Console.Write(DrawStringMap(i));
                //DrawStringMap(i);
                Console.WriteLine();
            }
            #endregion
            #region //第二横行
            for (int i = 64; i > 34; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion
            #region //第二竖行
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion
            #region //第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //画完最后一行应该换行
            Console.WriteLine();
        }//DrawMap方法的结尾

        /// <summary>
        /// 从画地图的方法中抽象出来的一个绘制方法
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
                str = "Ａ";
                //Console.Write("A");

            }
            else if (PlayPos[1] == i)
            {
                str = "Ｂ";
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
        /// <summary>
        /// 玩游戏代码
        /// </summary>
        public static void PlayGame(int playerNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("{0}按任意键开始掷骰子", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}掷出了{1}", PlayerNames[playerNumber], rNumber);
            PlayPos[playerNumber] += rNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            //玩家A有可能踩到了玩家B 方块 幸运轮盘 地雷 暂停 时空隧道
            if (PlayPos[playerNumber] == PlayPos[1 - playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                PlayPos[1 - playerNumber] -= 6;
                ChangePos();
                Console.ReadKey(true);
            }
            else//踩到了关卡
            {
                //玩家的坐标  
                switch (Maps[PlayPos[playerNumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全.", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择:1---交换位置 2---轰炸对方", PlayerNames[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择跟玩家{1}交换位置", PlayerNames[playerNumber], PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                int temp = PlayPos[playerNumber];
                                PlayPos[playerNumber] = PlayPos[1 - playerNumber];
                                PlayPos[1 - playerNumber] = temp;
                                Console.WriteLine("交换完成!!!按任意键继续游戏!!");
                                Console.ReadKey(true);
                                break;

                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1},玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                PlayPos[1 - playerNumber] -= 6;
                                ChangePos();
                                Console.WriteLine("玩家{0}退了6格", PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2 1--交换位置  2--轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷,退6格", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        PlayPos[playerNumber] -= 6;
                        ChangePos();
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerNames[playerNumber]);
                        Flags[playerNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playerNumber]);
                        PlayPos[playerNumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;

                }//switch
            }//else
            //ChangePos();
            Console.Clear();
            DrawMap();
        }

        /// <summary>
        /// 当玩家坐标发生改变时调用此函数来检测边界情况
        /// </summary>
        public static void ChangePos()
        {
            if (PlayPos[0] < 0)
            {
                PlayPos[0] = 0;
            }
            if (PlayPos[0] >= 99)
            {
                PlayPos[0] = 99;
            }
            if (PlayPos[1] < 0)
            {
                PlayPos[1] = 0;
            }
            if (PlayPos[1] >= 99)
            {
                PlayPos[1] = 99;
            }
        }



        /// <summary>
        /// 胜利标志
        /// </summary>
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
    }
}
