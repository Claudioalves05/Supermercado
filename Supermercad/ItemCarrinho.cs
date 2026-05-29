using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercad
{
    public class ItemCarrinho
    {
        public string CodigoProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public decimal Total => Quantidade * Preco;

        public override string ToString()
        {
            return $"{Nome} - {Quantidade} x {Preco:C}";
        }
    }
}