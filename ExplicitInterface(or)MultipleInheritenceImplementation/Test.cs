using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface_or_MultipleInheritenceImplementation
{
    //In c#.net Multiple Inheritence is not possible by using classes.
    //Through interface it is possible.Beacuse if 2 interfaces having same method name compiler doesn't know which method i need to call.
    //due to that through explict interface concept we can achoeve multiple inhertence.
    internal class Test : IFirst, ISecond
    {
        void IFirst.Show()
        {
            Console.WriteLine("IFirst Show");
        }
        void ISecond.Show()
        {
            Console.WriteLine("ISecond Show");
        }
    }
}
