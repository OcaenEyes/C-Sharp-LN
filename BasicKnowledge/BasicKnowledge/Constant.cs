using System;
namespace BasicKnowledge
{
    public class Constant
    {
        //定义常量实例
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;
        public void ShowConstant(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public void ConstantInit()
        /*
         * 常量
         *    固定值，程序执行期间不改变
         *    
         * 整数常量
         *    前缀指定基数：0x 或 0X 表示十六进制，
         *                  0 表示八进制，
         *                  没有前缀则表示十进制 
         *    后缀，可以是 U 和 L 的组合，
         *                  U 和 L 分别表示 unsigned 和 long
         *                  
         * 浮点常量
         *    由整数部分、小数点、小数部分和指数部分组成
         *    
         * 字符常量
         * 
         * 转义序列 含义
         * \\   \ 字符
         * \'   ' 字符
         * \"   " 字符
         * \?   ? 字符
         * \a   Alert 或 bell
         * \b   退格键（Backspace）
         * \f   换页符（Form feed）
         * \n   换行符（Newline）
         * \r   回车
         * \t   水平制表符 tab
         * \v   垂直制表符 tab
         * \ooo 一到三位的八进制数
         * \xhh . . .   一个或多个数字的十六进制数
         *  
         * 字符串常量
         * 字符串常量是括在双引号 "" 里，或者是括在 @"" 里 
         * 
         * 定义常量
         * const <data_type> <constant_name> = value;
         * 
         */
        {
            //字符常量实例
            Console.WriteLine("Hello\tGZY\n\n");

            //字符串常量实例
            string a = "Hello ,GZY!";
            string b = @"Hello ,高智勇";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

    }
}
