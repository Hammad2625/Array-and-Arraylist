using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Azrraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, };
            int[] arr2 = new int[5];
            arr2[0] = 10;
            arr2[1] = 20;
            arr2[2] = 30;
            arr2[3] = 40;
            arr2[4] = 50;

            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1520);
            arrayList.Add("Hammad");
            arrayList.Add(true);

            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
