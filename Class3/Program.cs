using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {

        #region 运用位逆运算交换两个变量的值
        static void Change_Value()
        {
            int a, b;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("交换前，a={0} b={1}", a, b);
            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine("交换后，a={0} b={1}", a, b);
        }
        #endregion

        #region 运算方法
        static string Multiplication(int a, int b)
        {
            return (a * b).ToString();
        }

        static string Multiplication(double a, double b)
        {
            return (a * b).ToString();
        }

        static string Division(int a, int b)
        {
            return (a / b).ToString();
        }

        static string Division(double a, double b)
        {
            return (a / b).ToString();
        }
        #endregion

        #region 利用递归求解阶乘的方法
        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region 调用交换值方法
            //Change_Value();
            //return;
            #endregion

            #region 简单的运算器
            //string a, b;
            //char op;
            //string result = "";
            //Console.Write("a=");
            //a = Console.ReadLine();
            //Console.Write("b=");
            //b = Console.ReadLine();
            //Console.Write("请输入运算符:\n+\n-\n*\n/\n");
            //op = Convert.ToChar(Console.ReadLine());
            //switch (op)
            //{
            //    case '*':
            //        {
            //            if (a.Contains(".") || b.Contains("."))
            //            {
            //                result = Multiplication(Convert.ToDouble(a), Convert.ToDouble(b));
            //            }
            //            else
            //            {
            //                result = Multiplication(Convert.ToInt32(a), Convert.ToInt32(b));
            //            }
            //        }; break;
            //    case '/':
            //        {
            //            if (Convert.ToDouble(b) != 0)
            //            {
            //                if (a.Contains(".") || b.Contains("."))
            //                {
            //                    result = Division(Convert.ToDouble(a), Convert.ToDouble(b));
            //                }
            //                else
            //                {
            //                    result = Division(Convert.ToInt32(a), Convert.ToInt32(b));
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("运算失败！因为除数是0！");
            //                Console.ReadKey();
            //                return;
            //            }
            //        }; break;
            //}
            //Console.WriteLine("运算结果为 {0}", result);
            //Console.ReadKey();
            //return;
            #endregion

            #region 相对高级的计算器
            //string input;
            //string[] nums = new string[50];
            //string ops = "";
            //string result = "";
            //Console.Write("请输入需要计算的内容: ");
            //input = Console.ReadLine();
            //if (System.String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("运算失败！输入的内容无法进行运算！");
            //}
            //nums = input.Split('+', '-', '*', '/');
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
            //    {
            //        ops += input[i];
            //    }
            //}
            //for (int i = 0; i < ops.Length; i++)
            //{
            //    switch (ops[i])
            //    {
            //        case '*':
            //            {
            //                if (System.String.IsNullOrWhiteSpace(result))
            //                {
            //                    result = Multiplication(Convert.ToInt32(nums[i]), Convert.ToInt32(nums[i + 1]));
            //                }
            //                else
            //                {
            //                    result = Multiplication(Convert.ToDouble(result), Convert.ToDouble(nums[i + 1]));
            //                }
            //            }; break;
            //        case '/':
            //            {
            //                if (Convert.ToDouble(nums[i + 1]) != 0)
            //                {
            //                    if (System.String.IsNullOrWhiteSpace(result))
            //                    {
            //                        result = Division(Convert.ToDouble(nums[i]), Convert.ToDouble(nums[i + 1]));
            //                    }
            //                    else
            //                    {
            //                        result = Division(Convert.ToDouble(result), Convert.ToDouble(nums[i + 1]));
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine("运算失败！因为除数是0！");
            //                    Console.ReadKey();
            //                    return;
            //                }
            //            }; break;
            //    }
            //}
            //Console.WriteLine("运算结果为 {0}", result);
            //Console.ReadKey();
            //return;
            #endregion

            #region 利用递归求解阶乘
            //int n;
            //Console.Write("n=");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}的阶乘为{1}", n, Factorial(n));
            //Console.ReadKey();
            //return;
            #endregion

            #region 作用域和声明空间
            //Person person1 = new Person();
            //person1.GrowUp();
            //person1.Fertility();
            //return;
            #endregion

            #region 字段、常量、属性、方法等
            //Person person2 = new Person();

            //#region 字段、常量
            //person2.Get_Student_School();
            //person2.Get_Student_Num();
            //#endregion

            //#region 属性
            //person2.Is_Relaxing = true;
            //if(person2.Is_Relaxing)
            //{
            //    Console.WriteLine("这个人睡着了");
            //}
            //else
            //{
            //    Console.WriteLine("这个人还在玩游戏");
            //}
            //Console.WriteLine("这个人的性别是{0}", person2.Sex);
            //#endregion

            //#region 方法
            //Person.Graduation();
            //Person.Graduation("山东蓝翔高级技工学校");
            //Person.Graduation(school: "皇家邮电大学", name: "");
            //#endregion
            #endregion

            #region 类的实例化
            //Person person1 = new Person();
            //person1.Get_Student_Num();
            //Person person2 = new Person(2016234567);
            //person2.Get_Student_Num();
            //A a = new A(2, 5);
            //Person person3 = new Person { Is_Relaxing = false, Age = 18 };
            #endregion
        }
    }
}