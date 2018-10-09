using System;
using System.Text;
namespace CustomList
{
    public class GenericList<T>
    {
        readonly int capacity = 1;

        public T[] items;

        private int count;

        public int Count { get { return count; } }

        GenericList<T> temp = new GenericList<T>();

        public GenericList()
        {
            items = new T[capacity];
        }

        public void Add(T value)
        {
            if (count == capacity)
            {
                T[] temporary = new T[capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    temporary[i] = items[i];
                }
            }
            items[count] = value;
            count++;
        }

        public void Remove(int index)
        {
            if (count - 1 == index)
            {
                items[index] = default(T);
            }
            else if (count != index)
            {
                for (int i = index; i < capacity; i++)
                {
                    items[i] = items[i + 1];
                }
            }
        }

        public GenericList<T> Zip(GenericList<T> array1, GenericList<T> array2)
        {
            int largestCount = array1.count + array2.count;
            for (int i = 0; i < largestCount; i++)
            {
                if (i < array1.count)
                {
                    temp.Add(array1.items[i]);
                }
                if (i < array2.count)
                {
                    temp.Add(array2.items[i]);
                }

            }

            return temp;
        }

        public override string ToString()
        {
            string returnString = "";

            for (int i = 0; i < count; i++)
            {
                returnString += items[i];
            }

            return returnString;
        }

        public static GenericList<T> operator+ (GenericList<T> list1, GenericList<T> list2)
        {
            GenericList<T> temp = new GenericList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                temp.Add(list1.items[i]);
            }

            for (int i = 0; i < list2.count; i++)
            {
                temp.Add(list2.items[i]);
            }
            return temp;
        }

        public static GenericList<T> operator- (GenericList<T> list1, GenericList<T> list2)
        {
            GenericList<T> temp = new GenericList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                for (int j = 0; j < list2.count; j++)
                {
                    if(list1.items[i].Equals(list2.items[j]))
                    {
                        list1.Remove(i);
                    }

                    else if(list2.items[i].Equals(list1.items[j]))
                    {
                        list2.Remove(i);
                    }

                    for (int k = 0; i < list1.count; i++)
                    {
                        temp.Add(list1.items[k]);
                    }
                    for (int l = 0; l < list2.count; l++)
                    {
                        temp.Add(list2.items[l]);
                    }
                }
            }
            return temp;
        }
    }
}

