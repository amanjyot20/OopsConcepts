using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class ValueByReferenceBy
    {
        int number1 = 10;
        int number2;
      //int number2;
        int[] arr = new int[5] {1,2,3,4,5 };
        int[] arr2;
        public ValueByReferenceBy()
        {
            number2 = number1;
            number2 = 20;

            arr2 = arr;       // Reference copy
            arr2[0] = 100;    // Changes arr[0] too
        }
        public void display()
        {
            Console.WriteLine("Value Type- Check change in Number 1 : = " + number1);
            Console.WriteLine("Reference Type-Check change in Array 1 : " + arr[0]);
        }
    }
}
