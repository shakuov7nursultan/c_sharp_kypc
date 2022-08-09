using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr2 = new string[5];
            // Создаем массив типа string, длиной 5
            Array myArr = Array.CreateInstance(typeof(string),5);

            // Инициализируем первые три поля массива
            myArr.SetValue("Name",0);
            myArr.SetValue("Age",1);
            myArr.SetValue("Adress",2);

            // Копируем массив с помощью метода Clone()
            string[] arr1 = (string[])myArr.Clone();

            foreach (string s in arr1)
                Console.Write("\t"+s);

            // Копируем с помощью метода Copy()
            Console.WriteLine();
            Array.Copy(myArr, arr2, myArr.Length);
            foreach (string s in arr2)
                Console.Write("\t"+s);

            Console.ReadLine();
        }
    }
}