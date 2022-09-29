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


    public class Magazine : Article
    {
        private string magazine_name; //название журнала
        private Frequency this_freequency; //частота выхода журнала
        private DateTime date_of_magazine; //дата выпуска журнала
        private int number_of_magazines; //тираж журнала
        private Article[] articles; //список статей в журнале


        public Magazine()
        {
            magazine_name = "Undefined magazine name";
            this_freequency = Frequency.Weekly;
            date_of_magazine = new DateTime(1970, 10, 20);
            number_of_magazines = 100;

        }

        public Magazine(string new_magazine_name, Frequency new_freequency, DateTime new_date_of_magazine, int new_number_of_magazines)
        {
            this.magazine_name = new_magazine_name;
            this.this_freequency = new_freequency;
            this.date_of_magazine = new_date_of_magazine;
            this.number_of_magazines = new_number_of_magazines;
        }

        public string get_set_magazine_NAME
        {
            get
            {
                return this.magazine_name;
            }

            set
            {
                this.magazine_name = value;
            }
        }

        public Frequency get_set_FREEQUENCY
        {
            get
            {
                return this.this_freequency;
            }
            set
            {
                this.this_freequency = value;
            }
        }

        public DateTime get_set_DATE_TIME
        {
            get
            {
                return this.date_of_magazine;
            }
            set
            {
                Console.Write("Пишите дату выхода журнала d формате ГГ ММ ДД: ");
                string new_date_of_magazine = Console.ReadLine();
                int[] m = new int[3];
                string[] separatingStrings = { " ", ".", "/", "." };
                string[] words = new_date_of_magazine.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
                m[0] = Convert.ToInt32(words[0]);
                m[1] = Convert.ToInt32(words[1]);
                m[2] = Convert.ToInt32(words[2]);

                int yy = m[0];
                int mm = m[1];
                int dd = m[2];

                this.date_of_magazine = new DateTime(yy, mm, dd);
            }
        }

        public int get_set_NUMBER_OF_MAGAZINES
        {
            get
            {
                return this.number_of_magazines;
            }
            set
            {
                this.number_of_magazines = value;
            }
        }

        public Article[] get_set_ARTICLE
        {
            get
            {
                return articles;
            }
            set
            {
                 articles=value;
            }
        }

        public double get_MIDDLE_RATHING
        {
            get
            {
                double sum = 0;
                for (int i =0; i<articles.Length; i++)
                {
                    sum+= articles[i].rathing;
                }

                return (sum / articles.Length);

            }
        }


        public bool this[Frequency index] //индексатор
        {
            get
            {
                return this_freequency == index;
            }
        }

        public void add_Article(params Article[] articles_new) //добавление экзаменов
        {
            if (articles == null)
            {
                articles = new Article[articles_new.Length];
                articles_new.CopyTo(articles, 0); //типа если еще нет элементов то просто помещаю в наш массив то что надо поместить и все ок 
            }
            else
            {
                Article[] old_articles = new Article[articles.Length]; //создаю временый массив старой длины
                articles.CopyTo(old_articles, 0); //копирую в новый массив старой длины старый заполненый массив

                articles = new Article[old_articles.Length + articles_new.Length]; //создаю массив с бОльшим количеством элементов
                old_articles.CopyTo(articles, 0); //копирую в только что созданый массив массив со старыми элементами
                articles_new.CopyTo(articles, old_articles.Length); //копирую в последний элемент то что мы добавляли
            }
        }


        public override string ToString()
        {
            string articles_string = "";
            if (articles == null)
                articles_string = "Нет статей";
            else
            {
                foreach (Article i in articles)
                {
                    
                    articles_string += "\n------\n"+i.ToString()+"\n------\n";
                    

                }
            }

            return "Название журнала: " + magazine_name + "\n"
                + " Частота выхода: " + this_freequency + "\n"
                + " Дата выхода: " + date_of_magazine + "\n"
                + " Тираж: " + number_of_magazines + "\n" + articles_string ;
        }


        public string toShortString()
        {
            string s = "Название журнала: " + magazine_name + "\n"
                + " Частота выхода: " + this_freequency + "\n"
                + " Дата выхода: " + date_of_magazine + "\n"
                + " Тираж: " + number_of_magazines + "\n" + "Вот рейтинг: "+ get_MIDDLE_RATHING ;

            return s;
        }
    }
}

