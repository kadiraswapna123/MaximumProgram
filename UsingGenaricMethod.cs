using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblem
{
    internal class UsingGenaricMethod
    {
            // define an Array of Generic type with length 5
            T[] obj = new T[5];
            int count = 0;

            // adding items mechanism into generic type
            public void Add(T item)
            {
                //checking length
                if (count + 1 < 6)
                {
                    obj[count] = item;

                }
                count++;
            }
            //indexer for foreach statement iteration
            public T this[int index]
            {
                get { return obj[index]; }
                set { obj[index] = value; }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //instantiate generic with Integer
                TestClass<int> intObj = new TestClass<int>();

                //adding integer values into collection
                intObj.Add(1);
                intObj.Add(2);
                intObj.Add(3);     
                intObj.Add(4);
                intObj.Add(5);

                //displaying values
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(intObj[i]);   
                }
                Console.ReadKey();
            }
        }
    }
}
}
