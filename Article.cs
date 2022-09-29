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
    public class Article : Person
    {
        public Person this_person;
        public string article_name;
        public double rathing;

        public Article(Person new_this_person, string new_article_name, double new_rathing)
        {
            // thisPerson
            this_person = new_this_person;

            // articleName
            article_name = new_article_name;
            rathing = new_rathing;
        }

        public Article()
        {
            this_person = new Person();
            article_name = "Undifined Article name";
            rathing = 1.1;
        }



        public override string ToString()
        {

            string s = "Автор: " + this_person.get_set_name + " " + this_person.get_set_surename + " " + this_person.get_set_date_of_birth + "\n"
                +"Название статьи: " + article_name + " \n Рейтинг " + rathing;
            return s;
            
        }




    }
}

