//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xpto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdemServico
    {
        public int IDOrdemServico { get; set; }
        public string TituloServico { get; set; }
        public string CNPJCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CPFPrestadorServico { get; set; }
        public string NomePrestadorServico { get; set; }
        public System.DateTime DataExecucao { get; set; }
        public decimal ValorServico { get; set; }
    }
}