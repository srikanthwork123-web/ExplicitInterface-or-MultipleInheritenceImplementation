using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface_or_MultipleInheritenceImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object obj1 = new object();//object is base class for all the classes.


            // Test obj=new Test();//you can't use normal object for calling the explicit methods.
            //obj.//you will not get any intellesense here
            //You can call the explicit interfce methods below way.
            Test obj = new Test();

            IFirst firstObj = obj;
            firstObj.Show();//calling the IFirst interface Show() Method.

            ISecond secondObj = obj;
            secondObj.Show();//calling the ISecond interface Show() Method.

            Console.ReadLine();



        }
    }
}
