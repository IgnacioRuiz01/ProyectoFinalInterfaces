using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto2TrimestreInterfaces
{
    /// <summary>
    /// Lógica de interacción para PorductsPage.xaml
    /// </summary>
    public partial class PorductsPage : Page
    {
        public PorductsPage()
        {
            InitializeComponent();
            agregarElementos();
            LlenarDataGridPorDefecto();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void agregarElementos()
        {
            List<String> categoriasBD = database.obtenerCategorias();
            foreach (string elemento in categoriasBD)
            {
                btnSelect.Items.Add(elemento);
            }
        }

        private void LlenarDataGridPorDefecto()
        {
            try
            {
                // Obtener los productos desde la base de datos
                List<String> productos = database.ObtenerProductos();

                // Asignar la lista de productos al ItemSource del DataGrid
                tabla.ItemsSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el DataGrid: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
