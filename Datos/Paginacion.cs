using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_ventas.Datos
{
    class Paginacion
    {
        public string table;               //Tabla de la cual se hará paginación
        public string order_by;            //Especifica el nombre por el cual se ordenarán los registros
        public int pages;                  //Numero total de páginas
        public int actual_page = 0;        //Página actual
        public int rows_per_page = 10;     //Cantidad de registros por página

        /// <summary>
        /// Calcula la cantidad de paginas
        /// </summary>
        public void CalculatePages()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand command = new SqlCommand("select count(*) from " + table, conexion);
                    var rows = command.ExecuteScalar();
                    conexion.Close();
                    pages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(rows) / rows_per_page));
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("La tabla no existe. \n" + ex.Message);
            }
        }
        /// <summary>
        /// Obtiene la página siguiente
        /// <returns> DataTable con los registros de la tabla</returns>
        public DataTable getNextPage()
        {
            DataTable dt = new DataTable();
            if (actual_page < pages)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        actual_page += 1; //Incrementa la página actual
                        string txt_sql = "select * from " + table + " order by '" + order_by + "' offset (@page-1)*@rows_per_page rows fetch next @rows_per_page rows only";
                        SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                        adapter.SelectCommand.Parameters.AddWithValue("@page", actual_page);
                        adapter.SelectCommand.Parameters.AddWithValue("@rows_per_page", rows_per_page);
                        adapter.Fill(dt);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error con la BD. \n" + ex.Message);
                }
            }
            return dt;
        }

        /// <summary>
        /// Obtiene la página anterior
        /// </summary>
        /// <returns> DataTable con los registros de la tabla</returns>
        public DataTable getPreviousPage()
        {
            DataTable dt = new DataTable();
            if (actual_page > 1)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        actual_page -= 1;
                        string txt_sql = "select * from " + table + " order by '" + order_by + "' offset (@page-1)*@rows_per_page rows fetch next @rows_per_page rows only";
                        SqlDataAdapter adapter = new SqlDataAdapter(txt_sql, conexion);
                        adapter.SelectCommand.Parameters.AddWithValue("@page", actual_page);
                        adapter.SelectCommand.Parameters.AddWithValue("@rows_per_page", rows_per_page);
                        adapter.Fill(dt);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error con la BD. \n" + ex.Message);
                }
            }
            return dt;
        }


    }
}
