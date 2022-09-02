#region FirstTask
//using System;
//using System.IO;
//namespace Lesson10
//{
//    class Tasks
//    {
//        static void Main()
//        {
//            string fileName = @"mytest.txt";
//            string[] ArrLines;
//            int n, i;

//            Console.WriteLine("\n\n Create and read the last line of a file  :\n");
//            Console.WriteLine("-----------------------------------------------\n");

//            if (File.Exists(fileName))
//            {
//                File.Delete(fileName);
//            }
//            Console.WriteLine("Input number of lines to write in the file  :");
//            n = Int32.Parse(Console.ReadLine());
//            ArrLines = new string[n];
//            Console.Write(" Input {0} strings below :\n", n);

//            for (i = 0; i < n; i++)

//            {
//                Console.Write("Input line {0} : ", i + 1);
//                ArrLines[i] = Console.ReadLine();
//            }

//            System.IO.File.WriteAllLines(fileName, ArrLines);
//            Console.Write("\n The content of the last line of the file {0} is  :\n", fileName);

//            if (File.Exists(fileName))
//            {
//                string[] lines = File.ReadAllLines(fileName);
//                Console.WriteLine(" {0}", lines[n - 1]);
//            }

//            Console.WriteLine();
//        }

//    }
//}
#endregion
#region ThirdTask

//using System;
//namespace Lesson10_
//{
//    public class Program
//    {
//        static void Main(string[] args);
//        MyArrayList myArrayList = new Lesson10_.MyArrayList;
//    }
//    public class MyArrayList<T>
//    {
//        public T[] asArray;
//        public int size;

//        public MyArrayList()
//        {
//            asArray = new T[size];
//        }

//        public void add(T t)
//        {
//            T[] temp = new T [asArray.Length + 1];

//            // copy everything over to the new array
//            for (int i = 0; i < asArray.Length; i++)
//            {
//                temp[i] = asArray[i];
//            }

//            // add the new element
//            temp[asArray.Length] = t;
//            asArray = temp;
//        }

//        public void remove(int index)
//        {
//            if (index < 0 || index >= asArray.Length) return;
//            T[] temp = new T[asArray.Length + 1];

//            Boolean found = false;

//            for (int i = 0; i < asArray.Length; i++)
//            {
//                if (i == index)
//                {
//                    found = true;
//                    continue;
//                }
//                temp[i - (found ? 1 : 0)] = asArray[i];
//            }
//            asArray = temp;
//        }

//        public T get(int index)
//        {
//            return asArray[index];
//        }
//    }
//}
#endregion
#region FifthTask
//using System;
//using System.Collections.Generic;

//namespace lesson_10
//{
//    // Program class-ni yaradiriq.
//    class Program
//    {
//        // Main yaradiriq.
//        public static void Main()
//        {
//            Dictionary<string, bool> characters = new Dictionary<string, bool>()
//            {
//            { "Luke", true },
//            { "Han", false },
//            { "Chewbacca", false }
//            };
//            characters.Remove("Han");

//            // Print edirik Console-a
//            foreach (KeyValuePair<string, bool> pair in characters)
//            {
//                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");


//            }
//        }

//    }
//}
#endregion