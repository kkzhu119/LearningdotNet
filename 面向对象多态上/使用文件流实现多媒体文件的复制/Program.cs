using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用文件流实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            //思路：就是先将要复制的多媒体文件读取出来，然后再写入到指定位置
            string source = @"X:\test.avi";
            string target = @"X:\new.avi";
            CopyFile(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }

        public static void CopyFile(string source, string target)
        {
            //1.我们创建一个负责读取的流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                //2.创建一个负责写入的流
                   using(FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];

                    //因为文件可能会比较大，所以我们在读取的时候应该通过循环读取
                    while (true)
                    {
                        //返回本次读取实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //如果返回一个0 也就意味着什么都没有读取到，即读取完了
                        if (r == 0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }
                    
                }
            }
        }
    }
}
