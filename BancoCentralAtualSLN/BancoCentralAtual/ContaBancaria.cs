using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentralAtual
{
    internal class ContaBancaria
    {
        public  string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public decimal Saldo { get; private set; }
    }
}
