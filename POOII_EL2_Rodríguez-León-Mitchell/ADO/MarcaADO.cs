using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using POOII_EL2_Rodríguez_León_Mitchell.Models;

namespace POOII_EL2_Rodríguez_León_Mitchell.ADO
{
    public class MarcaADO
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNX"].ConnectionString);

        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlCommand cmd = new SqlCommand("SP_MARCAS_LISTAR", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                lista.Add(new Marca()
                {
                    IdMarca = dr.GetInt32(0),
                    Nombre = dr.GetString(1)
                });
            }

            dr.Close();
            cn.Close();
            return lista;
        }
    }
}