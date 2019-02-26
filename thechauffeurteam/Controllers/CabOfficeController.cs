using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thechauffeurteam.DAL;
using thechauffeurteam.Models.API;
using thechauffeurteam.Models.ViewModel;

namespace CabsAdmin.Controllers
{
    public class CabOfficeController : Controller
    {
        MyContext db = new MyContext();

        // GET: CabOffice
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CabOfficeReg()
        {
            
                return View();
           
               
        }

        [HttpPost]
        public ActionResult CabOfficeReg(CabOfficeVM model, string businessType)
        {

            CabOffice cab = new CabOffice();
            if (ModelState.IsValid)
            {

                
                cab.CabOfficeBusiessType = businessType;
                cab.Status = "Waiting";

                cab.Id = model.Id;
                
                cab.CabofficeOwner = model.CabofficeOwner;
                cab.CabOfficeName = model.CabOfficeName;
                cab.DispachSystemName = model.DispachSystemName;
                cab.CabOfficePhoneNo = model.CabOfficePhoneNo;
                cab.CabOfficeFax = model.CabOfficeFax;
                cab.CabOfficeEmail = model.CabOfficeEmail;
                cab.CabOfficeAddress = model.CabOfficeAddress;
                cab.CabOfficeCity = model.CabOfficeCity;
                cab.CabOfficePostCode = model.CabOfficePostCode;
                cab.CabOfficeBusinessStartDate = model.CabOfficeBusinessStartDate;
                cab.CabOfficeLicenseNumber = model.CabOfficeLicenseNumber;
                cab.CabOfficeBusiessType = businessType;
                cab.AcceptDiractPayment = model.AcceptDiractPayment;
                cab.LikeAccount = model.LikeAccount;
                cab.NumberOfSaloon = model.NumberOfSaloon;
                cab.NumberOfEstate = model.NumberOfEstate;
                cab.NumberOfMPV = model.NumberOfMPV;
                cab.NumberOfOtherVehicle = model.NumberOfOtherVehicle;
                cab.InvAddress = model.InvAddress;
                cab.InvCity = model.InvCity;
                cab.InvPostCode = model.InvPostCode;
                cab.InvPrincipalContact = model.InvPrincipalContact;
                cab.InvPhone = model.InvPhone;
                cab.InvFax = model.InvFax;
                cab.InvEmail = model.InvEmail;


                cab.UserFirstName = model.UserFirstName;
                cab.UserLastName = model.UserLastName;
                cab.UserMobile = model.UserMobile;
                cab.UserEmail = model.UserEmail;
                cab.UserPassword = model.UserPassword;

                cab.RefBusinessName = model.RefBusinessName;
                cab.RefBusinessAddress = model.RefBusinessAddress;
                cab.RefBusinessCity = model.RefBusinessCity;
                cab.RefBusinessPostCode = model.RefBusinessPostCode;
                cab.RefBusinessPhone = model.RefBusinessPhone;
                cab.RefBusinessFax = model.RefBusinessFax;
                cab.RefBusinessEmail = model.RefBusinessEmail;


                db.CabOffices.Add(cab);

                db.SaveChanges();

                return RedirectToAction("submit", "CabOffice");
            }

            return View(model);
        }



        //cab user edit cab office information
         public ActionResult Edit_Profile_information(int id)
        {
            if (Session["cabOfficeuser"] != null)
            {
            CabOffice model = db.CabOffices.SingleOrDefault(m => m.Id == id);


                CabOfficeVM cab = new CabOfficeVM();
                cab.Id = model.Id;
                cab.Status = model.Status;
                cab.CabofficeOwner = model.CabofficeOwner;
                cab.CabOfficeName = model.CabOfficeName;
                cab.DispachSystemName = model.DispachSystemName;
                cab.CabOfficePhoneNo = model.CabOfficePhoneNo;
                cab.CabOfficeFax = model.CabOfficeFax;
                cab.CabOfficeEmail = model.CabOfficeEmail;
                cab.CabOfficeAddress = model.CabOfficeAddress;
                cab.CabOfficeCity = model.CabOfficeCity;
                cab.CabOfficePostCode = model.CabOfficePostCode;
                cab.CabOfficeBusinessStartDate = model.CabOfficeBusinessStartDate;
                cab.CabOfficeLicenseNumber = model.CabOfficeLicenseNumber;
                cab.CabOfficeBusiessType = model.CabOfficeBusiessType;
                cab.AcceptDiractPayment = model.AcceptDiractPayment;
                cab.LikeAccount = model.LikeAccount;
                cab.NumberOfSaloon = model.NumberOfSaloon;
                cab.NumberOfEstate = model.NumberOfEstate;
                cab.NumberOfMPV = model.NumberOfMPV;
                cab.NumberOfOtherVehicle = model.NumberOfOtherVehicle;
                cab.InvAddress = model.InvAddress;
                cab.InvCity = model.InvCity;
                cab.InvPostCode = model.InvPostCode;
                cab.InvPrincipalContact = model.InvPrincipalContact;
                cab.InvPhone = model.InvPhone;
                cab.InvFax = model.InvFax;
                cab.InvEmail = model.InvEmail;
                cab.UserFirstName = model.UserFirstName;
                cab.UserLastName = model.UserLastName;
                cab.UserMobile = model.UserMobile;
                cab.UserEmail = model.UserEmail;
                cab.UserPassword = model.UserPassword;
                cab.confirmPassword = model.UserPassword;
                cab.RefBusinessName = model.RefBusinessName;
                cab.RefBusinessAddress = model.RefBusinessAddress;
                cab.RefBusinessCity = model.RefBusinessCity;
                cab.RefBusinessPostCode = model.RefBusinessPostCode;
                cab.RefBusinessPhone = model.RefBusinessPhone;
                cab.RefBusinessFax = model.RefBusinessFax;
                cab.RefBusinessEmail = model.RefBusinessEmail;


                return View(cab);
            }
        return RedirectToAction("Login", "Drivers");

        }



        [HttpPost]
        public ActionResult Edit_Profile_information(CabOfficeVM model, string businessType)
        {

            CabOffice cab = new CabOffice();
            if (ModelState.IsValid)
            {


                cab.CabOfficeBusiessType = businessType;
                cab.Status = "Approved";

                cab.Id = model.Id;

                cab.CabofficeOwner = model.CabofficeOwner;
                cab.CabOfficeName = model.CabOfficeName;
                cab.DispachSystemName = model.DispachSystemName;
                cab.CabOfficePhoneNo = model.CabOfficePhoneNo;
                cab.CabOfficeFax = model.CabOfficeFax;
                cab.CabOfficeEmail = model.CabOfficeEmail;
                cab.CabOfficeAddress = model.CabOfficeAddress;
                cab.CabOfficeCity = model.CabOfficeCity;
                cab.CabOfficePostCode = model.CabOfficePostCode;
                cab.CabOfficeBusinessStartDate = model.CabOfficeBusinessStartDate;
                cab.CabOfficeLicenseNumber = model.CabOfficeLicenseNumber;
                cab.CabOfficeBusiessType = businessType;
                cab.AcceptDiractPayment = model.AcceptDiractPayment;
                cab.LikeAccount = model.LikeAccount;
                cab.NumberOfSaloon = model.NumberOfSaloon;
                cab.NumberOfEstate = model.NumberOfEstate;
                cab.NumberOfMPV = model.NumberOfMPV;
                cab.NumberOfOtherVehicle = model.NumberOfOtherVehicle;
                cab.InvAddress = model.InvAddress;
                cab.InvCity = model.InvCity;
                cab.InvPostCode = model.InvPostCode;
                cab.InvPrincipalContact = model.InvPrincipalContact;
                cab.InvPhone = model.InvPhone;
                cab.InvFax = model.InvFax;
                cab.InvEmail = model.InvEmail;


                cab.UserFirstName = model.UserFirstName;
                cab.UserLastName = model.UserLastName;
                cab.UserMobile = model.UserMobile;
                cab.UserEmail = model.UserEmail;
                cab.UserPassword = model.UserPassword;

                cab.RefBusinessName = model.RefBusinessName;
                cab.RefBusinessAddress = model.RefBusinessAddress;
                cab.RefBusinessCity = model.RefBusinessCity;
                cab.RefBusinessPostCode = model.RefBusinessPostCode;
                cab.RefBusinessPhone = model.RefBusinessPhone;
                cab.RefBusinessFax = model.RefBusinessFax;
                cab.RefBusinessEmail = model.RefBusinessEmail;


                db.Entry(cab).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Dashboard", "CabOffice");
            }

            return View(model);
        }

        // cab area 
        public ActionResult Coverage_And_Wating_Time()
        {
            //List<CoverageAndWaiting> CWList = db.CoverageAndWaitings.ToList<CoverageAndWaiting>();
            //return Json(new { data = CWList }, JsonRequestBehavior.AllowGet);

            return View(db.CoverageAndWaitings.ToList());
        }

        public JsonResult AddCoverageAndTime(string coverage, int Wating, int cabId)
        {
            
            CoverageAndWaiting addData = new CoverageAndWaiting();
            addData.postCode = coverage;
            addData.waiting = Wating;
            addData.CabOfficeId = cabId;

            db.CoverageAndWaitings.Add(addData);
            db.SaveChanges();

            var CW = db.CoverageAndWaitings.ToList();


            return Json(new { CWlist = CW }, JsonRequestBehavior.AllowGet);
            //return Json(1);
        }


        //delete the coverage and rate
        public JsonResult Delete(int id)
        {
            
                var dl = db.CoverageAndWaitings.Where(x => x.id == id).FirstOrDefault<CoverageAndWaiting>();
                db.CoverageAndWaitings.Remove(dl);
                db.SaveChanges();
              var CW = db.CoverageAndWaitings.ToList();


             return Json(new { CWlist = CW }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult EditCW(int id, string postcode ,int waitingTime, int cabid)
        {
            CoverageAndWaiting cw = new CoverageAndWaiting();
            cw.id = id;
            cw.postCode = postcode;
            cw.waiting = waitingTime;
            cw.CabOfficeId = cabid;

            db.Entry(cw).State = EntityState.Modified;
            db.SaveChanges();
            var CW = db.CoverageAndWaitings.ToList();


            return Json(new { CWlist = CW }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult CheckEmailAvailability(string useremail)
        {
            System.Threading.Thread.Sleep(200);
            var SeachData = db.CabOffices.Where(x => x.UserEmail == useremail).SingleOrDefault();
            if (SeachData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }

        }

        public JsonResult AddGet()
        {

            
                var empList = db.CoverageAndWaitings.ToList();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            
            //return Json(1);
        }
      


        public ActionResult Loged(string cabEmail, string cabPassword)
        {
            if (Session["cabOfficeuser"] == null)
            {
                if (!ModelState.IsValid)
                {
                    return HttpNotFound();
                }
                else
                {
                    //var p = db.CabOffices.Where(a => a.UserEmail == cabEmail && a.UserPassword == cabPassword).SingleOrDefault();

                    var p = db.CabOffices.Where(a => a.UserEmail.Equals(cabEmail) && a.UserPassword.Equals(cabPassword)).FirstOrDefault();
                   


                        if (p != null)
                    {
                        CabOffice cb = db.CabOffices.Where(m => m.Id == p.Id).SingleOrDefault();

                        if (cb.Status == "Approved")
                        {
                            Session["cabuser"] = p.UserFirstName;
                           Session["cabuserLastName"] = p.UserLastName;

                            Session["cabOfficeuser"] = "logedin";
                            Session["cabOfficeId"] = cb.Id;
                            //ID = cb.Id;
                            return RedirectToAction("CabOfficeProfile", "CabOffice", new { id = cb.Id });
                        }
                        if (cb.Status == "Rejected")
                        {
                            return RedirectToAction("Rejected", "CabOffice");
                        }
                        else
                        {
                            return RedirectToAction("submit", "CabOffice");
                        }
                    }
                    else
                    {
                        TempData["DErrormsg"] = "invalid your Email or Password";
                        return RedirectToAction("Login", "Drivers");
                    }


                }
            }
            return RedirectToAction("Login", "Drivers");
        }

        public ActionResult submit()
        {
            return View();
        }

        public ActionResult Rejected()
        {

            return View();

        }
        public ActionResult LogOut()
        {

            Session["cabOfficeuser"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Drivers");

        }

        //cab office login
        public ActionResult CabOfficeProfile(int id)
        {
            if (Session["cabOfficeuser"] != null)
            {
                CabOffice model = db.CabOffices.SingleOrDefault(m => m.Id == id);


                CabOfficeVM cab = new CabOfficeVM();
                cab.Id = model.Id;
                cab.Status = model.Status;
                cab.CabofficeOwner = model.CabofficeOwner;
                cab.CabOfficeName = model.CabOfficeName;
                cab.DispachSystemName = model.DispachSystemName;
                cab.CabOfficePhoneNo = model.CabOfficePhoneNo;
                cab.CabOfficeFax = model.CabOfficeFax;
                cab.CabOfficeEmail = model.CabOfficeEmail;
                cab.CabOfficeAddress = model.CabOfficeAddress;
                cab.CabOfficeCity = model.CabOfficeCity;
                cab.CabOfficePostCode = model.CabOfficePostCode;
                cab.CabOfficeBusinessStartDate = model.CabOfficeBusinessStartDate;
                cab.CabOfficeLicenseNumber = model.CabOfficeLicenseNumber;
                cab.CabOfficeBusiessType = model.CabOfficeBusiessType;
                cab.AcceptDiractPayment = model.AcceptDiractPayment;
                cab.LikeAccount = model.LikeAccount;
                cab.NumberOfSaloon = model.NumberOfSaloon;
                cab.NumberOfEstate = model.NumberOfEstate;
                cab.NumberOfMPV = model.NumberOfMPV;
                cab.NumberOfOtherVehicle = model.NumberOfOtherVehicle;
                cab.InvAddress = model.InvAddress;
                cab.InvCity = model.InvCity;
                cab.InvPostCode = model.InvPostCode;
                cab.InvPrincipalContact = model.InvPrincipalContact;
                cab.InvPhone = model.InvPhone;
                cab.InvFax = model.InvFax;
                cab.InvEmail = model.InvEmail;
                cab.UserFirstName = model.UserFirstName;
                cab.UserLastName = model.UserLastName;
                cab.UserMobile = model.UserMobile;
                cab.UserEmail = model.UserEmail;
                cab.UserPassword = model.UserPassword;
                cab.RefBusinessName = model.RefBusinessName;
                cab.RefBusinessAddress = model.RefBusinessAddress;
                cab.RefBusinessCity = model.RefBusinessCity;
                cab.RefBusinessPostCode = model.RefBusinessPostCode;
                cab.RefBusinessPhone = model.RefBusinessPhone;
                cab.RefBusinessFax = model.RefBusinessFax;
                cab.RefBusinessEmail = model.RefBusinessEmail;


                return View(cab);
         }
           return RedirectToAction("Login", "Drivers");
        }
        //cab office dashborad
        public ActionResult Dashboard()
        {
            if (Session["cabOfficeuser"] != null)
            {
                ViewData["txt"] = "Dashboard";
                ViewBag.txt = "Dashboard";
                //ViewBag.path = "/admin/index";
                //var job = db.jobs.ToList();
                //var jb = job.Where(m => m.status == 0).OrderByDescending(m => m.id).ToList();
                //ViewBag.allJobSum = job.Count();
                //ViewBag.NewJobSum = job.Where(M => M.status == 0).Count();
                //ViewBag.ActiveJobSum = job.Where(M => M.status == 1).Count();
                //ViewBag.FinishJobSum = job.Where(M => M.status == 2).Count();
                //ViewBag.CancelJobSum = job.Where(M => M.status == 3).Count();


                return View();
            }
            return RedirectToAction("login");

        }




        //admin lyout use below

        public ActionResult AllCabOffices()
        {

            if (Session["adminLog"] != null)
            {

                ViewBag.txt = "All Cab Offices";
            //ViewBag.path = "/admin/driver";

            var cab = db.CabOffices.OrderByDescending(a => a.Id).ToList();

            ViewBag.allSum = cab.Count();
            ViewBag.NewSum = cab.Where(M => M.Status == "Waiting").Count();
            ViewBag.ApprovedSum = cab.Where(M => M.Status == "Approved").Count();
            ViewBag.RejectedSum = cab.Where(M => M.Status == "Rejected").Count();
           return View(db.CabOffices.ToList());
            
             } 
           return RedirectToAction("login","Admin");
        }

        public ActionResult CabOfficeDetail(int id)
        {

            if (Session["adminLog"] != null)
            {
                return View(db.CabOffices.SingleOrDefault(m => m.Id == id));
             }
            return RedirectToAction("login", "Admin");
        }
        [HttpPost]
        public ActionResult CabOfficeDetail(CabOffice model , string status, string businessType)
        {

            if (Session["adminLog"] != null)
            {
                if (ModelState.IsValid)
            {
               
                CabOffice cab = new CabOffice();
                cab.Id = model.Id;
                cab.Status = status;
                cab.CabofficeOwner = model.CabofficeOwner;
                cab.CabOfficeName = model.CabOfficeName;
                cab.DispachSystemName = model.DispachSystemName;
                cab.CabOfficePhoneNo = model.CabOfficePhoneNo;
                cab.CabOfficeFax = model.CabOfficeFax;
                cab.CabOfficeEmail = model.CabOfficeEmail;
                cab.CabOfficeAddress = model.CabOfficeAddress;
                cab.CabOfficeCity = model.CabOfficeCity;
                cab.CabOfficePostCode = model.CabOfficePostCode;
                cab.CabOfficeBusinessStartDate = model.CabOfficeBusinessStartDate;
                cab.CabOfficeLicenseNumber = model.CabOfficeLicenseNumber;
                cab.CabOfficeBusiessType = businessType;
                cab.AcceptDiractPayment = model.AcceptDiractPayment;
                cab.LikeAccount = model.LikeAccount;
                cab.NumberOfSaloon = model.NumberOfSaloon;
                cab.NumberOfEstate = model.NumberOfEstate;
                cab.NumberOfMPV = model.NumberOfMPV;
                cab.NumberOfOtherVehicle = model.NumberOfOtherVehicle;
                cab.InvAddress = model.InvAddress;
                cab.InvCity = model.InvCity;
                cab.InvPostCode = model.InvPostCode;
                cab.InvPrincipalContact = model.InvPrincipalContact;
                cab.InvPhone = model.InvPhone;
                cab.InvFax = model.InvFax;
                cab.InvEmail = model.InvEmail;
                cab.UserFirstName = model.UserFirstName;
                cab.UserLastName = model.UserLastName;
                cab.UserMobile = model.UserMobile;
                cab.UserEmail = model.UserEmail;
                cab.UserPassword = model.UserPassword;
               
                cab.RefBusinessName = model.RefBusinessName;
                cab.RefBusinessAddress = model.RefBusinessAddress;
                cab.RefBusinessCity = model.RefBusinessCity;
                cab.RefBusinessPostCode = model.RefBusinessPostCode;
                cab.RefBusinessPhone = model.RefBusinessPhone;
                cab.RefBusinessFax = model.RefBusinessFax;
                cab.RefBusinessEmail = model.RefBusinessEmail;



              
                db.Entry(cab).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("AllCabOffices", "CabOffice");

            }
            else
            {
                return View();
            }
           }

            return RedirectToAction("login", "Admin");
        }

        public ActionResult NewCabOffice()
        {

            if (Session["adminLog"] != null)
            {
                ViewBag.txt = "New Cab Offices";
            //ViewBag.path = "/admin/driver";

            var cab = db.CabOffices.OrderByDescending(a => a.Id).ToList();

            ViewBag.allSum = cab.Count();
            ViewBag.NewSum = cab.Where(M => M.Status == "Waiting").Count();
            ViewBag.ApprovedSum = cab.Where(M => M.Status == "Approved").Count();
            ViewBag.RejectedSum = cab.Where(M => M.Status == "Rejected").Count();

            return View(db.CabOffices.Where(m => m.Status == "Waiting").OrderByDescending(a => a.Id).ToList());
           
        }

            return RedirectToAction("login", "Admin");
        }
        public ActionResult ApprovedCabOffice()
        {

            if (Session["adminLog"] != null)
            {
                ViewBag.txt = "Approved Cab Offices";
            //ViewBag.path = "/admin/driver";

            var cab = db.CabOffices.OrderByDescending(a => a.Id).ToList();

            ViewBag.allSum = cab.Count();
            ViewBag.NewSum = cab.Where(M => M.Status == "Waiting").Count();
            ViewBag.ApprovedSum = cab.Where(M => M.Status == "Approved").Count();
            ViewBag.RejectedSum = cab.Where(M => M.Status == "Rejected").Count();

            return View(db.CabOffices.Where(m => m.Status == "Approved").OrderByDescending(a => a.Id).ToList());

        }

            return RedirectToAction("login", "Admin");
        }

        public ActionResult RejectedCabOffice()
        {

            if (Session["adminLog"] != null)
            {
                ViewBag.txt = "Rejected Cab Offices";
            //ViewBag.path = "/admin/driver";

            var cab = db.CabOffices.OrderByDescending(a => a.Id).ToList();

            ViewBag.allSum = cab.Count();
            ViewBag.NewSum = cab.Where(M => M.Status == "Waiting").Count();
            ViewBag.ApprovedSum = cab.Where(M => M.Status == "Approved").Count();
            ViewBag.RejectedSum = cab.Where(M => M.Status == "Rejected").Count();

            return View(db.CabOffices.Where(m => m.Status == "Rejected").OrderByDescending(a => a.Id).ToList());

        }
            return RedirectToAction("login", "Admin");
        }


    


        }
}