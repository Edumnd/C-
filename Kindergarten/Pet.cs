using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarten
{
    public class Pet
    {
        public string name;
        virtual public void printName()
        {
            Console.WriteLine("this is Pet " + name);
        }

        virtual public void Speak()
        {
            Console.WriteLine(name + " is speaking");
        }
    }

    public class Snake : Pet
    {
        new public void printName()
        {
            Console.WriteLine("this is 隐藏方法 " + name);
        }

        sealed public override void Speak()
        {
            Console.WriteLine(name + " is speaking " + "sisi");
        }


    }


    public class Bird : Pet
    {
        public string name;
        static int Num;
        public delegate void Handle();
        public static event Handle NewBird;//定义为static是因为没有Bird对象的时候也是可以调用的

        static Bird() { Num = 0; }
        public Bird(string name)
        {
            this.name = name;
            ++Num;
            if (NewBird != null)
            {
                NewBird();
            }
        }

        /*public Bird(string name)
        {
            this.name = name;
        }*/

        override public void printName()
        {
            Console.WriteLine("this is bird " + name);
        }

        public void IsHappy<T>(T target) where T : Pet
        {
            Console.WriteLine(name + " is Happy: " + target.ToString());
            target.printName();
        }

        public void innocentLook()
        {
            Console.WriteLine(name + " innocent look");
        }
    }

    public class Fish : Pet
    {
        public string name;


        public Fish(string name)
        {
            this.name = name;
        }

        override public void printName()
        {
            Console.WriteLine("this is fish " + name);
        }
        public void WagTail()
        {
            Console.WriteLine(name + " wag Tail");
        }
    }
}
