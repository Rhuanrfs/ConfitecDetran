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
    public class VeiculosController : ControllerBase
    {
        private readonly IVeiculoService _service;

        public VeiculosController(IVeiculoService veiculo)
        {
            _service = veiculo;
        }

        [HttpPost("Editar")]
        public string Editar([FromBody] Veiculo veiculo)
        {
            return _service.Atualizar(veiculo);
        }

        [HttpPost("Incluir")]
        public string Incluir([FromBody] Veiculo veiculo)
        {
            return _service.Adicionar(veiculo);
        }

        [HttpGet("{codigo}")]
        public Veiculo Get(int codigo)
        {
            return _service.Get(codigo);
        }

        [HttpPost("Listar")]
        public List<Veiculo> Listar([FromBody] Veiculo buscar)
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
