
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace CustomAPI_V4
{
    public class GoogleClient
    {
        public List<Item> searchApi(string searchitem)
        {
            RestClient client = new RestClient(
                    "https://www.googleapis.com/customsearch/v1?key=AIzaSyC19-EocSwfWeacp7hHZ1L7SQT5ElR4cEg&cx=012558914576125397551:aqn3sajeroi&q=" + searchitem);
            RestRequest request = new RestRequest(Method.GET);

            var json = client.Execute(request).Content;

            var result = JsonConvert.DeserializeObject<Search>(json);
            List<Item> resultList = new List<Item>();
            try
            {
                foreach (var items in result.Items)
                {
                    if (items.Pagemap.Offer != null)
                    {
                        resultList.Add(items);
                    }
                }
                return resultList;
            }
            catch (Exception e)
            {
                Console.WriteLine("No items found in google api.");
                return resultList;
            }
            
        }
    }
}


