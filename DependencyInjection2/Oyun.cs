using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection2
{
    class Oyun
    {

        //Setter Injection
        //public IOyuncuArayuz _oyuncu { get; set; }

        //Constructor Based Dependecy Injection

        IOyuncuArayuz _oyuncu;

        public Oyun(IOyuncuArayuz oyuncu)
        {
            _oyuncu = oyuncu;
        }

        public void Init()
        {
            _oyuncu.Basla();
            _oyuncu.MerhabaDe();
            _oyuncu.Kos();
            _oyuncu.Devam();
        }
    }
}
