using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class fuvar
    {
        int taxi_id;
        string indulas;
        int idotartam;
        int tavolsag;
        int viteldij;
        int borravalo;
        string fizetes_modja;

        public fuvar(int taxi_id, string indulas, int idotartam, int tavolsag, int viteldij, int borravalo, string fizetes_modja)
        {
            this.taxi_id = taxi_id;
            this.indulas = indulas;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.viteldij = viteldij;
            this.borravalo = borravalo;
            this.fizetes_modja = fizetes_modja;
        }

        public int Taxi_id { get => taxi_id; set => taxi_id = value; }
        public string Indulas { get => indulas; set => indulas = value; }
        public int Idotartam { get => idotartam; set => idotartam = value; }
        public int Tavolsag { get => tavolsag; set => tavolsag = value; }
        public int Viteldij { get => viteldij; set => viteldij = value; }
        public int Borravalo { get => borravalo; set => borravalo = value; }
        public string Fizetes_modja { get => fizetes_modja; set => fizetes_modja = value; }
    }
}
