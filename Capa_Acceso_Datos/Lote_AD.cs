using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Entidades;

namespace Capa_Acceso_Datos
{
    public class Lote_AD
    {
        public int Registra_Lote(Lote_EN lote_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into lote(id_lote,cantidad,fecha_ingreso,fecha_salida,fk_estanque,fk_tipo_especie,estado_lote)values (" + lote_en.id_lote + "," + lote_en.cantidad + ",'" + lote_en.fecha_ingreso + "','" + lote_en.fecha_salida + "'," + lote_en.fk_estanque + ", " + lote_en.fk_tipo_especie + ", " + lote_en.estado_lote + ")";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public int Eliminar_Lote(Lote_EN lote_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from lote where id_lote= " + lote_en.id_lote + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Actualizar_Lote(Lote_EN lote_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update lote set cantidad=" + lote_en.cantidad + ", fecha_ingreso='" + lote_en.fecha_ingreso + "', fecha_salida='" + lote_en.fecha_salida + "', fk_estanque=" + lote_en.fk_estanque + ", fk_tipo_especie=" + lote_en.fk_tipo_especie + ", estado_lote=" + lote_en.estado_lote + " where id_lote=" + lote_en.id_lote + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Actualizar(Lote_EN lote_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update lote set cantidad="+ lote_en.cantidad + ", fecha_ingreso='" + lote_en.fecha_ingreso + "', fecha_salida='" + lote_en.fecha_salida + "', fk_tipo_especie=" + lote_en.fk_tipo_especie + " where id_lote=" + lote_en.id_lote + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Actualizar_Cantidad(Lote_EN lote_en)
        {

            Conexion_AD con = new Conexion_AD();
            String sql = "update lote set cantidad = cantidad - " + lote_en.cantidad + " where id_lote = " + lote_en.id_lote + " ;";
            return con.Ejecutar_DML(sql);
        }
        public int Actualizar_Cantidad_Rotacion(Lote_EN lote_en)
        {

            Conexion_AD con = new Conexion_AD();
            String sql = "update lote set cantidad = cantidad + " + lote_en.cantidad + " where id_lote = " + lote_en.id_lote2 + " ;";
            return con.Ejecutar_DML(sql);
        }

        public int Actividad_Produccion(Lote_EN lote_en)
        {

            Conexion_AD con = new Conexion_AD();
            String sql = "update lote set estado_lote = 0  where id_lote = " + lote_en.id_lote + " ;";
            return con.Ejecutar_DML(sql);
        }

        public DataTable Buscar_Lote(Lote_EN lote_en)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select * from  piscicola.lote where id_lote = " + lote_en.id_lote + " ; ";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Buscar(int id_lote)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select cantidad,fecha_ingreso,fecha_salida,fk_estanque,nombre_especie,estado_lote from  piscicola.lote inner join piscicola.tipo_especie on fk_tipo_especie = id_tipo_especie where id_lote = " + id_lote + " ; ";
            return con.Ejecutar_Consuta(sql);

        }

        public DataTable Listado_Lote()
        {
            Conexion_AD con = new Conexion_AD();
            DataTable dt = new DataTable();
            string sql = "select * from piscicola.lote";
            dt = con.Ejecutar_Consuta(sql);
            return dt;
        }
        public DataTable Consulta_lote()
        {
            Conexion_AD con = new Conexion_AD();
            DataTable dt = new DataTable();
            string sql = "SELECT id_lote AS Lote,cantidad AS Cantidad,fecha_ingreso AS Ingreso,fecha_salida AS Salida,fk_estanque AS Estanque ,nombre_especie AS Especie FROM  lote inner join tipo_especie on (id_tipo_especie=fk_tipo_especie)  inner join  estanque on (id_estanque=fk_estanque) where estado_lote=1;";
            dt = con.Ejecutar_Consuta(sql);
            return dt;
        }
        public DataTable Listado_Activos_Normal()
        {
            Conexion_AD con = new Conexion_AD();
            String sql = "select * from lote WHERE estado_lote = 1 ";
            return con.Ejecutar_Consuta(sql);
        }

        public DataTable Listado_Activos(int id_estanque)
        {
            Conexion_AD con = new Conexion_AD();
            String sql = "select id_lote from lote WHERE estado_lote = 1 AND fk_estanque=" + id_estanque + ";";
            return con.Ejecutar_Consuta(sql);
        }
        public DataTable lotes_activos_registrar_lote()
        {
            Conexion_AD con = new Conexion_AD();
            String sql = "SELECT lot.`id_lote`,lot.`cantidad`,lot.`fecha_ingreso`,lot.`fecha_salida`,lot.`fk_estanque`,lot.`fk_tipo_especie`,lot.`estado_lote` FROM lote lot INNER JOIN estanque est ON est.`id_estanque` = lot.`fk_estanque` INNER JOIN `tipo_especie` te ON te.`id_tipo_especie` = lot.`fk_tipo_especie`;";

            return con.Ejecutar_Consuta(sql);
        }
        public DataTable Listado_Lote_Activo()
        {
            Conexion_AD con = new Conexion_AD();
            String sql = "SELECT id_lote AS LOTE ,cantidad AS CANTIDAD,fecha_ingreso AS INGRESO, fecha_salida AS SALIDA,id_estanque AS ESTANQUE,nombre_especie AS ESPECIE FROM lote INNER JOIN tipo_especie ON id_tipo_especie= fk_tipo_especie INNER JOIN estanque ON id_estanque=fk_estanque WHERE estado_lote=1;";

            return con.Ejecutar_Consuta(sql);
        }
        public DataTable Listado_registro()
        {
            Conexion_AD con = new Conexion_AD();
            String sql = "SELECT id_lote AS LOTE ,cantidad AS CANTIDAD,fecha_ingreso AS INGRESO, fecha_salida AS SALIDA,id_estanque AS ESTANQUE,nombre_especie AS ESPECIE FROM lote INNER JOIN tipo_especie ON id_tipo_especie= fk_tipo_especie INNER JOIN estanque ON id_estanque=fk_estanque;";

            return con.Ejecutar_Consuta(sql);
        }

    }
}