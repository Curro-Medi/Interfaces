using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen29_01_2021
{
    public class Cliente
    {

        private String nombre;
        private String apellidos;
        private String dni;
        private List<Videojuego> videojuegos;

        public Cliente(string nombre, string apellidos, string dni, List<Videojuego> videojuegos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.videojuegos = videojuegos;
        }

        public string Dni { get => dni; set => dni = value; }

        public void addvideojuego(Videojuego videojuegoadd)
        {
            this.videojuegos.Add(videojuegoadd);
        }

        public void eliminarvideojuego()
        {
            this.videojuegos = new List<Videojuego>();
        }

        public List<Videojuego> vid()
        {
            return videojuegos;
        }

        public override string ToString()
        {
            return "Nombre --> " + nombre + " DNI --> " + Dni;
        }

    }
}
