using RatingAppApi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RatingAppApi.Data.Entities;
using RatingAppApi.Data;

namespace RatingAppApi.Data.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private RatingAppApiDbContext _context;

        public SkillRepository()
        {
            _context = new RatingAppApiDbContext();
        }
        public void AddSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
        }

        public void DeleteSkillById(int id)
        {
            var skillToRemove = _context.Skills.SingleOrDefault(x =>x.Id == id);
            _context.Skills.Remove(skillToRemove);
            _context.SaveChanges();
        }

        public Skill GetSkillById(int id)
        {
            return _context.Skills.SingleOrDefault(x => x.Id == id);
        }

        public List<Skill> GetAllSkills()
        {
            return _context.Skills.Where(x => x.Expertise != null).ToList();
        }
    }
}
