
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thechauffeurteam.DAL;
using thechauffeurteam.Models;

namespace thechauffeurteam.Controllers
{
    public class CabOfficeStatusController : Controller
    {
        MyContext db = new MyContext();


        public void postCodeMatch()
        {
            if (Session["cabOfficeuser"] != null)
            {
                int cId = (int)Session["cabOfficeId"];
                var jb = db.jobs.Where(m => m.status == 0).Select(a => a.postcode).ToList();
                var cabpostMatch = db.CoverageAndWaitings.Where(a => a.CabOfficeId == cId).Select(a => a.postCode).ToList();
                var matchJob = jb.Intersect(cabpostMatch);
                ViewBag.matchedjob = matchJob;
                ViewBag.matched = matchJob.ToList();
            }
        }
        // i ma consider deriver as a cab office
        // GET: CabOfficeStatus
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AcceptedJobs()
        {
            if (Session["cabOfficeuser"] != null)
            {
               

                int cId = (int)Session["cabOfficeId"];
                string cabId = Session["cabOfficeId"].ToString();



                //postcode match and counter of upcomming jobs

                var jb = db.jobs.Where(m => m.status == 0).Select(a => a.postcode).ToList();
                var cabpostMatch = db.CoverageAndWaitings.Where(a => a.CabOfficeId == cId).Select(a => a.postCode).ToList();
                var matchJob = jb.Intersect(cabpostMatch);
                ViewBag.matchedjob = matchJob;
                ViewBag.matched = matchJob.ToList();

                int counted = 0;
                var jbs = db.jobs.Where(m => m.status == 0).OrderByDescending(m => m.id).ToList();

                foreach (var match in matchJob.ToList())
                {
                    string mtjb = match;

                    foreach (var data in jbs)
                    {

                        if (mtjb == data.postcode)
                        {
                            counted = counted + 1;

                        }
                    }
                }


                ViewBag.NewJobSum = counted.ToString();




                var j = db.jobs.ToList();
               
                ViewBag.ActiveJobSum = j.Where(M => M.status == 1 && M.DriverId == cabId).Count();
               ViewBag.FinishJobSum = j.Where(M => M.status == 2 && M.DriverId == cabId).Count();
               ViewBag.CancelJobSum = j.Where(M => M.status == 3 && M.DriverId == cabId).Count();


                return View(db.jobs.Where(m => m.status == 1 && m.DriverId == cabId).ToList());
            }

            return RedirectToAction("login");
        }

        public ActionResult ActiveJobs(int id)
        {
            if (Session["cabOfficeuser"] != null)
            {
                //ViewData["txt"] = "Jobs";
                //ViewBag.txt = "Jobs";

                postCodeMatch();

                string cabId =Session["cabOfficeId"].ToString();
                 
                int cId= (int)Session["cabOfficeId"];

                var cabName = db.CabOffices.Where(i => i.Id == cId).Select(n => n.CabOfficeName).SingleOrDefault();

                var getjobdetails = db.jobs.Find(id);
                getjobdetails.status = 1;
                getjobdetails.DriverId = cabId;
                getjobdetails.DriverName = cabName;
                db.Entry(getjobdetails).State = EntityState.Modified;
                db.SaveChanges();
                

                // ViewBag.path = "/admin/ActiveJobs";
                var j = db.jobs.ToList();

                //ViewBag.allJobSum = j.Count();


                


                //postcode match and counter of upcomming jobs

                var jb = db.jobs.Where(m => m.status == 0).Select(a => a.postcode).ToList();
                var cabpostMatch = db.CoverageAndWaitings.Where(a => a.CabOfficeId == cId).Select(a => a.postCode).ToList();
                var matchJob = jb.Intersect(cabpostMatch);
                ViewBag.matchedjob = matchJob;
                ViewBag.matched = matchJob.ToList();

                int counted = 0;
                var jbs = db.jobs.Where(m => m.status == 0).OrderByDescending(m => m.id).ToList();

                foreach (var match in matchJob.ToList())
                {
                    string mtjb = match;

                    foreach (var data in jbs)
                    {

                        if (mtjb == data.postcode)
                        {
                            counted = counted + 1;

                        }
                    }
                }


                ViewBag.NewJobSum = counted.ToString();

                ViewBag.ActiveJobSum = j.Where(M => M.status == 1 && M.DriverId == cabId).Count();
                ViewBag.FinishJobSum = j.Where(M => M.status == 2 && M.DriverId == cabId).Count();
                ViewBag.CancelJobSum = j.Where(M => M.status == 3 && M.DriverId == cabId).Count();

                return View(db.jobs.Where(m => m.status == 1 && m.DriverId==cabId).ToList()); 
            }
            return RedirectToAction("login","Home");


        }


        public ActionResult Completed(int id)
        {
            if (Session["cabOfficeuser"] != null)
            {
                //ViewData["txt"] = "Jobs";
                //ViewBag.txt = "Jobs";


                postCodeMatch();


                string cabId = Session["cabOfficeId"].ToString();

                int cId = (int)Session["cabOfficeId"];

                var cabName = db.CabOffices.Where(i => i.Id == cId).Select(n => n.CabOfficeName).SingleOrDefault();

                var getjobdetails = db.jobs.Find(id);
                getjobdetails.status = 2;
                getjobdetails.DriverId = cabId;
                getjobdetails.DriverName = cabName;
                db.Entry(getjobdetails).State = EntityState.Modified;
                db.SaveChanges();


                // ViewBag.path = "/admin/ActiveJobs";
                var j = db.jobs.ToList();


               

                //postcode match and counter of upcomming jobs

                var jb = db.jobs.Where(m => m.status == 0).Select(a => a.postcode).ToList();
                var cabpostMatch = db.CoverageAndWaitings.Where(a => a.CabOfficeId == cId).Select(a => a.postCode).ToList();
                var matchJob = jb.Intersect(cabpostMatch);
                ViewBag.matchedjob = matchJob;
                ViewBag.matched = matchJob.ToList();

                int counted = 0;
                var jbs = db.jobs.Where(m => m.status == 0).OrderByDescending(m => m.id).ToList();

                foreach (var match in matchJob.ToList())
                {
                    string mtjb = match;

                    foreach (var data in jbs)
                    {

                        if (mtjb == data.postcode)
                        {
                            counted = counted + 1;

                        }
                    }
                }


                ViewBag.NewJobSum = counted.ToString();
                
                ViewBag.ActiveJobSum = j.Where(M => M.status == 1 && M.DriverId == cabId).Count();
                ViewBag.FinishJobSum = j.Where(M => M.status == 2 && M.DriverId == cabId).Count();
                ViewBag.CancelJobSum = j.Where(M => M.status == 3 && M.DriverId == cabId).Count();

                return View(db.jobs.Where(m => m.status == 2 && m.DriverId == cabId).ToList());
            }
            return RedirectToAction("login");
        }


        public ActionResult completedJobs()
        {
            if (Session["cabOfficeuser"] != null)
            {
                postCodeMatch();

                int cId = (int)Session["cabOfficeId"];
                string cabId = Session["cabOfficeId"].ToString();

               

                //postcode match and counter of upcomming jobs

                var jb = db.jobs.Where(m => m.status == 0).Select(a => a.postcode).ToList();
                var cabpostMatch = db.CoverageAndWaitings.Where(a => a.CabOfficeId == cId).Select(a => a.postCode).ToList();
                var matchJob = jb.Intersect(cabpostMatch);
                ViewBag.matchedjob = matchJob;
                ViewBag.matched = matchJob.ToList();

                int counted = 0;
                var jbs = db.jobs.Where(m => m.status == 0).OrderByDescending(m => m.id).ToList();

                foreach (var match in matchJob.ToList())
                {
                    string mtjb = match;

                    foreach (var data in jbs)
                    {

                        if (mtjb == data.postcode)
                        {
                            counted = counted + 1;

                        }
                    }
                }


                ViewBag.NewJobSum = counted.ToString();
               var j = db.jobs.ToList();
                 ViewBag.ActiveJobSum = j.Where(M => M.status == 1 && M.DriverId == cabId).Count();
                ViewBag.FinishJobSum = j.Where(M => M.status == 2 && M.DriverId == cabId).Count();
                ViewBag.CancelJobSum = j.Where(M => M.status == 3 && M.DriverId == cabId).Count();


                return View(db.jobs.Where(m => m.status == 2 && m.DriverId == cabId).ToList());
            }

            return RedirectToAction("login");
        }





        public JsonResult JobInfo(int id)
        {
            
            var job = db.jobs.Where(m => m.id == id).SingleOrDefault();
            var passenger = db.Passengers.Where(m => m.Id == job.PassengerId).SingleOrDefault();
            var drv = db.CabOffices.Where(m => m.Status == "Approved").ToList();

           
            var date = job.dateAndTime.Substring(11);
            var time = job.dateAndTime.Substring(0, 10);

            return Json(new { jb = job, pass = passenger, drivers = drv, dt = "" + date, tm = "" + time });

          
        }
    }
}