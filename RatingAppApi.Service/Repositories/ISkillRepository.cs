using RatingAppApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppApi.Data.Repositories
{
    public interface ISkillRepository
    {
        void AddSkill(Skill skill);
        void DeleteSkillById(int id);
        Skill GetSkillById(int id);
        List<Skill> GetAllSkills();
    }
}
