using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMVC.Web.Models
{
    public class Deal
    {
        int Id { get; set; }

        string Name { get; set; }

        double Price { get; set; }

        List<Product> Products { get; set; }
    }
}
