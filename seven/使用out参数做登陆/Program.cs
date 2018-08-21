using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用out参数做登陆
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别提示用户输入用户名和密码
            //写一个方法来判断用户输入的是否正确
            //返回给用户一个登陆结果，并且还要单独的返回一个登录信息
            //如果用户名错误，除了返回登陆结果之外，还要返回一个"用户名错误"
            //如果密码错误同上
            Console.WriteLine("请输入用户名");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string userpwd = Console.ReadLine();
            string msg;
            bool b =IsLogin(username, userpwd, out msg);
            Console.WriteLine("登陆结果{0}", b);
            Console.WriteLine("登录信息{0}", msg);
            Console.ReadKey();
        }
        public static bool MyTryParse(string s,out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
               // result = 0;
                return false;
            }
            
        }


        /// <summary>
        /// 判断登陆是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">多余返回的登陆信息</param>
        /// <returns></returns>
        public static bool IsLogin(string name,string pwd,out string msg)
        {
            if(name == "admin" && pwd == "123456")
            {
                msg = "登陆成功!";
                return true;
            }else if(name == "admin")
            {
                msg = "密码错误";
                return false;
            }else if (pwd == "123456")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }
    }
}
