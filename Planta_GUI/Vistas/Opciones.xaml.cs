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
    /// Lógica de interacción para Opciones.xaml
    /// </summary>
    public partial class Opciones : Window
    {
        public Opciones()
        {
            InitializeComponent();
        }
        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            Vistas.AgregarPlanta agregarPlanta = new Vistas.AgregarPlanta();
            agregarPlanta.ShowDialog();
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            Vistas.ListarPlantas listarPlantas = new Vistas.ListarPlantas();
            listarPlantas.ShowDialog();
        }
    }
}
