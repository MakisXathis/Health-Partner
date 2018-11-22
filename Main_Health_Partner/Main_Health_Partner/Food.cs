using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Health_Partner
{
    class Food
    {

        private string name { get; set; }
        private int id { get; set; }
        private System.Drawing.Image img { get; set; }

        public Food(string n, int i, System.Drawing.Image photo)
        {
            name = n;
            id = i;
            img = photo;

        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public System.Drawing.Image getImg()
        {
            return img;
        }

        public void setImage(System.Drawing.Image photo)
        {
            img = photo;
        }

        //public void GetNutrients()
        //{
        //   makeNutrientsRequest();
        //}




        public String toString()
        {
            String s = "Food id : " + id +
                "\r\n Food name : " + name + "\r\n"; 

            return s;

        }

    }
}
