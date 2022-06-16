using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CQRSRegular.Domain.Seed;
using CQRSRegular.Application.Command;
using System.Threading.Tasks;
using CQRSRegular.Application.Interfaces.Queries;

namespace CQRSRegular.WebMVC.Controllers
{
    public class OportunidadeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IOportunidadeQuery _oportunidadeQuery;

        public OportunidadeController(IMediator mediator,
            IOportunidadeQuery oportunidadeQuery)
        {
            _mediator = mediator;
            _oportunidadeQuery = oportunidadeQuery;
        }

        public ActionResult Index()
        {
            return View(_oportunidadeQuery.ObterOportunidades());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CadastrarOportunidadeCommand command)
        {
            bool commandResult = false;

            try
            {
                commandResult = await _mediator.SendCommand(command);

                if (!commandResult)
                {
                    return BadRequest();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
