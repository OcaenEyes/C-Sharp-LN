using System;
namespace BasicKnowledge
{
    /*
     * 循环类型
     *      while 循环
     *      for/foreach 循环
     *      do...while 循环
     *      嵌套循环
     * 循环控制语句
     *      break 语句      终止loop／switch语句，
     *      continue 语句    结束本次循环，继续执行
     * 无限循环
     *      条件不为假，循环就会变成无限循环
     * 
     */
    public class Cycle
    {
        public void InfiniteCycle()
        {
            for (; ; )
            {
                Console.WriteLine("当条件表达式不存在时，被假设为真，常使用 for(;;) 做无限循环");

            }
        }
    }
}
