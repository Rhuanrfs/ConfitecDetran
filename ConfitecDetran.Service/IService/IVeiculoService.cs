using ConfitecDetran.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfitecDetran.Service.IService
{
    public interface IVeiculoService
    {
        string Adicionar(Veiculo veiculo);

        string Atualizar(Veiculo veiculo);

        string Deletar(int codigo);

        Veiculo Get(int codigo);

        List<Veiculo> Listar(Veiculo veiculo);
    }
}
