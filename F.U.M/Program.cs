using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace F.U.M
{
    public class MyMethods
    {
        public static T FindMaxInArray<T>(T[] MyArray) where T : IComparable<T>
        {
            T Max = MyArray[0];

            foreach (T i in MyArray)
            {
                try
                {
                    if (i.CompareTo(Max) > 0)
                    {
                        Max = i;
                    }
                }
                catch
                {
                    Console.WriteLine("You cannot find the maximal number of this array.");
                }
            }

            return Max;
        }

        public static T FindMinInArray<T>(T[] MyArray) where T : IComparable<T>
        {
            T Min = MyArray[0];

            foreach (T i in MyArray)
            {
                try
                {
                    if (i.CompareTo(Min) < 0)
                    {
                        Min = i;
                    }
                }
                catch
                {
                    Console.WriteLine("You cannot find the minimal number of this array.");
                }
            }

            return Min;
        }

        public static void ResizeArray<T>(ref T[] MyArray, int newsize)
        {
            T[] newArray = new T[newsize];

            for (int i = 0; i < MyArray.Length && i < newArray.Length; i++)
            {
                newArray[i] = MyArray[i];
            }

            MyArray = newArray;
        }

        public static void AddElementToArray<T>(ref T[] MyArray, T value, int Where)
        {
            T[] newArray = new T[MyArray.Length + 1];

            newArray[Where] = value;

            for (int i = 0; i < Where; i++)
            {
                newArray[i] = MyArray[i];
            }

            for (int i = Where; i < MyArray.Length; i++)
            {
                newArray[i + 1] = MyArray[i];
            }

            MyArray = newArray;
        }

        public static void AddFirstElementToArray<T>(ref T[] MyArray, T value)
        {
            T[] newArray = new T[MyArray.Length + 1];

            newArray[0] = value;

            for (int i = 1; i < MyArray.Length; i++)
            {
                newArray[i] = MyArray[i];
            }

            MyArray = newArray;
        }

        public static void AddLastElementToArray<T>(ref T[] MyArray, T value)
        {
            T[] newArray = new T[MyArray.Length + 1];

            for (int i = 0; i < MyArray.Length; i++)
            {
                newArray[i] = MyArray[i];
            }

            newArray[^1] = value;

            MyArray = newArray;
        }

        public static void RemoveElementFromArray<T>(ref T[] MyArray, int Index)
        {
            T[] newArray = new T[MyArray.Length - 1];

            for (int i = 0; i < Index; i++)
            {
                newArray[i] = MyArray[i];
            }

            for (int i = Index; i < newArray.Length; i++)
            {
                newArray[i] = MyArray[i + 1];
            }

            MyArray = newArray;
        }

        public static void RemoveFirstElementFromArray<T>(ref T[] MyArray)
        {
            RemoveElementFromArray(ref MyArray, 0);
        }

        public static void RemoveLastElementFromArray<T>(ref T[] MyArray)
        {
            RemoveElementFromArray(ref MyArray, MyArray.Length - 1);
        }

        public static bool isPrime<T>(T number) where T : struct, IConvertible, IComparable<T>
        {
            long num = Convert.ToInt64(number);

            if (num <= 1)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;

            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void SplitSentence(string sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(sentence[i]);
                }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}