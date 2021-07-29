using System;

namespace intento1cactividad4
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int cantidad = 0;
            bool while1 = true; bool while2 = true;
            double sumamonto = 0.0;
            char son; char son2;
            double montopro = 0.0;
            int cuanto = 0;
            
           


            Console.WriteLine("Bienvenido al programa");
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine(" 1= Registro de ingredientes    2= Registro de una compra de un cliente ");
            string cadena = Console.ReadLine();
            int eleccion = Convert.ToInt32(cadena);
            switch (eleccion)
            {
                case 1:
                    
                    while (while1) {
                        Console.WriteLine("\n");
                        Console.WriteLine("¿Cual de los siguiente productos quiere registrar?");
                        Console.WriteLine("1= queso        2= Carne       3= Pan   \n4=combo de salsas     5= combo de vegetales");
                        cadena = Console.ReadLine();
                        int eleccion2 = Convert.ToInt32(cadena);
                        switch (eleccion2)
                        {
                            case 1:
                                ///metodo 1
                                ingrediente objingrediente = new ingrediente();
                                objingrediente.registroingrediente("Queso", 20000.00, "Lacteo", 1);
                                objingrediente.registroingrediente("Queso", 20000.00, "Lacteo",1);
                                Console.WriteLine(" Alimento: " + objingrediente.Nombre + "\n Precio: " + objingrediente.Precio + " el kg Bs" + " \n Es un alimento " + objingrediente.Tipodcomida);
                                Console.WriteLine("Ingrese la cantidad de kilogramos");
                                cadena = Console.ReadLine();
                                cantidad = Convert.ToInt32(cadena);
                                sumamonto = sumamonto + (20000.00 * cantidad);
                                Console.WriteLine("Precio hasta ahora: " + sumamonto+ "bs");
                                objingrediente.Kilos = objingrediente.Kilos * cantidad;
                                objingrediente.Kilos = objingrediente.Kilos + objingrediente.Kilos;
                                break;

                            case 2:
                                ///sobrecarga de metodo 1
                                ingrediente objetoingrediente2 = new ingrediente();
                                objetoingrediente2.registroingrediente("carne", 50000.00, "comida humeda", 1);
                                Console.WriteLine(objetoingrediente2.registroingrediente());
                                Console.WriteLine("ingrese la cantidad de kilogramos");
                                cadena = Console.ReadLine();
                                cantidad = Convert.ToInt32(cadena);
                                sumamonto = sumamonto + (50000.00*cantidad);
                                Console.WriteLine("Precio hasta ahora: " + sumamonto+ "bs");
                                objetoingrediente2.Kilos = objetoingrediente2.Kilos + cantidad;
                                objetoingrediente2.Kilos = objetoingrediente2.Kilos + objetoingrediente2.Kilos;
                                break;

                            case 3:
                                ///sobrecarga de metodo 2
                                ingrediente objetoingrediente3 = new ingrediente();
                                objetoingrediente3.registroingrediente("pan", 10000.00, "comida seca", 1);
                                Console.WriteLine(objetoingrediente3.registroingrediente());
                                Console.WriteLine("Ingrese la cantidad de kilogramos");
                                cadena = Console.ReadLine();
                                cantidad = Convert.ToInt32(cadena);
                                sumamonto = sumamonto + (10000.00 * cantidad);
                                Console.WriteLine("Precio hasta ahora: " + sumamonto + "bs");
                                objetoingrediente3.Kilos = objetoingrediente3.Kilos + cantidad;
                                objetoingrediente3.Kilos = objetoingrediente3.Kilos + objetoingrediente3.Kilos;
                                break;

                            case 4:
                                ///sobrecargametodo 4
                                ingrediente objetoingrediente4 = new ingrediente();
                                objetoingrediente4.registroingrediente("Combo de salsas ", 75000.00, "Viveres, comida seca", 1);
                                Console.WriteLine(objetoingrediente4.registroingrediente());
                                Console.WriteLine("Ingrese la cantidad de combos");
                                cadena = Console.ReadLine();
                                cantidad = Convert.ToInt32(cadena);
                                sumamonto = sumamonto + (75000.00 * cantidad);
                                Console.WriteLine("Precio hasta ahora: " + sumamonto + "bs");
                                objetoingrediente4.Kilos = objetoingrediente4.Kilos + cantidad;
                                objetoingrediente4.Kilos = objetoingrediente4.Kilos + objetoingrediente4.Kilos;
                                break;

                            case 5:
                                ingrediente objetoimgrediente5 = new ingrediente();
                                objetoimgrediente5.registroingrediente("Combo de vegetales", 47000.00, "Viveres secos", 2);
                                Console.WriteLine(objetoimgrediente5.uregistroingrediente());
                                Console.WriteLine("Ingrese la cantidad de combos");
                                cadena = Console.ReadLine();
                                cantidad = Convert.ToInt32(cadena);
                                sumamonto = sumamonto + (47000.00 * cantidad);
                                Console.WriteLine("Precio hasta ahora: " + sumamonto + "bs");
                                objetoimgrediente5.Kilos = objetoimgrediente5.Kilos + cantidad;
                                objetoimgrediente5.Kilos = objetoimgrediente5.Kilos + objetoimgrediente5.Kilos;
                                break;

                            default:
                                Console.WriteLine("Error. Opción no solicitada;");
                                break;
                        }
                        while (while2)
                        {
                            Console.WriteLine("¿finalizó de registrar la cantidad de ingredientes a comprar?\n s=si desea terminar con el registro y saber el precio a pagar al distribuidor   \n n=no, aun no he terminado");
                            son = char.Parse(Console.ReadLine());

                            ///primea condicion:
                            if (son == 's')
                            {
                                while2 = false;
                                while1 = false;

                            }
                            ///fin primera condicion
                            ///segunda condicion:
                            if (son == 'n')
                            {

                                while2 = false;

                            }
                            ///fin segunda condicion
                            ///tercera condicion
                            if ((son != 'n' && son != 's'))
                            {
                                Console.WriteLine("Error. debes ingresar s ó n");
                                while2 = true;
                            }
                            ///fin tercera condicion
                        }
                        while2 = true;
                    }

            
                    Console.WriteLine("El monto a pagar al ditribuidor por los ingredientes es: " + sumamonto+ "Bs");
                    Console.ReadLine();
                    break;

                case 2:
                    bool inicio = true;
                    while (inicio) { 
                    Clientes objcliente = new Clientes();
                    Console.WriteLine("Ingrese el nombre del cliente");
                    objcliente.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la cedula del cliente");
                    cadena = Console.ReadLine();
                    objcliente.Cedula = Convert.ToInt32(cadena);
                    Console.WriteLine("Ingrese el numero de telefono del cliente");
                    cadena = Console.ReadLine();
                    objcliente.Numerodetlf = Convert.ToInt32(cadena);
                    Console.WriteLine("Dirección corta del cliente");
                    objcliente.Direccion = Console.ReadLine();
                        bool engranaje = true;

                        while (engranaje)
                        {
                            Console.WriteLine("Ingrese el Producto");
                            Console.WriteLine("1= Big Mac      2= Cajita Feliz    \n3=Papitas fritas     4= Helado");
                            Console.WriteLine("5= Nuggets      6= Refresco");
                            cadena= Console.ReadLine();
                            int producto = Convert.ToInt32(cadena);
                            switch (producto)
                            {
                                case 1:
                                    Console.WriteLine("El precio es 20000.00 bs");
                                    Console.WriteLine("¿Cuantos desea llevar?");
                                    cadena = Console.ReadLine();
                                    cuanto = Convert.ToInt32(cadena);
                                    Console.WriteLine("\n");
                                    montopro = montopro + (20000.00 * cuanto);
                                    Console.WriteLine("El cliente " + objcliente.Nombre + "Tiene de cuenta hasta ahora: " + montopro+ "Bs");
                                    break;

                                case 2:
                                    Console.WriteLine("El precio es 15000.00 bs");
                                    Console.WriteLine("¿Cuantos desea llevar?");
                                    cadena = Console.ReadLine();
                                    cuanto = Convert.ToInt32(cadena);
                                    Console.WriteLine("\n");
                                    montopro = montopro + (15000.00 * cuanto);
                                    Console.WriteLine("El cliente " + objcliente.Nombre + "Tiene de cuenta hasta ahora: " + montopro + "Bs");
                                    break;

                                case 3:
                                    Console.WriteLine("El precio es 10000.00 bs");
                                    Console.WriteLine("¿Cuantos desea llevar?");
                                    cadena = Console.ReadLine();
                                    cuanto = Convert.ToInt32(cadena);
                                    Console.WriteLine("\n");
                                    montopro = montopro + (10000.00 * cuanto);
                                    Console.WriteLine("El cliente " + objcliente.Nombre + "Tiene de cuenta hasta ahora: " + montopro + "Bs");
                                    break;

                                case 4:
                                    Console.WriteLine("El precio es 20000.00 bs");
                                    Console.WriteLine("¿Cuantos desea llevar?");
                                    cadena = Console.ReadLine();
                                    cuanto = Convert.ToInt32(cadena);
                                    Console.WriteLine("\n");
                                    montopro = montopro + (20000.00 * cuanto);
                                    Console.WriteLine("El cliente " + objcliente.Nombre + "Tiene de cuenta hasta ahora: " + montopro + "Bs");
                                    break;

                                case 5:
                                    Console.WriteLine("El precio es 10000.00 bs");
                                    Console.WriteLine("¿Cuantos desea llevar?");
                                    cadena = Console.ReadLine();
                                    cuanto = Convert.ToInt32(cadena);
                                    Console.WriteLine("\n");
                                    montopro = montopro + (10000.00 * cuanto);
                                    Console.WriteLine("El cliente " + objcliente.Nombre + "Tiene de cuenta hasta ahora: " + montopro + "Bs");
                                    break;

                                case 6:
                                    Console.WriteLine("El precio es 6000.00 bs");
                                    Console.WriteLine("¿Cuantos desea llevar?");
                                    cadena = Console.ReadLine();
                                    cuanto = Convert.ToInt32(cadena);
                                    Console.WriteLine("\n");
                                    montopro = montopro + (6000.00 * cuanto);
                                    Console.WriteLine("El cliente " + objcliente.Nombre + "Tiene de cuenta hasta ahora: " + montopro + "Bs");
                                    break;

                                default:
                                    Console.WriteLine("Error. Opcion no solicitada");
                                    engranaje = true;
                                    break;
     
                            }
                            Console.WriteLine("¿Desea llevar algo mas? \n s= si     n= no");
                            son2 = char.Parse(Console.ReadLine());
                            if (son2 == 's')
                            {
                                engranaje = true;


                            }
                            ///fin primera condicion
                            ///segunda condicion:
                            if (son2 == 'n')
                            {

                                engranaje = false;

                            }
                            ///fin segunda condicion
                            ///tercera condicion
                            if ((son2 != 'n' && son2 != 's'))
                            {
                                Console.WriteLine("Error. debes ingresar s ó n");
                                engranaje = true;
                            }
                        }
                        Console.WriteLine("El cliente " + objcliente.Nombre+ " numero de cedula "+ objcliente.Cedula );
                        Console.WriteLine("Numero de telefono" + objcliente.Numerodetlf + " Cuya direccion es: " + objcliente.Direccion);
                        Console.WriteLine("Debe pagar el monto total de " + montopro);
                        Console.WriteLine("\n");
                        Console.WriteLine("¿Desea ingrsar otro cliente?     \n s= si     n= no");
                        char ultima = char.Parse(Console.ReadLine());
                        if (ultima == 's')
                        {
                            inicio= true;


                        }
                        ///fin primera condicion
                        ///segunda condicion:
                        if (ultima == 'n')
                        {

                            inicio = false;

                        }
                        ///fin segunda condicion
                        ///tercera condicion
                        if ((ultima != 'n' && ultima != 's'))
                        {
                            Console.WriteLine("Error. debes ingresar s ó n");
                            inicio = true;
                        }
                    }

                    break;
                    
            }


        }
            
    }
}
