using Planta_GUI.Vistas;
using Planta_Negocio;
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

namespace Planta_GUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Planta_Negocio.Planta login;
        public MainWindow()
        {
            InitializeComponent();
            login = new Planta();
            this.DataContext = login;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                bool response = login.ReadUser(username, password);

                if (response)
                {
                    MessageBox.Show($"Bienvenido {username}");
                    Opciones opcion = new Opciones();
                    opcion.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username o password incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
