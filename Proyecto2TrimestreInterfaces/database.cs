using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2TrimestreInterfaces
{
    class database
    {
        // definimos conexion
        public static MySqlConnection conexion =
            new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind");

        public static List<String> obtenerCategorias()
        {
            conexion.Open();
            List<String> list = new List<String>();
            String consulta = "SELECT CategoryName FROM categories;";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta, conexion);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                list.Add(mySqlDataReader.GetString(0));
            }
            conexion.Close();
            return list;
        }
        /* 
         public static List<String> ObtenerProductos()
        {
            conexion.Open();
            List<String> listaProductos = new List<String>();
            String consulta = "SELECT * FROM products;"; // Reemplaza "productos" con el nombre real de tu tabla

            MySqlCommand mySqlCommand = new MySqlCommand(consulta, conexion);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                Producto producto = new Producto
                {
                    ProductoID = mySqlDataReader.GetInt32(0),  // Reemplaza con el índice correcto según la estructura de tu tabla
                    Nombre = mySqlDataReader.GetString(1),    // Reemplaza con el índice correcto según la estructura de tu tabla
                    Precio = mySqlDataReader.GetDecimal(2)    // Reemplaza con el índice correcto según la estructura de tu tabla
                                                              // Agrega otras propiedades según la estructura de tu tabla
                };

                listaProductos.Add(producto);
            }

            conexion.Close();
            return listaProductos;
        }
         */
    }
}
