using ConfitecDetran.Model.Entities;
using ConfitecDetran.Repository.Repository;
using ConfitecDetran.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfitecDetran.Service.Service
{
    public class CondutorService : ICondutorService
    {
        private readonly CondutorRepository _repository;

        public CondutorService()
        {
            _repository = new CondutorRepository();
        }

        public string Adicionar(Condutor condutor)
        {
            try
            {
                if (ValidarCondutor(condutor))
                    return "Preencha corretamente.";

                _repository.Adicionar(condutor);
                return "Incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        private bool ValidarCondutor(Condutor condutor)
        {
            return string.IsNullOrWhiteSpace(condutor.Nome);
        }

        public string Atualizar(Condutor condutor)
        {
            try
            {
                if (ValidarCondutor(condutor))
                    return "Preencha corretamente.";

                _repository.Atualizar(condutor);
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

        public Condutor Get(int codigo) => _repository.Get(codigo);

        public List<Condutor> Listar(Condutor condutor) => _repository.GetAll().Where(x => condutor.Nome == null || x.Nome.Contains(condutor.Nome)).ToList();

    }
}
