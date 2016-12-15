using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddStringToArray_Count_Pass_Test()
        {
            MyList<string> testString = new MyList<string>();

            testString.MyListAdd("car");
            testString.MyListAdd("tear");
            testString.MyListAdd("jar");
            testString.MyListAdd("par");
            testString.MyListAdd("far");
            testString.MyListAdd("star");
            testString.MyListAdd("bar");
            testString.MyListAdd("dag");
            testString.MyListAdd("man");
            testString.MyListAdd("bat");
            testString.MyListAdd("funk");
            testString.MyListAdd("shim");
            testString.MyListAdd("Peach");
            testString.MyListAdd("Fallout 4");
            testString.MyListAdd("tar");
            testString.MyListAdd("pam");
            testString.MyListAdd("can");
            testString.MyListAdd("jackalope");


            Assert.AreEqual(20, testString.MyListCapacity());

        }
        [TestMethod]
        public void AddStringToArray_Pass_Test()
        {
            MyList<string> testString = new MyList<string>();

            testString.MyListAdd("car");
            testString.MyListAdd("tear");
            testString.MyListAdd("jar");
            testString.MyListAdd("par");
            testString.MyListAdd("far");
            testString.MyListAdd("star");
            testString.MyListAdd("bar");
            testString.MyListAdd("dag");
            testString.MyListAdd("man");
            testString.MyListAdd("bat");
            testString.MyListAdd("funk");
            testString.MyListAdd("shim");
            testString.MyListAdd("Peach");
            testString.MyListAdd("Fallout 4");
            testString.MyListAdd("tar");
            testString.MyListAdd("pam");
            testString.MyListAdd("can");
            testString.MyListAdd("jackalope");


            Assert.AreEqual("jackalope", testString[17]);

        }
        [TestMethod]
        public void AddIntToArray_CheckCapacity_Pass_Test()
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


            Assert.AreEqual(10, Test.MyListCapacity());

        }
        [TestMethod]
        public void AddIntToArray_CheckCapacity_Fail_Test()
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


            Assert.AreEqual(20, Test.MyListCapacity());

        }
        [TestMethod]
        public void AddStringToMyList_Pass_Test()
        {
            MyList<string> testString = new MyList<string>();

            testString.MyListAdd("cheese");
            testString.MyListAdd("beer");


            Assert.AreEqual("cheese", testString[0]);

        }
        [TestMethod]
        public void AddLargeNumberToMyList_Pass_Test()
        {
            MyList<int> testInt = new MyList<int>();

            testInt.MyListAdd(2147483647);
            testInt.MyListAdd(-2147483647);


            Assert.AreEqual((testInt[0] - -testInt[1]), 0);

        }
        [TestMethod]
        public void IndexerString_Pass_Test()
        { 
            MyList<string> testString = new MyList<string>();

            testString.MyListAdd("cat");
            testString.MyListAdd("dog");


            Assert.AreEqual(testString[1], "dog");

        }
        [TestMethod]
        public void ZipInt_Pass_Test()
        {
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

            Assert.AreEqual(testZip[9], 10);
        }
        [TestMethod]
        public void ZipString_Count_Pass_Test()
        {
            MyList<string> testString1 = new MyList<string>();

            testString1.MyListAdd("car");
            testString1.MyListAdd("can");
            testString1.MyListAdd("cake");
            testString1.MyListAdd("cam");
            testString1.MyListAdd("cat");
            testString1.MyListAdd("call");
            testString1.MyListAdd("cart");

            MyList<string> testString2 = new MyList<string>();

            testString2.MyListAdd("bar");
            testString2.MyListAdd("bat");
            testString2.MyListAdd("boat");
            testString2.MyListAdd("bon");
            testString2.MyListAdd("bear");

            MyList<string> testStringZip = new MyList<string>();

            testStringZip = testString2.Zip(testString2, testString1);

            Assert.AreEqual(testStringZip.Count, 10);
        }
        [TestMethod]
        public void OverloadPosOpInt_Pass_Test()
        {
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

            testZip = testOdd + testEven;

            Assert.AreEqual(testZip.Count, 10);
        }
        [TestMethod]
        public void OverloadPosOpString_Pass_Test()
        {
            MyList<string> testString1 = new MyList<string>();

            testString1.MyListAdd("car");
            testString1.MyListAdd("can");
            testString1.MyListAdd("cake");
            testString1.MyListAdd("cam");
            testString1.MyListAdd("cat");
            testString1.MyListAdd("bear");
            testString1.MyListAdd("cart");

            MyList<string> testString2 = new MyList<string>();

            testString2.MyListAdd("bar");
            testString2.MyListAdd("bat");
            testString2.MyListAdd("car");
            testString2.MyListAdd("bon");
            testString2.MyListAdd("bear");

            MyList<string> testStringZip = new MyList<string>();

            testStringZip = (testString1 + testString2);

            Assert.AreEqual(testStringZip.Count, 12);
        }

        [TestMethod]
        public void OverloadNegOpString_Pass_Test()
        {
            MyList<string> testString1 = new MyList<string>();

            testString1.MyListAdd("car");
            testString1.MyListAdd("can");
            testString1.MyListAdd("cake");
            testString1.MyListAdd("cam");
            testString1.MyListAdd("cat");
            testString1.MyListAdd("bear");
            testString1.MyListAdd("cart");

            MyList<string> testString2 = new MyList<string>();

            testString2.MyListAdd("bar");
            testString2.MyListAdd("bat");
            testString2.MyListAdd("car");
            testString2.MyListAdd("bon");
            testString2.MyListAdd("bear");

            MyList<string> testStringZip = new MyList<string>();

            testStringZip = (testString1 -testString2);

            

            Assert.AreEqual(testStringZip.Count, 5);
        }
        [TestMethod]
        public void RemoveString_Pass_Test()
        {
            MyList<string> testString1 = new MyList<string>();

            testString1.MyListAdd("car");
            testString1.MyListAdd("can");
            testString1.MyListAdd("cake");
            testString1.MyListAdd("cam");
            testString1.MyListAdd("cat");
            testString1.MyListAdd("bear");
            testString1.MyListAdd("cart");

            testString1.MyListRemove("car");

            Assert.AreEqual("can", testString1[0]);

        }
        [TestMethod]
        public void RemoveIntIsPresent_Pass_Test()
        {
            MyList<int> testInt = new MyList<int>();
            testInt.MyListAdd(1);
            testInt.MyListAdd(3);
            testInt.MyListAdd(5);
            testInt.MyListAdd(7);
            testInt.MyListAdd(9);

            testInt.MyListRemove(5);

            Assert.AreEqual(7, testInt[2]);

        }
        [TestMethod]
        public void RemoveIntNotPresent_Pass_Test()
        {
            MyList<int> testIntNp = new MyList<int>();
            testIntNp.MyListAdd(1);
            testIntNp.MyListAdd(3);
            testIntNp.MyListAdd(5);
            testIntNp.MyListAdd(7);
            testIntNp.MyListAdd(9);

            testIntNp.MyListRemove(4);

            Assert.AreEqual(testIntNp[1], 3);
            
        }
        [TestMethod]
        public void StringsToString_Pass_Test()
        {
            MyList<string> testString1 = new MyList<string>();

            testString1.MyListAdd("car");
            testString1.MyListAdd("can");
            testString1.MyListAdd("cake");

            Assert.AreEqual(testString1.ToString(),"carcancake");
        }
    }
}
