using System.Data;
using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{

    public class CNProveedor
    {

        public PROVEEDOR ObtenerProveedorPorRNC(string rnc)
        {
            PROVEEDOR proveedor = null;

            using (SqlConnection conn = new SqlConnection(connBD.conexion))
            {
                conn.Open();

                string query = "SELECT * FROM Proveedor WHERE RNC = @RNC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RNC", rnc);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    proveedor = new PROVEEDOR
                    {
                        RNC = reader["RNC"].ToString(),
                        NOMBRE = reader["Nombre"].ToString(),
                        TELEFONO = reader["Telefono"].ToString(),
                        TIPO = reader["Tipo"].ToString(),
                        PRODUCTO = reader["Producto"].ToString()
                    };
                }
            }

            return proveedor;
        }
    }





    public class PROVEEDOR
    {

        
        public string RNC { get; set; } = string.Empty;
        public string NOMBRE { get; set; } = string.Empty;
        public string TELEFONO { get; set; } = string.Empty;
        public string TIPO { get; set; } = string.Empty;
        public string PRODUCTO { get; set; } = string.Empty;

        public virtual bool ValidarRNC()
        {
            // Validación simple 
            return RNC.All(char.IsDigit) && RNC.Length == 5;
        }

       
    }

    public class ProveedorLocal : PROVEEDOR
    {
        public override bool  ValidarRNC()
        {
            // validar RNC
           if (string.IsNullOrWhiteSpace(RNC)) return false;
            return RNC.All(char.IsDigit) && RNC.Length == 5;
        }


        
    }


    public class ProveedorInternacional : PROVEEDOR
    {
        public override bool ValidarRNC()
        {
            if (string.IsNullOrWhiteSpace(RNC)) return false;
            return RNC.All(char.IsDigit) && RNC.Length == 5;

        }
        
        



    }
    
   


}
