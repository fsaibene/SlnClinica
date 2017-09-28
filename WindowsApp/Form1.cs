using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        private ServiceMedicos medicosService;
        private ServicePacientes pacientesService;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            medicosService.Clear();
            medicosService.Agregar("Pediatra", "Carolina", "Garcia", "Carolina@Clinica.com", DateTime.Now);
            medicosService.Agregar("Pediatra", "Juan", "Perez", "JuanP@Clinica.com", DateTime.Now);
            medicosService.Agregar("Clinico", "Ana", "Pocetti", "AnaP@Clinica.com", DateTime.Now);

            gridMedicos.DataSource = medicosService.Listar();
            lstMedicos.DataSource = medicosService.Nombres();
            cmbFiltro.DataSource = medicosService.Especialidades();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            medicosService = new ServiceMedicos();
            pacientesService = new ServicePacientes();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridMedicos.DataSource = medicosService.Listar(cmbFiltro.SelectedValue.ToString());
        }
    }
}
