using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha_de_pagamento_2._0.Model
{
    internal class ClassCalculoFolhha
    {
        public string Cpf { get; set; } 
        public string Nome { get; set;}
        public string HorasTrab {  get; set;}
        public string Periculosidade { get; set;}   
        public string SalarioBase { get; set; }  
        public decimal SalarioLiqui { get; set; } 
        public decimal DescINSS { get; set;}  
        public decimal DescIRRF { get; set;}  
        public decimal AddPericulosidade { get; set;}
        public decimal AddInsalubridade { get; set;}
    }
}
