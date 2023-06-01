using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class dij
    {
        int evszam;
        string nobelTipus;
        string keresztNev;
        string vezetekNev;

        public dij(int evszam, string nobelTipus, string keresztNev, string vezetekNev)
        {
            this.evszam = evszam;
            this.nobelTipus = nobelTipus;
            this.keresztNev = keresztNev;
            this.vezetekNev = vezetekNev;
        }

        public int Evszam { get => evszam;  }
        public string NobelTipus { get => nobelTipus;  }
        public string KeresztNev { get => keresztNev;  }
        public string VezetekNev { get => vezetekNev;  }
    }
}
