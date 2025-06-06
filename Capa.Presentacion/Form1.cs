using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            adapt = new SqlDataAdapter("SELECT * FROM PROVEEDOR", conn);
            adapt.Fill(dt);
            dgvProveedores.DataSource = dt;
            conn.Close();
        }



        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string rnc = TxtRNC.Text.Trim();
            CNProveedor negocio = new CNProveedor();
            var proveedor = negocio.ObtenerProveedorPorRNC(rnc);

            //captura de error (solo 9 numeros para el RNC)
            if (TxtRNC.Text.Length != 9)
            {
                MessageBox.Show("El RNC debe tener 9 dígitos.");
                return;
            }

            
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

           /* if (string.IsNullOrWhiteSpace(TxtRNC.Text) ||
           string.IsNullOrWhiteSpace(TxtNOMBRE.Text) ||
           string.IsNullOrWhiteSpace(TxtTELEFONO.Text) ||
           string.IsNullOrWhiteSpace(TxtTIPO.Text) ||
           string.IsNullOrWhiteSpace(TxtPRODUCTO.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;*/

                // Llama a la capa de negocio
                CNProveedor negocio = new CNProveedor();
                negocio.RegistrarProveedor(proveedor);
               //PARA QUE ACTUALICE
               ObtenerRegistro();

          
            
        }
        



        private void TxtTELEFONO_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void TxtNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }

                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
        }

        private void dgvProveedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtRNC.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            TxtNOMBRE.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
            TxtTELEFONO.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            TxtTIPO.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
            TxtPRODUCTO.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            conn.Open();
            string RNC = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            string connBD = "DELETE FROM PROVEEDOR WHERE RNC = '" + RNC + "'";
            SqlCommand cmd = new SqlCommand(connBD, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("El Registro se elimino correctamente");
            TxtRNC.Text = "";
            TxtNOMBRE.Text = "";
            TxtTELEFONO.Text = "";
            TxtTIPO.Text = "";
            TxtPRODUCTO.Text = "";
            conn.Close();
            ObtenerRegistro();
        }

        private void TxtRNC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
