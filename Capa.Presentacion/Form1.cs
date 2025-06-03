using Capa_Negocios;

namespace Capa.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string rnc = TxtRNC.Text.Trim();
            CNProveedor negocio = new CNProveedor();
            var proveedor = negocio.ObtenerProveedorPorRNC(rnc);

            //captura de error (solo 5 numeros)
            if (TxtRNC.Text.Length != 5)
            {
                MessageBox.Show("El RNC debe tener 5 dígitos o menos.");
                return;
            }

            //
            if (proveedor != null)
            {
                MessageBox.Show("Proveedor encontrado: " + proveedor.NOMBRE);
                // muestrar los datos en controles
                TxtNOMBRE.Text = proveedor.NOMBRE;
                TxtRNC.Text = proveedor.RNC;
                TxtTELEFONO.Text = proveedor.TELEFONO;
                TxtTIPO.Text = proveedor.TIPO;
                TxtPRODUCTO.Text = proveedor.PRODUCTO;

            }
            else
            {
                MessageBox.Show("Proveedor no encontrado.");
            }
              

        }
        
    }
}
