using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HashtableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();
            
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.NET");

            ICollection keys = ht.Keys;
            
            foreach (String k in keys)
            {

                Console.WriteLine(ht[k]);

                Console.ReadKey();
            }

        }
    }
}
