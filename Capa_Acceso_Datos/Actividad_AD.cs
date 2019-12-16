using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;

namespace Capa_Acceso_Datos
{
    public class Actividad_AD
    {
        public int Registra_Actividad(Actividad_EN acti_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into actividad(id_actividad,foto,cantidad,descripcion,fecha,fk_estanque,fk_persona,fk_tipo_actividad,lote)values (" + acti_en.Id_actividad + "," + acti_en.foto + "," + acti_en.cantidad + ",'" + acti_en.descripcion + "','" + acti_en.fecha + "'," + acti_en.fk_estanque + ", " + acti_en.fk_persona + ", " + acti_en.fk_tipo_actividad + " , "+acti_en.lote+")";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Registra_Actividad2(Actividad_EN acti_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into actividad(id_actividad,foto,cantidad,descripcion,fecha,fk_estanque,fk_persona,fk_tipo_actividad,lote)values (" + acti_en.Id_actividad + "," + acti_en.foto + "," + acti_en.cantidad + ",'" + acti_en.descripcion + "','" + acti_en.fecha + "'," + acti_en.fk_estanque + ", " + acti_en.fk_persona + ", " + acti_en.fk_tipo_actividad + " , " + acti_en.lote2 + ")";
            int res = con.Ejecutar_DML(sql);
            return res;
        }


        public int Eliminar_Actividad(Actividad_EN acti_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from actividad where id_actividad=" + acti_en.Id_actividad + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Actualizar_Actividad(Actividad_EN acti_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update actividad set foto=" + acti_en.foto + ", cantidad=" + acti_en.cantidad + ", descripcion='" + acti_en.descripcion + "', fecha='" + acti_en.fecha + "', fk_estanque=" + acti_en.fk_estanque + ",  fk_persona=" + acti_en.fk_persona + ", fk_tipo_actividad=" + acti_en.fk_tipo_actividad + " where id_actividad=" + acti_en.Id_actividad + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public DataTable Buscar_Actividad(Actividad_EN acti_en)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select * from  piscicola.actividad where id_actividad = " + acti_en.Id_actividad + "";
            return con.Ejecutar_Consuta(sql);

        }


        public DataTable Listado_Actividad()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from actividad";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Alimentacion()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select  nombre as NOMBRE, fecha as FECHA, cantidad as CANTIDAD,descripcion as DESCRIPCION, fk_estanque as ESTANQUE , lote as LOTE from actividad inner join persona on id_persona = fk_persona  where fk_tipo_actividad =5;";
            return con.Ejecutar_Consuta(sql);

        }

        public DataTable Listado_Mortalidad()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select  nombre as NOMBRE, fecha as FECHA, cantidad as CANTIDAD,descripcion as DESCRIPCION, fk_estanque as ESTANQUE , lote as LOTE from actividad inner join persona on id_persona = fk_persona  where fk_tipo_actividad =3 ;";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Mortalidad_Lote(int id_lote)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select  nombre as NOMBRE, fecha as FECHA, cantidad as CANTIDAD,descripcion as DESCRIPCION, fk_estanque as ESTANQUE , lote as LOTE from actividad inner join persona on id_persona = fk_persona  where fk_tipo_actividad =3 AND lote=" + id_lote + ";";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Rotacion()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select  nombre as NOMBRE, fecha as FECHA, cantidad as CANTIDAD,descripcion as DESCRIPCION, fk_estanque as ESTANQUE , lote as LOTE from actividad inner join persona on id_persona = fk_persona  where fk_tipo_actividad =2;";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Muestreo()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select  nombre as NOMBRE, fecha as FECHA, cantidad as CANTIDAD,descripcion as DESCRIPCION, fk_estanque as ESTANQUE , LOTE as LOTE from actividad inner join persona on id_persona = fk_persona  where fk_tipo_actividad =1;";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Pesca()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select  nombre as NOMBRE, fecha as FECHA, cantidad as CANTIDAD,descripcion as DESCRIPCION, fk_estanque as ESTANQUE , LOTE as LOTE from actividad inner join persona on id_persona = fk_persona  where fk_tipo_actividad =4;";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Produccion()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "SELECT  nombre AS NOMBRE,fecha AS FECHA,cantidad AS CANTIDAD,descripcion AS DESCRIPCION,lote AS LOTE, 'Inactivo' AS ESTADO FROM  actividad INNER JOIN persona ON (fk_persona=id_persona)  WHERE fk_tipo_actividad=6";
            return con.Ejecutar_Consuta(sql);

        }

        public List<Actividad_EN> Listar_mortalidad_fecha()
        {
            Conexion_AD con = new Conexion_AD();
            String sql = "SELECT `fk_estanque` AS ESTANQUE,t.nombre_actividad, LOTE AS LOTE, fecha AS FECHA, cantidad AS CANTIDAD, per.`nombre` FROM actividad act INNER JOIN `persona` per ON per.`id_persona` = act.`fk_persona`inner join tipo_actividad t on t.id_tipo_actividad = act.fk_tipo_actividad  WHERE fecha = CURDATE()";

            Actividad_EN act_en = new Actividad_EN();

            DataTable dt = new DataTable();
            dt = con.Ejecutar_Consuta(sql);
            Actividad_EN dato;
            List<Actividad_EN> lista = new List<Actividad_EN>();
            foreach (DataRow row in dt.Rows)
            {
                dato = new Actividad_EN();
                dato.cantidad = Convert.ToInt32(row["CANTIDAD"]);
                dato.lote = Convert.ToInt32(row["LOTE"]);
                dato.descripcion = row["nombre"].ToString();
                dato.tipo = row["nombre_actividad"].ToString();
                lista.Add(dato);
            }
            return lista;
        }
    }
}