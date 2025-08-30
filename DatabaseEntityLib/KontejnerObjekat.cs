// Kontejner objekat definise klasu koja ce predstavljati sva tri kontejner tipa: Projekte, Radne Pakete i Zadatke
// U zavisnosti od tipa kontejnera, kontejner dobija atribute
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace DatabaseEntityLib
{
    public class KontejnerObjekat
    {
        //Osnovne Informacije
        public int ID { get; set; }
        public string ImeKontejnera { get; set; }
        public string OpisKontejnera { get; set; }
        public string PredvidjenDatum { get; set; }


        //Informacije koje se dobijaju od konstruktora
        public string TipKontejnera { get; set; }

                
    }
}
