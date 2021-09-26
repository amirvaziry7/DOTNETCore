using Amlak_Web_Domain.Entity.Owner;
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
    public class OwnerController : Controller
    {
        private IUnitOfWrork DbContext;
        public OwnerController(IUnitOfWrork DbContext)
        {
           this.DbContext = DbContext;
        }
        public IActionResult Index()
        {
            var Entities = DbContext.Owner.Gets();
            return View(Entities);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string FullName,string Tel,string Address)
        {
            Owner owner = new Owner()
            {
                FullName=FullName,
                Address=Address,
                Tel=Tel,
                InsertDate=DateTime.Now
            };
            DbContext.Owner.Insert(owner);
            DbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? ID)
        {
            var Entity = DbContext.Owner.Get(c=>c.ID==ID);
            return View(Entity);
        }
        [HttpPost]
        public IActionResult Edit(int? ID,[Bind("FullName,Tel,Address")]Owner owner)
        {
            if(ModelState.IsValid)
            {
                var Entity = DbContext.Owner.Get(c => c.ID == ID);
                Entity.UpdateTime = DateTime.Now;
                Entity.FullName = owner.FullName;
                Entity.Address = owner.Address;
                Entity.Tel = owner.Tel;
                DbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? ID)
        {
            if(ID !=null)
            {
                var Entity = DbContext.Owner.Get(c => c.ID == ID);
                DbContext.Owner.Delete(Entity);
                DbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
