using System.Windows.Forms;
using System.IO;

namespace Logica
{
    public class Archivos
    {
        string nombre;
        string carrera;
        string asignatura;
        string semestre;
        string periodo;
        string notaExamen;
        string evaluacionContinua;
        string notaSAGA;
        string ruta;
        public void getDatosEstudiante(TextBox nombre, TextBox carrera,TextBox asignatura, string semestre, string periodo)
        {
            this.nombre = nombre.Text;
            this.carrera = carrera.Text;
            this.asignatura = asignatura.Text;
            this.semestre = semestre;
            this.periodo = periodo;
        }
        public void getNotas(TextBox notaExamen, TextBox evaluacionContinua, TextBox notaSAGA)
        {
            this.notaExamen = notaExamen.Text;
            this.evaluacionContinua = evaluacionContinua.Text;
            this.notaSAGA = notaSAGA.Text;
        }

        public void guardarNotas()
        {
            try
            {
                if(double.Parse(notaExamen) >= 0 && double.Parse(notaExamen) <=10 && double.Parse(evaluacionContinua) <= 10 && double.Parse(evaluacionContinua) >= 0)
                {
                    ruta = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\AdministracionNotas\Archivos\NotasEstudiantes.txt";
                    StreamWriter sw = new StreamWriter(ruta, true);
                    sw.WriteLine($"Nombre del Estudiante {nombre}");
                    sw.WriteLine($"Carrera: {carrera}");
                    sw.WriteLine($"Semestre: {semestre}");
                    sw.WriteLine($"Periodo de Evaluacion: {periodo}");
                    sw.WriteLine($"Nota Examen: {notaExamen}");
                    sw.WriteLine($"Evaluación Continua: {evaluacionContinua}");
                    sw.WriteLine($"Nota SAGA: {notaSAGA}");
                    sw.WriteLine("");
                    sw.Close();
                    MessageBox.Show("Se ha guardado la informacion con exito");
                }
            }
            catch
            {
                MessageBox.Show("No ha sido posible guardar la informacion.");
            }
        }
    }
}
