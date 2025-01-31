using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class locale
    {
        public int cena;
        public int typ;

        public int id { get; set; }
        public string nazwa { get; set; }
        public string miasto { get; set; }
        public string ulica { get; set; }
        public int numer { get; set; }
    }
}
