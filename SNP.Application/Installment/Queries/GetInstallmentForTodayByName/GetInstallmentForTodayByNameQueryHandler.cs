using AutoMapper;
using MediatR;
using SNP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.Installment.Queries.GetInstallmentForTodayByName
{
    public class GetInstallmentForTodayByNameQueryHandler : IRequestHandler<GetInstallmentForTodayByNameQuery, IEnumerable<InstallmentDto>>
    {
        private readonly IInstallmentRepository _installmentRepository;
        private readonly IMapper _mapper;
        public GetInstallmentForTodayByNameQueryHandler(IInstallmentRepository installmentRepository, IMapper mapper)
        {
            _installmentRepository = installmentRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<InstallmentDto>> Handle(GetInstallmentForTodayByNameQuery request, CancellationToken cancellationToken)
        {
            var agreements = await _installmentRepository.GetAgreementsByUser(request.UserName);
            var dtos = _mapper.Map<IEnumerable<InstallmentDto>>(agreements);
            return dtos;
        }
    }
}
