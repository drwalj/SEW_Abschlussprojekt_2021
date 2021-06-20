using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class RechnungViewModel :INotifyPropertyChanged
    {
        public decimal betrag;
        public decimal Betrag
        {
            get
            {
                return betrag;
            }
            set
            {
                betrag = value;
                OnPropertyChanged("Betrag");
            }
        }

        public decimal restgeld;
        public decimal Restgeld
        {
            get
            {
                return restgeld;
            }
            set
            {
                restgeld = value;
                OnPropertyChanged("Restgeld");
            }
        }
        public ObservableCollection<Product> Swag { get; set; }  = new ObservableCollection<Product>() {};

        public decimal kosten;
        public decimal Kosten {
            get
            {
                return kosten;
            }
            set 
            {
                kosten = value;
                OnPropertyChanged("Kosten");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public IEnumerable<Zahlungsart> Enumbox { get; set; } = Enum.GetValues(typeof(Zahlungsart)).Cast<Zahlungsart>();

        public string server { get; set; } = "localhost";
        public string userid { get; set; } = "root";
        public string password { get; set; } = "newpassword";
        public string database { get; set; } = "drwal_projekt";



        public void Additem(string i)
        {
            string connectionstring = $"server={server};userid={userid};password={password};database={database}";
            var mysqlconnection = new MySqlConnection(connectionstring);
            mysqlconnection.Open();

            MySqlCommand cmd = mysqlconnection.CreateCommand();

            cmd.CommandType = CommandType.Text;
            var lyrics = "select preis from produkt where produktname = " + (char)34 + i + (char)34 + ";";
            cmd.CommandText = lyrics;
            MySqlDataReader rd = cmd.ExecuteReader(); 
            rd.Read();
            if (i == "Kaiserschmarren") { Swag.Add(new Kaiserschmarren((decimal)rd[0])); }
            else if (i == "Eistee") { Swag.Add(new Eistee((decimal)rd[0])); }
            else if (i == "Käseleberkäse Krapfen") { Swag.Add(new Käseleberkäsekrapfen((decimal)rd[0])); }
            else if (i == "Chicken Nuggets"){ Swag.Add(new Chickennuggets((decimal)rd[0])); }
            else if (i == "Fried Chicken") { Swag.Add(new Friedchicken((decimal)rd[0])); }
            else if (i == "Tiramisu") { Swag.Add(new Tiramisu((decimal)rd[0])); }
            else if (i == "Wein") { Swag.Add(new Wein((decimal)rd[0])); }
            else if (i == "Choccy Milk") { Swag.Add(new Choccymilk((decimal)rd[0])); }
            else { Swag.Add(new Icecream((decimal)rd[0])); }

            Kosten = 0M;
            foreach (var j in Swag)
            {
                Kosten += j.Price;
            }
        }
    }
}
