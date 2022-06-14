using System;
using System.Collections.Generic;
using System.Text;

namespace Medidas.Models
{
    class Mujer : Persona 
    {
        public double pesoMaximo { get; set; } = 25;
        public double pesoMinimo { get; set; } = 19;
        public double estatura { get; set; } = 0;

        public void maximo()
        {

            pesoMaximo = pesoMaximo * estatura;

        }
        public double GetEstatura()
        {
            return estatura;
        }
        public void minimo()
        {

            pesoMinimo = pesoMinimo * estatura;
        }

        public string calcularEstatura()
        {

            return "La persona " + nombre + " tiene un Indice de Masa Corporal de " + estatura * 0;

        }

        public void calcularAreaAltura()
        {
            calcularEstatura();

            peso = Math.Pow(estatura, 2) * (Math.Sqrt(3.00) / 3.00);
        }
    }
}
