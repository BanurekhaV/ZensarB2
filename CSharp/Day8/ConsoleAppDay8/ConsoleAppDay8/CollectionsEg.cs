using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    class CollectionsEg
    {
        static void Main()
        {
            //int x;
            //x = 7;
            //var v = 5;
            ////?  v = 'y';

            //dynamic d;
            //d = 10;
            //d = 'a';
            //d = "Rama";
            //d = 56.6666;
            //d = (new Flower("aa","bb"));
            // Console.WriteLine(v);
            //ArrayList al = new ArrayList();
            //al.Add(10);
            //al.Add("ABCD");
            //al.Add(4.5f);
            //al.Add('v');
            //al.Add(true);
            //al.Insert(1, 15);
            //ArrayList al2 = new ArrayList();
            //al2.Add(2);
            //al2.Add(8);
            //al2.Add(3);
            //al2.Add(10);
            //al.InsertRange(1,al2);
            //al2.Sort();
            //foreach (var item in al)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach(var item in al2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("The capacity of the arraylist is :{0}", al.Capacity);
            //Console.WriteLine("The elements count of the arraylist is :{0}", al.Count);

            //hashtable
            Hashtable ht = new Hashtable();
            ht.Add("E003", "Vamsi P");
            ht.Add("E005", "Vajreshwari");
            ht.Add("E001", "Revathi");
            ht.Add("E004", "Pavithra");
            ht.Add("E002", "Manoj B");
            ht.Add("E007", "Revathi");
            ht.Add("E010", null);

            foreach (var s in ht.Keys)
            {
                Console.WriteLine(s);
            }
            foreach (var s in ht.Values)
            {
                Console.WriteLine(s);
            }
            //inorder to see both the keys and values together, we use a structure called as
            //DictionaryEntry
            Console.WriteLine("--------------");
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
