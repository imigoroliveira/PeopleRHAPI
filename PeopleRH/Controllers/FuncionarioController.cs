using System.Collections.Generic;
using System.Linq;
using PeopleRH.Models;
using PeopleRH.Data;
using Microsoft.AspNetCore.Mvc;

namespace PeopleRH.Controllers
{

    [ApiController]
    [Route("funcionarios")]
    public class FuncionarioController : ControllerBase
    {
        private readonly DataContext _context;
        public FuncionarioController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create")]
        public Funcionario Create(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
            return funcionario;
        }
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Funcionarios.ToList());
    }
}