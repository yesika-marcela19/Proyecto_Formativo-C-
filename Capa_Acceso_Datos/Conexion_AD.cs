using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Acceso_Datos
{
    public class Conexion_AD
    {

        MySqlConnection llave = new MySqlConnection();
        public void Conectar_bd()
        {
            try
            {
                llave.ConnectionString =//server=10.97.128.75;database=piscicola;uid=piscicola;pwd=ADSI1613696";
                "server=localhost;database=piscicola;uid='root';pwd=''";
                llave.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("error :" + ex.Message);
            }
        }

        public DataTable Ejecutar_Consuta(String Sql)
        {
            Conectar_bd();
            DataTable dt = new DataTable();
            try
            {

                if (llave != null)
                {
                    MySqlCommand comando = new MySqlCommand(Sql, llave);
                    MySqlDataReader reader = comando.ExecuteReader();


                    dt.Load(reader);
                    llave.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :" + ex);
            }
            return dt;


        }

        public int Ejecutar_DML(string sql)
        {
            int cant = 0;
            try
            {
                Conectar_bd();
                MySqlCommand comando = new MySqlCommand(sql, llave);
                cant = comando.ExecuteNonQuery();
                llave.Close();

                return cant;



            }
            catch (Exception ex)
            {
                return 0;
            }
        }


    }
}
