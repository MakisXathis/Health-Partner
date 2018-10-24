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


        //DOES NOT WORK PROPERLY YET
        public Dictionary<int, WeekMeal> makeMealRequest()
        {
            var jMeal = JsonConvert.DeserializeObject<dynamic>(getResponse(this.endPoint));

            Dictionary<int, WeekMeal> weeklyPlan = new Dictionary<int, WeekMeal>();

            for (int i = 0; i < 21; i++)
            {
                var value = JsonConvert.SerializeObject(jMeal.items[i].value);


                var food = JsonConvert.DeserializeObject<dynamic>(value);

                Console.WriteLine((String)food);

                weeklyPlan.Add((int)jMeal.items[i].day, new WeekMeal((int)food.id, (String)food.title));

                Console.WriteLine((String)food.title);
            }

            return weeklyPlan;

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

    }


}
