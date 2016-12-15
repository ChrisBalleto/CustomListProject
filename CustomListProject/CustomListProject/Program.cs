using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> Test = new MyList<int>();
            
            Test.MyListAdd(1);
            Test.MyListAdd(3);
            Test.MyListAdd(5);
            Test.MyListAdd(7);
            Test.MyListAdd(9);
            Test.MyListAdd(21);
            Test.MyListAdd(17); 
            Test.MyListAdd(2);
            Test.MyListAdd(3);
            Test.MyListAdd(50);

            MyList<int> Test2 = new MyList<int>();

            Test2.MyListAdd(2);
            Test2.MyListAdd(4);
            Test2.MyListAdd(6); 
            Test2.MyListAdd(8);
            Test2.MyListAdd(10);
            Test2.MyListAdd(4);
            Test2.MyListAdd(5);
            Test2.MyListAdd(6);
            Test2.MyListAdd(7); 
            Test2.MyListAdd(6);
            Test2.MyListAdd(7);
            Test2.MyListAdd(5);
            MyList<int> theList = new MyList<int>();
            theList = Test - Test2;

            MyList<int> Test3 = new MyList<int>();

            MyList<int> testOdd = new MyList<int>();
            testOdd.MyListAdd(1);
            testOdd.MyListAdd(3);
            testOdd.MyListAdd(5);
            testOdd.MyListAdd(7);
            testOdd.MyListAdd(9);

            MyList<int> testEven = new MyList<int>();
            testEven.MyListAdd(2);
            testEven.MyListAdd(4);
            testEven.MyListAdd(6);
            testEven.MyListAdd(8);
            testEven.MyListAdd(10);

            MyList<int> testZip = new MyList<int>();

            testZip = testOdd.Zip(testOdd, testEven);

            Console.ReadLine();

            testZip = testZip.Zip(Test, Test2);

            Console.WriteLine(testZip.ToString());
            foreach(int item in testZip.ToString())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
            theList = Test - Test2;

            Console.WriteLine(Test.MyListCount());
           
            Test.MyListRemove(4);
            Console.WriteLine(Test.MyListCount());
            Console.WriteLine(Test[6]);

            Console.ReadLine();
        }
    }
}
