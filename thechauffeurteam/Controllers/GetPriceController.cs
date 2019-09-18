using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thechauffeurteam.DAL;
using thechauffeurteam.Models;

namespace thechauffeurteam.Controllers
{
    public class GetPriceController : Controller
    {
        private MyContext db = new MyContext();
        // GET: FixedPrice
        public ActionResult fixedPrice()
        {
           
            return View();
        }

        public ActionResult chauffeur()
        {

            //if (User.Identity.IsAuthenticated)
            //{
            //    ViewBag.id = db.Passengers.Where(a => a.UserEmail == User.Identity.Name)
            //                  .Select(m => m.Id).SingleOrDefault();
            //}
            return View();
        }
        [HttpPost]
        public JsonResult FixedPickup(string Prefix)
        {

            var PickUppostCodes = db.FixPrices.Where(p => p.PickUp.Contains(Prefix)).Select(x => x.PickUp).ToList();

            var distinct = PickUppostCodes.Distinct();
            //var PickUppostCodes = (from c in db.FixPrices
            //                 where c.PickUp.ToLower().StartsWith(Prefix.ToLower())
            //                 select new { c.PickUp, c.Id });
            return Json(distinct, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult fixedDropOff(string Prefix ,string pickup)
        {

            var DroppostCodes = db.FixPrices.Where(p => p.DropOff.Contains(Prefix));

            var onemorefilter = DroppostCodes.Where(p => p.PickUp == pickup).Select(x => x.DropOff).ToList();
            //var PickUppostCodes = (from c in db.FixPrices
            //var PickUppostCodes = (from c in db.FixPrices
            //                       where c.DropOff.ToLower().StartsWith(Prefix.ToLower())
            //                       select new { c.DropOff, c.Id });
            return Json(onemorefilter, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult FixedPriceForCar(string p, string d, string c)
        {

            int getIdIndex = (from m in db.FixPrices
                              where m.PickUp == p && m.DropOff == d
                              select m.Id).SingleOrDefault();
            float gotprice=0;
            if (c == "Saloon")
            {
                gotprice = db.FixPrices.Where(a => a.Id == getIdIndex).Select(a => a.Sclass).SingleOrDefault();
               

            }
           else if (c == "Estate")
            {
                gotprice = db.FixPrices.Where(a => a.Id == getIdIndex).Select(a => a.Eclass).SingleOrDefault();


            }

            else
            {
                gotprice = db.FixPrices.Where(a => a.Id == getIdIndex).Select(a => a.Vclass).SingleOrDefault();
            }

            return Json(gotprice, JsonRequestBehavior.AllowGet);
        }


        // getting 

        public JsonResult getChauffeur(int value, string cartype)
        {
            if (!Request.IsAjaxRequest())
            {
                return null;

            }
            else
            {
                int pricerange;


                int lastValue = db.chauffeurPrices.Select(p => p.MileTo).Max();

                if (lastValue > value)
                {
                    pricerange = db.chauffeurPrices.Where(p => p.MileTo >= value)
                                         .Select(p => p.MileTo).Min();
                }

                else
                {
                    pricerange = lastValue;

                }

                int getRangeId = db.chauffeurPrices.Where(p => p.MileTo == pricerange)
                    .Select(p => p.Id).SingleOrDefault();

                string caroptions = cartype;
                float FirsMile = 0;
                float PerMile = 0;

                float totalAmount = 0;

                if (caroptions == "EClass")
                {

                    FirsMile = db.chauffeurPrices.Where(p => p.Id == getRangeId).Select(p => p.EclassFirstMile).SingleOrDefault();
                    PerMile = db.chauffeurPrices.Where(p => p.Id == getRangeId).Select(p => p.EclassPerMile).SingleOrDefault();
                    value = value - 1;
                    totalAmount = (PerMile * value) + FirsMile;

                }
                else if (caroptions == "SClass")
                {

                    FirsMile = db.chauffeurPrices.Where(p => p.Id == getRangeId).Select(p => p.SclassFirstMile).SingleOrDefault();
                    PerMile = db.chauffeurPrices.Where(p => p.Id == getRangeId).Select(p => p.SclassPerMile).SingleOrDefault();
                    value = value - 1;
                    totalAmount = (PerMile * value) + FirsMile;

                }
                else if (caroptions == "VClass")
                {

                    FirsMile = db.chauffeurPrices.Where(p => p.Id == getRangeId).Select(p => p.VclassFirstMile).SingleOrDefault();
                    PerMile = db.chauffeurPrices.Where(p => p.Id == getRangeId).Select(p => p.VclassPerMile).SingleOrDefault();
                    value = value - 1;
                    totalAmount = (PerMile * value) + FirsMile;

                }




                return new JsonResult { Data = new { totalAmount = totalAmount } };
            }
        }
    }
}