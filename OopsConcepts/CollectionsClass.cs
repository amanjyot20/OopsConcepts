using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class CollectionsClass
    {
        int[] arra = new int[3];
        ArrayList list = new ArrayList();
        Dictionary<string, string> hashMap = new Dictionary<string, string>();

        public void displayArray()
        {

            arra[0] = 12;
            arra[1] = 32;
            arra[2] = 21;
            foreach (int row in arra)
            {
                Console.WriteLine(row);
            }
        }
        public void displayArrayList()
        {
            list.Add("Credit");
            list.Add("Debit");
            list.Add("Cash");
            foreach (String str in list)
                Console.WriteLine(str);
        }
        public void displayHashMap()
        {
            hashMap.Add("RollNo.", "123");
            hashMap.Add("Name.", "taran");
            hashMap.Add("Class.", "M.tech");
            foreach (var str in hashMap)
                Console.WriteLine(str.Key + "  : " + str.Value);
        }


    }
}
