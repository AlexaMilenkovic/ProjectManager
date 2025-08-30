using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEntityLib
{
    public class Tim
    {
        public int ID { get; set; }
        public Zaposlen TimMenadzer { get; set; }
        public ICollection<Zaposlen> ListaZaposlenih { get; set; } = new List<Zaposlen>();        
                
    }
}