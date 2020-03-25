using Pausenmodell;
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

namespace Pausenmodellneu
{
    /// <summary>
    /// Interaktionslogik für Lehrer.xaml
    /// </summary>
    public partial class Lehrer : Page
    {
        public DB_Connection dbConnection;
        public Lehrer()
        {
            InitializeComponent();
            /*
            dbConnection = new DB_Connection("localhost", "pausenmodell", "root", "");
            for (int i = 0; i < 100; i++)
            {         
            List<string> matrikelnummern = dbConnection.GetColumn("SELECT S_Matrikelnummer,S_Passwort FROM tbl_schueler;", 0);
            List<string> namen = dbConnection.GetColumn("SELECT S_Name,S_Passwort FROM tbl_schueler;", 0);
            List<string> vornamen = dbConnection.GetColumn("SELECT S_Vorname,S_Passwort FROM tbl_schueler;", 0);
            List<string> klassen = dbConnection.GetColumn("SELECT S_Klasse,S_Passwort FROM tbl_schueler;", 0);
            List<string> pausen = dbConnection.GetColumn("SELECT P_Pause,S_Passwort FROM tbl_schueler;", 0);
            List<string> respausenzeiten = dbConnection.GetColumn("SELECT P_Restpausenzeit,S_Passwort FROM tbl_schueler;", 0);
            List<string> aufenthaltsorte = dbConnection.GetColumn("SELECT P_Aufenthaltsortr,S_Passwort FROM tbl_schueler;", 0);
            List<Schueler> items = new List<Schueler>();
            items.Add(new Schueler() { Matrikelnummer = matrikelnummern, Name = namen, Vorname= vornamen , Klasse = klassen, Restpausen = pausen, Restpausenzeit = respausenzeiten, Aufenthaltsort = aufenthaltsorte });
                if (matrikelnummern.Count < i)
                {

                }
            lSchueler.ItemsSource = items;
            }
            */
        }

        


        private void Suchen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
