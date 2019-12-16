using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;

namespace Capa_Acceso_Datos
{
    public class Persona_AD
    {
        public int Registra_Persona(Persona_EN pers)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into persona(id_persona,nombre,telefono,login,pasword,estado_pers,fk_rol)values (" + pers.Id_persona + ",'" + pers.Nombre + "','" + pers.Telefono + "','" + pers.Login + "','" + pers.Password + "'," + pers.Rol + "," + pers.Estado_persona + ")";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public int Eliminar_Persona(Persona_EN pers)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from persona where Id_persona= " + pers.Id_persona + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Actualizar_Persona(Persona_EN pers)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update persona set nombre= '" + pers.Nombre + "',telefono = " + pers.Telefono + ",login= '" + pers.Login + "',pasword='" + pers.Password + "' where Id_persona= " + pers.Id_persona + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Habilitar_Persona(Persona_EN pers)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update persona set estado_pers=1  where Id_persona= " + pers.Id_persona + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }
        public int Deshabilitar_Persona(Persona_EN pers)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update persona set estado_pers= 0  where Id_persona= " + pers.Id_persona + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public DataTable Buscar_persona_Id(Persona_EN pers)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select * from  piscicola.persona where id_persona = " + pers.Id_persona + "";
            return con.Ejecutar_Consuta(sql);

        }

        public DataTable Listado_Persona()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from persona";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Adminstrador()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "SELECT id_persona AS CEDULA,nombre AS NOMBRE,telefono AS TELEFONO,nombre_rol AS ROL,login AS USUARIO, 'Activo'  AS ESTADO FROM  persona inner join rol on (id_rol=fk_rol) where fk_rol=1 AND estado_pers =1;";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Operario()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "SELECT id_persona AS CEDULA,nombre AS NOMBRE,telefono AS TELEFONO,nombre_rol AS ROL,login AS USUARIO, 'Activo'  AS ESTADO FROM  persona inner join rol on (id_rol=fk_rol) where fk_rol=2 AND estado_pers =1;";
            return con.Ejecutar_Consuta(sql);

        }
        public DataTable Listado_Inactivo()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "SELECT id_persona AS CEDULA,nombre AS NOMBRE,telefono AS TELEFONO,nombre_rol AS ROL,login AS USUARIO, 'Inactivo'  AS ESTADO FROM  persona inner join rol on (id_rol=fk_rol) where estado_pers =0;";
            return con.Ejecutar_Consuta(sql);

        }

        public DataTable Validar_Persona(Persona_EN pers)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select * from persona where login= '" + pers.Login + "' and pasword= '" + pers.Password + "'; ";
            return con.Ejecutar_Consuta(sql);
        }

    }
}
