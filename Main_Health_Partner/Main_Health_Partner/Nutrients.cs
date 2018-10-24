using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Health_Partner
{
    class Nutrients
    {

        int id { get; set; }
        Dictionary<String, String> foodNutrients { get; set; }

        public Nutrients(int id, Dictionary<String, String> fn)
        {

            this.id = id;
            foodNutrients = fn;

        }

        public Nutrients()
        {
        }


        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }


        public void setfoodNutrients(Dictionary<String, String> foodNutrients)
        {
            this.foodNutrients = foodNutrients;
        }

        public Dictionary<String, String> getfoodNutrients()
        {
            return foodNutrients;
        }

        public void toString()
        {
            Console.WriteLine("Id : " + id + "\r\n");

            foreach (KeyValuePair<string, String> pair in foodNutrients)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);

            }



        }

    }
}
