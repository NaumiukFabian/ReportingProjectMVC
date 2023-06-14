using AutoMapper;
using SNP.Application.Installment;
using SNP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.Mapping
{
    public class InstallmentMappingProfile : Profile
    {
        public InstallmentMappingProfile()
        {
            CreateMap<Agreement, InstallmentDto>()
                .ForMember(dto => dto.Signature, opt => opt.MapFrom(src => src.Case.Signatures))
                .ForMember(dto => dto.User, opt => opt.MapFrom(src => src.Case.User.Name));
        }
    }
}
