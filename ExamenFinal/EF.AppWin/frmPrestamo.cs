using EF.Dominio;
using EF.Logic;
using System.Runtime.CompilerServices;

namespace EF.AppWin
{
    public partial class frmPrestamo : Form
    {
       
        public frmPrestamo()
        {
            InitializeComponent();
            
        }

        private void IniciarFormulario(object sender, EventArgs e)
        {
            cargarDatos();
        }
        
        private void Consultar(object sender, EventArgs e)
        {
            
        }
        private void cargarDatos()
        {
            var listado = PrestamoBL.Listar();
            listado.Insert(0, new Prestamo
            {
                Numero = "--SELECCIONE--"
            });
            cboPrestamo.DataSource = listado;
            cboPrestamo.DisplayMember = "Numero";
            cboPrestamo.ValueMember = "ID";
        }
    }
}