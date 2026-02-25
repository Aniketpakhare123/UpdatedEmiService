using AutoMapper;
using InterestService.Application.DTO;
using InterestService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestService.Application.Mapping
{
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            CreateMap<EmischeduleResponse, LoanEmiSchedule>().ReverseMap();
        }
    }
}
