using ConfitecDetran.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfitecDetran.Repository.Repository
{
    public class TransferenciaRepository
    {
        private readonly Confitec_DetranContext context;

        public TransferenciaRepository()
        {
            context = new Confitec_DetranContext();
        }

        public Transferencium Get(int codigo) => context.Transferencia.FirstOrDefault<Transferencium>(u => u.CodTransferencia == codigo);

        public IQueryable<Transferencium> GetAll() => context.Transferencia;

        public void Adicionar(Transferencium Transferencium)
        {
            context.Add(Transferencium);
            context.SaveChanges();
        }

        public void Atualizar(Transferencium Transferencium)
        {
            Transferencium editar = Get(Transferencium.CodTransferencia);
            if (editar != null)
            {
                context.Update(Transferencium);
                context.SaveChanges();
            }
            else
                throw new Exception("Registro não encontrado");
        }

        public void Deletar(int codigo) => context.Remove<Transferencium>(Get(codigo));

    }
}
