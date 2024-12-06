using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.BaseEntity;

namespace WebApp.Domain
{
    public class Ksiazka : Base
    {
        public required string Tytul { get; set; }
        public required string Autor { get; set; }
        public int Kategoria { get; set; }
    }
}
