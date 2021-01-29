using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen29_01_2021
{
    public class Videojuego
    {

        private int codigo;
        private String nombre;
        private String tema;

        public Videojuego(Videojuego selectedItem)
        {
        }

        public Videojuego(int codigo, string nombre, string tema)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.tema = tema;
        }

        public override string ToString()
        {
            return "Nombre --> " + nombre + " Tema --> " + tema;
        }

    }
}
