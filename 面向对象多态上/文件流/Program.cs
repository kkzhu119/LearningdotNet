using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream与File
            //FileStream 操作字节的
            //StramReader和StreamWriter  操作字符的
            //------------------------------
            //1、创建FileStream对象
            //FileStream fsRead = new FileStream(@"X:\文件流.txt",FileMode.OpenOrCreate,FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////r：这次读取得到的实际有效的字节数
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            ////将字节数组中每一个元素按照指定的编码格式解码成字符串
            //string s = Encoding.Default.GetString(buffer,0,r);
            ////关闭流
            //fsRead.Close();
            ////释放流所占用的资源
            //fsRead.Dispose();
            //Console.WriteLine(s);
            //Console.ReadKey();
            //使用FileStream来写入数据
            using (FileStream fsWrite = new FileStream(@"X:\文件流.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str = "看我有没有把你覆盖掉";
                byte[] buffer = Encoding.UTF8+.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("写入完成");
            Console.ReadKey();



        }
    }
}
