﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thechauffeurteam.DAL;
using thechauffeurteam.Migrations;
using thechauffeurteam.Models.API;
using thechauffeurteam.Models.ViewModel;

namespace CabsAdmin.Controllers
{
    public class CabOfficeController : Controller
    {
        MyContext db = new MyContext();
        public HttpCookie DriverLog = null;
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
                postCodeMatch();
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
            if (Session["cabOfficeuser"] != null)
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

            return RedirectToAction("Login", "Drivers");
        }


        // cab area 
        public ActionResult Coverage_And_Wating_Time()
        {
            if (Session["cabOfficeuser"] != null)
            {
                postCodeMatch();

                //List<CoverageAndWaiting> CWList = db.CoverageAndWaitings.ToList<CoverageAndWaiting>();
                //return Json(new { data = CWList }, JsonRequestBehavior.AllowGet);
                var cabid = (int)Session["cabOfficeId"];

                var cvlist = db.CoverageAndWaitings.Where(m => m.CabOfficeId == cabid).ToList();

                return View(cvlist);
            }

            return RedirectToAction("Login", "Drivers");
        }

        public JsonResult AddCoverageAndTime(string coverage, int Wating, int cabId)
        {

            CoverageAndWaiting addData = new CoverageAndWaiting();
            addData.postCode = coverage.ToUpper();
            addData.waiting = Wating;
            addData.CabOfficeId = cabId;

            db.CoverageAndWaitings.Add(addData);
            db.SaveChanges();

            var cabid = (int)Session["cabOfficeId"];

            var CW = db.CoverageAndWaitings.Where(a => a.CabOfficeId == cabId).ToList();


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

        public JsonResult EditCW(int id, string postcode, int waitingTime, int cabid)
        {
            CoverageAndWaiting cw = new CoverageAndWaiting();
            cw.id = id;
            cw.postCode = postcode.ToUpper();
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




        [HttpPost]
        public ActionResult Loged(string cabEmail, string cabPassword)
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



                        //HttpCookie cabOfficeuser = new HttpCookie("cabOfficeuser");

                        //cabOfficeuser.Expires = DateTime.Now.AddDays(7);
                        //Response.Cookies.Add(cabOfficeuser);

                        Session["cabOfficeId"] = cb.Id;

                        return RedirectToAction("Dashboard", "CabOffice", new { id = cb.Id });
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
            Session["matched"] = null;
            Session["cabuser"] = null;
            Session["cabuserLastName"] = null;

            Session["cabOfficeuser"] = null;
            Session["cabOfficeId"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Drivers");

        }


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
        //cab office login
        public ActionResult CabOfficeProfile(int id)
        {
            if (Session["cabOfficeuser"] != null)
            {
                postCodeMatch();
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
        public ActionResult Dashboard(int id)
        {
            if (Session["cabOfficeuser"] != null)
            {
                //ViewData["txt"] = "Dashboard";
                //ViewBag.txt = "Dashboard";
                //ViewBag.path = "/admin/index";
                //var job = db.jobs.ToList();



                //postcode match and counter of upcomming jobs

                var jb = db.jobs.Where(m => m.status == 0).Select(a => a.postcode).ToList();
                var cabpostMatch = db.CoverageAndWaitings.Where(a => a.CabOfficeId == id).Select(a => a.postCode).ToList();
                var matchJob = jb.Intersect(cabpostMatch);
                ViewBag.matchedjob = matchJob;

                TempData["match"] = matchJob.ToList();

                ViewBag.matched = matchJob.ToList();

                Session["matched"] = matchJob.ToList();

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


                string cabId = Session["cabOfficeId"].ToString();
                ViewBag.ActiveJobSum = db.jobs.Where(M => M.status == 1 && M.DriverId == cabId).Count();
                ViewBag.FinishJobSum = db.jobs.Where(M => M.status == 2 && M.DriverId == cabId).Count();
                ViewBag.CancelJobSum = db.jobs.Where(M => M.status == 3 && M.DriverId == cabId).Count();

                return View(jbs);

            }
            return RedirectToAction("Login", "Drivers");

        }




        ////////////////admin lyout use below//////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////

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
            return RedirectToAction("login", "Admin");
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
        public ActionResult CabOfficeDetail(CabOffice model, string status, string businessType)
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