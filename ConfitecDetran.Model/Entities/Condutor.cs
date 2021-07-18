using System;
using System.Collections.Generic;

#nullable disable

namespace ConfitecDetran.Model.Entities
{
    public partial class Condutor
    {
        public Condutor()
        {
            Transferencia = new HashSet<Transferencium>();
        }

        public int CodCondutor { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cnh { get; set; }
        public DateTime DataNascimento { get; set; }

        public virtual ICollection<Transferencium> Transferencia { get; set; }
    }
}
