using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasTables
{
    public class HasTableMain
    {
        Hashtable hashtable = null;
        public HasTableMain() 
        { 
            if (hashtable == null)
            {
                hashtable = new Hashtable();
            }
        }

        public bool Check()
        {
            if(hashtable != null && hashtable.Count!=0)
            {
                return true;
            }
            return false;
        }
        public Hashtable AddValue()
        {
            hashtable.Add("Id", 100);
            hashtable.Add("UserName", "Tharmesh");
            hashtable.Add("Password", "Tharmesh@123");
            hashtable.Add("PhoneNumber", 9087654321);
            hashtable.Add("DOB", new DateTime(2002,11,22));
            return hashtable;
        }

        public void RemoveValue() 
        { 
            if(Check())
            {
                hashtable.Remove("Id");
                Console.WriteLine("\nKey Value Removed Successfully !\n");
                Display(hashtable);
            }
            else
            {
                Console.WriteLine("\nHashTable is Empty !\n");
            }
        }
        public void Display(Hashtable hashtable)
        {
            if(Check())
            {
                foreach(DictionaryEntry item in  hashtable)
                {
                    Console.WriteLine("KEY   -  {0}     VALUE   -  {1}",item.Key,item.Value);
                }
            }
            else
            {
                Console.WriteLine("HashTable is Empty !");
            }
        }

        public void ClearTable()
        {
            if(Check())
            {
                hashtable.Clear();
                Console.WriteLine("\nHashTable Cleared Successfully !\n");
                Display(hashtable);
            }
            else
            {
                Console.WriteLine("HashTable is Empty !");
            }
        }

        public void ContainsKey()
        {
            if(Check())
            {
                Console.WriteLine("\nKEY - "+hashtable.ContainsKey("Id"));
                Console.WriteLine("KEY - "+hashtable.ContainsKey("Password"));
                Console.WriteLine();
            }
           
        }

        public void ContainsValue()
        {
            if(Check())
            {
                Console.WriteLine("VALUE - "+hashtable.ContainsValue("tharmesh@123"));
                Console.WriteLine("VALUE - "+hashtable.ContainsValue(100));
            }
        }

    }
}
