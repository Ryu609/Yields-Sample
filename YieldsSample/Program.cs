using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldsSample
{
    class Program
    {
        static List<int> MyList = new List<int>();

        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }

        static IEnumerable<int> FilterWithYield()
        {
            foreach (int i in MyList)
            {
                if (i > 3) yield return i;

            }

        }

        static void Main(string[] args)
        {
            FillValues();
           
            foreach (int i in FilterWithYield()) // Browses through the list
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
