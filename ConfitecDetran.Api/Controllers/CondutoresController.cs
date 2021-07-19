using ConfitecDetran.Model.Entities;
using ConfitecDetran.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfitecDetran.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondutoresController : ControllerBase
    {
        private readonly ICondutorService _service;

        public CondutoresController(ICondutorService condutor)
        {
            _service = condutor;
        }

        [HttpPost("Editar")]
        public string Editar([FromBody] Condutor condutor)
        {
            return _service.Atualizar(condutor);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Condutor condutor)
        {
            return _service.Adicionar(condutor);
        }

        [HttpGet("{codigo}")]
        public Condutor Get(int codigo)
        {
            return _service.Get(codigo);
        }

        [HttpPost("Listar")]
        public List<Condutor> Listar([FromBody] Condutor buscar)
        {
            return _service.Listar(buscar);
        }

        [HttpPost("Remover")]
        public string Remover([FromBody] int codigo)
        {
            return _service.Deletar(codigo);
        }
    }
}
