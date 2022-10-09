using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_Practice
{
    class Person
    {
        public string name;
        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "You have to put a name");
            }
            else
            {
                this.name = name;
            }
            
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string toString()
        {
            string pers = "Name : " + this.name;
            return pers;
        }
        ~Person()
        {
            name = String.Empty;
        }
    }
}
