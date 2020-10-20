using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_en_WPF
{
    public class Persona
    {
        private String DNI;
        private String nombre;
        private String apellidos;
        private int altura;
        private int peso;
        private int edad;
        private String fecha_nac;


        public Persona(string dNI, string nombre, string apellidos, int altura, int peso, int edad, String fecha_nac)
        {
            DNI = dNI;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.altura = altura;
            this.peso = peso;
            this.edad = edad;
            this.Fecha_nac = fecha_nac;
        }

        public override string ToString()
        {
            return "DNI: " + this.DNI + "   Nombre: " + this.nombre + "   Apellidos: " + this.apellidos + "   Altura: " + this.altura + "   Peso: "
                + this.peso + "   Edad: " + this.edad + "   Fecha de nacimiento: " + this.fecha_nac;
        }

        public string DNI1 { get => DNI; set => DNI = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Altura { get => altura; set => altura = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Edad { get => edad; set => edad = value; }
        public String Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
    
    }
}
