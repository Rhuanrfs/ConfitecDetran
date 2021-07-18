using System;
using System.Collections.Generic;

#nullable disable

namespace ConfitecDetran.Model.Entities
{
    public partial class Usuario
    {
        public int CodUsuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
