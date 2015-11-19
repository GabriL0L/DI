using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ProyectoMagic
{
    public static class DataBaseConnection
    {
        
        
        public static SqlConnection conectarBD()
        {
            SqlConnection con =  new SqlConnection();
            con.ConnectionString = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=Magic;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();

            return con;
        }

        public static void cerrarBD(SqlConnection con)
        {
            con.Close();
        }

        public static Boolean login(String user, String pass)
        {
            bool salida = false;
            int resultado;
            SqlConnection con = conectarBD();
            SqlCommand orden = new SqlCommand();

            orden.CommandText = String.Format("SELECT COUNT(*) FROM dbo.Usuario WHERE nombre='{0}' AND pass='{1}'",user,pass);
            orden.CommandType = System.Data.CommandType.Text;
            orden.Connection = con;
            resultado = (int) orden.ExecuteScalar();
            cerrarBD(con);

            if(resultado == 1)
            {
                salida = true;
            }

            return salida;
        }

        public static ArrayList mostrarListaCartas(String color)
        {
            SqlConnection con = conectarBD();
            SqlCommand orden = new SqlCommand();
            ArrayList salida = new ArrayList();

            orden.CommandText = String.Format("SELECT nombreCarta FROM dbo.Carta WHERE color='{0}'",color);
            orden.CommandType = System.Data.CommandType.Text;
            orden.Connection = con;
            SqlDataReader reader = orden.ExecuteReader();

            while (reader.Read())
            {
                salida.Add(reader.GetString(0));
            }
            

            return salida;
        }

    }
}
