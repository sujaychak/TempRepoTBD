using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*
 Find the degree of an Array i.e. the max occurance of a single value
 Find min length that would have same degree as the input array
*/
//css_include NewBaseClass.cs
namespace DegreeOfArray
{
    class Program
    {
        internal struct ArrayStats
        {
            public int itemCount;
            public int lastIdx;
        }
        static void Main(string[] args)
        {
        	//Some Text for testing GIT
            ArrayList array = new ArrayList();
            Dictionary<int, ArrayStats> ar = new Dictionary<int, ArrayStats>();
            Console.WriteLine("Enter the array, with elements separated by space");
            string resp = Console.ReadLine();
			array.AddRange(resp.Split(' ').ToList());
            int i = 0;
            foreach (var item in array)
            {
                int temp = (int)item;
                if (ar.Count > 0 && ar.ContainsKey(temp))
                {
                    ArrayStats ast = ar[temp];
                    ast.itemCount++;
                    ast.lastIdx = i;
                    ar[temp] = ast;
                }
                else
                {
                    ar.Add((int)item, new ArrayStats { itemCount = 1, lastIdx = i });
                }
                i++;
            }
        }
    }
}
