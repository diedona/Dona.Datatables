using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dona.Datatables.ViewModels
{
    public class PessoaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DtNascStr { get; set; }
        public string Cargo { get; set; }
    }
}