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

namespace Gabinett
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        // Logowanie do apliakcji
        private void Zaloguj_Click(object sender, RoutedEventArgs e)
        {
            string uzytkownik = this.nick.Text;
            string haslo = this.password.Password;

            if (SprawdzNazweiHaslo(uzytkownik, haslo))
            {
                logowanie.Hide();
                Pacjenci fr = new Pacjenci();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło", "Błąd logowania");
                return;
            }
        }
        //funkcja która sprawdza poprawonosc hasła 
        public bool SprawdzNazweiHaslo(string uzytkownik, string haslo)
        {
            if (uzytkownik == "Marcin" & haslo == "marcin")
                return true;
            else
                return false;

        }


    }
}