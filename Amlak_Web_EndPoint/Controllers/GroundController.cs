using Amlak_Web_Domain.DTO;
using Amlak_Web_Domain.Entity.Ground;
using Amlak_Web_Persistence;
using Amlak_Web_Persistence.Services.UnitOfWork;
using Amlak_Web_Persistence.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amlak_Web_EndPoint.Controllers
{
    public class GroundController : Controller
    {
        private IUnitOfWrork dbcontext;
        public GroundController(IUnitOfWrork context)
        {
            dbcontext = context;
        }
        public IActionResult Index()
        {
            var Grounds = (from ground in dbcontext.Ground.Gets()
                           join owner in dbcontext.Owner.Gets()
                           on ground.OwnerID equals owner.ID
                           select new GroundDTO
                           {
                               ID=ground.ID,
                               Owner=owner.FullName,
                               Title=ground.Title,
                               Address=ground.Address,
                               Area=ground.Area,
                               Possition=ground.Possition
                           });
            return View(Grounds);
        }
        public IActionResult Create()
        {
            var Owners = (from owner in dbcontext.Owner.Gets()
                          select new OwnerDTO
                          {
                              ID = owner.ID,
                              Info = owner.FullName
                          }).ToList();
            ViewBag.Owner = new SelectList(Owners, "ID", "Info");

            return View();
        }
        [HttpPost]
        public IActionResult Create(int OwnerID,string Title,int Area,string Address,string Possition)
        {

            Ground ground = new Ground()
            {
                OwnerID=OwnerID,
                Address=Address,
                Title=Title,
                Area=Area,
                InsertDate=DateTime.Now,
                Possition=Possition,
                IsRemoved=false
            };
            dbcontext.Ground.Insert(ground);
            dbcontext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? ID)
        {
            if (ID is null)
            {
                return NotFound();
            }
            var Ground = dbcontext.Ground.Get(c => c.ID == ID);
            var Owners = (from owner in dbcontext.Owner.Gets()
                          select new OwnerDTO
                          {
                              ID = owner.ID,
                              Info = owner.FullName
                          }).ToList();
            ViewBag.Owner = new SelectList(Owners, "ID", "Info");

            return View(Ground);
        }
        [HttpPost]
        public IActionResult Edit(int? ID, [Bind("OwnerID,Title,Area,Address,Possition")] Ground ground)
        {
            if (ModelState.IsValid)
            {
                var Ground = dbcontext.Ground.Get(c => c.ID == ID);
                Ground.Area = ground.Area;
                Ground.Address = ground.Address;
                Ground.OwnerID = ground.OwnerID;
                Ground.Possition = ground.Possition;
                Ground.UpdateTime = DateTime.Now;
                Ground.Title = ground.Title;
                //dbcontext.Ground.Update(Ground);
                dbcontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Delete(int? ID)
        {
            var Ground = dbcontext.Ground.Get(c => c.ID == ID);
            dbcontext.Ground.Delete(Ground);
            dbcontext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
