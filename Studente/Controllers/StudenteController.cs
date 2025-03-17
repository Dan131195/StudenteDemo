using Microsoft.AspNetCore.Mvc;
using Studente.Models;
using Studente.Services;

namespace Studente.Controllers
{
    public class StudenteController : Controller
    {
        private readonly StudenteService _studenteService;

        public StudenteController(StudenteService studenteService)
        {
            _studenteService = studenteService;
        }

        public async Task<IActionResult> Index()
        {
            var studenti = await _studenteService.GetStudentiAsync();
            return View(studenti);
        }

        public async Task<IActionResult> Dettagli(int id)
        {
            var studente = await _studenteService.GetStudenteByIdAsync(id);
            if (studente == null) return NotFound();
            return PartialView("_Dettagli", studente);
        }

        public async Task<IActionResult> Modifica(int id)
        {
            var studente = await _studenteService.GetStudenteByIdAsync(id);
            if (studente == null) return NotFound();
            return PartialView("_Modifica", studente);
        }

        [HttpPost]
        public async Task<IActionResult> Modifica(Student studente)
        {
            if (ModelState.IsValid)
            {
                await _studenteService.UpdateStudenteAsync(studente);
                return PartialView("_Dettagli", studente);
            }
            return PartialView("_Modifica", studente);
        }
    }
}
