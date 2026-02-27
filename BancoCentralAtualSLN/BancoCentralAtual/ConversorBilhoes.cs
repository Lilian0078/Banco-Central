using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentralAtual
{
        public class ConversorBilhoes : IConversorGrandeza
        {
            public decimal Converter(decimal valor) => 15750000000 / 1000000000m;
            public string ObterSimbolo() => "Bi";
        }
}
