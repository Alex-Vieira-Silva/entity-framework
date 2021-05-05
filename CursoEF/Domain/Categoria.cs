using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Categoria
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public virtual ICollection<Cliente> clientes { get; set; }
    }
}
