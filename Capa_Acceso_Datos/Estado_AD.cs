using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;

namespace Capa_Acceso_Datos
{
    public class Estado_AD
    {


        public int Registrar_Estado(Estado_EN est)
        {
            string sql = " insert into estado(fecha,temperatura,turbiedad,lluvia,fk_estanque)values('" + est.fecha + "', " + est.temperatura + ", " + est.turbiedad + ", " + est.lluvia + ", " + est.estanque + ")";
            Conexion_AD con = new Conexion_AD();
            return con.Ejecutar_DML(sql);
        }

        public int Eliminar_Estado(Estado_EN est)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from estado where id_estado= " + est.id + ";";
            return con.Ejecutar_DML(sql);
        }
        public DataTable Buscar_Estado(Estado_EN est)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from piscicola.estado";
            return con.Ejecutar_Consuta(sql);
        }

        public int Actualizar_estado(Estado_EN est)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update estado set fecha= '" + est.fecha + "',temperatura=" + est.temperatura + ", turbiedad = " + est.turbiedad + ", lluvia=" + est.lluvia + ",fk_estanque=" + est.estanque + " where id_estado=" + est.id + "; ";
            return con.Ejecutar_DML(sql);
        }


        public DataTable Listado_Estado()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from estado";
            return con.Ejecutar_Consuta(sql);

        }

    }
}
