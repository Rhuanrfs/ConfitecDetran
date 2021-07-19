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
    public class TransferenciasController : ControllerBase
    {
        private readonly ITransferenciaService _service;

        public TransferenciasController(ITransferenciaService transferencium)
        {
            _service = transferencium;
        }

        [HttpPost("Editar")]
        public string Editar([FromBody] Transferencium transferencium)
        {
            return _service.Atualizar(transferencium);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Transferencium transferencium)
        {
            return _service.Adicionar(transferencium);
        }

        [HttpGet("{codigo}")]
        public Transferencium Get(int codigo)
        {
            return _service.Get(codigo);
        }

        [HttpPost("Listar")]
        public List<Transferencium> Listar([FromBody] Transferencium buscar)
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
