using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;

namespace Capa_Acceso_Datos
{
    public class Tipo_Alimentacion_AD
    {
        public int Registra_Alimentacion(Tipo_Alimentacion_EN alimen_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into tipo_alimentacion(id_tipo_alimentacion,nombre_alimentacion)values (" + alimen_en.Id_Alimentacion + ",'" + alimen_en.Nombre_Alimentacion + "' )";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public int Eliminar_Alimentacion(Tipo_Alimentacion_EN alimen_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from tipo_alimentacion where id_tipo_alimentacion= " + alimen_en.Id_Alimentacion + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Actualizar_Alimentacion(Tipo_Alimentacion_EN alimen_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update tipo_alimentacion set nombre_alimentacion= '" + alimen_en.Nombre_Alimentacion + "' where id_tipo_alimentacion= " + alimen_en.Id_Alimentacion + " ; ";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public DataTable Buscar_Alimentacion(Tipo_Alimentacion_EN alimen_en)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select * from  piscicola.tipo_alimentacion where id_tipo_alimentacion = " + alimen_en.Id_Alimentacion + " ";
            return con.Ejecutar_Consuta(sql);

        }

        public DataTable Listado_Alimentacion()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from tipo_alimentacion";
            return con.Ejecutar_Consuta(sql);

        }
    }
}
