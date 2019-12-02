using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Department.BLL;
using Department.DAL;

namespace MVC.Controllers
{
    public class AwardsController : Controller
    {
        // GET: Awards
        AwardsBL awardsBL = new AwardsBL(new AwardsSqlDAO());
        public ActionResult Index()
        {
            return View(awardsBL.Awards);
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View(awardsBL.GetAward(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            try
            {
                awardsBL.DeleteAward(awardsBL.GetAward(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View(awardsBL.GetAward(id));
            }
        }

        public ActionResult Edit(int id)
        {
            return View(awardsBL.GetAward(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Award award = awardsBL.GetAward(id);
            try
            {
                award.Name = collection["Name"];
                award.Description = collection["Description"];

                awardsBL.ReplaceData(award);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(award);
            }
        }
    }
}