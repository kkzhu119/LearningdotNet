using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来实现将移动硬盘或者u盘或者MP3插入到电脑上进行读写数据

            //MobileDisk md = new MobileDisk();
            //UDisk U = new UDisk();
            //Mp3 MP3 = new Mp3();
            //Computer CPU = new Computer();
            //CPU.CpuRead(U);
            //CPU.CpuWrite(U);
            MobileStorage ms = new Mp3();
            Computer cpu = new Computer();
            cpu.Ms = ms;
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();
        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }
    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }
    public class Mp3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("自己可以播放音乐");
        }
    }
    public class Computer
    {
        private MobileStorage _ms;
        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }
        public void CpuRead()
        {
            Ms.Read();
        }
        public void CpuWrite()
        {
            Ms.Write();
        }
    }

}
