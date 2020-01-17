using System;

/*
 * 布尔条件（Boolean Conditions）
 * 自动垃圾回收（Automatic Garbage Collection）
 * 标准库（Standard Library）
 * 组件版本（Assembly Versioning）
 * 属性（Properties）和事件（Events）
 * 委托（Delegates）和事件管理（Events Management）
 * 易于使用的泛型（Generics）
 * 索引器（Indexers）
 * 条件编译（Conditional Compilation）
 * 简单的多线程（Multithreading）
 * LINQ 和 Lambda 表达式
 * 集成 Windows
 * 
 */

namespace BasicKnowledge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //数据类型
            DataType dt = new DataType();
            dt.ShowDataType();
            //类型转换
            dt.ChangeDataType();
            //常量
            Constant cs = new Constant();
            cs.ConstantInit();
            Console.WriteLine("c1的值:{0}", Constant.c1);
            Console.WriteLine("c2的值:{0}", Constant.c2);
            cs.ShowConstant(12,34);
            Console.WriteLine("x的值:{0}", cs.x);
            Console.WriteLine("y的值:{0}", cs.y);
            //
            Console.ReadLine();

        }
    }
}
