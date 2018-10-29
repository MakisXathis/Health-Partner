using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Health_Partner
{
    class Recipe
    {

        private int id { get; set; }
        private String name { get; set; }
        private int minutes { get; set; }
        private int servings { get; set; }

        public Recipe(int i, String n, int min, int serv)
        {
            id = i;
            name = n;
            minutes = min;
            servings = serv;
        }

        public void setId(int i)
        {
            id = i;
        }

        public void setName(String n)
        {
            name = n;
        }

        public void setMinutes(int min)
        {
            minutes = min;
        }

        public void setServings(int serv)
        {
            servings = serv;
        }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public int getMinutes()
        {
            return minutes;
        }

        public int getServings()
        {
            return servings;
        }


        public void ToString()
        {
            Console.WriteLine("Id : " + id +
                "\nName : " + name +
                "\nReady in Minutes : " + minutes +
                "\nNumer of Servings : " + servings);
        }
    }
}
