using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentralAtual
{
    public class ConversorMilhoes : IConversorGrandeza
    {
        public decimal Converter(decimal valor) => 1250000000000 / 1000000m;
        public string ObterSimbolo() => "Mi";
    }
}
