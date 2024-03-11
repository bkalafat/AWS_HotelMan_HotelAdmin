using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMan_HotelAdmin.Models
{
    internal class HotelCreatedEvent
    {
        public string UserId { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
        public int Rating { get; set; }
        public string CityName { get; set; }
        public string FileName { get; set; }

        public DateTime CreationDateTime { get; set; }
    }
}
