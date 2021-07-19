using ConfitecDetran.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfitecDetran.Repository.Repository
{
    public class UsuarioRepository
    {
        private readonly Confitec_DetranContext context;

        public UsuarioRepository()
        {
            context = new Confitec_DetranContext();
        }

        public Usuario Get(int codigo) => context.Usuarios.FirstOrDefault<Usuario>(u => u.CodUsuario == codigo);

        public IQueryable<Usuario> GetAll() => context.Usuarios;

        public void Adicionar(Usuario usuario)
        {
            context.Add(usuario);
            context.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            Usuario editar = Get(usuario.CodUsuario);
            if (editar != null)
            {
                context.Update(usuario);
                context.SaveChanges();
            }
            else
                throw new Exception("Registro não encontrado");
        }

        public void Deletar(int codigo) => context.Remove<Usuario>(Get(codigo));

    }
}
