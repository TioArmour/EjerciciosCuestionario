using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class RegistroNotas : Form
    {
        Logica.Archivos Archivos = new Logica.Archivos();
        Logica.Notas Notas = new Logica.Notas();
        public RegistroNotas()
        {
            InitializeComponent();
        }

        private void RegistroNotas_Load(object sender, EventArgs e)
        {
            gbNotas.Enabled = false;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtCarrera.Text != "" && cbSemestre.Text != "" && cbPeriodo.Text != "")
            {
                Archivos.getDatosEstudiante(txtNombre, txtCarrera,txtAsignatura, cbSemestre.SelectedItem.ToString(), cbPeriodo.SelectedItem.ToString());
                gbNotas.Enabled = true;
                btnSalir.Enabled = false;
                gbDatosEstudiantes.Enabled = false;
                txtSAGA.Enabled = false;
            }
            else
            {
                MessageBox.Show("Existe Informacion Faltante.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtExamen.Text != "" && txtEvaluacion.Text != "")
                {
                    Notas.setNotas(txtExamen, txtEvaluacion, txtSAGA);
                    Archivos.getNotas(txtExamen, txtEvaluacion, txtSAGA);
                    if (double.Parse(txtExamen.Text) >= 0 && double.Parse(txtExamen.Text) <= 10 && double.Parse(txtEvaluacion.Text) <= 10 && double.Parse(txtEvaluacion.Text) >= 0)
                    {
                        Archivos.guardarNotas();
                        txtExamen.Clear();
                        txtEvaluacion.Clear();
                        txtSAGA.Clear();
                        txtNombre.Clear();
                        txtCarrera.Clear();
                        txtAsignatura.Clear();
                        gbDatosEstudiantes.Enabled = true;
                        gbNotas.Enabled = false;
                        btnSalir.Enabled = true;
                    }
                }
            }
            catch
            {
                
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
