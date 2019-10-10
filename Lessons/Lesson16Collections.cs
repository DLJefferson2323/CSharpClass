using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* This class goes over lesson 16 content
Collections & LINQ */
namespace CSharpClass.Lessons
{
    public class Lesson16Collections
    {
        public void MyArrayListExample()
        {
            ArrayList myList = new ArrayList();
            myList.Add("Hello");
            myList.Add(42);
            myList.Add(true);
            myList.Add('D');
            PrintValues(myList);

        } // end method my array list example

        private void PrintValues(IEnumerable myListing)
        {
            foreach (Object item in myListing)
            {
                Console.WriteLine("Values: {0}", item);

            } // end method for each
        } // end method print values

        public void MyHashtableExample()
        {
            Hashtable myHash = new Hashtable();
            myHash.Add(10, "CSharp");
            myHash.Add(42, 25);
            myHash.Add(99, "Brooklyn");
            myHash.Add(50, 'D');

            foreach (DictionaryEntry item in myHash)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                item.Key, item.Value);
            } // end method for each
        } // end method my hashtable example

        public void MyListExample()
        {
            List<string> myList = new List<string>();
            myList.Add("Alpha");
            myList.Add("Beta");
            myList.Add("Charlie");
            myList.Add("Delta");
            myList.Add("Echo");
            myList.Add("Foxtrot");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            } // end method for each
        } // end method my list example

        public void myOtherList()
        {
            List<House> myHouseList = new List<House>();
            myHouseList.Add(new House(24, "granite"));
            myHouseList.Add(new House());
            myHouseList.Add(new House(42, "brick", "solar", "red"));

            foreach (House item in myHouseList)
            {
                Console.WriteLine(item.DoorColor +" , " + item.RoofType);
            } // end method for each

        } // end method my other list

        public void MyDictionaryExample()
        {
            Dictionary<int, string> myList = new Dictionary<int, string>();
            myList.Add(36, "FSharp");
            myList.Add(26, "Rocks");
            myList.Add(16, "Paper");
            myList.Add(56, "Scissor");

            // to get a single value we use the TryGetValue method
            string temp = "";
            if(myList.TryGetValue(30, out temp))
            {
                Console.WriteLine("Key 20 is {0}", temp);
            } // end method try get value

            foreach (KeyValuePair<int, string> item in myList)
            {
                Console.WriteLine("Key : {0}, Value : {1}", item.Key, item.Value);
            } // end method for each

        } // end nethod my dictionary example

        public void myLinqExample()
        {
            int[] scores = new int[] {97,92,88,60,55,40,15};

            IEnumerable <int> query = from score in scores
            where score < 85
            select score;

            foreach (int item in query)
            {
                Console.WriteLine(item);
            }// end method for each
        } // end method my linq example

        public void MyOtherLinq()
        {
            List<House> myHouseList = new List<House>();
            myHouseList.Add(new House(25, "granite"));
            myHouseList.Add(new House(26, "steel","plastic","grey"));
            myHouseList.Add(new House());
            myHouseList.Add(new House(42, "oak","maple","blue"));

            var subset = from theHouse in myHouseList
            where theHouse.RoofType == "shingle"
            orderby theHouse.DoorColor
            select theHouse;

            foreach (House item in subset)
            {
                Console.WriteLine("My house has a {0} roof", item.RoofType);
            } // end method for each
        } // end method my other linq

    } // end class
} // end namespace