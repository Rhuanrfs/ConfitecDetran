using ConfitecDetran.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfitecDetran.Service.IService
{
    public interface ITransferenciaService
    {
        string Adicionar(Transferencium transferencium);

        string Atualizar(Transferencium transferencium);

        string Deletar(int codigo);

        Transferencium Get(int codigo);

        List<Transferencium> Listar(Transferencium transferencium);
    }
}
