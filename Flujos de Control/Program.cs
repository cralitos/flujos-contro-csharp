using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flujos_de_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejemploFor();
            //ejemploIfAnidado();
            //ejemploSwitch();
            Console.WriteLine("ingrese el precio del producto");
            int precio = int.Parse(Console.ReadLine());
            // bool boolVal = verificarEdad(edad);
            
            if (precio > 100)
            {
                int desc = (int)(precio * 0.1); ;
                Console.WriteLine("el precio con descuento es" + (precio - desc));
            }
            else if (precio > 50)
            {
                int desc = (int)(precio * 0.05); ;
                Console.WriteLine("el precio con descuento es" + (precio - desc));
            }
            else
            {
                Console.WriteLine("no tiene descuento");
            }
            
            Console.WriteLine("fin del programa");
        }

        static bool verificarEdad(int edad)
        {
            return edad > 19 && edad < 40;
        }

        static void ejemploSwitch()
        {
            int codProducto = 2;
            switch (codProducto)
            {
                case 1:
                    Console.WriteLine("el producto esta en liquidacion");
                    break;
                case 2:
                    Console.WriteLine("el producto esta en oferta");
                    break;
                case 3:
                    Console.WriteLine("el producto esta a precio normal");
                    break;
                default:
                    Console.WriteLine("no se cumple ningun caso");
                    break;
            }

            
        }
        static void ejemploIfAnidado()
        {
            bool esMiembro = true;
            Console.WriteLine("ingrese precio ");
            int precio = int.Parse(Console.ReadLine());
            double desc = 0;    
            if (esMiembro)
            {
                if(precio > 100) {
                    desc = precio * 0.2;
                    Console.WriteLine("el precio con descuento es: " + (precio - desc));

                }else if (precio > 50)
                {
                    desc = precio * 0.1;
                    Console.WriteLine("el precio con descuento es: " + (precio - desc));

                }
                else
                {
                    desc = precio * 0.05;
                    Console.WriteLine("el precio con descuento es: " + (precio - desc));
                }
            }
            else
            {
                Console.WriteLine("no tiene descuentos");
            }
        }

        static void ejemploFor()
        {
            for (int c = 0; c < 8; c++)
            {
                Console.WriteLine(c);
            }
        }
    }
}
