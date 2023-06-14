using Microsoft.AspNetCore.Mvc;
using SNP.Application.Services;
using SNP.Domain.Interfaces;

namespace SNP.Controllers
{
    public class InstallmentController : Controller
    {
        private readonly IInstallmentService _innstallmentService;
        public InstallmentController(IInstallmentService installmentService)
        {
            _innstallmentService = installmentService;
        }
        public async Task<IActionResult> GetInstallmentForToday()
        {
            var installments = await _innstallmentService.GetAgreements();
            return View(installments);
        }

        [Route("/Installment/GetInstallmentForTodayByName/{username}")]
        public async Task<IActionResult> GetInstallmentForTodayByName(string username)
        {
            var installments = await _innstallmentService.GetAgreementsByName(username);
            return View(installments);
        }
    }
}
