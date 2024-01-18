using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para ActualizarPlanta.xaml
    /// </summary>
    public partial class ActualizarPlanta : Window
    {
        Planta_Negocio.Planta planta;
        private static Regex s_regex = new Regex("[^0-9]+");
        public ActualizarPlanta(int id)
        {
            InitializeComponent();
            this.Title = string.Format("Actualizar planta {0}", id);

            planta = new Planta_Negocio.Planta();

            CargarFormulario(id);
            this.DataContext = planta;
        }

        private void ButtonActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (!planta.DatosValidos)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.");
                return;
            }

            bool response = planta.Update();

            if (response)
            {
                MessageBox.Show(string.Format("Planta {0} ha sido actualizado exitósamente!", planta.Id));
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("No fue posible actualizar la planta {0}", planta.Id));
                this.Close();
            }
        }

        private void CargarFormulario(int id)
        {
            bool response = planta.Read(id);
            if (!response)
            {
                MessageBox.Show(string.Format("La planta con ID {0} no fue encontrado.", id));
            }
            MessageBox.Show(string.Format("Modifique la planta con ID {0}.", id));
        }
        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
