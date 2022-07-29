﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AdSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdSkill(Skill skill)
        {
            skillManager.Tadd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult Deleteskill(int id)
        {
            var values=skillManager.TGetByID(id); 
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values=skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
           skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }

    }
}
