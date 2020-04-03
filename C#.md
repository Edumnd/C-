const是C#中定义常亮的关键字。

使用变量分为3步：声明、赋值、使用。

Console.WriteLine("我今天吃{0}，明天吃{1}。",today,tomorrow);

字符类型 char ，存储用 '' (单引号)括起来的一个字符，例如：char sex='男';//存储性别
字符串类型 string ，存储用“”（双引号）括起来的一串字符，例如：string address="北京市宣武区牛街北口";//存储地址
整数类型 int ，存储整数，例如：int age=23;//存储年龄
双精度浮点型 double ，存储小数，例如：double salary=7991.63;//存储工资
以上四种是最常用的数据类型，其他常用类型，我们会随着课程深入慢慢介绍。

自动类型转换：2种不同类型的数据运算，低精度类型会自动转换为较高精度的类型。

强制类型转换：无法自动转换为我们需要的类型，可以用强制类型转换，比如上例可以这样完成：int i=(int)3.0;

C#标识符的命名规则
程序中的变量名、常量名、类名、方法名，都叫做标识符。
C#有一套标识符的命名规则，如果命名时不遵守规则，就会出错。这套规则简单说有下面三条：
  ①标识符只能由英文字母、数字和下划线组成，不能包含空格和其他字符。
   错误的标识符声明：string $user; //错在使用了其他字符
  ②变量名不能用数字开头。
   错误的标识符声明：double 6h;//错在用数字开头
  ③不能用关键字当变量名。
   错误的标识符声明：char static ;//错在用关键字static做变量名

C#的算术运算符（一）
计算机程序，当然少不了“计算”，要计算就必须了解运算符。今天，我们先学习算术运算符中的加、减、乘、除。

加：+ 。加号有2个用途：当用加号连接两个数字时，会计算出这两个数字的和。比如：Console.WriteLine(9+2.2);//输出11.2
另一种情况，当加号两边包含字符串的时候，会把两边的表达式连接成新的字符串。比如：Console.WriteLine(9+"2.2");//输出92.2，因为"2.2"是字符串，所以9也被转换为"9"，+起的作用是连接字符串

减：- 。减号的作用就是减法。比如：Console.WriteLine(15-23);//输出-8

乘：* 。乘号的作用是求2数的乘积。比如：Console.WriteLine(0.8*3);//输出2.4
除：/ 。除号的作用是求2数相除的商。比如：Console.WriteLine(2/0.5);//输出4.0
但是，2个整数相除，结果仅保留整数部分，小数部分会被舍去。Console.WriteLine(5/10);//输出0


C#的算术运算符（二）
这一节我们学习取余运算符。C#中的取余运算符就是%。
上一节学习的除号，作用是求2个数字相除的商，而取余运算符%的作用是求两个数字相除的余数。比如：
Console.WriteLine(19/5);//求19除以5的商，输出3
Console.WriteLine(19%5);//求19除以5的余数，输出4（商3余4）

编程中，%常常用来检查一个数字是否能被另一个数字整除。比如下面的代码片段：
int number = 29;
Console.WriteLine(number%2);//求number除以2的余数
如果输出0,表示没有余数，即number能够被2整除（是偶数）；如果输出1，表示有余数，即number不能被2整除（是奇数）。

C#的算术运算符（三）
++，叫做自加运算符。比如你今年18岁，明年长了一岁，用代码写出来是这样：age++;与age=age+1;作用相同，都是变量的值+1。
--，叫做自减运算符。

另外，age++;与age--;也可以写作++age;或--age;
但请注意：如果与其他运算在同一语句中，++写在变量前面或后面，算法不一样，请看下例：
Console.WriteLine(age++);作用等同于下面两句：
  Console.WriteLine(age);//先打印
  age=age+1;//后自加

Console.WriteLine(++age);作用等同于下面两句：
  age=age+1;//先自加
  Console.WriteLine(age);//后打印

C#的比较运算符
比较数字大小，或者比较数字相等的运算符是比较运算符。C#中的比较运算符有：
= 等于, != 不等于, > 大于, < 小于, >= 大于等于, <= 小于等于
注意：表示两个值相等的“等于”是由2个“=”组成的。
比较运算的结果，都是布尔类型（ bool ），bool类型我们是第一次提到，它表示逻辑上的真(成立)与假(不成立)。真与假用关键字 true 和 false 表示。

C#的逻辑运算符（一）
逻辑运算符用来连接多个 bool 类型表达式，实现多个条件的复合判断。C#中的逻辑运算符包括：逻辑非( ! )、逻辑与( && )、逻辑或( || )。

逻辑非用来对某一个 bool 类型表达式取反，即“真变假”或“假变真”。请看下面的代码：
Console.WriteLine(1 > 0);//条件表达式为true，输出True
Console.WriteLine(!(1 > 0));//用逻辑非对条件表达式取反，输出False

逻辑与用来判断 2 个 bool 类型表达式是否同时为 true 。请看下面的代码：
int x = 5, y = 2;//同时声明2个int型变量并赋值
Console.WriteLine(x>3 && y>3);//判断x>3和y>3是否同时为true，由于y>3为false，所以整个表达式为false
只有当&&两边的表达式均为 true 时，整个表达式才为 true ；若任意一个表达式为 false ，整个表达式即为 false 。

逻辑或用来判断2个 bool 类型表达式中是否有一个为 true 。请看下面的代码：
int x = 5, y = 2;//同时声明2个int型变量并赋值
Console.WriteLine(x>3 || y>3);//判断x>3和y>3是否有一个为true，由于x>3为true，所以整个表达式为true
只要||两边的表达式有一个为 true ，整个表达式即为 true ；若两边的表达式均为 false ，整个表达式为 false 。

对比一下，就是说： && 运算符，两边同真才算真，一边为假就算假； || 运算符，一边为真即为真，两边同假才是假。


C#的赋值运算符
前面，我们已经学过一个赋值运算符“=”，这次我们学习一下其他的赋值运算符：

加赋值“+=”：先加后赋值。请看下面的例子：int x=5; x += 2;//这句等同于x=x+2;执行后，x的值为7
减赋值“-=”：先减后赋值。请看下面的例子：int x=5; x -= 2;//这句等同于x=x-2;执行后，x的值为3
乘赋值“*=”：先乘后赋值。请看下面的例子：int x=5; x *= 2;//这句等同于x=x*2;执行后，x的值为10
除赋值“/=”：先除后赋值。请看下面的例子：int x=5; x /= 2;//这句等同于x=x/2;执行后，x的值为2
取余赋值“%=”：先取余后赋值。请看下面的例子：int x=5; x %= 2;//这句等同于x=x%2;执行后，x的值为1
与其他运算符从左向右计算不同，赋值运算符从右向左计算。

C#的运算符优先级
前面我们学习了那么多运算符，如果编程中同时使用了多个运算符，到底哪一个会先运算呢？这就是优先级的问题。C#运算符的优先级请参考下面的顺序：
①括号。学数学的时候我们就知道，要先计算括号里面的内容。C#语言也是一样，如果有多层括号，要从里向外计算。括号优先级最高。
②一元运算符。有些运算符两边有2个操作数，比如2+3、6%5等等，这些叫做二元运算符。只有一个操作数的叫做一元运算符，它们的优先级高于二元运算符。一元运算符包括：++(自加) 、 --（自减） 、 !（逻辑非）。
③*（乘）、/（除）、%（取余）。
④+（加）、-（减）。
⑤>（大于）、<（小于）、>=（大于等于）、<=（小于等于）。
⑥==（等于）、!=（不等于）。
⑦&&（逻辑与）。
⑧||（逻辑或）。
⑨赋值运算符。包括：=、+=、-=、*=、/=、%=。
另外，还需要注意一点：优先级相同的运算符从左向右计算（赋值运算符相反）。

请看下面这段代码：
bool b = 20 - (15 - 8) * 2 > 10 && (2 % 2 * 2 + 2) > 2;
Console.WriteLine(b);
分析：首先计算优先级最高的括号，(15-8)得到7，(2%2*2+2)则需要先计算%和*，后算+，结果是2，表达式就变成了：bool b=20-7*2>10&&2>2;
接下来优先级最高的是7*2，然后是减法，变成：bool b=6>10&&2>2;
继续计算两个大于号，得到：bool b=false&&false;
最后的结果当然是false.

外层的if (userName == "admin") 会被首先判断，如果为 false ，就会输出“用户名错误！”；如果为 true ，再判断内层的if (password == "bj2022")。

C#提供了一种条件运算符，能够代替简单的 if...else 结构。这种条件运算符的语法如下：
条件表达式 ? 分支1 : 分支2
?: 就是条件运算符，可以看到它有3个操作数，所以又被称为三元运算符。它的运算逻辑是：当条件表达式为 true 时，执行分支1；当条件表达式为 false 时，执行分支2。

if...else 之外，C#中还有一种 switch 条件结构，可以用来对变量进行多个分支的等值判断。语法如下：
switch(变量){
case 常量1:分支1;break;
case 常量2:分支2;break;
...
default:分支n;break;
}

（变量）与每一个 case 后面的常量进行等值比较，如果相等，就执行对应的分支。
执行分支以后， break 关键字会使 switch 结构中止，不会再判断后面的常量。如果变量与所有的常量都不相同，则执行 default 后面的分支。

switch 中的（变量）只能是3种类型：整型(如 int )、字符型( char )、字符串类型( string )。

C#中还有一种非常有用的 for 循环，特别适合于“已知循环次数”的循环。
while 循环有的变量声明、循环条件、变量自加， for 循环一个也不缺，但是 for 循环把这些跟循环次数有关的元素都放在 ( ; ; ) 中，使得{}中的循环体更加纯粹，程序结构更加清晰。
*  for 循环 ( ; ; ) 中的两个分号是不能缺少的。
for 循环运行时，首先进行变量声明和赋值；接下来判断循环条件，若条件为 true ，则执行循环体一次，若条件为 false ，则结束循环；执行循环体后，进行变量自加。然后会进入下一次循环。

C#中， do...while 循环也是一种常用的循环结构。循环结构各部分运行顺序如下：
do{
循环体
变量自加
}while(循环条件);
do...while 循环第一次执行循环体是没有经过条件判断的，也就是说会无条件的执行一次循环体，此后的逻辑顺序就与while循环相同了——先判断条件，条件为true再执行循环体一次。

循环中可以应用 continue 关键字中止一次循环，直接进入下一次。

前面学习 switch 结构时，我们曾经遇到过 break 关键字， break 在 switch 结构的作用是“跳出 switch 结构”。
break 关键字还可以用在循环中，作用是“结束循环”。

在一个循环体中包含另一个循环，称为“嵌套循环”。当2个循环嵌套的时候，外层循环体执行一次，内层循环体执行 n 次（ n 是内层循环的次数）。

编程中有这样一种情形：我们需要存储多个同类型数据。比如，保存 1600 个学生的年龄。是否需要声明 1600 个 int 类型的变量？过了一年，学生们长了 1 岁，是否需要给每个变量重新赋值？这件事情，想想就怕怕。
好在C#中有一种数组，专门存储一组相同类型的数据。数组的声明和初始化语法如下：
<b>数据类型[ ] 数组名 = new 数据类型[长度]; </b>
注意：数组名像变量名一样要遵循标识符的命名规则；长度必须是整数

因为初始化数组时在 [ ] 中声明的长度为 3 。既然都在数组 y 中，所以 3 个变量（应该叫数组元素）的名字都叫 y ，为了区分它们，按照顺序给它们加上索引 [0]、[1]、[2] 。
请注意：数组的索引从 0 开始递增。那么，数组 y 中 3 个元素的名字就变成了 y[0]、y[1]、y[2] 。
最后再注意一点：数组经过初始化以后，数组元素有默认的初始值， double 类型为 0.0 ， int 类型为 0 ， char 类型为 'a' ， bool 类型为 false ， string 类型为 null 。
数组元素的赋值与普通变量相同。

如何知道一个数组的长度呢？ 数组.Length 属性会返回数组的长度（即数组元素的个数）。

数组，可以用来存储相同类型的多个数值。声明并初始化数组的语法：
数据类型[] 数组名 = new 数据类型[]{初始值1,初始值2,...初始值3};
数组元素用索引来区分，索引从 0 开始。
数组的 Length 属性返回数组的长度，即数组元素的个数。

循环访问一组数据，从中找出符合条件的数据，这样的算法叫做查找。
写查找的算法，需要做 2 件事，一是写循环访问每一个数据，二是对每一个数据进行验证。这样，就需要写 2 个“条件”：循环条件和筛选条件。

如上例，循环条件是x<=10，筛选条件是x%2==0。初学者常见的错误是把 2 个条件都写在循环条件里，比如把循环条件写成 x<=10 && x%2== 0 ，请注意甄别：循环条件必须能够遍历每一个数据，如果你写的循环条件会漏掉某些数据，或者循环没有能够正常运行，请检查是不是把筛选条件也写在循环条件里了。

查找算法，主要有 2 个步骤：
1、使用循环访问数组中的每一个元素
2、在循环体中设置筛选条件，打印符合条件的元素

一组数据中只要有一个符合条件，就可以认为“有符合条件的数据”；但只有一组数据中每一个都不符合条件，才能认为“没有符合条件的数据”——一个相等即为"有"，全都不等才是"无"。

变量 hasNbr 起到了关键作用：记录筛选结果。它的初始值为 false ，表示没有，如果循环中找到了相等的数据，再修改 hasNbr 的值为 true ，表示有。循环结束后，只要看看变量 hasNbr 是 true 还是 false ，就知道循环中是否修改过。

for 循环使我们可以通过索引访问数组元素；而 foreach 循环则可以不依赖索引而读取每一个数组元素。

使用 foreach 的语法：
foreach(数据类型 迭代变量名 in 数组名) 注：数据类型必须与数组类型相同
{
使用迭代变量
}
迭代变量 x 只能用于读取数组 num 中的值，但是不能给数组元素赋值，如果尝试给 x 赋值，则会有下面的错误提示：

了解了 foreach 循环的语法，你可能会有疑问：好像 foreach 循环能做的 for 都能做， foreach 存在的意义是什么呢？其实，C#中还存在一些类似于数组的数据组织方式，它们中有一些是没有元素索引的，对于这些元素，只能通过 foreach 遍历。关于那些更高级的对象，我们留待后面的课程介绍。

C#的二维数组的声明和访问
二维数组，就是以数组作为元素的数组。
总结一下，二维数组这样声明：
int[,] arr = new int[2,3]; //包含2个一维数组，每个一维数组包含3个变量，总共2*3=6个数组元素

二维数组元素这样赋值和打印：
arr[1,0] = 28; //二维数组元素有2个索引，都是从0开始，以arr数组为例，元素索引从[0,0]到[1,2]
Console.Write( arr[1,0] );
我们可以用二维数组管理相关的数据，比如有 4 名同学参加语文和数学两门考试，我们用二维数组存储他们的成绩，每位同学的 2 门课分数，存储在一个一维数组中：

类型转换：score[i]=int.Parse(Console.ReadLine());

调试程序：Visual Studio添加断点，快捷键F9，调试运行快捷键F5，单步执行F10.


using System;

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



1、	面向对象设计思想使用三种基本的设计手段：封装、继承、多态来模拟现实世界的事物。
2、	一个小朋友是对象，多小朋友的特征总结出来就是类。
3、	人这个类有姓名、性别、年龄、身高、爱好等特征。
姓名、性别、年龄、身高是静态特征，它们通常是一个名词，可用字段属性来表示；
而爱好是动态的行为，它是一个动词，难以用文字或数字来描述，可用方法来实现，
例：定义一个关于小朋友的类
class Child
{
		stirng _name; //姓名
		string _sex; //性别
		int _age; //年龄           字段，用来描述小朋友的静态特征
		int _height; //身高

		void PlayBall()          //方法的声明
		{//方法体，方法的实现    方法，用来描述小朋友的动态行为
			//代码略
}
}
创建一个小朋友类的对象，也叫类的实例化，如：
Child xiaoMing=new Child(); //实例化了Child类的对象

实例化对象在Main方法中，类名 对象名=new  类名（）；<br>
Child xiaoming=new Child();
有了对象后可以访问他的字段属性和方法
访问字段：对象名.字段="值";  xiaoming._name="小明";
调用方法：对象名.方法名（）;   xiaoming.PlayBall();
输出字段：对象名.字段    xiaoming._name

public关键字，private关键字

public是公共字段，可以在类外被修改（不安全）
private 是私有字段 无法在类外访问（无法使用）

封装：隐藏对象的信息，留出访问的接口
在C#中，通常使用属性对字段进行封装。
隐藏字段，公开属性
利用get(读)，set(写)
public string 
get{return a}
set{a = value}


class Child
    {
        private string _sex;    //隐藏字段
        public string Sex       //公开属性
        {
            get { return _sex; }     //get,set为访问器   get为读   set为写
            set { _sex = value; }	//如果只有get为只读属性，不能修改
        }
    }

属性封装技巧：
private 数据类型 _字段名称;
public 与上数据类型保持一致 字段名称(首字母大写)
{
	get{ return _字段名称; }//读访问器
	set{ _字段名称 = value; }//写访问器
}
新字段名称在Main中的也要引用出来。

封装快捷键：Ctrl + R + E

将set属性删除就是只读属性，则Main中不能为属性赋值了，想要赋值
1.可以得在Child.cs中为字段直接赋值：private string sex="男";同样的也不能在Main中修改；
2.用构造方法

在set访问器中添加条件，约束性赋值：
public int Age
        {
            get => age;
            set { if (value >= 3 && value <= 7) age = value; }
        }
不合理赋值语句不会执行

定义并调用无参方法：
对象{字段、属性、方法}
使用方法{定义方法——调用方法（声明方法——实例化对象——调用方法）}
声明方法：访问修饰符 返回值 方法名
      例：public viod EatSugar()
                {
                   Console.WriteLine("我是吃糖的方法体");
                }
实例化对象：类名 对象名 = new 类名();
        例：Child child = new Child();
调用方法：对象名.方法名();
      例：child.EatSugar();


方法配置了形式参数的情况下，调用方法的时候就需要传入对应形参个数个类型的实际参数.
程序执行方法的时候，程序跳转到方法的定义位置，实参复制一份给形参，方法体执行完毕，返回到方法调用的位置。

方法的重载：
同一个类中，多个方法名相同，但是参数的类型或数量不同
调用时直接通过传入参数的类型判断调用的是哪个
如果参数类型和数量相同，无法实现重载

return：结束方法的调用。
如果使用if...else语句时，return写在if中的最后一句话中，并且else可以省略，并且可以去掉大括号。

在定义方法时，尽量让每一个方法只完成一个单一的功能。
返回值：用于提供方法的输出结果。
方法的返回值类型与return后类型一致。

方法的返回值类型不再是void，而是与放回的值相同的类型，如int、string等等。
方法的最后用return关键字返回结果。
声明一个和方法返回值相同类型的变量来接收结果，使用赋值语句接收：
最后的思考题现象：main中的double sum，默认0.0，接收方法中的int sum计算后得到1

Child child = new Child();//调用构造方法（构造方法的作用：为属性赋值）
            Console.WriteLine("我的名字是{0}",child.Name );
            //如果没有显示定义构造方法，则会有一个默认的无参数的构造方法。
            //如果显示定义了构造方法（不管是有参无参），则没有默认构造方法。
            //只能用new 方法名()的形式调用构造方法。
            //1、构造方法通常声明位public（如果需要的话也可以是private），
            //2、构造方法没有返回值类型，
            //3、构造方法名字必须和类名相同。

this关键字表示当前对象，可以用来调用类的字段、属性和方法。
比如用this.sex用来区分形参sex。
this.sex=sex;
this 表示的是当前对象！没有this的是表示形参sex
this.EatSugar();
用this来调用当前的对象的属性和方法！

构造方法重载：与方法重载一样，名相同但是参数不能相同。
根据传入的参数类型选择最匹配的构造方法
一旦定义了有参构造后，原始的默认的无参构造就失效了

初始化器首先要保证有一个无参构造，必须调用无参构造方法，要用花括号进行赋值，小括号可以省略
对象初始化器：
Child child = new Child() { };  //大括号内对属性进行赋值，小括号可以省略

C#中的数据类型:
值类型：int char double bool
值类型变量存储对象的值，赋值会创建值得副本，修改任何一个副本，不会影响其他的副本

引用类型：类 数组 接口 string(string属于类，所以也是引用类型)
引用类型变量存储对象的内存地址，赋值不会创建值得副本，只会创建地址的副本，修改任何一个副本，也同时修改其他的副本
引用类型new的时候慧创建新的对象，=赋值仅仅是地址的副本。

值类型赋值会创建值的副本（开辟新的内存空间），修改某个副本，并不会影响其他副本的值； 
而引用类型赋值创建的是内存地址的副本（仅仅存储地址而没有开辟内训空间），修改任何一个副本，也同时修改其他的副本。

Child c1 = new Child(); //c1遥控器指向child类型新对象电视机
c1.Name = "张小明";     //c1遥控器初始化电视机的节目“张小明”
Child c2 = c1;          //c1遥控器将它指向的对象电视机赋给c2遥控器
c2.Name = "刘小勇";     //c2遥控器改变所指向的电视机节目，改变初始化
Console.WriteLine(c1.Name);//电视机节目为刘小勇
Console.WriteLine(c2.Name);//电视机节目为刘小勇

struct 结构体也可以象类一种包含字段、属性和方法。
   例：
  struct Dog
    {
        string _name;

        //结构中可以定义属性
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Sing()
        {
            Console.WriteLine("汪汪");
        }

        public Dog(string name)//结构中只能显式定义有参构造方法，且要把所有字段赋值
        {
            _name = name;
        }
    }

static Dog dog;//结构也可以不用实例化对象，即可将=new Dog()去除，定义在Main方法之外
Main方法中
//Dog dog = new Dog();
            dog.Name ="小白";
            Console.WriteLine("The Name of "+dog.Name);
            dog.Sing();
结构与类的区别：
结构是值类型，类是引用类型；
不能为结构中的字段赋初始值；
结构中的构造方法中必须为所有字段赋值；
不能为结构显式定义无参的构造方法；
结构类型的对象可以不实例化，可以定义在Main方法之外；
结构与类的共同点：
结构中可以象类一样定义字段、属性和方法。


枚举：枚举是值类型，枚举中不能定义字段属性和方法，枚举值是从0递增的整数(Gender)0
// <summary>
/// 性别类型
/// </summary>
enum Gender
{
    男, 女
}
//同时在类和方法中将sex变量的类型全改成Gender类型，如：private Gender sex;


方法传参中的值类型参数和引用类型参数
例：
static void Growth(Child child)//引用类型参数，按引用传参
{
	child.Age++;
	Console.WriteLine(“我又长大了一岁!”);
}
static void Growth(int age)//值类型参数，按值传参
{
	age++;
	Console.WriteLine(“我又长大了一岁!”);
}
static void Main()
{
	Child c1=new Child(“小明”,Gender.男,5);
	Growth(c1);//按引用传参，方法修改形参，通常实参也会被修改
	Growth(c1.Age);//按值传参，方法修改形参，实参不会被修改
	Console.WriteLine(“我现在{}岁了!”,c1.Age);
}
二种传参结果会不同，值类型传参显示的年龄还是5，引用类型传参显的的年龄是6。


ref作用是使得值类型形参按引用类型来传参
例如：
static void Growth(ref int age)//ref将值类型形参age变成了引用类型形参
        {
            age++;
        }
        static void Main()
        {
            int age = 5;
            Growth(ref age);
            Console.WriteLine("我现在{ }岁了!",c1.Age);
        }
    }  
输出的结果为6。


out作用是按引用类型传参并获取方法的多个计算结果，可以返回多个值
例如：
static void Growth(int age, out int lastYear, out int nextYear)
{
	lastYear = age - 1;
        nextYear = age + 1;
}
	
static void Main()
{
	int age_out = 7;
        int ly, ny;//去年的年龄，明年的年龄
        Growth(age_out, out ly, out ny);
        Console.WriteLine("我明年{0}岁，去年{1}岁!", ny, ly);
}


一、面向对象的特点：
   封装：
       把客观事物的信息封装成抽象的类，类就是一个封装了数据以及操作这些数据的代码（比如属性和行为）的逻辑实体；
   继承：
       让某个类型的对象获得另一个类型的对象的属性的方法；
   多态：
       一个类实例的相同方法在不同情形有不同表现形式，多态机制使具有不同内部结构的对象可以共享相同的外部接口
--------------------------------------------------------------------------------
二、面向对象的优点：
易维护、易扩展、易开发
>面向过程：第一步、第二步、第三步……
>面向对象：只需要命令做什么（怎么做是对象自己的事情），可以相互调用和派生
--------------------------------------------------------------------------------
三、面向对象编程的方法：
   掌握面向对象的核心思想（一切皆对象）
   使用面向对象的语言技巧
   
 
 
 面向对象的编程思想是一切皆对象，对象具有属性（特征）和行为（函数）。
1.面向对象封装了对象实现的细节，方便多人协作，使用时只需关心公开的属性和函数就行；
2.通过继承可以在基类的基础上实现对象，不用从头编写代码，节省工作量；
3.多态能够改写和增加基类的函数和属性，并且不同的派生类可以作为一个集合进行统一管理。大大增强了程序的扩展性和可管理性。
 
面向对象编程
 特点：封装  继承  多态
 优点：易维护 易扩展 易开发
 继承语法：
     class ChildClass:ParentClass
         {
         .......
         }
   特殊的基类：
       object类是所有的共同基类，它是唯一的非派生类，是继承层次结构的基础。
       继承只能单继承；

要明白object是所有对象的基类，工作中多用继承，把基类的代码拿来，把基类的函数改写，用声明基类指向不同的派生类，放到集合中管理，把对象池化。
继承的专有名词：父类和子类，基类和派生类。
派生类默认拥有基类的所有属性和方法，派生类不用从头开始，节省创建新类的工作量。在c#中object是始祖类，只有object没有基类，明确基类的对象都默认集成object。所以代码中可用 object指向任何对象。
c#中只能有一个直接基类。
多态表现为：
1-通过构造函数的不同入参实例化各种的对象。
2-通过overwrite来重写基类方法的实现过程多态。
3-通过增加属性和方法实现多态最常用的方式。
4-通过写一个与积累同名的函数覆盖基类方法。
对象池化管理：
1-声明基类指向不同的派生类，因为派生类用了overwrite重写了基类的函数，所以集合中的对象函数实现代码不同。
2-通过类的构造函数入参不同实例化不同特征的对象，池化管理，这种方法常用。


隐藏方法：我们不能删除基类中的任何成员，但是可以用与基类成员名称相同的成员来屏蔽基类成员。
语法细节：
屏蔽数据成员：在派生类中声明名称和类型相同的成员
屏蔽函数成员：在派生类中声明新的带有相同函数签名的成员
让编译器知道：可以添加new关键字，否则会有警告


面向对象编程中，都遵循一个原则：依赖倒置原则。意思是程序设计中尽量用抽象类  少用具体类 能解耦
（软件设计中  一般分为  六大设计原则 23种设计模式）
派生类是基类得一种特殊形式，通过一个基类类型得引用指向派生类，只能访问派生类中的基类部分。
为了提高效率：可以用一个容器保存同一种类型所有基类，遍历展示派生类
虚方法：声明virtual的方法就是虚方法
基类的虚方法在派生类中使用override进行重写
多态：通过指向派生类的基类引用，调用虚函数，会根据引用所指向的派生类的实际类型，调用派生类中的同名重写函数，便是多态
虚方法是一种静态方法的定义，多态是一种过程

可以使用基类去引用指向派生类【如：Pet Dog = new Dog()，可以用宠物类去产生狗类，需要注意的是，调用的方法是引用的方法，即Pet】
共性：通过统一的容器，我们可以方便去管理。(如：当需要修改货品金额时，可以在容器中进行修改)
子类差异性：统一的行为中有所区别，也就是个性

【虚方法】是方法定义
作用：虚方法，可以使得类既有共性的属性和方法，也可以在运用时，体现出派生类的个性
用法：声明为“virtual”的。基类的虚方法，可以在派生类中使用override重写

【多态】是一种过程
作用：可以通过基类引用，调用虚函数，会指向派生类，调用派生类里面的同名函数，就叫多态

【数组定义】引用名[] 数组名 = new 类名[]{new 类名(),new 类名()};
                    Pet[] pets = new Pet[]{new Dog(),new Cat()};
然后使用循环遍历 for(int i=0; i<pets.Length; i++){pets[i].Speak();}

【虚方法的知识点】
*重写虚方法，必须有相同的可访问性，且基类方法不能是私有的(private)
*不能重写静态(static)方法或者非虚方法
*方法、属性、索引器、事件，都可以用虚方法定义（既用virtual或override声明）


【构造函数】
作用：派生类对象中，包含基类的信息，在执行派生类的构造函数的时候，会先去隐式或显式的，调用基类构造函数。因为是有了基类才有派生类
调用顺序：引用类的 实例成员初始化>基类>引用类

【在派生类中直接调用基类构造函数】
实例：基类
          基类私有属性 protected string _Name;
          基类定义构造函数public Pet(string name){_Name = name;}
          派生类引用基类构造函数(通过base直接去引用基类构造函数)
          派生类定义构造函数public Dog(string name):base(name){}

1.构造函数：
即使用与类同名的参数作为方法名；注意：构造函数无返回值类型
2.目的：
实例化对象时能同时调用同名函数，使代码更简洁；
3.带参数的构造函数：构造函数存在形参（public jiaosheng（string name）），这样初始化实例是同时可以调用此方法，并且把name的实参赋给方法；
4.若带的参数为基类内的公有参数，为了统一，将基类创建同样的构造函数。初始化派生类的实例时，需将实参赋值给基类的构造函数：Pet（基类） Dogs派生类；派生类内构造函数后需加上：base(形参)； 如：jiaosheng（string name）:base(name)
5.调用构造函数顺序
实例成员初始化->基类构造函数->派生类的构造方法

base()适用情况：
① 基类构造函数（无参），派生类构造函数（无参）
public Pet(){ }
public Dog():base(){ }
② 基类构造函数（无参），派生类构造函数（有参）
public Pet(){ }
public Dog(string name):base(){ }
③ 基类构造函数（有参），派生类构造函数（有参）
public Pet(string name){ }
public Dog(string name):base(name){ }


1、抽象方法
在方法声明前加abstract，抽象方法不能有实际的函数体，抽象方法必须在派生类中重写，才能调用。虚方法在派生类中可以不重写，调用时就是调用的是基类中的方法。
2、抽象类
一个类中含有抽象方法就是抽象类
抽象类中可以含有普通方法可以包含抽象成员、普通成员、抽象方法和普通方法
抽象类不能实例化
抽象类的存在只有一个目的就是被继承。
抽象类的抽象成员必须在派生类中用override关键字实现，否则不能实例化

抽象方法：关键字：abstract（比virtual更进一步：无函数体，需要在子类中进行重写）
抽象的成员必须是：方法、属性、事件、索引；
抽象类：abstract class Pet{}
可以包含抽象成员和普通成员，以及他们的任意组合；抽象类的抽象成员在派生类中需要使用override关键字实现
抽象类
 abstract class Animal
    {
        abstract public void spirits();
    }

密闭类 ：声明为sealed的类；  不能通过继承来修改（不可继承，不是不可修改，当然，无法继承导致了无法修改），禁止产生派生类。
密闭方法：声明为sealed的方法； 不能重写

1、如果是基类方法不希望子类对其重写，就不声明为virtual，基类方法不被标记virtual ，派生类方法无法进行重写
2、如果是派生类不希望其子类（即派生类的派生类）对其进行重写，同时是override重写，就可以使用sealed机制（即同时使用override和sealed）
若派生类中的重写方法（用override修饰的方法）不想再被重写，则可以同时用override和sealed进行修饰。


接口
1、接口就是制定一组函数成员，而不实现他们的引用类型，用interface声明。接口函数不能用其他访问修饰符修饰，默认为public。
2、接口用来被实现
例如Cat:ICatchMice{
//实现接口函数
}
3、一个类可以实现多个接口，当一个类同时继承基类和实现接口时，应该将基类写在最前面，用逗号隔开
  例如：一个类只能单继承，继承自一个父类，但是是可以实现多个接口的，但是在写的时候是要按照下面的顺序来写的：继承的父类，实现的接口一，实现的接口二，，，，
4、一个类实现接口时，必须实现接口声明的函数。
5、可以通过接口引用调用接口中的方法，也可通过实例调用接口方法。例子
爬树为一个接口，抓老鼠为一个接口，当猫这个类实现这两个接口时，
Cat c=new Cat("tom");
爬树 ci=(爬树)c;
c.pashu();//通过实例调用接口方法
ci.pashu();//通过接口引用调用接口方法

接口作用的例子：
用接口还是用类调用要看具体的使用场景的。
假如有10只不同的宠物，攻城狮A负责收集这10只宠物的叫声，攻城狮B负责听这些宠物的声音来给宠物分类。那么你难道要传10个不同的宠物类给B吗，这样B会打死你的。这个时候，你就要建一个叫的接口集合，把10只宠物都封装进这个接口集合，把这个接口集合传给B，B只要循环遍历接口集合，分别调用这个接口的叫的方法，就能让不同宠物叫出声。。。

//攻城狮A负责把不同的宠物装进箱子
        public static List<ICall> GcsA()
        {
            Pig p = new Pig();
            Dog d = new Dog();
            List<ICall> listi = new List<ICall>();
            listi.Add((ICall)p);
            listi.Add((ICall)d);
            return listi;
        }

        static void Main(string[] args)
        {
            //攻城狮B拿到了10只宠物的箱子，循环让它门叫
            List<ICall> listi = GcsA();
            for (int i = 0; i < listi.Count; i++)
            {
                Console.WriteLine(listi[i].Call());
            }
        }
最后说一句，接口一般用于规范，这个规范不仅仅只是对创建者的规范，也是对使用者的规范。B只要宠物的叫声，那么你还有必要告诉B这些宠物叫什么名字吗？


关于堆和栈内存：
  栈内存:栈内存首先是一片内存区域，存储的都是局部变量，凡是定义在方法中的都是局部变量（方法外的是全局变量），for循环内部定义的也是局部变量，是先加载函数才能进行局部变量的定义，所以方法先进栈，然后再定义变量，变量有自己的作用域，一旦离开作用域，变量就会被释放。栈内存的更新速度很快，因为局部变量的生命周期都很短。
  堆内存:存储的是数组和对象（其实数组就是对象），凡是new建立的都是在堆中，堆中存放的都是实体（对象），实体用于封装数据，而且是封装多个（实体的多个属性），如果一个数据消失，这个实体也没有消失，还可以用，所以堆是不会随时释放的，但是栈不一样，栈里存放的都是单个变量，变量被释放了，那就没有了。堆里的实体虽然不会被释放，但是会被当成垃圾，Java有垃圾回收机制不定时的收取。

结构和类
1、不同点
结构是值类型（存储在栈中），类是引用类型（存储在堆中）
结构不支持继承，类支持继承
结构不定义默认构造函数，编译器会定义，自动隐含生成的
2、使用场合
结构由于分配内存块，作用域结束即被删除。不需要垃圾回收，用于小型数据结构，传递过程会复制，应该用ref提高效率。
类用于其他需要继承体系的场合。
例如：定义食物是一个不需要长期存储的数据类型，吃完就没有了，所以可以定义一个食物struct

静态类和静态成员
1、类的静态成员
成员被标记为static时，就是静态成员。静态成员将会被类的所有势力共享，所有实例都访问统一内存位置。
静态成员跟实例成员分开存放。静态成员存放在堆中。
2、静态成员访问
直接通过类名访问，普通成员需要通过实例访问。
3、静态成员声明周期
独立任何实例，没有实例也可以访问。静态成员使用之前编译器已经帮忙完成初始化。
4、静态函数不能访问实例成员，仅能访问其他静态成员，普通方法可以访问静态成员
5、静态构造函数
用于初始化静态字段
在引用任何静态成员之前，和创建任何实例之前调用。
与类同名，使用static，无参数，没有访问修饰符，普通构造函数可以重载的.
静态函数只能访问静态成员，非静态函数可以访问静态/非静态成员

1、静态类
包含静态属性和方法，被标记为static
静态类不能创建实例，不能被继承。
可以为静态类定义静态构造函数。
2、作用
主要用于基础类库（math类）和扩展方法。
3、如何扩展方法
若有源代码，直接添加一个新方法
如果不能修改单也不是密闭类，可以派生子类扩展
如果以上条件不满足，可以使用静态类扩展方法
3、在静态类中的静态方法中参数中加入this关键，则可以直接利用对象调用方法就可以。
4、总结扩展要求
扩展方法所属的类，必须是static类
扩展方法本身就是static方法
扩展方法的第一个参数类型，必须是this+类名。
例如：
Dog类没办法修改，修改Dog类就需要扩展方法，需要一个喂养宠物的方法
static class PetGuide//扩展Dog类的方法
{
  static public void HowToFreedDog(this Dog dog)
{
Console.WriteLine("播放如何喂养一直狗狗的视频");
}
}
···
Dog dog=new Dog();//Dog类中没有HowToFreedDog();方法
dog.HowToFreedDog();//扩展之后好像Dog类中有这样的方法一样。
···

装箱和拆箱
1、装箱：根据值类型的值，在堆上创建一个完整的引用类型对象，并返回对象的引用，是一种隐式转换（语言自动完成）。
2、为什么要装箱
有时候需要将值类型转化为引用类型（比如object）来进行统一的操作（比如作为函数的参数）和统一的存储（比如object[]）。
3、装箱简单实例
int i=3；//这个是int类型的值类型，值为3
object oi=null；//这个是object的引用，赋值为空
oi=i;//将 i的值3赋值给 oi 的过程就是装箱。发生装箱，原来的int保持不变，创建了一个新的对象，该对象在堆当中。需要性能消耗的。
这样输出 i 和oi，输出的都是3
只有写了oi=i；输出的值才会相同
其它时候 i 就是 i 的值，oi就是oi的值
装箱属于增加副本，值与值互不干扰

4、装箱的本质
就是在堆上创建了一个引用类型的副本，新创建的引用类型和原来的值类型相互独立。（就像电影《致命魔术》，不是人瞬间转移，而是有两个人）
相互独立代码验证：
int i=3；
object oi=i;//发生装箱
Console.WriteLine("i="+i+",oi="+oi.ToString);//输出为i=3,oi=3
oi=10;
i=7;
Console.WriteLine("i="+i+",oi="+oi.ToString);//输出为i=7,oi=10
说明两者相互独立
5、拆箱
将装箱后的对象转化回值类型的过程，是一种显示转换（需要手动完成）（in a =（int）b; 强制转换）。
6、拆箱实例
in i=3;
object oi=i;//装箱
int j=(int)oi;//拆箱 把oi这个引用类型的对象通过一个强制的显示转换（int），转换为我们想要的值类型
输出 j 的值就为3


自定义转换：为自己的结构或者类定义显示或隐式转换。
原因：为了让我们自己的结构或者类可以变成一个预期相关的类型，并且是这种转换更加简单。

自定义装换，主要是类或结构使用，区别是显示在调用时需要加括号，括号内是需要装换类型的对象，如A a=new A(); a=(A)B；如果是隐式就直接B赋给a;
显式装换语法public static explicit operator A(B b){`````}
隐式示装换语法public static implicit operator A(B b){`````}

pubilc static--静态方法 implicit--隐式 operator--转换操作
pubilc static--静态方法 explicit--显式 operator--转换操作
public static explicit（显式）/ implicit（隐式） operator 没有函数名称

隐式转换实例：
public static implicit operator Dog(Cat cat){return new Dog(cat.Name)}//将猫咪的类转换为狗狗的类，为猫咪的类定义一个静态的方法

显示转换实例：
public static explicit operator Dog(Cat cat){return new Dog(cat.Name)}

说明：其中implicit为隐式关键字，explicit为显示关键字。Dog是目标类型。语句中无函数名称

调用实例：
Dog dog=new Dog("Jack");
隐式调用：
Cat cat=dog;
显式调用：使用时需要加()来进行强制转换，括号中放一个转换的目标类型
Dog dog2=(Dog)cat;

重载运算符：利用现有的某种运算符（不能创造新的运算符），针对自定义（预定义类型和现有运算符的运算含义是确定的）类或者结构，定义某种运算操作（公狗狗+母狗狗=新生狗狗）。

目的： 利用现有运算符，简化自定义类型的操作，最好是该运算符和该操作，具有一定的相关性。
重载加法 例子;  
public static 类 operator +(类 类属性. 类 类属性) ｛... return new 类();｝

public static Dog operator +(Dog male,Dog female)//如公狗狗+母狗狗=新生狗狗
{···
return new Dog();
}
说明：Dog为返回值，重载加法（+）运算符。

注意重载运算符是运用在自己设计的类的对象上，因此其操作数只能是自己类或结构的对象，因此重载操作符声明定义时要指定好适用于那个类型的形参

那些运算符可以重载
一元运算符：+、-、！、~、++、- -、true、false（操作数必须是类和结构）
二元运算符：+、-、*、%、&、|！、^、<<、>>、= =、！=、>、<、>=、<=（两个操作数至少有一个表示类或者结构）
不能重载：=、&&、||、[]（索引操作）、()等

重载运算符不能做什么：
1、创造新运算符；
2、改变运算符语法；
3、重定义运算符如何处理预定义类型（int a+int b等于a-b）（如：+等于-）；
4、改变运算符的优先级和结合性。

重载运算符举例
···
public void ShowAge()
{
Console.WriteLine("Age="+_age);
}
···
//重载自增操作，针对宠物的年龄
public static Pet opertor ++(Pet pet)//返回值为Pet类型,参数为宠物自身。所有的重载方法都需要public static修饰
{
++pet._age;
return pet;
}
···
Dog dog=new Dog("Jack");
dog._age=2;
dog++;
dog.ShowAge();


泛型
1、什么是泛型类
泛型类就是一个模子，，放入类型的材料（字段属性方法），可以塑造出想要的产品。
2、语法
class Cage<T>//这是一个笼子类，这是一个泛型类，类名后加上一对<>,加上一个泛型参数（类类型参数）
{
T[] petArray;//定义T类型的数组
public void PutIn(T pet){···}//方法 （放入）
public T TakeOut(int index){···}//方法 （取出），占位符T，cage类变为具体类时，T相应的变成具体数据类型
}
说明：T为占位符。类型：为类类型。

//实例化
var dogCage=new Cage<Dog>();//得到狗狗笼子
var catCage=new Cage<Cat>();//得到猫咪笼子

3、为什么需要泛型
用基类或者公共的接口，甚至是所有类的基类object，也可以实现一个Cage类，但是类型态宽泛，需要显示转换类型，并且判断真实类型是什么。
只有需要的类型才会被实例化。

4、泛型使用
声明一个泛型类->引用泛型->构造实例
泛型实例化：
class Cage<T>{.....} //泛型类声明
class Cage<Dog>{···}

Cage<Dog> dogCage; //类型的引用
dogCage = new Cage<Dog>(); //构造实例
var dogCage = new Cage<Dog>();

泛型类优势：
1）代码量更小，无论多少种笼子，我们只需要一个实现
2）只有需要的类型才会被实例化
3）易于维护，修改模板，所有的实例都将改变

泛型类就是相当于一个模板，然后我去给这个模板传递什么参数值然后会根据我传递的这个值去生产出来个性化的东西

泛型类与模板的区别？  泛型类声明定义就是先设计一个可以传入各种类型的“形参”，因此他的实例化过程也同时需要传入一个类（实参）

然后泛型类定义的方法是：/T是一中类型，可能是猫啊狗啊的。然后根据这个传递的类型，其实有点类似于实参，然后我们去创建出不哦她那个的对象来进行处理，可以减少编写重复的代码

完整实例代码：
using System;
namespace MyArrayApplication
{
    public class Array<T>
    {
        public int index;
        T[] a;
        public Array(int num)
        {
            a = new T[num];
        }
        public T GetArray(int index)
        {
            return a[index];
        }
        public void SetArray(int index, T value)
        {
            a[index] = value;
        }
    }
    public class Print
    {
        static void Main(string[] args)
        {

            Array<char> b = new Array<char>(5);
            for (int i = 0; i < 5; i++)
            {
                b.SetArray(i, (char)(i + 98));
                Console.Write(b.GetArray(i) + " ");
            }
            Array<double> d = new Array<double>(20);
            for (int k = 0; k < 20; k++)
            {
                d.SetArray(k, Convert.ToDouble(k + 5.2));
                Console.Write(d.GetArray(k) + " ");
            }
            Console.ReadKey();
        }
    }
}

泛型就是在不确定类的参数类型和返回类型时，设置一个变量来代替这个固定的类型。当创建类实例时，在给这个变量赋对应类类型值，这样就可以实现一个类，输出不同类型的值和方法； 
不用老师的例子，用一个给数组赋值输出数组的例子更好理解；比如设置一个类，构造函数初始化一个数组，数组类型为int,有给数组赋值方法和获取数组值的方法，在此注意：数组的类型int和获取数组值的方法的返回值类型都为int，如果实例此类调用方法，实参和返回值类型也必须是int；就此限定死了此类的实例； 如果想要一个设置char类型的实例，还得必须创建一个新的char的类和方法，才能实现；这样代码工作量就会很大；如果使用泛型，用变量<T>代替固定类型int或char,这样在实例化的时候，将T赋不同类型（int、double、char）,这样就可以获得想要的返回值类型，从而实现了一个模板，只变一个参数T 就能实现相同的功能；
上面给出的例子。只需要把所有<T>去掉，后面的T全改为int或char 就能变为普通类了。对比理解非常简单了

var：
C# 中的var关键字
var 是3.5新出的一个定义变量的类型 其实也就是弱化类型的定义 VAR可代替任何类型 编译器会根据上下文来判断你到底是想用什么类型的 至于什么情况下用到VAR 我想就是你无法确定自己将用的是什么类型 就可以使用VAR 类似 OBJECT 但是效率比OBJECT高点。
或者通俗的讲：
var可以理解为匿名类型，我们可以认为它是一个声明变量的占位符。它主要用于在声明变量时，无法确定数据类型时使用。
使用var定义变量时有以下四个特点:
1. 必须在定义时初始化。也就是必须是var s = “abcd”形式，而不能是如下形式: var s; s = “abcd”;
2. 一但初始化完成，就不能再给变量赋与初始化值类型不同的值了。
3. var要求是局部变量。
4. 使用var定义变量和object不同，它在效率上和使用强类型方式定义变量完全一样。


泛型方法
1、什么是泛型方法：就是方法的模型，给定具体的类型，可以实例化出一个操作该类型的具体方法。
注意：泛型类中往往有泛型方法，泛型类中的泛型参数和泛型方法的泛型参数可以相互独立，普通类中也可以有泛型方法。
2、泛型方法语法
例如：
class Dog{ //普通类
void DogIsHappy<T>(T target){//普通类中的泛型方法
···
}
}
说明：T为类类型

一个类的实例对象就相当于这个类类型的值；
比如 int 4；4是int类型的值；  
Person new person() ;new person()是Person类型的值或实例； 其实就相当于创建一个Person类，然后Person person=new Person();  person 就是Person的一个类型值

实例：
public void isHappy<T>(T target)
{
Console.Write("happy"+target.ToString())
}
class Person{}
...
var dog=new Dog("A");
dog.isHappy<Person>(new Person());
dog.isHappy<int>(3);


约束
1、什么是约束
约束就是控制泛型这匹烈马的缰绳！缩小泛型参数的范围（无论多么泛泛，总有一个范围，范围越小越好控制）
2、约束的意义
只有添加了约束，才能调用泛型参数中（比如T）的方法。
对泛型类和方法都可添加约束。
3、约束的类型
类名  ——该类或者继承该类的类
class  ——任何类
struct ——任何值
接口名 ——该接口类型或任何实现该接口的类型
new()  ——带有无參共有构造函数的类
4、约束叠加规则（这三个约束可以任意存在）
A、主约束，只能有一个（类名，class，struct）
B、接口约束，可以有任意多个
C、构造约束
三个约束可以三个都有，也可以一个都没有。使用where来进行约束。

5、约束例子
void Cage<T,M>
    where T:Pet,IClibTree,new()//where约束哪个类型参数
    where M:Pet,IClibTree,new()
{···}

实例：
//约束范围 class,接口
        public void IsHappy<T>(T target) where T:Pet
        {
            Console.WriteLine(target.ToString());
        }
//调用
Cat b = new Cat("66");
Dog dog = new Dog("A");
b.IsHappy<Dog>(dog);


泛型接口
1、泛型接口允许我们将接口成员的参数和返回类型设置为泛型参数的接口。
2、语法
interface IMyself<T>{//可以写多个泛型参数
  T Myself(T self);//泛型参数可以出现在泛型成员的定义当中，可以出现在参数位置，也可以出现在返回值位置，可以接一个泛型参数，也可以接多个泛型参数
}//和反省语法类似
3、实现泛型接口语法
class A<T>:IMyself<A>{
  public A Myself(A self);//类型参数可以是实现类本身或者其他类型
}
4、代码示例
interface ILearn<A>{
void Act(A cmd);//学习技能的接口
}
class Labrador:Dog,ILearn<Sit>{
public void Act(Sit cmd);
}


集合：一种存放多个数据的容器类型。
最简单的集合：数组Array（完整的类型是System.Array）

预定义常用集合：
动态数组：ArrayList
列表：List
字典：Dictionary
队列：Queue
栈：Stack

使用集合的原因：比数组更为强大，实现了更加丰富的功能。可以提高我们的开发效率。

动态数组ArrayList：
优点：
1、初始化，可以不指定大小（数组初始化必须指定大小）；
2、获取长度，使用Count属性；
3、添加Add；
4、删除Remove（根据对象），RemoveAt（根据索引）；
5、访问 [index]。

缺点：
1、比数组耗费更多的内存；
2、存取速度不如数组那么快；
3、内部数据类型为object，需要装箱/拆箱，Object装箱、拆箱，性能损耗。

ArrayList是类型不安全，而且有装箱拆箱的性能问题，所以有了List<T>
List<T>不会有装箱拆箱的性能问题，但是存取速度较慢。
列表类继承了很多的泛型接口,另外其他泛型的集合类也一般继承了这些泛型接口，因此一版有这些操作（当然有些操作是某些集合类定制的）
另外注意调用这些接口时注意这些接口的不同重载,这些泛型接口的重载不仅针对对同一个集合类有不同重载，因不同集合类的不同也有不同重载

List<Dog> list = new List<Dog>();
list.Add(new Dog("A"));
list.Add(new Dog("B"));
list.Add(new Dog("C"));
list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Sing();
            }
	    

1、字典Dictionary<TKey,Tvalue>
字典容器存储的是一系列的键值对，每个值对应一个唯一的键。键的意义在于，我们可以通过键相对高效的访问到值。
2、字典操作 dictionary-->java.Map
数量 Count  
添加  Add(key,value)
删除  Remove
访问  [key]
3、栈(先进后出，后进先出)
出栈 Pop
入栈 Push
获取栈顶元素  Peek
4、队列
先进先出容器，类似一个两端开口的羽毛球筒
出队  Dequeue
入队  Enqueue，有返回值

list以及数组只能通过索引访问，字典可以通过键访问成员。键一般就是常用的数据类型的值，值可以是对象，键与值是字典类的全部，通过“键"去查“值”。

代码示例：
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


委托、事件和lambda表达式
1、委托
就是持有一个或者多个方法的对象并且该对象可以执行，可以传递。可以安全的调用其他对象的方法。
2、声明委托
可以声明，它是一种引用类型。用delegate声明：delegate 返回值类型 方法名();
例如：声明一个卖萌的委托类型 delegate void ActCute();
3、定义委托类型的对象
既然委托是一种类型，就可以定义该类型的对象。例如ActCute  actCute;
4、给委托对象赋值
例如;
class Dog{
public void WagTai(){···}
}
actCute=dog.WagTail;//没有圆括号
5、使用委托类型
想调用函数一样使用委托类型。
actCute();//像调用函数一样使用委托类型
actCute = dog.WagTail;
delegate string wang(int a); //这是一个代理有参数，有返回值的代理。

委托与继承相似，都是复用代码，继承是类级别的复用，委托是方法级别的复用。
可以保存一些列方法；
调用方式从声明中的变量获得，例如del();

代码示例：
class Bird
{
    public void innocentLook()
    {
        Console.WriteLine(name + " innocent look");
    }
}

class Fish
{
    public void WagTail()
    {
        Console.WriteLine(name + " wag Tail");
    }
}

class Program
{
    delegate void ActCute();//声明委托，这个代理是无参，无返回值的代理，所代理的方法也是无参，无返回值。
    static void Main(string[] args)
    {
	Console.WriteLine("-------------委托-----------");
        ActCute del = null;//给初始化的代理变量赋值
        Fish fish = new Fish("J");
        Bird bird_d = new Bird("K");
        del = fish.WagTail;//没有括号，只是让委托持有方法。这里的方法不能加圆括号，主要是因为这里是赋值，而并非调用
        del += bird.innocentLook;//这里的+=中间是不能有空格的。如果没有+号，则后一个方法会覆盖前一个方法。
        del();//执行委托
    }
}


Lambda表达式
1、什么是匿名方法
delegate void ActCute();
ActCute del;
del=delegate(){//方法的具体内容};//用委托关键字delegate声明一个匿名方法
del = delegate(参数列表){方法体};
2、Lambda表达式
del=delegate(){};
del=()=>{···};
del=(参数列表)=>{方法体};


C#2.0的声明方法为 del=delegate(){...};
C#3.0的声明方法为 del=()=>{...}; 叫做Lambda表达式，用=>取代了delegate的命名方式

//lambda 表达式绑定匿名委托
del += () => { Console.WriteLine("do nothing"); };


事件
1、发布者和订阅者
发布者：通知某件事情发生的
订阅者：对某件事情关注的
2、事件触发和注册
触发：事件发生时，会通知所有关注该事件的订阅者。
注册：想在事件发生时被通知，必须注册以表示关注。
3、用程序语言解释
事件发生时，通知订阅者，就是调用订阅者的注册函数。注册，就是告诉发布者调用哪一个注册函数。
4、事件声明
需要用关键字event，需要声明事件的访问类型和委托类型依据事件的名称
delegate void Handler();//委托
public event Handler NewDog;//Handler 是委托类型，NewDog为事件名
/* event是事件的关键字*/
//NewDog是一个成员，并且会被隐式自动初始化为null
5、事件订阅
NewDog + = 方法 //关注
NewDog - = 方法 //取消关注
方法可以是，实例方法，静态方法，匿名方法、Lambda表达式
6、事件触发
if（NewDog!=null）{
   NewDog();
}
7、事件可以理解为一种封装的受限制的委托，就是对委托进行的一种封装，只有两种，注册(+=)和取消(-=)。委托当中包含着订阅者的注册函数，事件触发就是调用委托当中的回调函数。

代码示例：

public delegate void Handle();
public static event Handle NewBird;//定义为static是因为没有Bird对象的时候也是可以调用的
public Bird(string name)
{
    this.name = name;
    if (NewBird != null)
    {
        NewBird();//触发事件
    }
}

class Client
    {
        //定义事件方法
        public void WantADog()
        {
            Console.WriteLine("Great,I want to see the new bird");
        }
    }

Console.WriteLine("-------------事件-----------");//实际上也是观察者模式设置的过程
Client client_1 = new Client();
Client client_2 = new Client();
//绑定事件方法
Bird.NewBird += client_1.WantADog;//注册事件
Bird.NewBird += client_2.WantADog;//注册事件
Bird bird_event = new Bird("event_bird");


