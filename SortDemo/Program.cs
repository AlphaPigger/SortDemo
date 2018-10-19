using System;

namespace SortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取输入数组
            int[] array_tem = ReadNumber();
            //产生随机数组
            int[] array=RandArray(array_tem[0], array_tem[1], array_tem[2]);
            //打印排序前数组
            WriteLine_Before(array);
            //排序
            Sort(ref array);
            //打印排序后数组
            WriteLine_After(array);
        }
        private static int[] ReadNumber()
        {
            Console.WriteLine("随机产生长度n的整形数组！请输入长度n：");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请输入数组下界(必须为整数)：");
            int min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请输入数组上界(必须为整数)：");
            int max = Int32.Parse(Console.ReadLine());
            int[] array = new int[3];
            array[0] = n;
            array[1] = min;
            array[2] = max;
            return array;
        }
        private  static int[] RandArray(int n,int min,int max)
        {
            Random random = new Random(n);
            int[] array = new int[n];
            for (int i=0; i<n;i++)
            {
                array[i] = random.Next(min,max);
            }
            return array;
        }
        private static void WriteLine_Before(int[] array)
        {
            Console.WriteLine("排序前数组：");
            for (int i=0; i< array.Length;i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
        //改进后的冒泡升序排序算法
        private static void Sort(ref int[] array)
        {
            int l = array.Length;
            bool swapped = true;
            while (l>1&& swapped)
            {
                swapped = false;
                for (int i=0; i<l-1;i++)
                {
                    //比较
                    if (array[i] > array[i + 1])
                    {
                        int tem = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = tem;
                        swapped = true;
                    }
                }
                l -= 1;
            }
        }
        private static void WriteLine_After(int[] array)
        {
            Console.WriteLine("\n排序后数组：");
            for (int i=0; i<array.Length;i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("\n程序结束");
            Console.ReadKey();
        }
    }
}
