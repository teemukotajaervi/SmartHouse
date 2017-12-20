using Newtonsoft.Json;
using SmartHouse.Databse;
using SmartHouse.Models;
using SmartHouse.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartHouse.Controllers
{
    public class LuontiController : Controller
    {
        // GET: Luonti
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sauna()
        {
            return View();
        }
        //POST: Luonti/Create
        [HttpPost]
        public ActionResult CreateSauna()
        {
            string json = Request.InputStream.ReadToEnd();
            SaunaModel inputData = JsonConvert.DeserializeObject<SaunaModel>(json);
            bool success = false;
            string error = "";

            SmartHouseEntities entities = new SmartHouseEntities();
            try
            {
                string koodi = inputData.Koodi;
                string tyyppi = inputData.Tyyppi;
                             
                Sauna newEntry = new Sauna();
                newEntry.Koodi = koodi;
                newEntry.Tyyppi = tyyppi;
               
                entities.Sauna.Add(newEntry);
                entities.SaveChanges();
                success = true;
            }
            catch (Exception ex)
            {
                error = ex.GetType().Name + ": " + ex.Message;
            }
            finally
            {
                entities.Dispose();
            }
            // palautetn JSON-muotoinen tulos kutsujalle.
            var result = new { success = success, error = error };
            return Json(result);

        }
    }
}
