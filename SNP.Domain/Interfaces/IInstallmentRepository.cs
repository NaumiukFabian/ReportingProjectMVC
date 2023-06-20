using SNP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Domain.Interfaces
{
    public interface IInstallmentRepository
    {
        Task<IEnumerable<SNP.Domain.Entities.Agreement>> GetAgreements(DateTime dayToShow);
        Task<IEnumerable<SNP.Domain.Entities.Agreement>> GetAgreementsByUser(string user);
        string GetUserNameBySignature(string signature);
    }
}
