using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Main_Health_Partner
{

    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RESTClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RESTClient()
        {
            endPoint = "";
            httpMethod = httpVerb.GET;
        }

        public Food[] makeFoodRequest()
        {

            var jFood = JsonConvert.DeserializeObject<dynamic>(getResponse(this.endPoint));
            Food[] foodarray = new Food[10];


            for (int i = 0; i < 10; i++)
            {
                foodarray[i] = new Food((string)jFood.products[i].title, (int)jFood.products[i].id, getImage((String)jFood.products[i].image));
            }
            return foodarray;
        }




        public Nutrients makeNutrientsRequest()
        {

            var jNutrients = JsonConvert.DeserializeObject<dynamic>(getResponse(this.endPoint));

            Dictionary<String, String> dict = new Dictionary<String, String>();

            //for (int i = 0; i <= 22; i++)
            //{
            //  dict.Add((String)jNutrients.calories, (int)jNutrients.calories.value);
            //}

            dict.Add("calories", (String)jNutrients.nutrition.calories);
            dict.Add("fat", (String)jNutrients.nutrition.fat);
            dict.Add("protein", (String)jNutrients.nutrition.protein);
            dict.Add("carbs", (String)jNutrients.nutrition.carbs);


            Nutrients foodNutrient = new Nutrients((int)jNutrients.id, dict);

            return foodNutrient;

        }



        public Dictionary<int, WeekMeal> makeMealRequest()
        {
            var jMeal = JsonConvert.DeserializeObject<dynamic>(getResponse(this.endPoint));

            Dictionary<int, WeekMeal> weeklyPlan = new Dictionary<int, WeekMeal>();

            for (int i = 0; i < 21; i++)
            {
                var food = (String)jMeal.items[i].value;
                String meal = (String)food;


                String id = getIdFromPlan(meal);
                String title = getTitleFromPlan(meal);
                weeklyPlan.Add(i, new WeekMeal((int)jMeal.items[i].day, id, title));
                WeekMeal myMeal = new WeekMeal((int)jMeal.items[i].day, id, title);
                myMeal.ToString();
            }

            return weeklyPlan;

        }

        public RecipeInfo makeRecipeInformationRequest()
        {
            var jRecipe = JsonConvert.DeserializeObject<dynamic>(getResponse(this.endPoint));

            List<String> ingredients = new List<String>();
            String Steps = (String)jRecipe.instructions;
            int i = 0;


            do
            {
                ingredients.Add((String)jRecipe.extendedIngredients[i].name);
                i++;
                try
                {
                    String nextOne = (String)jRecipe.extendedIngredients[i].name;
                }
                catch
                {
                    break;
                }
            } while (i >= 0);


            return new RecipeInfo(ingredients, Steps);

        }


        //Returns an image from a webpage
        public System.Drawing.Image getImage(String url)
        {

            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

            return img;
        }


        //makes the webrequest and returns the response as a String
        public String getResponse(String endpoint)
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);

            request.Method = httpMethod.ToString();
            request.Headers.Add("X-Mashape-Key", "zziIR5RRzImshohyrTsYRJHjOHZ6p1IXX96jsnak6eUWFWfoi5");
            request.Headers.Add("X-Mashape-Host", "spoonacular-recipe-food-nutrition-v1.p.mashape.com");
            HttpWebResponse response = null;


            response = (HttpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                if (responseStream != null)
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        strResponseValue = reader.ReadToEnd();
                    }
                }
            }

            if (response != null)
            {
                ((IDisposable)response).Dispose();
            }

            return strResponseValue;
        }


        //Utility functions
        private String getIdFromPlan(String s)
        {
            char[] arrayId = new char[6];
            int k = 0;
            for (int i = 6; i < s.Length; i++)
            {

                if (s[i] == ',')
                    break;

                arrayId[i - 6] = s[i];

            }

            for (int i = 0; i < arrayId.Length; i++)
            {
                if (arrayId[i] == '\0')
                {
                    k = i;
                    break;
                }
                else
                {
                    k = i + 1;
                }
            }

            char[] FinalId = new char[k];

            for (int i = 0; i < FinalId.Length; i++)
            {
                FinalId[i] = arrayId[i];
            }


            String stringId = new string(FinalId);
            return stringId;
        }

        private String getTitleFromPlan(String s)
        {
            char[] arrayTitle = new char[80];
            int j = 0;
            int k = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ':')
                {
                    j = j + 1;
                }


                if (s[i] == ':' && j == 3)
                    do
                    {
                        arrayTitle[k] = s[i + k + 2];
                        k++;

                    } while (s[i + k + 2] != '\"');
                if (k > 0)
                    break;
            }

            for (int i = 0; i < arrayTitle.Length; i++)
            {
                if (arrayTitle[i] == '\0')
                {
                    k = i;
                    break;
                }
            }

            char[] FinalTitle = new char[k];

            for (int i = 0; i < FinalTitle.Length; i++)
            {
                FinalTitle[i] = arrayTitle[i];
            }


            String Title = new String(FinalTitle);

            return Title;
        }

    }


}
