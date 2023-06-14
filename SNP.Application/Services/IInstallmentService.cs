using SNP.Application.Installment;
using SNP.Domain.Entities;

namespace SNP.Application.Services
{
    public interface IInstallmentService
    {
        Task<IEnumerable<InstallmentDto>> GetAgreements();
        Task<IEnumerable<InstallmentDto>> GetAgreementsByName(string username);
    }
}