using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection2
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyun oyun = new Oyun(new Ninja());

            oyun.Init();
        }
    }
}
