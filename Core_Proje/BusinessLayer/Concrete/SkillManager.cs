﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Tadd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);    
        }

        public Skill TGetByID(int id)
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
