using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProfessorController : ControllerBase
  {

    public List<Aluno> Alunos = new List<Aluno>(){
      new Aluno() {
        Id = 1,
        Nome = "Marcos",
        Sobrenome = "Almeida",
        Telefone = "23232323"
      },
      new Aluno() {
        Id = 1,
        Nome = "Marta",
        Sobrenome = "Sobral",
        Telefone = "787878788"
      },
      new Aluno() {
        Id = 1,
        Nome = "Laura",
        Sobrenome = "Miller",
        Telefone = "56565656"
      },
    };
    public ProfessorController() { }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(Alunos);
    }

  }
}