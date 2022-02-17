using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserURL_dll
{
    class Epicentr
    {

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        
     
            [JsonProperty("@context")]
            public string Context { get; set; }

            [JsonProperty("@type")]
            public string Type { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public Offers offers { get; set; }
            public Brand brand { get; set; }
            public string model { get; set; }
            public string description { get; set; }


        public class Seller
        {
            [JsonProperty("@type")]
            public string Type { get; set; }
            public string name { get; set; }
        }

        public class Offers
        {
            [JsonProperty("@type")]
            public string Type { get; set; }
            public string priceCurrency { get; set; }
            public string priceValidUntil { get; set; }
            public string url { get; set; }
            public double price { get; set; }
            public string itemCondition { get; set; }
            public Seller seller { get; set; }
            public string availability { get; set; }
        }

        public class Brand
        {
            [JsonProperty("@type")]
            public string Type { get; set; }
            public string name { get; set; }
        }
    }
    

}
