using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class MyList<T> : IEnumerable
    {
        int count;
        int capacity;     
        public T[] myListArray;
        public MyList()
        {
            count = 0;
            capacity = 5;
            myListArray = new T[capacity];            
        }
        public MyList(int capacity)
        {
            count = 0;           
            myListArray = new T[capacity];
            this.capacity = capacity;        
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }           
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                capacity = value;
            }
        }
        public int MyListCount()
        {
            return this.count;
        }
        public int MyListCapacity()
        {
            return this.capacity;
        }
        public MyList<T> Zip(MyList<T> list1, MyList<T> list2)
        {           
            MyList<T> list3 = new MyList<T>(list1.Count >= list2.Count ? list2.count * 2 : list1.count * 2 );
            for (int i = 0; i < (list1.Count > list2.Count ? list2.count : list1.count); i++)
            {
                list3.MyListAdd(list1[i]);
                list3.MyListAdd(list2[i]);
            }
            return list3;
        }
        public void MyListAdd(T item)
        { 
            if ((capacity - count) == 0)
            {               
                DoubleArraySize();
                myListArray[count] = item;
                count++;
            }
            else
            {
                myListArray[count] = item;
                count++;
            }            
        }

        public void DoubleArraySize()
        {
            int doubleCapacity = capacity * 2;
            T[] temporary = new T[(doubleCapacity)];
            for (int i = 0; i < (capacity); i++)
            {
                temporary[i] = myListArray[i];
            }
            capacity = capacity * 2;
            myListArray = temporary;
        }
        public static MyList<T> operator -(MyList<T> list1, MyList<T> list2) //This function should subtract (from list1) every instance where an element that list 1 and list 2 have.
        {
            int x = 0;
            bool shouldAdd = true;
            MyList<T> subtractList = new MyList<T>(list1.Count);
            for (int i = 0; i < list1.count; i++)
            {
                shouldAdd = true;
                for (int j = 0; j < list2.count;j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        shouldAdd = false;
                    }                        
                }
                if(shouldAdd == true)
                {
                    subtractList[x] = list1[i];
                    x++;
                    subtractList.count++;
                }
            }           
            return subtractList;
        }
        public int UseLargerCap(MyList<T> list1, MyList<T> list2)
        {
            if (list1.Capacity > list2.Capacity)
            {
                Capacity = list1.Capacity;
                return capacity;
            }
            else if (list2.Capacity >= list1.Capacity)
            {
                Capacity = list2.Capacity;
                return capacity;
            }
            return capacity;
        }
        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> addedList = new MyList<T>(list1.Count + list2.Count);
            for (int i = 0; i < list1.count; i++)
            {
                
            }
            for (int i = 0; i < list2.count; i++)
            {
                addedList.MyListAdd(list2[i]);
            }
            return addedList;
        }
        public int DoubleLargerCap(MyList<T> list1, MyList<T> list2)
        {
            if (list1.Capacity > list2.Capacity)
            {
                Capacity = list1.Capacity * 2;
                return capacity;
            }
            else if (list2.Capacity >= list1.Capacity)
            {
                Capacity = list2.Capacity * 2;
                return capacity;
            }
            return capacity;
        }
        public bool MyListRemove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (myListArray[i].Equals(item))
                {
                    myListArray[i] = myListArray[i + 1];
                    count--;
                    return true;
                }
            }
            return false; 
        }      
        public T this[int number]
        {
            get
            {
                return myListArray[number];
            }
            set
            {
                myListArray[number] = value;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return myListArray[i];
            }            
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {           
            string myString = "";
            foreach (T element in myListArray)
            {
                myString += element;
            }
            return myString;
        }
    }
}
//    class CustomList
//{
//    public int Capacity { get; set; }
//    public int Count { get; }
//    public CustomList();
//    public void Add(T item);
//    public void Insert(int index, T item);
//    public bool Remove(T item);
//    public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2);
//    public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2);
//    public IEnumerator<T> GetEnumerator();
//    IEnumerator IEnumerable.GetEnumerator();
//}
