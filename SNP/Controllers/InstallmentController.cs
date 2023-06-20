using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SNP.Application.Installment;
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

        [Authorize(Roles = "Administrator,Zarząd")]
        public IActionResult GetView()
        {
            var query = new GetInstallmentForTodayQuery() { DateToShow = DateTime.Today };

            return View(query);
        }

        [Authorize]
        [HttpGet]
        [Route("/Installment/GetInstallmentForToday/{dateToShow}")]
        public async Task<IActionResult> GetInstallmentForToday(string dateToShow)
        {
            var installments = await _mediator.Send(new GetInstallmentForTodayQuery() { DateToShow = Convert.ToDateTime(dateToShow) });
            return PartialView("GetInstallmentForToday",installments);
        }


        [Route("Installment/GetInstallmentForTodayByName/{username}")]
        public async Task<IActionResult> GetInstallmentForTodayByName(string username)
        {
            var installments = await _mediator.Send(new GetInstallmentForTodayByNameQuery() { UserName = username });
            return View(installments);
        }
    }
}
