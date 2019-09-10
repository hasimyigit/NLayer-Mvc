using Katmanli.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katmanli.DTO;
using Katmanli.REP;

namespace Katmanli.BL
{
   public class Repository
    {
        public class CategoriesRep : BaseRepository<Categories>
        {
        }
        public class ProductsRep : BaseRepository<Products>
        {
            // Product'tan ProductDTO atılan özel bir liste
            public List<ProductsDTO> UrunDoldur()
            {
                return GenelListe().Select(x => new ProductsDTO
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    CategoryName = x.Categories.CategoryName,
                    CompanyName = x.Suppliers.CompanyName,
                    UnitPrice = (decimal)x.UnitPrice,
                    QuantityPerUnit = x.QuantityPerUnit

                }).ToList();

            }



        }
        public class SuppliersRep : BaseRepository<Suppliers>
        {

        }
        public class CustomersRep : BaseRepository<Customers>
        {
        }
        public class OrdersRep : BaseRepository<Orders>
        {
        }
        public class OrdersDetailsRep : BaseRepository<Order_Details>
        {
        }
        public class ShippersRep : BaseRepository<Shippers>
        {
        }
    }
}
