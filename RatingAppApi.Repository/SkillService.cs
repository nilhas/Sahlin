using System;
using System.Collections.Generic;
using RatingAppApi.Data.Entities;
using RatingAppApi.Business.Models;
using RatingAppApi.Data.Repositories;
using AutoMapper;

namespace RatingAppApi.Business.Services
{
    public class SkillService : ISkillService
    {
        private ISkillRepository _repository;

        public ISkillRepository Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new SkillRepository();
                }
                return _repository;
            }
        }

        public void AddSkill(SkillDTO skilldto)
        {
           
            Repository.AddSkill(Mapper.Map<Skill>(skilldto));
        }

        public void DeleteSkillById(int id)
        {
            Repository.DeleteSkillById(id);
        }

        public Skill GetSkillById(int id)
        {
            return Repository.GetSkillById(id);
        }

        public List<Skill> GetAllSkills()
        {
            return Repository.GetAllSkills();
        }

       
    }
}
