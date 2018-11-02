using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Health_Partner
{
    class RecipeInfo
    {
        List<String> Names = new List<String>();
        String Steps { get; set; }

        public RecipeInfo(List<String> n, String s)
        {
            Names = n;
            Steps = s;
        }

        public List<String> getIngredients()
        {
            return Names;
        }

        public String getSteps()
        {
            return Steps;
        }

        public void setIngredients(List<String> n)
        {
            Names = n;
        }

        public void setSteps(String s)
        {
            Steps = s;
        }

        public string ToString()
        {
            String s = "Ingredients : ";
            for (int i = 0; i < Names.Count; i++)
            {
                String ingredient = Names[i] + ", ";
                s = s + ingredient;
            }
            return s;
  
        }

    }
}
