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
using System.Windows.Shapes;

namespace Planta_GUI.Vistas
{
    /// <summary>
    /// Lógica de interacción para ListarPlantas.xaml
    /// </summary>
    public partial class ListarPlantas : Window
    {
        Planta_Negocio.PlantaCollection plantaCollection;
        public ListarPlantas()
        {
            InitializeComponent();
            CargarGrilla();
        }
        private void ModificarButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ListViewItem item = FindParent<ListViewItem>(button);

            if (item != null)
            {
                lvPlantas.SelectedItem = item.Content;

                var filaSeleccionada = (Planta_Negocio.Planta)lvPlantas.SelectedItem;
                ActualizarPlanta modificarPlanta = new ActualizarPlanta(filaSeleccionada.Id);
                modificarPlanta.ShowDialog();
                CargarGrilla();
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ListViewItem item = FindParent<ListViewItem>(button);
            if (item != null)
            {
                lvPlantas.SelectedItem = item.Content;
                EliminarRegistroSeleccionado();
            }
        }
        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            plantaCollection = new Planta_Negocio.PlantaCollection();
            lvPlantas.ItemsSource = plantaCollection.ReadAll();
        }
        private void EliminarRegistroSeleccionado()
        {
            var filaSeleccionada = (Planta_Negocio.Planta)lvPlantas.SelectedItem;
            int id = filaSeleccionada.Id;
            string title = "Eliminar planta";
            string message = string.Format("Estás seguro de eliminar la planta {0}", id);

            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if (result == MessageBoxResult.Yes)
            {
                var res = filaSeleccionada.Delete(id) ?
                    MessageBox.Show(string.Format("Planta {0} eliminado", id)) :
                    MessageBox.Show("Planta no pudo ser eliminado");
                CargarGrilla();
            }
        }
        private static T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentObj = VisualTreeHelper.GetParent(child);
            if (parentObj == null) return null;

            if (parentObj is T parent)
            {
                return parent;
            }

            return FindParent<T>(parentObj);
        }
    }
}
