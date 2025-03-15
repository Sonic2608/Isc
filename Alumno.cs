using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumno_y_profe
{
    internal class Alumno
    {
        private int nl;
        private string nombre_alumno;
        private ArrayList materias = new ArrayList();
        private ArrayList calificaciones = new ArrayList();

        public int Nl { get => nl; set => nl = value; }
        public string Nombre_Alumno { get => nombre_alumno; set => nombre_alumno = value; }
        public ArrayList Materias { get => materias; set => materias = value; }
        public ArrayList Calificaciones { get => calificaciones; set => calificaciones = value; }
        public Alumno()
        {
            Materias = new ArrayList();
            Calificaciones = new ArrayList();
        }
        public void agregarMaterias(string materia)
        {
            materias.Add(materia);
        }
        public void agregarCalificación (int calificación)
        {
            calificaciones.Add(calificación);
        }
    }
}
