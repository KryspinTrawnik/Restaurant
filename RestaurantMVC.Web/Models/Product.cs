using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Web.Models
{
    public class Product
    {
        int Id { get; set; }

        string Name { get; set; }

        double Price { get; set; }

        string Description { get; set; }

        int Type { get; set; }


    }
}
