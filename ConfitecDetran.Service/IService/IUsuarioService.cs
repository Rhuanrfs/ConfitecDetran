using ConfitecDetran.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfitecDetran.Service.IService
{
    public interface IUsuarioService
    {
        string Adicionar(Usuario usuario);

        string Atualizar(Usuario usuario);

        string Deletar(int codigo);

        Usuario Get(int codigo);

        List<Usuario> Listar(Usuario usuario);
    }
}
