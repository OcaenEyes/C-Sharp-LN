using System;


namespace BasicKnowledge
{
    public class DataType
    {
        public void ShowDataType()
        {

            /*
             * 一、值类型 (Value Type)
             * 值类型变量可以直接分配给一个值。它们是从类 System.ValueType 中派生的
             * 
             * bool     布尔值 True 或 False                                        False
             * byte    8 位无符号整数    0 到 255                                      0
             * char    16 位 Unicode 字符 U +0000 到 U +ffff                            '\0'
             * decimal 128 位精确的十进制值，28-29 有效位数(-7.9 x 1028 到 7.9 x 1028) / 100 到 28   0.0M
             * double  64 位双精度浮点型(+/-)5.0 x 10-324 到(+/-)1.7 x 10308                        0.0D
             * float   32 位单精度浮点型  -3.4 x 1038 到 + 3.4 x 1038                                   0.0F
             * int      32 位有符号整数类型 -2,147,483,648 到 2,147,483,647                              0
             * long    64 位有符号整数类型 -923,372,036,854,775,808 到 9,223,372,036,854,775,807         0L
             * sbyte   8 位有符号整数类型  -128 到 127                                                   0
             * short   16 位有符号整数类型 -32,768 到 32,767                                             0
             * uint    32 位无符号整数类型 0 到 4,294,967,295                                            0
             * ulong   64 位无符号整数类型 0 到 18,446,744,073,709,551,615                               0
             * ushort  16 位无符号整数类型 0 到 65,535                                                   0
             * 
             * 二、引用类型（Reference types）
             * 引用类型不包含存储在变量中的实际数据，但它们包含对变量的引用;它们指的是一个内存位置。使用多个变量时，引用类型可以指向一个内存位置
             * 1、对象（Object）类型
             * 对象（Object）类型 是 C# 通用类型系统（Common Type System - CTS）中所有数据类型的终极基类。Object 是 System.Object 类的别名
             * 对象（Object）类型可以被分配任何其他类型（值类型、引用类型、预定义类型或用户自定义类型）的值
             * 但是，在分配值之前，需要先进行类型转换
             * 对象类型变量的类型检查是在编译时发生的
             * 2、动态（Dynamic）类型
             * 可以存储任何类型的值在动态数据类型变量中
             * 动态类型检查是在运行时发生的
             * 3、字符串（String）类型
             * 字符串（String）类型 允许您给变量分配任何字符串值
             * 字符串（String）类型是 System.String 类的别名
             * 它是从对象（Object）类型派生的。
             * 字符串（String）类型的值可以通过两种形式进行分配：引号和 @引号。
             *  
             * 三、指针类型（Pointer types）
             * 指针类型变量存储另一种类型的内存地址
             * 
             */

            Console.WriteLine("Size of int:{0}",sizeof(int));
        }

        public void ChangeDataType()
        {

            /*  类型转换
             *  隐式类型转换
             *       安全转换，不会导致数据丢失
             *  显式类型转换   
             *       强制转换，会导致数据丢失 
             */
            double d = 123456.78;
            int i;
            // 强制进行数据转换
            i = (int) d;
            Console.WriteLine(i);
            /*
             *  1   ToBoolean
             *  如果可能的话，把类型转换为布尔型。
                2   ToByte
                把类型转换为字节类型。
                3   ToChar
                如果可能的话，把类型转换为单个 Unicode 字符类型。
                4   ToDateTime
                把类型（整数或字符串类型）转换为 日期-时间 结构。
                5   ToDecimal
                把浮点型或整数类型转换为十进制类型。
                6   ToDouble
                把类型转换为双精度浮点型。
                7   ToInt16
                把类型转换为 16 位整数类型。
                8   ToInt32
                把类型转换为 32 位整数类型。
                9   ToInt64
                把类型转换为 64 位整数类型。
                10  ToSbyte
                把类型转换为有符号字节类型。
                11  ToSingle
                把类型转换为小浮点数类型。
                12  ToString
                把类型转换为字符串类型。
                13  ToType
                把类型转换为指定类型。
                14  ToUInt16
                把类型转换为 16 位无符号整数类型。
                15  ToUInt32
                把类型转换为 32 位无符号整数类型。
                16  ToUInt64
                把类型转换为 64 位无符号整数类型。
             *               
             */

            int i1 = 520;
            float f1 = 50.221f;
            double d1 = 2345.5022;
            bool b1 = false;

            Console.WriteLine(i1.ToString());
            Console.WriteLine(f1.ToString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine(b1.ToString());

        }
    }
}
