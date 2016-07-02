using GraysPortableWelding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraysPortableWelding.ViewModels
{
    public class ServicesViewModel
    {
        public List<Service> Services { get; set; }

        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (Service service in this.Services)
                {
                    total += service.Price;
                }
                return total;
            }
        }
    }
}