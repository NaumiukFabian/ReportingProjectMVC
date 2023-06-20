using AutoMapper;
using MediatR;
using SNP.Application.ApplicationUser;
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
        private readonly IUserContext _userContext;
        public GetInstallmentForTodayQueryHandler(IInstallmentRepository installmentRepository, IMapper mapper, IUserContext userContext)
        {
            _installmentRepository = installmentRepository;
            _mapper = mapper;
            _userContext = userContext;
        }

        public async Task<IEnumerable<InstallmentDto>> Handle(GetInstallmentForTodayQuery request, CancellationToken cancellationToken)
        {
            var agreements = await _installmentRepository.GetAgreements(request.DateToShow ?? DateTime.Today);
            var dtos = _mapper.Map<IEnumerable<InstallmentDto>>(agreements);

            foreach (var d in dtos)
            {
                d.User = _installmentRepository.GetUserNameBySignature(d.Signature);
            }

            return dtos;
        }
    }
}
