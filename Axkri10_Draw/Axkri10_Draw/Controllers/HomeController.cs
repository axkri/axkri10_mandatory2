using Axkri10_Draw.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace Axkri10_Draw.Controllers
{
    public class HomeController : Controller
    {
        string pathString = "~/App_Data/submissions.xml";
        SerialGenerator serialgenerator = new SerialGenerator();
        
        [HttpGet]
        public ActionResult Index()
        {
            serialgenerator.GenerateSerials();
            //serialize the serials... 

            return View();
        }

        [HttpPost]
         public ActionResult Index(SubFormModel submodel)
         {
            

            string firstName = submodel.FirstName;
            string surName = submodel.SurName;
            string email = submodel.Email;
            int phonenumber = submodel.PhoneNumber;
            int birthday = submodel.Birthday;
            int serialNo = submodel.SerialNo;
            
            ViewBag.Demo = submodel;

            string pathToFolder = Server.MapPath(pathString);
         
            XmlSerialization.WriteToXmlFile(submodel, pathToFolder, true);

            return View();
         }

        [HttpGet]
        public ActionResult SubmissionList(SubFormModel submodel)
        {
            ViewBag.Message = "Submission list";

            //ViewBag.Display = submodel;
            string pathToFolder = Server.MapPath(pathString);

            // submodel bliver ikke populated??..
            XmlSerialization.ReadFromXmlFile(submodel, pathToFolder);

            //ViewBag.Display = submodel.FirstName;
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}