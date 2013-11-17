using Dona.Datatables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dona.Datatables.DAL
{
    public class FakeDbContext
    {
        public List<Pessoa> Pessoas { get; set; }

        public FakeDbContext()
        {
            this.Pessoas = new List<Pessoa>()
            {
                new Pessoa
                {
                    Id = 1, Cargo = "Programador", DtNasc = new DateTime(1989, 3, 12), Nome = "Aline"
                },
                new Pessoa
                {
                    Id = 2, Cargo = "Programador", DtNasc = new DateTime(1989, 5, 22), Nome = "Luiza"
                },
                new Pessoa
                {
                    Id = 3, Cargo = "Programador", DtNasc = new DateTime(1978, 3, 16), Nome = "Gabriel"
                },
                new Pessoa
                {
                    Id = 4, Cargo = "Programador", DtNasc = new DateTime(1956, 4, 13), Nome = "Alonso"
                },
                new Pessoa
                {
                    Id = 5, Cargo = "Programador", DtNasc = new DateTime(1991, 12, 2), Nome = "Leonardo"
                },
                new Pessoa
                {
                    Id = 6, Cargo = "Web Designer", DtNasc = new DateTime(1987, 3, 12), Nome = "Renato"
                },
                new Pessoa
                {
                    Id = 7, Cargo = "Web Designer", DtNasc = new DateTime(1982, 1, 2), Nome = "Josué"
                },
                new Pessoa
                {
                    Id = 8, Cargo = "Web Designer", DtNasc = new DateTime(1986, 3, 1), Nome = "Emílio"
                },
                new Pessoa
                {
                    Id = 9, Cargo = "Adm. Redes", DtNasc = new DateTime(1982, 8, 12), Nome = "Raul"
                },
                new Pessoa
                {
                    Id = 10, Cargo = "Adm. Redes", DtNasc = new DateTime(1989, 8, 12), Nome = "Lucas"
                },
                new Pessoa
                {
                    Id = 11, Cargo = "Estagiário", DtNasc = new DateTime(1993, 7, 22), Nome = "Juca"
                },
                new Pessoa
                {
                    Id = 12, Cargo = "DBA", DtNasc = new DateTime(1970, 1, 2), Nome = "Marcelo"
                },
                new Pessoa
                {
                    Id = 13, Cargo = "DBA", DtNasc = new DateTime(1956, 4, 18), Nome = "Fabrício"
                },
                new Pessoa
                {
                    Id = 14, Cargo = "DPT", DtNasc = new DateTime(1966, 5, 20), Nome = "Ronney"
                },
                new Pessoa
                {
                    Id = 15, Cargo = "Engenheiro de Software", DtNasc = new DateTime(1795, 1, 10), Nome = "Anderson"
                }
            };
        }
    }
}