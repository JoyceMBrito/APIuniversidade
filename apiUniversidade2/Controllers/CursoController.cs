using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade2.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiUniversidade2.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
      
       [HttpGet]
       public ActionResult <IEnumereble <Curso>> Get()
       {
        var cursos = _context.Curso.ToList();
        if (cursos is null)
           return NotFound();

           return cursos;
       }

        private readonly ILogger<CursoController>_logger;

        private readonly ApiUniversidadeContext _context;

        public CursoController(ILogger <Controllers> logger,ApiUniversidadeCintext)
        {
                _logger = logger;
                _context= _context;

        }

        [httpGet]
        public ActionResult<IEnumerable<Cuso>> Get()
        {
                var cursos = _context.Curso.ToList();
                if (cursos is null)
                   return NotFound();
                
                return cursos;
        }
    }

