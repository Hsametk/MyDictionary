using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<N,T>
    {
        T[] items;
        N[] numbers;

        public MyDictionary()
        {
            items = new T[0];
            numbers = new N[0];
        }

        public void Add(T item,N number)
        {
            T[] tempArray = items;
            N[] tempArray2 = numbers;

            items= new T[tempArray.Length+1];
            numbers= new N[tempArray2.Length+1];

            for(int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {   
                numbers[i] = tempArray2[i];

            }

            items[items.Length - 1] = item;
            numbers[numbers.Length - 1] = number;
            
        }

    }
}
