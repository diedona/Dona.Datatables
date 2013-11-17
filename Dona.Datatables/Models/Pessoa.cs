using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dona.Datatables.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cargo { get; set; }
    }
}