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
    public class PeopleController : Controller
    {
        PersonsBL personsBL = new PersonsBL(new PersonsSqlDAO());
        AwardsBL awardsBL = new AwardsBL(new AwardsSqlDAO());
        public ActionResult Index()
        {
            return View(personsBL.People);
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            List<Award> awardStr = new List<Award>();
            Person p = personsBL.GetPerson(id);
            foreach (Award i in awardsBL.Awards)
            {
                if (p.GetAwards().Find(item => item.ID == i.ID) == null)
                {
                    awardStr.Add(i);
                }

            }

            ViewBag.AwardStr = awardStr;
            return View(p);
        }
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, int[] awardSelected)
        {

            List<Award> awardStr = new List<Award>();
            Person p = personsBL.GetPerson(id);
            foreach (Award i in awardsBL.Awards)
            {
              if(p.GetAwards().Find(item=>item.ID == i.ID)==null)
                {
                    awardStr.Add(i);
                }

            }
           
            ViewBag.AwardStr = awardStr;

            foreach(int i in awardSelected)
            {
                personsBL.AddAwardPerson(awardsBL.GetAward(i), p);
            }
            //  ViewBag. = awardStr;

            try
            {
               
                // p.ID = collection["ID"];
                p.FirstName = collection["FirstName"];
                p.LastName = collection["LastName"];
                p.DateBirth = DateTime.Parse(collection["DateBirth"]);
                personsBL.ReplaceData(p);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                personsBL.DeletePerson(personsBL.People.ToList().Find(item => item.ID == id));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {

            try
            {
                personsBL.AddPerson(new Person(collection["FirstName"], collection["LastName"], DateTime.Parse(collection["DateBirth"])));
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}