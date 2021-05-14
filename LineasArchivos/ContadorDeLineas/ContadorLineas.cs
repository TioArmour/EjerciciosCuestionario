using System;
using System.IO;

namespace ContadorDeLineas
{
    class ContadorLineas
    {
        public string ruta;
        public ContadorLineas(string ruta)
        {
            this.ruta = ruta;
        }
        public ContadorLineas()
        {
            ruta = "";
        }

        public void setRuta(string ruta)
        {
            this.ruta = ruta;
        }

        public void contar()
        {
            try
            {

                StreamReader sr = new StreamReader(ruta);
                string linea = sr.ReadLine();
                int contador = 0;
                while (linea != null)
                {
                    contador += 1;
                    if (linea == "")
                    {
                        contador -= 1;
                    }
                    linea = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine($"Tu archivo tiene {contador} lineas.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido abrir el archivo.");
                Console.WriteLine("El error es: " + e);
            }
        }

        public static void Main(string[] args)
        {
            ContadorLineas CL = new ContadorLineas();
            string ruta;
            string resp = "si";
            while(resp == "si")
            { 
                Console.WriteLine("Introduce la ruta o ubicacion del archivo que quieres saber su numero de lineas:");
                ruta = Console.ReadLine();
                CL.setRuta(ruta);
                CL.contar();
                Console.WriteLine("¿Tienes otro archivo para saber el numero de lineas?(Si/No)");
                resp = Console.ReadLine().ToLower();
            }
        }
    }

}
