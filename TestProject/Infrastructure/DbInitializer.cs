using Microsoft.EntityFrameworkCore;
using xAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xAI.Data;

namespace TestProject.Infrastructure
{
    class xAIInitializer
    {
        public static void Initialize(xAIContext context)
        {
            //[SEEDDBIBINIT]
            //if (context.Customers.Any())
            //{
            //    return;
            //}

            //Seed(context);
        }

        private static void Seed(xAIContext context)
        {

            //[SEEDDB]

//            var Customer = new[]
//            {
//                new Customer { Id = 100, Name = "Customer 1" },
//                new Customer { Id = 2, Name = "Customer 2" },
//                new Customer { Id = 3, Name = "Customer 3" },
//                new Customer { Id = 4, Name = "Customer 4" },
//                new Customer { Id = 5, Name = "Customer 5" },
//                new Customer { Id = 6, Name = "Customer 6" },
//                new Customer { Id = 7, Name = "Customer 7" },                                                                                        new Customer { Id = 1, Name = "Customer 1" },
//                new Customer { Id = 8, Name = "Customer 8" },
//                new Customer { Id = 9, Name = "Customer 9" },
//                new Customer { Id = 10, Name = "Customer 10" },
//                new Customer { Id = 11, Name = "Customer 11" }
//            };

//            context.AddRange(Customer);
//            context.SaveChanges();

//            var Brands = new[]
//{
//                new Brands { brand_id = 100, brand_name = "Brand 1" },
//                new Brands { brand_id = 2, brand_name = "Brand 2" },
//                new Brands { brand_id = 3, brand_name = "Brand 3" },
//                new Brands { brand_id = 4, brand_name = "Brand 4" },
//                new Brands { brand_id = 5, brand_name = "Brand 5" },
//                new Brands { brand_id = 6, brand_name = "Brand 6" },
//                new Brands { brand_id = 7, brand_name = "Customer 7" },
//                new Brands { brand_id = 8, brand_name = "Customer 8" },
//                new Brands { brand_id = 9, brand_name = "Customer 9" },
//                new Brands { brand_id = 10, brand_name = "Customer 10" },
//                new Brands { brand_id = 11, brand_name = "Customer 11" }
//            };

//            context.AddRange(Brands);
//            context.SaveChanges();

        }
    }
}
