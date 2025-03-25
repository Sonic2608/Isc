using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{
    public abstract class Juego
    {
        public abstract string Nombre { get; }
        public abstract bool GanaContra(Juego otro);
    }
}