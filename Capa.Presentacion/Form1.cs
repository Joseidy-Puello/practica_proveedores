using System.Data;
using Capa_Datos;
using Capa_Negocios;
using Microsoft.Data.SqlClient;

namespace Capa.Presentacion
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection(connBD.conexion);
        SqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
            ObtenerRegistro();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ObtenerRegistro()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Proveedor", conn);
            adapt.Fill(dt);
            dgvProveedores.DataSource = dt;
            conn.Close();
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

        private void btnREGISTRAR_Click(object sender, EventArgs e)
        {
            PROVEEDOR proveedor = new PROVEEDOR();
            proveedor.NOMBRE = TxtNOMBRE.Text;
            proveedor.RNC = TxtRNC.Text;
            proveedor.TELEFONO = TxtTELEFONO.Text;
            proveedor.TIPO = TxtTIPO.Text;
            proveedor.PRODUCTO = TxtPRODUCTO.Text;

            // Llama a la capa de negocio
            CNProveedor negocio = new CNProveedor();
            negocio.RegistrarProveedor(proveedor);
            //PARA QUE ACTUALICE
            ObtenerRegistro();

            /*if (exito)
                MessageBox.Show("Proveedor registrado correctamente.");
            else
                MessageBox.Show("Error al registrar el proveedor.");*/
        }



        private void TxtTELEFONO_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           

        }

        private void TxtNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
