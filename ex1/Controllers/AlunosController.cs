using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex1.Data;
using Microsoft.AspNetCore.Mvc;

namespace ex1.Controllers
{
    
    [ApiController]
    [Route("api/alunos")]
    public class AlunosController:ControllerBase
    {

        private readonly ApplicationDBContext _context;
        
        public AlunosController(ApplicationDBContext context)
        {   
            //infos da bd
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var alunos = _context.Alunos.ToList();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.Find(id);
            if(aluno == null)
            {
                return NotFound();
            }
            return Ok(aluno);
        }
    }
}