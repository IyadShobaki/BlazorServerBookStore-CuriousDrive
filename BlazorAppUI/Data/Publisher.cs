using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppUI.Data
{
    public class Publisher
    {
        public string PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Publisher()
        {

        }

        public Publisher(string publisherId, string publisherName, 
            string city, string state, string country)
        {
            PublisherId = publisherId;
            PublisherName = publisherName;
            City = city;
            State = state;
            Country = country;
        }
    }
}
