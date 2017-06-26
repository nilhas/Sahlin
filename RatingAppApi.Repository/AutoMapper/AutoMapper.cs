using AutoMapper;
using RatingAppApi.Business.Models;
using RatingAppApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppApi.Business.AutoMapper
{
    public class AutoMapper
    {
        public static void InitializeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Skill, SkillDTO>();
                cfg.CreateMap<SkillDTO, Skill>();
            });
        }
    }
}

