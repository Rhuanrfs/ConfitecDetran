using ConfitecDetran.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfitecDetran.Repository.Repository
{
    public class VeiculoRepository
    {
        private readonly Confitec_DetranContext context;

        public VeiculoRepository()
        {
            context = new Confitec_DetranContext();
        }

        public Veiculo Get(int codigo) => context.Veiculos.FirstOrDefault<Veiculo>(u => u.CodVeiculo == codigo);

        public IQueryable<Veiculo> GetAll() => context.Veiculos;

        public void Adicionar(Veiculo Veiculo)
        {
            context.Add(Veiculo);
            context.SaveChanges();
        }

        public void Atualizar(Veiculo Veiculo)
        {
            Veiculo editar = Get(Veiculo.CodVeiculo);
            if (editar != null)
            {
                context.Update(Veiculo);
                context.SaveChanges();
            }
            else
                throw new Exception("Registro não encontrado");
        }

        public void Deletar(int codigo) => context.Remove<Veiculo>(Get(codigo));
    }
}
