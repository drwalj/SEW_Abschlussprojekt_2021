using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace Drwal_Projekt
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Chicken Nuggets");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            restgeldblock.Text = "";
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Kosten = 0M;
            n.Swag.Clear();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Swag.Remove((Product)datengrid.SelectedItem);
            n.Kosten = 0M;
            foreach (var j in n.Swag)
            {
                n.Kosten += j.Price;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Käseleberkäse Krapfen");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Fried Chicken");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Kaiserschmarren");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Eistee");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Tiramisu");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Ice Cream");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Wein");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            n.Additem("Choccy Milk");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;
            if (combobox.Text == "Karte") { n.Betrag = n.Kosten; n.Restgeld = n.Betrag - n.Kosten; n.Betrag = n.Kosten; }
            else if (combobox.Text == "Bar") { n.Betrag = decimal.Parse(betragbox.Text); n.Restgeld = n.Betrag - n.Kosten; }
            else { MessageBox.Show("Zahlungsart auswählen!"); }

            if (n.Betrag < n.Kosten) { MessageBox.Show("Kunde muss mehr zahlen!"); }

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            var n = (RechnungViewModel)Ganzesgrid.DataContext;

            if (combobox.Text == "Karte")
            {
                n.Betrag = n.Kosten;
            }

            if (n.Kosten > n.Betrag || combobox.Text == ""){ MessageBox.Show("Betrag muss Stimmen und Zahlungsart muss ausgewählt sein!");}
            else
            {
                string connectionstring = $"server={n.server};userid={n.userid};password={n.password};database={n.database}";
                var mysqlconnection = new MySqlConnection(connectionstring);
                mysqlconnection.Open();

                MySqlCommand cmd = mysqlconnection.CreateCommand();

                cmd.CommandType = CommandType.Text;
                var lyrics = $"INSERT INTO rechnung (zahlungsart, total) VALUES('{combobox.Text}','{n.Kosten}'); ";
                cmd.CommandText = lyrics;
                cmd.Connection = mysqlconnection;
                int cheq = cmd.ExecuteNonQuery();
                if (cheq == 1)
                {
                    MessageBox.Show("Daten gespeichert.");

                }
                else
                {
                    MessageBox.Show("Daten fehler.");
                }
            }
        }

    }
}