using RatingAppApi.Business.Models;
using RatingAppApi.Business.Services;
using System.Web.Http;

namespace RatingAppApi.Controllers
{
    public class RatingController : ApiController
    {
        private ISkillService _service;

        public ISkillService Service
        {
            get
            {
                if (_service == null)
                {
                    _service = new SkillService();
                }
                return _service;
            }
        }

        [Route("api/add/skill")]
        [HttpPost]
        public IHttpActionResult AddSkill(SkillDTO skilldto)
        {
            if (skilldto == null)
            {
                return BadRequest();
            }

            else if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Service.AddSkill(skilldto);
            return Ok("Skill has been saved");
        }

        [Route("api/delete/skill/{id}")]
        [HttpPost]
        public IHttpActionResult DeleteSkill(int id)
        {
            var findId = Service.GetSkillById(id);

            if (findId == null)
            {
                return NotFound();
            }

            Service.DeleteSkillById(id);
            return Ok("Skill has been deleted");
        }

        [Route("api/get/skill/{id}")]
        [HttpGet]
        public IHttpActionResult GetSkillById(int id)
        {
            var skill = Service.GetSkillById(id);

            if(skill == null)
            {
                return NotFound();
            }
            return Ok(skill);
        }

        [Route("api/get/allskills")]
        [HttpGet]
        public IHttpActionResult GetAllSkills()
        {
            var allSkills = Service.GetAllSkills();
            return Ok(allSkills);
        }
    }
}
    
