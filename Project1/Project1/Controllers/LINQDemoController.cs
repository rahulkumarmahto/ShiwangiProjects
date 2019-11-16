using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class LINQDemoController : Controller
    {
        public IActionResult Index()
        {
            //var dataSource = new string[] { "Ranchi", "Bokaro", "Jamshedpur", "Hazaribagh", "Ramgarh" };

            ////select what from where where condition
            //var list = (from d in dataSource
            //            //where d.Contains("Ra")
            //            select d).ToList().OrderByDescending(o => o);
            //ViewBag.Data = list;


            //var array = (from d in dataSource
            //             where d.Contains("Ra")
            //             select d).ToArray();

            var dataSource = new int[] { 1, 45, 67, 34, 68, 23, 79, 78 };

            var result = (from d in dataSource
                         select d).Max();

            ViewBag.Data = new List<string>() { result.ToString() };
            return View();
        }
    }
}