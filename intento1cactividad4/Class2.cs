using System;
using System.Collections.Generic;
using System.Text;

namespace intento1cactividad4
{
    class ingrediente
    {
        private string nombre;
        private double precio;
        private string tipodcomida;
        int kilos;
         
        public ingrediente()
        {
            /// Este constructor lo uso con el fin de dar un salto de linea
            /// y que los textos no se vean tan pegados.
            Console.WriteLine("\n");
        }
    public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Tipodcomida { get => tipodcomida; set => tipodcomida = value; }
        public int Kilos { get => kilos; set => kilos = value; }

        public void registroingrediente(string _nombre, double _precio, string _tipodcomida, int _kilos  )
        {
            nombre = _nombre;
            precio = _precio;
            kilos = _kilos;
            tipodcomida = _tipodcomida;
            
        }

        public string registroingrediente()
        {
            int _kilos=0;
            kilos = _kilos;
            return "Alimento: " + nombre + "\n Precio: " + precio + " el kg bs" + "\n Es un alimento: " + tipodcomida;
        }
        public string uregistroingrediente()
        {
            int _kilos = 0;
            kilos = _kilos; 
            return "Alimento: " + nombre + "\n Precio: " + precio + " bs los 3kg" + "\n Es un alimento: " + tipodcomida;
        }
        
    }
}
