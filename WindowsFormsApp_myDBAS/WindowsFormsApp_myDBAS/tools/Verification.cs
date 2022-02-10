using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_myDBAS
{
    class Verification
    {
        //随机生成验证码
        public static string SystemPassword = "admin";//系统密码
        public static string Code()
        {
            string code = "";           //验证码字符串
            Random random = new Random();
            for (int i = 0; i < 5; i++) //随机生成六位验证码功能
            {
                int n = random.Next(9);//获取0到9以内的随机整数
                code += n;
            }
            string str = "abcdefghigklmnopqrstuvwxyz";
            code+=str.Substring(random.Next(26), 1);

            return code;
        }
    }
}
