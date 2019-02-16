using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using thechauffeurteam.DAL;
using thechauffeurteam.Models;

namespace thechauffeurteam.Controllers
{
    public class JobBookingController : Controller
    {
        private MyContext db = new MyContext();
        


        [HttpPost]
        public ActionResult booking(string jobType, string origin, string postcode_1, string postcode_2, int? hours, string destination, string slectoption, string date, string time
            , string date2, string time2, string selectedcar, int? inMiles, string price, string driverMessage, int? passengerId, string PassengerName, string PassengerPhone)
        {




            if (ModelState.IsValid)
            {


                string PassemgerN;
                string PassengerPhoneNumber;
                string passengerEmail = string.Empty;

                //byte[] logoImg=db.Drivers.Where(a => a.Id == 2).SingleOrDefault().DriverImage;




                job job = new job();
                if (passengerId == null)
                {
                    PassemgerN = PassengerName;
                    PassengerPhoneNumber = PassengerPhone;

                }
                else
                {
                    PassemgerN = db.Passengers.Where(a => a.Id == passengerId).Select(b => b.UserFirstName).SingleOrDefault();
                    PassengerPhoneNumber = db.Passengers.Where(a => a.Id == passengerId).Select(a => a.UserPhNo).SingleOrDefault();
                    passengerEmail = db.Passengers.Where(a => a.Id == passengerId).Select(b => b.UserEmail).SingleOrDefault();
                }


                job.JobType = jobType;
                if (string.IsNullOrEmpty(origin))
                {
                    job.pickUp = postcode_1.ToString();
                    job.DropUP = postcode_2.ToString();


                }

                else
                {
                    job.pickUp = origin;
                    job.DropUP = destination;
                }


                job.Hours = hours;
                job.dateAndTime = time + "\t" + date;
                job.CarType = selectedcar;
                job.Mile = inMiles;
                job.DriverMessage = driverMessage;
                job.Price = price;
                job.PassengerId = passengerId;
                job.PassengerName = PassemgerN;
                job.PassengerPhone = PassengerPhoneNumber;
                job.status = 0;




                //  sending email to admin 
                //MailMessage mm = new MailMessage("thechauffeurteam@gmail.com", "malikaamir966@gmail.com");
                //mm.Subject = "Hi i am testing email";
                //mm.Body = "email context";

                //mm.IsBodyHtml = false;

                //SmtpClient smtp = new SmtpClient();

                //smtp.Host = "smtp.gmail.com";
                //smtp.Port = 587;
                //smtp.EnableSsl = true;
                
                //NetworkCredential nc = new NetworkCredential("thechauffeurteam@gmail.com", "Asdfjkl12345");
                //smtp.UseDefaultCredentials = true;
                //smtp.Credentials = nc;
                //smtp.Send(mm);








                //string Emailbodya = string.Empty;
                //using (StreamReader readera = new StreamReader(Server.MapPath("~/adminlayout.html")))
                //{
                //    Emailbodya = readera.ReadToEnd();
                //}
                //Emailbodya = Emailbodya.Replace("{TimeAndDate}", time + "\t" + date);
                //Emailbodya = Emailbodya.Replace("{from}", origin);
                //Emailbodya = Emailbodya.Replace("{to}", destination);
                //Emailbodya = Emailbodya.Replace("{Miles}", inMiles.ToString());
                //Emailbodya = Emailbodya.Replace("{price}", price.ToString());
                //Emailbodya = Emailbodya.Replace("{phone}", PassemgerN);
                //Emailbodya = Emailbodya.Replace("{name}", PassengerPhoneNumber);




                //MailMessage msga = new MailMessage();
                //msga.From = new MailAddress("thechauffeurteam@gmail.com");
                //msga.To.Add("malikaamir966@gmail.com");
                //msga.Subject = "New Job Booked ";
                //msga.Body = Emailbodya;
                //msga.IsBodyHtml = true;
                //SmtpClient smtpa = new SmtpClient("smtp.gmail.com",587);
                //smtpa.Credentials = new NetworkCredential("thechauffeurteam@gmail.com", "Asdfjkl12345");
                //smtpa.EnableSsl = true;
                //smtpa.Send(msga);
                //smtpa.Dispose();


                /// --------Send email to passenger-----------------

                //string Emailbodyp = string.Empty;
                //using (StreamReader readerp = new StreamReader(Server.MapPath("~/PassengCoformationWithEmail.html")))
                //{
                //    Emailbodyp = readerp.ReadToEnd();
                //}
                //Emailbodyp = Emailbodyp.Replace("{TimeAndDate}", time + "\t" + date);
                //Emailbodyp = Emailbodyp.Replace("{from}", origin);
                //Emailbodyp = Emailbodyp.Replace("{to}", destination);
                //Emailbodyp = Emailbodyp.Replace("{Miles}", inMiles.ToString());
                //Emailbodyp = Emailbodyp.Replace("{price}", price.ToString());
                //Emailbodyp = Emailbodyp.Replace("{phone}", PassengerPhoneNumber);
                //Emailbodyp = Emailbodyp.Replace("{name}", PassemgerN);


                //MailMessage msgp = new MailMessage();
                //msgp.From = new MailAddress("info@heathrowairportminicablondon.com");
                //msgp.To.Add(passengerEmail);
                //msgp.Subject = "Job confirmation  Message of The Heathrow airport cars";
                //msgp.Body = Emailbodyp;
                //msgp.IsBodyHtml = true;
                //SmtpClient smtpp = new SmtpClient("smtpout.europe.secureserver.net", 80);
                //smtpp.Credentials = new NetworkCredential("info@heathrowairportminicablondon.com", "Asdfjkl12345");
                //smtpp.EnableSsl = false;
                //smtpp.Send(msgp);
                //smtpp.Dispose();




                db.jobs.Add(job);
                db.SaveChanges();



                if (slectoption == "return")
                {

                    if (string.IsNullOrEmpty(origin))
                    {
                        job.pickUp = postcode_1;
                        job.DropUP = postcode_2;


                    }

                    else
                    {
                        job.pickUp = origin;
                        job.DropUP = destination;
                    }

                    if (passengerId == null)
                    {
                        PassemgerN = PassengerName;
                        PassengerPhoneNumber = PassengerPhone;

                    }
                    else
                    {
                        PassemgerN = db.Passengers.Where(a => a.Id == passengerId).Select(b => b.UserFirstName).SingleOrDefault();
                        PassengerPhoneNumber = db.Passengers.Where(a => a.Id == passengerId).Select(a => a.UserPhNo).SingleOrDefault();
                    }


                    job job2 = new job();
                    job2.JobType = jobType;
                    if (string.IsNullOrEmpty(origin))
                    {
                        job2.pickUp = postcode_2;
                        job2.DropUP = postcode_1;


                    }

                    else
                    {
                        job2.pickUp = destination;
                        job2.DropUP = origin;
                    }
                    job2.Hours = hours;
                    job2.dateAndTime = time2 + "\t" + date2;
                    job2.CarType = selectedcar;
                    job2.Mile = inMiles;
                    job2.DriverMessage = driverMessage;
                    job2.Price = price;
                    job2.PassengerId = passengerId;
                    job2.status = 0;
                    job2.PassengerName = PassemgerN;
                    job2.PassengerPhone = PassengerPhoneNumber;
                    db.jobs.Add(job2);
                    db.SaveChanges();

                }
                if (Session["adminLog"] != null)
                {
                    return RedirectToAction("index", "admin");
                }

                else
                {
                    return View();
                }



            }

            else
            {
                return null;


            }

        }

    }
}