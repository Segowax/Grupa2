using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class Rezerwacje
    {
        public int ID { get; set; }
        public int nr_stolika { get; set; }
        public DateTime data_rez { get; set; }
        public int liczba_osob {  get; set; }
        public TextWriter telefon {  get; set; } 
    }
}
