using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Capa_Acceso_Datos
{
    public class vistas
    {
        public DataTable Listar_Calcular_Alimentacion()
        {


            Conexion_AD con = new Conexion_AD();
            string sql = " select * from calcular_alimentacion_semana_actual;";
            return con.Ejecutar_Consuta(sql);
        }

        public DataTable Listar_Calcular_Alimentacion_id(int id_estanque)
        {
            Conexion_AD con = new Conexion_AD();
            string sql = " select estanque AS ESTANQUE,id_lote AS LOTE,nombre_especie AS ESPECIE,cantidad AS CANTIDAD,semanas_transcurridas AS SEMANA,  total_diario AS ALIMENTACION  from calcular_alimentacion_semana_actual  where estanque="+id_estanque+";";
            return con.Ejecutar_Consuta(sql);
        }
    }
}
