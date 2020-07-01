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
    public class VehiculoADO
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNX"].ConnectionString);

        public int Insertar(Vehiculo v)
        {
            int resultado = -1;

            SqlCommand cmd = new SqlCommand("SP_VEHICULOS_REGISTRAR", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Placa", v.Placa);
            cmd.Parameters.AddWithValue("@Año", v.Año);
            cmd.Parameters.AddWithValue("@Modelo", v.Modelo);
            cmd.Parameters.AddWithValue("@IdMarca", v.IdMarca);

            cn.Open();
            resultado = cmd.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

        public List<Vehiculo> Listar()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            SqlCommand cmd = new SqlCommand("SP_VEHICULOS_LISTAR", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                lista.Add(new Vehiculo()
                {
                    ID = dr.GetInt32(0),
                    Placa = dr.GetString(1),
                    Año = dr.GetInt32(2),
                    Modelo = dr.GetString(3),
                    IdMarca = dr.GetInt32(4),
                    Marca = dr.GetString(5)
                });
            }

            dr.Close();
            cn.Close();
            return lista;
        }
    }


}