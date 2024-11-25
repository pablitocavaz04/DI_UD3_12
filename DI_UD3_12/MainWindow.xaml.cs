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

namespace DI_UD3_12
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /* EJERCICIO 1
        private int attempts = 0;
        private const int MaxAttempts = 2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CorrectButton_Click(object sender, RoutedEventArgs e)
        {
            if (attempts >= MaxAttempts)
            {
                MessageBox.Show("No te quedan intentos.");
                return;
            }

            attempts++;
            if (Option2.IsChecked == true)
            {
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta.");
            }

            AttemptsLabel.Content = $"Intentos: {attempts}/{MaxAttempts}";
        }*/

        /* EJERCICIO 3
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Password;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Inicio de sesión exitoso.");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }*/
        /*EJERCICIO 4
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
            string password = PasswordBox.Password;
            if (password.Length <= 6)
            {
                MessageBox.Show("La contraseña debe tener más de 6 caracteres.");
                return;
            }

            string level = LowSecurity.IsChecked == true ? "Bajo" :
                           MediumSecurity.IsChecked == true ? "Medio" : "Alto";

            MessageBox.Show($"Nivel de seguridad seleccionado: {level}\nContraseña: {password}");
        }*/
        /*EJERCICIO 5
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            string password = PasswordBox.Password;

            if (password != "1234")
            {
                MessageBox.Show("Contraseña incorrecta.");
                return;
            }

            string method = CreditCard.IsChecked == true ? "Tarjeta de Crédito" :
                            PayPal.IsChecked == true ? "PayPal" : "Transferencia";

            MessageBox.Show($"Pago realizado con éxito usando {method}.");
        }*/
    }
}
