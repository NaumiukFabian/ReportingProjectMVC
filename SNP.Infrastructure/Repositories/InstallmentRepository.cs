using Microsoft.EntityFrameworkCore;
using SNP.Domain.Entities;
using SNP.Domain.Interfaces;
using SNP.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNP.Infrastructure.Repositories
{
    public class InstallmentRepository : IInstallmentRepository
    {
        private readonly NewB2cContext _dbContext;
        public InstallmentRepository(NewB2cContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Agreement>> GetAgreements(DateTime dayToShow)
        {
            var agreements = await _dbContext.Agreements
                .Join(_dbContext.Cases, agr => agr.CaseId, cs => cs.Id, (agr, cs) => new { Agreement = agr, Case = cs })
                .Where(a => a.Agreement.Date == dayToShow && a.Agreement.Case.StateId != 8 && a.Agreement.Case.StateId != 5)
                .Select(y=> new Agreement
                {
                    Case = y.Case,
                    Date = y.Agreement.Date,
                    Id = y.Agreement.Id,
                    Ammount = y.Agreement.Ammount,
                    CaseId = y.Agreement.CaseId,
                    EventsOfAgrements = y.Agreement.EventsOfAgrements
                })
                .ToListAsync();

            return agreements;
        }

        public async Task<IEnumerable<Agreement>> GetAgreementsByUser(string user)
        {
            var agreements = await _dbContext.Agreements
                .Join(_dbContext.Cases, agr => agr.CaseId, cs => cs.Id, (agr, cs) => new { Agreement = agr, Case = cs })
                .Where(a => a.Agreement.Date == DateTime.Today && a.Case.User.Name == user)
                .Select(y => new Agreement
                {
                    Case = y.Case,
                    Date = y.Agreement.Date,
                    Id = y.Agreement.Id,
                    Ammount = y.Agreement.Ammount,
                    CaseId = y.Agreement.CaseId,
                    EventsOfAgrements = y.Agreement.EventsOfAgrements
                })
                .ToListAsync();

            return agreements;
        }

        public string GetUserNameBySignature(string signature) 
        {
            int? userId = _dbContext.Cases.FirstOrDefault(c => c.Signatures == signature).LeadingUserId;

            if (userId == null)
            {
                return "brak prowadzącego";
            }

            string userName = _dbContext.Users.FirstOrDefault(u => u.Id == userId).Name;
            return userName;
        }
    }
}
