using ConfitecDetran.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfitecDetran.Service.IService
{
    public interface ICondutorService
    {
        string Adicionar(Condutor condutor);

        string Atualizar(Condutor condutor);

        string Deletar(int codigo);

        Condutor Get(int codigo);

        List<Condutor> Listar(Condutor condutor);
    }
}
