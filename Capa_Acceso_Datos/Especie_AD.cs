using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;

namespace Capa_Acceso_Datos
{
    public class Especie_AD
    {
        public int Registra_Especie(Especie_EN especie_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into tipo_especie(id_tipo_especie,nombre_especie)values (" + especie_en.Id_especie + ",'" + especie_en.Nombre_especie + "' )";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public int Eliminar_Especie(Especie_EN especie_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from tipo_especie where id_tipo_especie= " + especie_en.Id_especie + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Actualizar_Especie(Especie_EN especie_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update tipo_especie set nombre_especie= '" + especie_en.Nombre_especie + "' where id_tipo_especie= " + especie_en.Id_especie + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public DataTable Buscar_Especie(Especie_EN especie_en)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select * from  piscicola.tipo_especie where id_tipo_especie = " + especie_en.Id_especie + " ";
            return con.Ejecutar_Consuta(sql);

        }

        public DataTable Listado_Especie()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from tipo_especie";
            return con.Ejecutar_Consuta(sql);

        }


    }
}
