using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arcade;
using juegos;

namespace juegos
{
    public class Piedra : Juego
    {
        public override string Nombre => "Piedra";
        public override bool GanaContra(Juego otro)
        {
            return otro is Tijera;
        }

    }
}