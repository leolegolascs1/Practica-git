using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones
{
    class Auto
    {
        private int _anio;
        private string _marca;
        private string _modelo;
        private string _color;
        private string _patente;
        private string _detalles;

        //  Ejemplo Constructor

        public Auto(int anio, string marca, string modelo, string color, string patente)
        {
            _anio = anio;
            _marca = marca;
            _modelo = modelo;
            _color = color;
            _patente = patente;
        }

        public int Anio
        {
            get { return _anio; }
            set { _anio = value;}
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }

        public string get_resumen()
        {
            mostrar_resumen();
            return _detalles; 
        }
        public void mostrar_resumen()
        {
            _detalles = "Marca: "+_marca +"Modelo: " + _modelo + "Año Fabricacion: " + _anio + "Color: " + _color + "Patente: " + _patente;
        }

       public void Encender()
        {
            Console.WriteLine("Encender");
        }
        public void Mover_metros()
        {
            Console.WriteLine("Se mueve");
        }
        public void Apagar()        
        {
            Console.WriteLine("Apagar");
        }














    }
}
