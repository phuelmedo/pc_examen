using Planta_Negocio;
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
    /// Lógica de interacción para AgregarPlanta.xaml
    /// </summary>
    public partial class AgregarPlanta : Window
    {
        private static Regex s_regex = new Regex("[^0-9]+");
        Planta_Negocio.Planta planta;
        public AgregarPlanta()
        {
            InitializeComponent();
            planta = new Planta_Negocio.Planta();
            this.DataContext = planta;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bool response = planta.Create();

                if (response)
                {
                    MessageBox.Show("Planta fue agregada correctamente");
                    AgregarOtraPlanta();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intentelo más tarde");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
        private void AgregarOtraPlanta()
        {
            string title = "Agregar nueva planta";
            string message = "¿Desea agregar nueva planta?";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if (result == MessageBoxResult.No)
            {
                this.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtNombreComun.Text = string.Empty;
            txtNombreCientifico.Text = string.Empty;
            txtTipoPlanta.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtTiempoRiego.Text = string.Empty;
            txtCantidadAgua.Text = string.Empty;
            txtEpoca.Text = string.Empty;
            chkEsVenenosa.IsChecked = false;
            chkEsAuctoctona.IsChecked = false;
        }
    }
}
