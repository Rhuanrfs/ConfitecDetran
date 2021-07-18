using System;
using System.Collections.Generic;

#nullable disable

namespace ConfitecDetran.Model.Entities
{
    public partial class Transferencium
    {
        public int CodTransferencia { get; set; }
        public int CodCondutor { get; set; }
        public int CodVeiculo { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        public virtual Condutor CodCondutorNavigation { get; set; }
        public virtual Veiculo CodVeiculoNavigation { get; set; }
    }
}
