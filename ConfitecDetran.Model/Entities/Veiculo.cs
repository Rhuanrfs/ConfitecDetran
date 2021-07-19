using System;
using System.Collections.Generic;

#nullable disable

namespace ConfitecDetran.Model.Entities
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            Transferencia = new HashSet<Transferencium>();
        }

        public int CodVeiculo { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }

        public virtual ICollection<Transferencium> Transferencia { get; set; }
    }
}
