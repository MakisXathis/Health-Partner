using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Health_Partner
{
    class WeekMeal
    {

        int id { get; set; }
        String title { get; set; }

        public WeekMeal(int i, String name)
        {
            id = i;
            title = name;
        }


        public void setId(int i)
        {
            id = i;
        }

        public void setTitle(String name)
        {
            title = name;
        }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return title;
        }



    }
}
