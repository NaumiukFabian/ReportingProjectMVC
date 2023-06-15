using MediatR;
using Microsoft.AspNetCore.Mvc;
using SNP.Application.Installment.Queries.GetInstallmentForToday;
using SNP.Application.Installment.Queries.GetInstallmentForTodayByName;
using SNP.Domain.Interfaces;

namespace SNP.Controllers
{
    public class InstallmentController : Controller
    {
        private readonly IMediator _mediator;
        public InstallmentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> GetInstallmentForToday()
        {
            var installments = await _mediator.Send(new GetInstallmentForTodayQuery());
            return View(installments);
        }

        [Route("/Installment/GetInstallmentForTodayByName/{username}")]
        public async Task<IActionResult> GetInstallmentForTodayByName(string username)
        {
            var installments = await _mediator.Send(new GetInstallmentForTodayByNameQuery() { UserName = username });
            return View(installments);
        }
    }
}
