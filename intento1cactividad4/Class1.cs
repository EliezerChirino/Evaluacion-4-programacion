using System;
using System.Collections.Generic;
using System.Text;

namespace intento1cactividad4
{
    class Clientes:ingrediente
    {
        private int cedula;
        private int numerodetlf;
        private string direccion;
        

        public int Cedula { get => cedula; set => cedula = value; }
        public int Numerodetlf { get => numerodetlf; set => numerodetlf = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }

    

}
