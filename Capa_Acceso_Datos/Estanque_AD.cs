using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;

namespace Capa_Acceso_Datos
{
    public class Estanque_AD
    {
        public int Registra_Estanque(Estanque_EN estan_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into estanque(id_estanque,latitud,longitud,area,capacidad,fk_bateria,tipo_estanque)values (" + estan_en.Id_estanque + "," + estan_en.latitud + "," + estan_en.longitud + "," + estan_en.area + ",'" + estan_en.capacidad + "'," + estan_en.fk_bateria + " , '" + estan_en.tipo_estanque + "' )";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public int Eliminar_Estanque(Estanque_EN estan_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from estanque where id_estanque= " + estan_en.Id_estanque + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Actualizar_Estanque(Estanque_EN estan_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update estanque set latitud= " + estan_en.latitud + ", longitud=" + estan_en.longitud + ", area=" + estan_en.area + ", capacidad=" + estan_en.capacidad + ", fk_bateria=" + estan_en.fk_bateria + ", tipo_estanque='" + estan_en.tipo_estanque + "'  where id_estanque=" + estan_en.Id_estanque + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public DataTable Buscar_Estanque(Estanque_EN estan_en)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select * from  piscicola.estanque where id_estanque = " + estan_en.Id_estanque + " ";
            return con.Ejecutar_Consuta(sql);
        }
  
        public DataTable Listado_Estanque()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from estanque where estado_estanque=1";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select id_estanque AS ESTANQUE,latitud AS LATITUD,longitud AS LONGITUD,area AS AREA,capacidad AS CAPACIDAD,nombre_bateria AS BATERIA,tipo_estanque AS ESTANQUE from estanque inner join bateria on id_bateria=fk_bateria where estado_estanque=1; ";
            return con.Ejecutar_Consuta(sql);
        }
        public DataTable Listado_inactivo()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select id_estanque AS ESTANQUE,latitud AS LATITUD,longitud AS LONGITUD,area AS AREA,capacidad AS CAPACIDAD,nombre_bateria AS BATERIA,tipo_estanque AS ESTANQUE from estanque inner join bateria on id_bateria=fk_bateria where estado_estanque=0;";
            return con.Ejecutar_Consuta(sql);
        }

        public DataTable Estanques_vacios_de_lote()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = " select est.id_estanque,est.tipo_estanque from estanque  est inner join lote lt on lt.fk_estanque = est.id_estanque where est.id_estanque not in(select l.fk_estanque from lote l where l.estado_lote = 1 ) and lt.estado_lote = 0 ";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Estado_Activo()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "SELECT fk_estanque AS Estanque,fecha AS Fecha ,temperatura AS Temperatura,turbiedad AS Turbiedad ,lluvia AS Lluvia,'Activo' AS Estado from estado inner join estanque on (id_estanque=fk_estanque)  where estado_estanque=1 ";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Estado_Inactivo()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "SELECT fk_estanque AS Estanque,fecha AS Fecha ,temperatura AS Temperatura,turbiedad AS Turbiedad ,lluvia AS Lluvia,'Inactivo' AS Estado from estado inner join estanque on (id_estanque=fk_estanque) where estado_estanque=0 ";
            return con.Ejecutar_Consuta(sql);

        }
        public int Habilitar(Estanque_EN estan_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update estanque set estado_estanque=1  where id_estanque=" + estan_en.Id_estanque + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Deshabilitar(Estanque_EN estan_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update estanque set estado_estanque=0  where id_estanque=" + estan_en.Id_estanque + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        /*public int Activar_estanque(Estanque_EN estan_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update estanque set estado_estanque=1 where id_estanque = " + estan_en.Id_estanque + "";
            int res = con.Ejecutar_DML(sql);
            return res;

        }*/

    }
}
