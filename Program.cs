using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
//variant2


public enum Frequency
{
    Weekly,
    Montly,
    Yearly,
}

namespace Lab1
{
    class Program
    {

        static void Main(string[] args)
        {

            //var stu1 = new Person("Vika", "Veselkovaaa", "2000 10 20");
            //var stu2 = new Person("Vika2", "Veselkovaaa2", "2009 11 21");

            //var article1 = new Article(stu1, "Aaa", 993.01);
            //var article2 = new Article(stu2, "BBbb", 123.031);

            //var magazine1 = new Magazine("Череда хороших событий",0, new DateTime(2022,2,14),18);
            //magazine1.add_Article(article1);
            //magazine1.add_Article(article2);
            //Console.WriteLine(magazine1.ToString());
            //Console.WriteLine(magazine1.toShortString());

            Console.WriteLine("что тут у меня такооооое");

            var first1 = new Task1();
            first1.start_1();

        }
    }
}
