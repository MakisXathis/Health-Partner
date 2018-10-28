using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Health_Partner
{
    class WeekMeal
    {

        int day { get; set; }
        String id { get; set; }
        String title { get; set; }

        public WeekMeal(int d, String i, String name)
        {
            day = d;
            id = i;
            title = name;
        }


        public void setId(String i)
        {
            id = i;
        }

        public void setTitle(String name)
        {
            title = name;
        }

        public void setDay(int d)
        {
            day = d;
        }

        public String getId()
        {
            return id;
        }

        public String getName()
        {
            return title;
        }

        public int getDay()
        {
            return day;
        }

        public void ToString()
        {
            Console.WriteLine("Day : " + day +
                "\nId : " + id +
                "\nName : " + title);
        }

    }
}
