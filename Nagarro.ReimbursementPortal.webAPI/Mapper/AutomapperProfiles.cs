using AutoMapper;
using Nagarro.ReimbursementPortal.webAPI.DTOs;
using Nagarro.ReimbursementPortal.webAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nagarro.ReimbursementPortal.webAPI.Mapper
{
    public class AutomapperProfiles:Profile
    {
       public AutomapperProfiles()
        {
            CreateMap<ReimType, ReimTypeDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
