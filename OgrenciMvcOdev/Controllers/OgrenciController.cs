using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OgrenciMvcOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciMvcOdev.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public ActionResult OgrenciEkle()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult OgrenciEkle(FormCollection form)
        //{
        //    var ad = Request.Form["Ad"];
        //    var soyad = Request.Form["Soyd"];
        //    var numara = Convert.ToInt32(Request.Form["Numara"]);



        //    return View();
        //}
       
        [HttpGet]
        public IActionResult OgrenciEkle()
        {
            return View();       
        
        }
        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenciler ogrenci)
        {
            using (OgrencilerContext cont = new OgrencilerContext())
            {
                cont.tblOgrenciler.Add(ogrenci);
                cont.SaveChanges();
            }
            return View();
        }
    }
}
