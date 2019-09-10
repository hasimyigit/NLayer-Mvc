using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Katmanli.BL.Repository;

namespace Katmanli.Web.UI.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        ProductsRep prep = new ProductsRep();
        public ActionResult Liste()
        {
           

            return View(prep.UrunDoldur());
        }
    }
}