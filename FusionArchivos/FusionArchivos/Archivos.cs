using System;
using System.IO;

namespace FusionArchivos
{
    class Archivos
    {
        string rutaArchivo1;
        string rutaArchivo2;
        string rutaArchivoNuevo;

        public Archivos()
        {
            rutaArchivo1 = "";
            rutaArchivo2 = "";
            rutaArchivoNuevo = "";
        }

        static void combinarArchivos(string ruta1, string ruta2, string ruta3)
        {
            try
            {
                StreamReader srArchivo1 = new StreamReader(ruta1);
                StreamReader srArchivo2 = new StreamReader(ruta2);
                StreamWriter sw = new StreamWriter(ruta3, true);
                string lineaArchivo1 = srArchivo1.ReadLine();
                while(lineaArchivo1 != null)
                {
                    sw.WriteLine(lineaArchivo1);
                    lineaArchivo1 = srArchivo1.ReadLine();
                }
                srArchivo1.Close();
                string lineaArchivo2 = srArchivo2.ReadLine();
                while (lineaArchivo2 != null)
                {
                    sw.WriteLine(lineaArchivo2);
                    lineaArchivo2 = srArchivo2.ReadLine();
                }
                srArchivo2.Close();
            }
            catch
            {
                Console.WriteLine("Ha ocurrido un error.");
            }
        }

        static void Main(string[] args)
        {
            string resp = "si";
            while(resp == "si")
            {
                Archivos AR = new Archivos();
                Console.WriteLine("Introduce la ruta de los dos archivos a combinar:");
                Console.WriteLine("Archivo 1: ");
                AR.rutaArchivo1 = Console.ReadLine();
                Console.WriteLine("Archivo 2: ");
                AR.rutaArchivo2 = Console.ReadLine();
                Console.WriteLine("Introduce la ruta del archivo donde se combinaran los anteriores dos: ");
                AR.rutaArchivoNuevo = Console.ReadLine();
                combinarArchivos(AR.rutaArchivo1, AR.rutaArchivo2, AR.rutaArchivoNuevo);
                Console.WriteLine("¿Tienes mas archivos para combinar? (Si/No)");
                resp = Console.ReadLine().ToLower();
            }
            Console.ReadKey();
        }
    }
}
