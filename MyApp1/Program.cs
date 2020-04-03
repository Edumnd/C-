using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14159265359;
            Console.WriteLine("Hello world!");
            Console.WriteLine(Pi);
            Console.WriteLine((double)3.6);
            Console.WriteLine(9 + "2.2");//num9 transform the string,the result is 92.2
            Console.WriteLine(5 / 10);//result is 0, just save the front

            for (int x = 1; x < 8; x++)//循环7行
            {
                for (int y = 1; y < 8; y++)//循环7列
                {
                    if (x == y || x == (8 - y))//对角线打印O
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(".");//其他位置打印.
                    }
                }
                Console.WriteLine();//换行
            }

            Console.WriteLine("---------------");

            string[,] score = new string[8, 2] { { "吴松", "89" }, { "钱东宇", "90" }, { "伏晨", "98" }, { "陈陆", "56" }, { "周蕊", "60" }, { "林日鹏", "9" }, { "何昆", "93" }, { "关欣", "85" } };
            string name = "";
            string result = "0";
            for (int i = 0; i < score.Length / 2; i++)
            {
                if (String.Compare(score[i, 1], result) > 0)
                {
                    name = score[i, 0];
                    result = score[i, 1];
                }
            }
            //Console.WriteLine("分数最高是的{0}，分数是{1}", name, result);
            Console.WriteLine("分数最高的是" + name + ",分数是" + result);

            Console.WriteLine("---------------");

            string[] name1 = new string[] { "吴松", "钱东宇", "伏晨", "陈陆", "周薇", "林日鹏", "何昆", "关欣" };
            int[] num = new int[] { 89, 90, 98, 56, 60, 91, 93, 85 };
            int temp = 0;
            string temp_name = "";
            for (int i = 0; i < num.Length; i++)
            {
                if (temp < num[i])
                {
                    temp = num[i];
                    temp_name = name1[i];
                }
            }
            Console.WriteLine("The highest score is {0}，score is {1}", temp_name, temp);


            Console.WriteLine("---------------");
            string in_name;
            Console.Write("Please input your name:");
            in_name = Console.ReadLine();
            Console.WriteLine("Hello,{0}!", in_name);
            Console.WriteLine("Hello," + in_name + "!");

            Console.WriteLine("---------------");
            string[] name_shuru = new string[2];
            int[] score_shuru = new int[2];
            for (int i = 0; i < name_shuru.Length; i++)
            {
                Console.Write("Please input the number of " + (i + 1) + " name:");
                name_shuru[i] = Console.ReadLine();
                Console.Write("Please input the number of " + (i + 1) + " score:");
                score_shuru[i] = int.Parse(Console.ReadLine());

            }
            //Calculate the total and average score
            int sum_shuru = 0, avg = 0;
            for (int i = 0; i < score_shuru.Length; i++)
            {
                sum_shuru += score_shuru[i];
            }
            avg = sum_shuru / name_shuru.Length;
            Console.WriteLine("The total score is:" + sum_shuru + ", The average score is:" + avg);

            Console.WriteLine("-----The final project----------");
            string[] final_name = new string[8] { "景珍", "林惠洋", "成蓉", "洪南昌", "龙玉民", "单江开", "田武山", "王三明" };
            int[] final_score = new int[8] { 90, 65, 88, 70, 46, 81, 100, 68 };
            int final_sum = 0, final_avg = 0;
            for (int i = 0; i < final_score.Length; i++)
            {
                final_sum += final_score[i];
            }
            final_avg = final_sum / final_score.Length;
            Console.WriteLine("平均分是" + final_avg + "，高于平均分的有：");
            for (int j = 0; j < final_score.Length; j++)
            {
                if (final_score[j] >= final_avg)
                {
                    int k = j;
                    Console.Write(final_name[k] + " ");
                }
            }

        }
    }
}
