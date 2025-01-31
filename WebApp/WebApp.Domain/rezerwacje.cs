using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class rezerwacje
    {
        public int id {  get; set; }
        public int nr_stolika { get; set; }
        public DateTime data_rez { get; set; }
        public int liczba_osob {  get; set; }
        public string telefon {  get; set; }

    }
}
