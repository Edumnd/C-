using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarten
{
    /// <summary>
    /// 结构
    /// </summary>
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
            Console.WriteLine("这是"+Name+"汪汪");
        }

        public Dog(string name)//结构中只能显式定义有参构造方法，且要把所有字段赋值
        {
            _name = name;
        }
    }
}

