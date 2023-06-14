using AutoMapper;
using SNP.Application.Installment;
using SNP.Application.Mapping;
using SNP.Domain.Entities;
using SNP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Application.Services
{
    public class InstallmentService : IInstallmentService
    {
        private readonly IInstallmentRepository _installmentRepository;
        private readonly IMapper _mapper;
        public InstallmentService(IInstallmentRepository installmentRepository, IMapper mapper)
        {
            _installmentRepository = installmentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InstallmentDto>> GetAgreements()
        {
            var agreements = await _installmentRepository.GetAgreements();
            var dtos = _mapper.Map<IEnumerable<InstallmentDto>>(agreements);
            return dtos;
        }

        public async Task<IEnumerable<InstallmentDto>> GetAgreementsByName(string usernname)
        {
            var agreements = await _installmentRepository.GetAgreementsByUser(usernname);
            var dtos = _mapper.Map<IEnumerable<InstallmentDto>>(agreements);
            return dtos;
        }
    }
}
