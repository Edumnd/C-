using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarten
{
    class Client
    {
        public void WantADog()
        {
            Console.WriteLine("Great,I want to see the new bird");
        }
    }

    abstract class A { }
    class Program
    {

        static Dog dog;//结构也可以不用实例化对象，即可将=new Dog()去除，定义在Main方法之外

        static void Growth(Child child) //引用类型参数，按引用传参
        {
            child.Age++;
            Console.WriteLine("又长大一岁");
        }

        static void Growth(int age) //值类型参数，按值传参
        {
            age++;
            Console.WriteLine("(重写静态方法int类型)又长大一岁" + age);
        }

        static void Growth(ref int age) //值类型参数，按值传参
        {
            age++;
            //Console.WriteLine("(重写静态方法int类型)又长大一岁" + age);
        }

        static void Growth(int age, out int lastYear, out int nextYear)
        {
            lastYear = age - 1;
            nextYear = age + 1;
        }

        delegate void ActCute();//声明一个委托的类型


        static void Main(string[] args)
        {
            Child xiaoMing = new Child();//实例化Child类的对象
            xiaoMing.Name = "maxiaoming";//为字段赋值
                                         //xiaoMing.Sex="";
            xiaoMing.Age = 6;
            xiaoMing.Age = 5;
            xiaoMing.Height = 120;
            Console.WriteLine("My name is " + xiaoMing.Name + ". I am " + xiaoMing.Sex + ". I am " + xiaoMing.Age + " years old.");
            xiaoMing.PlayBall();//调用方法
            xiaoMing.EatSugar("榴莲糖");//实参 sugar="榴莲糖"
            xiaoMing.EatSugar(4);
            xiaoMing.EatSugar("牛奶糖", 2);
            xiaoMing.EatSugarage(5);
            int sum;
            sum = xiaoMing.Add(2, 3);
            Console.WriteLine("两数之和是：" + sum);

            Console.WriteLine("我的名字是{0}-根据无参构造方法", xiaoMing.Name);

            Child child = new Child("田翠华", Gender.女, 5);//调用构造方法
            Console.WriteLine("我的名字是" + child.Name + "，我的性别是" + child.Sex + "，我的年龄是" + child.Age);

            //用有参数构造方法初始化
            Child child1 = new Child("小白", Gender.男, 4);

            //用无参数构造方法初始化
            Child child2 = new Child();
            child2.Name = "胡晓梅";
            child2.Age = 4;

            //用对象初始化器初始化对象
            Child child3 = new Child() { Name = "周润发", Age = 5 };
            Console.WriteLine("我叫{0}, 今年{1}岁了", child3.Name, child3.Age);

            Console.WriteLine("------------结构----------------");
            //Dog dog = new Dog();
            dog.Name = "小白";
            Console.WriteLine("The Name of " + dog.Name);
            dog.Sing();


            Console.WriteLine("------------------------");
            Child c1 = new Child("刘有才", Gender.男, 3);
            Growth(c1);//按引用传参，方法修改形参，通常实参也会被修改
                       //Console.WriteLine("我现在{0}岁了！", c1.Age);

            Growth(c1.Age);//按值传参，方法修改形参，实参不会被修改
            Console.WriteLine("我现在{0}岁了！", c1.Age);

            int age = 3;//年龄
            Growth(ref age);
            Console.WriteLine("我现在{0}岁了！", age);

            int age_out = 7;
            int ly, ny;//去年的年龄，明年的年龄
            Growth(age_out, out ly, out ny);
            Console.WriteLine("我明年{0}岁，去年{1}岁!", ny, ly);

            Console.WriteLine("-------------父类-----------");
            Pet snake = new Snake();
            //Pet snake = new Snake();//直接调用父类
            snake.name = "蛇";
            snake.printName();
            snake.Speak();
            /*snake1.printName();
            snake1.Speak();*/

            Console.WriteLine("-------------泛型方法-----------");
            var bird = new Bird("xiaoniao");
            bird.IsHappy<Bird>(new Bird("Tom"));//int只是例子，可以是任意类型

            Console.WriteLine("-------------List集合-----------");
            List<Dog> list = new List<Dog>();
            list.Add(new Dog("A"));
            list.Add(new Dog("B"));
            list.Add(new Dog("C"));
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Sing();
            }

            Console.WriteLine("-------------Dictionary集合-----------");
            Dictionary<string, Dog> dic = new Dictionary<string, Dog>();
            dic.Add("A", new Dog("A"));
            dic.Add("B", new Dog("B"));
            dic.Add("C", new Dog("C"));

            dic["A"].Sing();

            Console.WriteLine("-------------栈Stack集合-----------");
            Stack<Pet> stack = new Stack<Pet>();
            stack.Push(new Bird("D"));
            stack.Push(new Fish("E"));
            stack.Push(new Bird("F"));

            stack.Peek().printName();//显示栈顶元素
            stack.Pop();//出栈
            stack.Peek().printName();

            Console.WriteLine("-------------队列Queue集合-----------");
            Queue<Pet> queue = new Queue<Pet>();
            queue.Enqueue(new Bird("G"));
            queue.Enqueue(new Bird("H"));
            queue.Enqueue(new Fish("I"));

            Pet pet = null;
            pet = queue.Dequeue();
            pet.printName();
            pet = queue.Dequeue();
            pet.printName();
            pet = queue.Dequeue();
            pet.printName();

            Console.WriteLine("-------------委托-----------");
            ActCute del = null;
            Fish fish = new Fish("J");
            Bird bird_d = new Bird("K");
            del = fish.WagTail;//没有括号，只是持有方法
            del += bird.innocentLook;
            del += () => { Console.WriteLine("do nothing"); };

            del();

            Console.WriteLine("-------------事件-----------");//实际上也是观察者模式设置的过程
            Client client_1 = new Client();
            Client client_2 = new Client();
            Bird.NewBird += client_1.WantADog;//注册事件
            Bird.NewBird += client_2.WantADog;//注册事件

            Bird bird_event = new Bird("event_bird");
        }

    }
}
