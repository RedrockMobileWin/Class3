using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Person
    {
        private int age; //作用域为整个类，是一个字段

        private const string school = "重庆邮电大学"; //String类型的常量，值为 重庆邮电大学

        private int student_id; //学生的学号

        private static readonly Random student_num = new Random(); //Random类型的静态只读字段，用来构建学生的学号

        public bool Is_Relaxing { get; set; } = false; //一个自动实现的属性，可以直接把他当成字段来使用

        public int Age //一个Age属性，用来供类外部读写age字段
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Sex //性别属性，根据学好判断性别，并且为只读
        {
            get
            {
                if (student_num.Next() % 2 == 0)
                {
                    return "男";
                }
                else
                {
                    return "女";
                }
            }
        }

        internal Person()
        {
            student_id = student_num.Next();
        }

        internal Person(int num)
        {
            student_id = num;
        }

        public void GrowUp()
        {
            age++;
            Console.WriteLine("你现在已经" + age + "岁了！");
        }

        public void Fertility()
        {
            int age;
            age = 0;
            Console.WriteLine("新生的宝宝现在" + age + "岁了！");
        }

        public void Get_Student_School()
        {
            Console.WriteLine("他的学校是" + school);
        }

        public void Get_Student_Num()
        {
            Console.WriteLine("他的学号是" + student_id);
        }

        public static void Graduation()
        {
            Console.WriteLine("这个人已经从{0}毕业了", school);
        }

        public static void Graduation(string name, string school)
        {
            Console.WriteLine("{0}已经从{1}毕业了", name, school);
        }

        public static void Graduation(string school)
        {
            Console.WriteLine("这个人已经从{0}毕业了", school);
        }
    }
}