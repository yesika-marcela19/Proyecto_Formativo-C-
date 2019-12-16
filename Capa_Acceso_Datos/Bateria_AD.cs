using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;

namespace Capa_Acceso_Datos
{
    public class Bateria_AD
    {
        public int Registra_bateria(Bateria_EN bate_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into bateria(id_bateria,nombre_bateria)values ( " + bate_en.Id_bateria + ", '" + bate_en.Nombre + "' ) ";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Eliminar_bateria(Bateria_EN bate_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from bateria where Id_bateria= " + bate_en.Id_bateria + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public int Actualizar_bateria(Bateria_EN bate_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = " update bateria set nombre_bateria= '" + bate_en.Nombre + "'  where id_bateria= " + bate_en.Id_bateria + " ; ";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public DataTable Buscar_bateria(Bateria_EN bate_en)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select * from  piscicola.bateria where id_bateria = " + bate_en.Id_bateria + "";
            return con.Ejecutar_Consuta(sql);

        }

        public DataTable Listado_bateria()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select nombre_bateria AS BATERIA from bateria";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_bateria_registro_lote()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from bateria";
            return con.Ejecutar_Consuta(sql);

        }
    }
}
