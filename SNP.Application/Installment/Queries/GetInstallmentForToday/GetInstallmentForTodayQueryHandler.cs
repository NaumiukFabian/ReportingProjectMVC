using AutoMapper;
using MediatR;
using SNP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.Installment.Queries.GetInstallmentForToday
{
    public class GetInstallmentForTodayQueryHandler : IRequestHandler<GetInstallmentForTodayQuery, IEnumerable<InstallmentDto>>
    {
        private readonly IInstallmentRepository _installmentRepository;
        private readonly IMapper _mapper;
        public GetInstallmentForTodayQueryHandler(IInstallmentRepository installmentRepository, IMapper mapper)
        {
            _installmentRepository = installmentRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<InstallmentDto>> Handle(GetInstallmentForTodayQuery request, CancellationToken cancellationToken)
        {
            var agreements = await _installmentRepository.GetAgreements();
            var dtos = _mapper.Map<IEnumerable<InstallmentDto>>(agreements);
            foreach (var d in dtos)
            {
                d.User = _installmentRepository.GetUserNameBySignature(d.Signature);
            }
            return dtos;
        }
    }
}
