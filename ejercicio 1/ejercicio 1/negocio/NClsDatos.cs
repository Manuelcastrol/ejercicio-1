using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1.negocio
{
    class NClsDatos
    {

        public string venta()
        {
            Console.WriteLine("para ingresar el dia de la semana escribir los dias con minusculas,\nejemplo: lunes, martes, miercoles, etc\n");
            ClsDatos datos = new ClsDatos();
            int dato = 2;
            while (dato == 2)
            {
                Console.WriteLine("cuanto va a pagar?........\n");
                datos.Pago = int.Parse(Console.ReadLine());
                Console.WriteLine("en que dia se realiza el pago.....\n");
                datos.Dia = Console.ReadLine();
                if (datos.Dia == "martes" || datos.Dia == "jueves")
                {
                    datos.Resultado = datos.Pago - (datos.Pago * 0.15);
                    Console.WriteLine("se le ha aplicado un descuento de un 15% por se " + datos.Dia + " \nsu tota a pagar es de " + datos.Resultado + " dolares");
                    Console.WriteLine("deseas cerrar el progrma?\npreciona 1) para si  \n2) para no");
                    dato = int.Parse(Console.ReadLine());
                }
                if (datos.Dia == "lunes" || datos.Dia == "miercoles" || datos.Dia == "viernes" || datos.Dia == "sabado" || datos.Dia == "domingo")
                {
                    datos.Resultado = datos.Pago;
                    Console.WriteLine("el total a pagar es de " + datos.Pago + " dolares");
                    Console.WriteLine("deseas cerrar el progrma?\npreciona 1) para si \n2) para no");
                    dato = int.Parse(Console.ReadLine());
                }
                if (datos.Dia != "lunes" && datos.Dia != "martes" && datos.Dia != "miercoles" && datos.Dia != "jueves" && datos.Dia != "viernes" && datos.Dia != "sabado" && datos.Dia != "domingo" && datos.Dia != "")
                {
                    Console.WriteLine("el valor que ingreso no es valido\n----------------------------------------------------\nsolo puedes ingresar los dias de la semana\n---------------------------------------");
                    Console.WriteLine("deseas cerrar el progrma?\npreciona 1) para si \n2) para no");
                    dato = int.Parse(Console.ReadLine());
                }


            }

            return "";
        }


    }



}


