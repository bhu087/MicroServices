using Newtonsoft.Json;
using PlaceOrder.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PlaceOrder.Repo
{
    public class PlaceOrderRepo : IPlaceOrderRepo
    {
        public async Task<string> PlaceOrder(OrderDetails orderDetails)
        {
            //The data that needs to be sent. Any object works.
            var order = new
            {
                OrderID = 0,
                UserID = orderDetails.UserID,
                Quantity = orderDetails.Quantity,
                TotalAmount = orderDetails.TotalAmount
            };

            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            string json = JsonConvert.SerializeObject(order);

            //Needed to setup the body of the request
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            //The url to post to.
            var url = "http://localhost:56403/Order";
            var client = new HttpClient();

            //Pass in the full URL and the json string content
            var response = await client.PostAsync(url, data);

            //It would be better to make sure this request actually made it through
            string result = await response.Content.ReadAsStringAsync();

            //close out the client
            client.Dispose();

            return result.ToString();
        }
    }
}
