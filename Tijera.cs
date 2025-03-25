using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arcade;

namespace juegos
{
    public class Tijera : Juego
    {
        public override string Nombre => "Tijera";
        public override bool GanaContra(Juego otro)
        {
            return otro is Papel;
        }
    }
}