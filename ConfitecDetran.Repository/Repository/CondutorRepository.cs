using ConfitecDetran.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfitecDetran.Repository.Repository
{
    public class CondutorRepository
    {
        private readonly Confitec_DetranContext context;

        public CondutorRepository()
        {
            context = new Confitec_DetranContext();
        }

        public Condutor Get(int codigo) => context.Condutors.FirstOrDefault<Condutor>(u => u.CodCondutor == codigo);

        public IQueryable<Condutor> GetAll() => context.Condutors;

        public void Adicionar(Condutor condutor)
        {
            context.Add(condutor);
            context.SaveChanges();
        }

        public void Atualizar(Condutor condutor)
        {
            Condutor editar = Get(condutor.CodCondutor);
            if (editar != null)
            {
                context.Update(condutor);
                context.SaveChanges();
            }
            else
                throw new Exception("Registro não encontrado");
        }

        public void Deletar(int codigo) => context.Remove<Condutor>(Get(codigo));

    }
}
