using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_pagamento_2._0.Model
{
    internal class ClassCalculoFolhha
    {
        public string Cpf { get; set; } 
        public string Nome { get; set;}
        public string HorasTrab {  get; set;}
        public string Periculosidade { get; set;}   
        public double Insalubridade { get; set;}
        public string SalarioBase { get; set; }  
        public double SalarioLiqui { get; set; } 
        public double DescINSS { get; set;}  
        public double DescIRRF { get; set;}  
        public double AddPericulosidade { get; set;}
        public double AddInsalubridade { get; set;}
    }
}
