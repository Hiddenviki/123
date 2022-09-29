using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace Lab1
{
    public class Task1:Magazine
    {

        public int ncolumns; //в этом классе у нас хранится количество строчек и столбцов матриц
        public int nrows;

        public Task1()
        {
            ncolumns = 2;
            nrows = 2;
        }

        private int[] GetNums(string text)
        {
            int[] m = new int[2];

            string[] separatingStrings = { "<<", " ", "-", "!", ".", "@", "+" };

            string[] words = text.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
            m[0] = Convert.ToInt32(words[0]);
            m[1] = Convert.ToInt32(words[1]);

            Console.WriteLine($"вот какие значения поймала консоль: {m[0]} и {m[1]}");

            return m;
        }

        public void start_1()
        {

            Console.WriteLine("Введите количество СТОЛБЦОВ и СТРОК в двумерном массиве (символы разделения <<, -, !, ., @, +):");
            string string_from_console = Console.ReadLine();
            int[] tmp = new int[2]; //тут у нас получаются цифры в массиве, из этого массивы расфасуютя в поля класса
            tmp = GetNums(string_from_console);
            ncolumns = tmp[0];
            nrows = tmp[1];


            //////сначала делаю двумерный массив/////
            Magazine[,] array2 = new Magazine[nrows, ncolumns];
            Console.WriteLine("Про двумерный массив: ");

            for (int i = 0; i < nrows; i++)
            {
                for (int j = 0; j < ncolumns; j++)
                {
                    array2[i, j] = new Magazine();
                    
                }
            }
            ///////засекаю двумерное изменение)))
            int time1 = Environment.TickCount;
            for (int i = 0; i < nrows; i++)
            {
                for (int j = 0; j < ncolumns; j++)
                {
                    array2[i, j].get_set_magazine_NAME = "NEW NAME";
                }
            }
            int time2 = Environment.TickCount;
            Console.WriteLine("Время для двумерного массива: "+(time2-time1));

            /////теперь делаю одномерный/////

            Magazine[] array1 = new Magazine[nrows * ncolumns];

            Console.WriteLine("Одномерный массив: ");
            for (int i = 0; i < (nrows * ncolumns); i++)
            {
                array1[i] = new Magazine();
            }

            ///////засекаю одномерное изменение)))
            time1 = Environment.TickCount;
            for (int i = 0; i < nrows * ncolumns; i++)
            {
                array1[i].get_set_magazine_NAME = "NEW NAME";

            }
            time2 = Environment.TickCount;
            Console.WriteLine("Для одномерного массива: " + (time2 - time1));




            //////теперь ступенчатый/////
            ///
            ////тип [][] имя массива = new тип[размер] [];

            static Magazine[][] makeArray(int n)
            {
                Magazine[][] arr = new Magazine[n][];
                for (int i = 0; i < n; i++)
                {
                    Magazine[] tempArr = new Magazine[i * 2];
                    for (int j = 0; j < tempArr.Length; j++)
                    {
                        tempArr[j] = new Magazine();
                    }
                    arr[i] = tempArr;
                }
                return arr;
            }

            Console.Write("\nВведите количество строк в ступенчатом массиве: ");
            int n = int.Parse(Console.ReadLine());
            n++;
            Magazine[][] myArray = makeArray(n);



            ///////засекаю сТупЕнчАтОе изменение)))
            time1 = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j].get_set_magazine_NAME = "NEW NAME";
                }
            }
            time2 = Environment.TickCount;
            Console.WriteLine("Для ступенчатого массива: " + (time2 - time1));

            //foreach (Magazine[] tmp1 in myArray)
            //{
            //    Console.WriteLine(String.Join(" ", tmp1));
            //}
            //Console.ReadKey();




        }



    }
}

