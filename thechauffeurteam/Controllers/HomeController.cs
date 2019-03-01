using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using thechauffeurteam.DAL;
using thechauffeurteam.Models.ViewModel;

namespace thechauffeurteam.Controllers
{
    
    public class HomeController : Controller
    {
        private MyContext db = new MyContext();
        public JsonResult CheckValidUser(string email, string password)
        {
            string result = "Fail";

            var DataItem = db.Passengers.Where(x => x.UserEmail == email && x.Password == password).SingleOrDefault();
            if (DataItem != null)
            {
                Session["user"] = DataItem.Id;
                Session["userName"] = DataItem.UserFirstName;
                //  Session["UserName"] = DataItem.UserFirstName.ToString() +"\t"+ DataItem.UserLastName.ToString();
                //  Session["phone"] = DataItem.UserPhNo.ToString();

                result = "Success";
            }
            //return Json(result, JsonRequestBehavior.AllowGet);


            return new JsonResult { Data = new { result = result, sessionId = Session["user"] } };
        }
        public ActionResult Index()
        {
            
            //ViewBag.pickUpPostcode = new SelectList(db.PostCodes.ToList(), "Id", "PostCodeValue");
            //ViewBag.dropOffPostcode = new SelectList(db.PostCodes.ToList(), "Id", "PostCodeValue");

            return View();
        }

        public ActionResult About()
        {


            return View();
        }

        public ActionResult Contact()
        {


            return View();
        }

       
        public ActionResult Services()
        {
            return View();
        }


        public ActionResult Prices()
        {
            return View();
        }

        public ActionResult Fleet()
        {
            return View();
        }
        
        public ActionResult directBooking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBooking(string origin,string destination,string selectedcar, int? inMiles,string duration_text, string price, int? passengerId, string PassengerName, string PassengerPhone)
        {


            jobVM job = new jobVM();

            job.pickUp = origin;
            job.DropUP = destination;
            job.CarType = selectedcar;
            job.Mile = inMiles;
            job.Price = price;
            job.textDurantion = duration_text;


            //ViewBag.pickUpPostcode = new SelectList(db.PostCodes.ToList(), "Id", "PostCodeValue");
            //ViewBag.dropOffPostcode = new SelectList(db.PostCodes.ToList(), "Id", "PostCodeValue");



            //if (Session["user"] == null && Session["Dirveruser"]==null)
            //{

            //    return RedirectToAction("Login", "Drivers");
            //}
            return View(job);
        }


        [HttpPost]
        public ActionResult Booking(string name, string Phone, string email, string cabType, string date, string Time, string PickUp, string DropOff, string passengers, string direction)
        {



            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("malikaamir966@gmail.com");
            msg.To.Add("Contact@justairportcar.com");
            msg.Subject = "Hi new job ! by " + "\t" + name;
            msg.Body = "Passerger Name  \t     " + "\t" + name + "\n" +
                      "Phone Number  \t       " + "\t" + Phone + "\n" +
                       "Email  \t \t  \t       " + "\t" + email + "\n" +
                       "Cab Type   \t \t    " + "\t \t" + cabType + "\n" +
                       "Date   \t\t  \t       " + "\t" + date + "\n" +
                       "Time      \t\t \t      " + "\t" + Time + "\n" +
                       "Pickup Location \t  " + "\t" + PickUp + "\n" +
                       "Drop off location \t    " + "\t" + DropOff + "\n" +
                       "Number of passengers" + "\t \t \t" + passengers + "\n" +
                       "Direction      \t\t     " + "\t" + " \t" + direction;
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("relay-hosting.secureserver.net", 25);
            smtp.Credentials = new NetworkCredential("Contact@justairportcar.com", "Asdfjkl12345");
            smtp.EnableSsl = false;

            smtp.Send(msg);
            smtp.Dispose();


            return View();
        }

        public ActionResult test()
        {
            return View();
        }


        public JsonResult getPrice(int value, string cartype)
        {
            if (!Request.IsAjaxRequest())
            {
                return null;

            }
            else
            {
                int pricerange;


                int lastValue = db.DistancePrices.Select(p => p.MileTo).Max();

                if (lastValue > value)
                {
                    pricerange = db.DistancePrices.Where(p => p.MileTo >= value)
                                         .Select(p => p.MileTo).Min();
                }

                else {
                    pricerange = lastValue;

                }
              

                int getRangeId = db.DistancePrices.Where(p => p.MileTo == pricerange)
                    .Select(p => p.Id).SingleOrDefault();

                string caroptions = cartype;
                float FirsMile = 0;
                float PerMile = 0;

                float totalAmount = 0;

                if (caroptions == "Saloon")
                {

                    FirsMile = db.DistancePrices.Where(p => p.Id == getRangeId).Select(p => p.EclassFirstMile).SingleOrDefault();
                    PerMile = db.DistancePrices.Where(p => p.Id == getRangeId).Select(p => p.EclassPerMile).SingleOrDefault();
                    value = value - 1;
                    totalAmount = (PerMile * value) + FirsMile;

                }
                else if (caroptions == "Estate")
                {

                    FirsMile = db.DistancePrices.Where(p => p.Id == getRangeId).Select(p => p.SclassFirstMile).SingleOrDefault();
                    PerMile = db.DistancePrices.Where(p => p.Id == getRangeId).Select(p => p.SclassPerMile).SingleOrDefault();
                    value = value - 1;
                    totalAmount = (PerMile * value) + FirsMile;

                }
                else if (caroptions == "MPV")
                {

                    FirsMile = db.DistancePrices.Where(p => p.Id == getRangeId).Select(p => p.VclassFirstMile).SingleOrDefault();
                    PerMile =  db.DistancePrices.Where(p => p.Id == getRangeId).Select(p => p.VclassPerMile).SingleOrDefault();
                    value = value - 1;
                    totalAmount = (PerMile * value) + FirsMile;

                }




                return new JsonResult { Data = new { totalAmount = totalAmount } };
            }
        }


    }
}