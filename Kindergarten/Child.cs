using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarten
{
    /// <summary>
    /// 小朋友类
    /// </summary>
    class Child
    {
        //封装快捷键Ctrl+R+E

        private string _name;
        private Gender sex = Gender.男;
        private int age;
        private int height;
        /// <summary>
        /// 姓名属性
        /// </summary>
        public string Name
        {
            get { return _name; }//读访问器
            set { _name = value; }//写访问器
        }


        public Gender Sex
        {
            get { return sex; }
            // set { sex = value; }
        }
        public int Age
        {
            get => age;
            set { if (value >= 3 && value <= 7) age = value; }
        }
        public int Height { get => height; set => height = value; }

        //无参方法
        public void PlayBall()
        {
            Console.WriteLine("I am C luo!");
        }

        //有参方法
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sugar">糖的类型 形参</param>
        public void EatSugar(string sugar)
        {
            if (sugar == "榴莲糖")
            {
                Console.WriteLine("不喜欢榴莲的味道！");
            }
            else { Console.WriteLine("最喜欢吃糖了！"); }
        }

        //方法名一样，所以是方法的重载
        public void EatSugar(int count)
        {
            if (count > 3) { Console.WriteLine("吃糖太多对牙齿不好！"); }
            else { Console.WriteLine("还能吃"); }
        }

        public void EatSugar(string sugar, int count)
        {
            if (sugar == "牛奶糖" && count > 2) { Console.WriteLine("牛奶糖不能吃太多"); }
            else { Console.WriteLine("吃糖糖吧！"); }
        }

        public void EatSugarage(int age)
        {
            if (age < 5) { Console.WriteLine("太小了还不能吃糖！"); return; }
            Console.WriteLine("吃牛奶糖吧hh");
        }

        public int Add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }

        public Child()
        {
            Name = "周星星";
        }

        public Child(string name, Gender sex, int age)
        {
            Name = name;
            this.sex = sex;//this当前对象，没有this的就是形参
            Age = age;
        }
    }
}
