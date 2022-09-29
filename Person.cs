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
    public class Person
    {
        private string name;   // имя
        private string surename; //фамилия
        private DateTime date_of_birth; //дата рождения

        public Person()
        {
            name = "Undefined name";
            surename = "Undefined surename";
            date_of_birth = new DateTime(2003, 10, 20);
        }
        public Person(string new_name, string new_surename, string new_date_of_birth)
        {
            name = new_name;
            surename = new_surename;
            //date_of_birth = Convert.ToDateTime(new_date_of_birth);

            //фу
            int[] m = new int[3];
            string[] separatingStrings = { " ", ".", "/", "." };
            string[] words = new_date_of_birth.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
            m[0] = Convert.ToInt32(words[0]);
            m[1] = Convert.ToInt32(words[1]);
            m[2] = Convert.ToInt32(words[2]);

            int yy = m[0];
            int mm = m[1];
            int dd = m[2];

            date_of_birth = new DateTime(yy, mm, dd);

        }

        public override string ToString()
        {
            string s = "Имя: " + name + " Фамилия: " + surename + " Дата рождения: " + date_of_birth;
            return s;
        }

        public virtual void ToShortString()
        {
            Console.WriteLine($"Имя: {name}  Фамилия: {surename} ");
        }


        public string get_set_name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string get_set_surename
        {
            get
            {
                return surename;
            }

            set
            {
                surename = value;
            }
        }

        public string get_set_date_of_birth
        {
            get
            {
                return Convert.ToString(date_of_birth);
            }

            set
            {
                date_of_birth = Convert.ToDateTime(value);
            }

        }


    }
}

