using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entidades;

namespace Capa_Acceso_Datos
{
    public class Ciclo_Vida_AD
    {
        public int Registra_Ciclo_Vida(Ciclo_Vida_EN ciclo_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "insert into ciclo_vida(id_ciclo_vida,semana,consumo_diario,consumo_semanal,biomasa,peso_min,peso_max,fk_tipo_especie,fk_tipo_alimentacion)values (" + ciclo_en.id_ciclo_vida + "," + ciclo_en.semana + "," + ciclo_en.consumo_diario + "," + ciclo_en.consumo_semanal + "," + ciclo_en.biomasa + "," + ciclo_en.peso_min + ", " + ciclo_en.peso_max + ", " + ciclo_en.tipo_especie + " , " + ciclo_en.tipo_alimentacion + ")";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public int Eliminar_Ciclo_Vida(Ciclo_Vida_EN ciclo_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "Delete from ciclo_vida where id_ciclo_vida= " + ciclo_en.id_ciclo_vida + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }

        public int Actualizar_Ciclo_Vida(Ciclo_Vida_EN ciclo_en)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "update ciclo_vida set semana=" + ciclo_en.semana + ", consumo_diario=" + ciclo_en.consumo_diario + ", consumo_semanal=" + ciclo_en.consumo_semanal + ", biomasa=" + ciclo_en.biomasa + ", peso_min=" + ciclo_en.peso_min + ", peso_max=" + ciclo_en.peso_max + ", fk_tipo_especie=" + ciclo_en.tipo_especie + ", fk_tipo_alimentacion=" + ciclo_en.tipo_alimentacion + " where id_ciclo_vida=" + ciclo_en.id_ciclo_vida + ";";
            int res = con.Ejecutar_DML(sql);
            return res;
        }


        public DataTable Buscar_Ciclo_Vida(Ciclo_Vida_EN ciclo_en)
        {
            Conexion_AD con = new Conexion_AD();

            string sql = "select * from  piscicola.ciclo_vida where id_ciclo_vida = " + ciclo_en.id_ciclo_vida + "";
            return con.Ejecutar_Consuta(sql);
        }
        public DataTable Buscar(int id_ciclo)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select id_ciclo_vida,semana,consumo_diario,consumo_semanal,biomasa,peso_min,peso_max,fk_tipo_especie,fk_tipo_alimentacion from  ciclo_vida where id_ciclo_vida = " + id_ciclo + " ";
            return con.Ejecutar_Consuta(sql);
        }

        public DataTable Listado_Ciclo_Vida()
        {
            Conexion_AD con = new Conexion_AD();
            string sql = "select id_ciclo_vida AS CICLO,semana AS SEMANA ,consumo_diario AS DIARIO,consumo_semanal AS SEMANAL,biomasa AS BIOMASA,peso_min AS MINIMO,peso_max AS MAXIMO,fk_tipo_especie AS ESPECIE ,nombre_alimentacion AS ALIMENTACION from ciclo_vida inner join tipo_alimentacion ON id_tipo_alimentacion=fk_tipo_alimentacion";
            return con.Ejecutar_Consuta(sql);
        }
    }
}
