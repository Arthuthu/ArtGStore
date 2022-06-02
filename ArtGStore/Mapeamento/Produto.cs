using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGStore.Mapeamento
{
    public class Produto
    {        
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int IDCategoria { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
