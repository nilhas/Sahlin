using RatingAppApi.Business.Models;
using RatingAppApi.Data.Entities;
using System.Collections.Generic;

namespace RatingAppApi.Business.Services
{
    public interface ISkillService
    {
        void AddSkill(SkillDTO skilldto);
        Skill GetSkillById(int id);
        List<Skill> GetAllSkills();
        void DeleteSkillById(int id);
    }
}
