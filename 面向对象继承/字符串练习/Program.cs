using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //随机输入你心中想到的一个名字,然后输出它的字符串长度
            //Console.WriteLine("请输入你心中想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的那个人的名字是{0}", name.Length);
            //两个学员输入各自最喜欢的课程名称,判断是否一致,如果相等,则输出你们俩喜欢相同的课程.如果不相同,则输出你们俩喜欢不相同的课程
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////将字符串转换为大写
            ////if (lessonOne.ToUpper() == lessonTwo.ToUpper())
            ////{
            ////    Console.WriteLine("你们俩喜欢的课程相同");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("你们俩喜欢的课程不同");
            ////}
            ////避免转换大小写 一步到位
            //if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们俩喜欢的课程不同");
            //}

            //字符串的分割
            //string s = "a  b  dfd _ +  , =  qdqed";
            ////分割字符串 调用Split
            //char[] chs = {' ','_','+','=','=' };
            //string[] str=s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            ////练习:从日期字符串("2008-08-08")中分析出年,月,日;2008年08月08日
            ////让用户输入一个日期格式如:2008-01-02,你输出你输入的日期为2008年1月2日
            //string s2 = "2008-08-08";
            ////char[] chs2 = { '-'};
            //string[] str2 = s2.Split(new char[]{'-'}, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",str2[0],str2[1],str2[2]);
            //字符串替换

            //string str = "国家关键人物老赵";
            //if (str.Contains("老赵"))
            //{
            //    str=str.Replace("老赵", "**");
            //}
            //Console.WriteLine(str);


            //Substring  截取字符串
            //string str = "今天天气好晴朗,处处好风光";
            ////str = str.Substring(2);
            //str=str.Substring(1,3);
            //Console.WriteLine(str);

            //string str = "今天天气好晴朗,处处好风光";
            //if (str.StartsWith("今天"))//对应EndsWith
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //字符查找 找不到返回-1
            //string str = "今天天气好晴朗,天天处处好风光";
            //int index=str.IndexOf('天');//第一次出现的位置
            //int indexsearch = str.IndexOf('天', 2);
            //int lastindexof = str.LastIndexOf('天');
            //Console.WriteLine(index);
            //Console.WriteLine(indexsearch);
            //Console.WriteLine(lastindexof);
            //LastIndexOf 与SubString配合使用
            //string path = @"f:\a\b\c\d\小泽玛利亚\你懂的\希岛爱理.wav";
            //int indexPath = path.LastIndexOf("\\");
            //path=path.Substring(indexPath+1);
            //Console.WriteLine(path);

            //Trim() 去空格
            //string strSpace = "       hahahhaha     ";
            //string strSpace1 = strSpace.Trim();
            //Console.WriteLine(strSpace1);
            //string strSpace2 = strSpace.TrimStart();
            //Console.WriteLine(strSpace2);
            //string strSpace3 = strSpace.TrimEnd();
            //Console.WriteLine(strSpace3);

            //判断字符串null或空
            //string str = null;
            //if (string.IsNullOrEmpty(str))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}

            //string.join();
            //string[] names = { "张三","李四","王五","赵六"};
            //string str = string.Join("||", names);
            //Console.WriteLine(str);
            
            Console.ReadKey();
        }
    }
}
