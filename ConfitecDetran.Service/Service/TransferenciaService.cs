using ConfitecDetran.Model.Entities;
using ConfitecDetran.Repository.Repository;
using ConfitecDetran.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfitecDetran.Service.Service
{
    public class TransferenciaService : ITransferenciaService
    {
        private readonly TransferenciaRepository _repository;

        public TransferenciaService()
        {
            _repository = new TransferenciaRepository();
        }

        public string Adicionar(Transferencium transferencium)
        {
            try
            {
                if (ValidarTransferencia(transferencium))
                    return "Preencha corretamente.";

                _repository.Adicionar(transferencium);
                return "Incluido com sucesso.";
            }
            catch
            {
                return "Não foi possivel atender a solicitação.";
            }
        }

        private bool ValidarTransferencia(Transferencium transferencium)
        {
            return transferencium.CodCondutor != 0 && transferencium.CodVeiculo != 0;
        }

        public string Atualizar(Transferencium transferencium)
        {
            try
            {
                if (ValidarTransferencia(transferencium))
                    return "Preencha corretamente.";

                _repository.Atualizar(transferencium);
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

        public Transferencium Get(int codigo) => _repository.Get(codigo);

        public List<Transferencium> Listar(Transferencium transferencium) => _repository.GetAll().Where(x => (transferencium.DataInicio == null || (x.DataFim >= transferencium.DataInicio && x.DataInicio <= transferencium.DataInicio))).ToList();

    }
}
