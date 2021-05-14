using System;
using System.Windows.Forms;

namespace Logica
{
    public class Notas
    {
        double notaExamen;
        double evaluacionContinua;
        double notaSAGA;

        public void setNotas(TextBox notaExamen, TextBox evaluacionContinua, TextBox notaSAGA)
        {
            try
            {
                this.notaExamen = double.Parse(notaExamen.Text);
                this.evaluacionContinua = double.Parse(evaluacionContinua.Text);
                if( this.notaExamen >= 0 && this.notaExamen <=10 && this.evaluacionContinua >= 0 && this.evaluacionContinua <= 10)
                {
                    this.notaSAGA = (this.notaExamen*0.6) + (this.evaluacionContinua*0.4);
                    notaSAGA.Text = Convert.ToString(this.notaSAGA);
                }
                else
                {
                    MessageBox.Show("Las notas introducidas estan fuera del rango permitido");
                }
            }
            catch
            {
                MessageBox.Show("Existio un error. Revisa los datos introducidos e intentalo nuevamente.");
            }
        }

    }
}
