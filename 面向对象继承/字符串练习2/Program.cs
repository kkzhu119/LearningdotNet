using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace 字符串练习2
{
    class Program
    {
        static void Main(string[] args)
        {

            //课上练习1:接受用户输入的字符串,将其中的字符以与输入相反的顺序输出
            //string str = "abcdefg";
            ////for (int i = str.Length-1; i >=0; i++)
            ////{
            ////    Console.Write(str[i]);
            ////}
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length/2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}

            //str = new string(chs);
            //Console.WriteLine(str);
            //课上练习2  将字符串"hello c sharp"变成"sharp c hello"
            //string str = "hello c sharp";
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length/2; i++)
            //{
            //    string temp = strNew[i];
            //    strNew[i] = strNew[strNew.Length - 1 - i];
            //    strNew[strNew.Length - 1 - i] = temp;
            //}
            //str = string.Join(" ", strNew);
            //Console.WriteLine(str);
            //string.join:将字符串按照指定的分隔符连接

            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    Console.Write(strNew[i]);
            //}

            //课上练习3 从Email中提取出用户名和域名:abc@163.com
            //string email = "abc@163.com";
            //int index = email.IndexOf('@');
            //string userName = email.Substring(0, index);
            //string yuMing = email.Substring(index + 1);
            //Console.WriteLine(userName);
            //Console.WriteLine(yuMing);

            //课上练习4 文本文件中存储了多个文章标题,作者.
            //标题和作者之间用若干空格(数量不定)隔开,每行一个
            //标题有的长有的短,输出到控制台的时候最多标题长度10,
            //如果超过10,则截取长度8的子串并且最后添加"...",加上一个竖线后输出作者的名字
            //string path = @"C:\Users\wxkpc\source\repos\LearningdotNet\面向对象继承\字符串练习2\1.txt";
            //string[] contents = File.ReadAllLines(path, Encoding.Default);
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    string[] strNew =contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine((strNew[0].Length>10?strNew[0].Substring(0,8)+"......":strNew[0])+"|"+strNew[1]);
            //}

            ////课上练习5 让用户输入一句话,找出这句话中所有e的位置
            //string str = "adnwwedeedkeowedokwedk";
            //int index = str.IndexOf('e');
            //Console.WriteLine("第1次出现e的位置是{0}", index);
            //int count = 1;
            //while (index!=-1)
            //{
            //    count++;
            //    index = str.IndexOf('e',index+1);
            //    if (index==-1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}出现e的位置是{1}", count, index);
            //}

            //下面这个找法的缺陷 只能找当个字符
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //课上练习6 用户输入一句话,判断这句话中有没有邪恶,如果有邪恶就替换成这种形式然后输出
            //string str = "老张很邪恶";
            //if (str.Contains("邪恶"))
            //{
            //    str= str.Replace("邪恶", "**");
            //}
            //Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
