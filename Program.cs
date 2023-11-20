using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HasTableMain hasTableMain = new HasTableMain();
            Hashtable hashtable = hasTableMain.AddValue();
            hasTableMain.Display(hashtable);
            hasTableMain.RemoveValue();
            hasTableMain.ContainsKey();
            hasTableMain.ContainsValue();
            hasTableMain.ClearTable();
        }
    }
}
