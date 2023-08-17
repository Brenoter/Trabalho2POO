using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class AlunoController : Controller
    {
        private static IList<Aluno> alunos = new List<Aluno>()
        {
            new Aluno()
            {
                AlunoID = 1,
                Nome = "Luan",
                Matricula = "212021202120"
            },
            new Aluno()
            {
                AlunoID = 2,
                Nome = "Santana",
                Matricula = "66666666666"
            }
        };
        public IActionResult Index()
        {
            return View(alunos);
        }
    }
}
