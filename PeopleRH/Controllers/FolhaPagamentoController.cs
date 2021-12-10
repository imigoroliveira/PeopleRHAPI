using System.Collections.Generic;
using System.Linq;
using PeopleRH.Models;
using PeopleRH.Data;
using Microsoft.AspNetCore.Mvc;

namespace PeopleRH.Controllers
{

    [ApiController]
    [Route("folhadepagamento")]
    public class FolhaPagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public FolhaPagamentoController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create")]
        public FolhaPagamento Create(FolhaPagamento folhaPagamento)
        {

            _context.FolhaPagamentos.Add(folhaPagamento);
            _context.SaveChanges();
            return folhaPagamento;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.FolhaPagamentos.ToList());



        [HttpGet]
        [Route("findById/{id?}")]
        public IActionResult GetById(int id) => Ok(_context.FolhaPagamentos.Find(id));


        // [HttpDelete]
        //[Route("delete/{id?}")]
        // public FolhaPagamentoController Delete(int id)
        //  {
        // FolhaPagamentoController FolhaPagamentoController = GetById(id);

        //_context.FolhaPagamentos.Remove(FolhaPagamentoController);
        // _context.SaveChanges();

        //     // return FolhaPagamentoController;
        // }
    }
}