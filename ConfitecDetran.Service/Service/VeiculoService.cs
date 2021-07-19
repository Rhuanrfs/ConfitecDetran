using ConfitecDetran.Model.Entities;
using ConfitecDetran.Repository.Repository;
using ConfitecDetran.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfitecDetran.Service.Service
{
    public class VeiculoService : IVeiculoService
    {
        private readonly VeiculoRepository _repository;

        public VeiculoService()
        {
            _repository = new VeiculoRepository();
        }

        public string Adicionar(Veiculo veiculo)
        {
            try
            {
                if (ValidarVeiculo(veiculo))
                    return "Preencha corretamente.";

                _repository.Adicionar(veiculo);
                return "Incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        private bool ValidarVeiculo(Veiculo veiculo)
        {
            return string.IsNullOrWhiteSpace(veiculo.Placa);
        }

        public string Atualizar(Veiculo veiculo)
        {
            try
            {
                if (ValidarVeiculo(veiculo))
                    return "Preencha corretamente.";

                _repository.Atualizar(veiculo);
                return "Atualizado com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        public string Deletar(int codigo)
        {
            try
            {
                if (codigo > 0)
                    return "Escolha um registro para a exclusão.";

                _repository.Deletar(codigo);
                return "Atualizado com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        public Veiculo Get(int codigo) => _repository.Get(codigo);

        public List<Veiculo> Listar(Veiculo veiculo) => _repository.GetAll().Where(x => veiculo.Placa == null || x.Placa.Contains(veiculo.Placa)).ToList();

    }
}
