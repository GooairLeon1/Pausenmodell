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

namespace Pausenmodell
{
    /// <summary>
    /// Interaktionslogik für LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public DB_Connection dbConnection;


        public LoginScreen()
        {
            InitializeComponent();
            dbConnection = new DB_Connection("localhost", "pausenmodell", "root", "");
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            dbConnection.Open();
            List<string> matrikelnummern = dbConnection.GetColumn("SELECT S_Matrikelnummer FROM tbl_schueler;", 0);
            List<string> passwoerter = dbConnection.GetColumn("SELECT S_Passwort FROM tbl_schueler;", 0);
            List<string> lkuerzel = dbConnection.GetColumn("SELECT L_Kuerzel FROM tbl_lehrer;", 0);
            List<string> lpasswoerter = dbConnection.GetColumn("SELECT L_Passwort FROM tbl_lehrer;", 0);

            
            if (Int64.TryParse(txtMatrikelnummer.Text, out long l))
            {
                for (int i = 0; i < matrikelnummern.Count; i++)
                {
                    if (matrikelnummern[i] == txtMatrikelnummer.Text && passwoerter[i] == txtPasswort.Password)
                    {
                        loginSchueler(matrikelnummern[i]);
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < lkuerzel.Count; i++)
                {
                    if (lkuerzel[i] == txtMatrikelnummer.Text && lpasswoerter[i] == txtPasswort.Password)
                    {
                        loginLehrer(lkuerzel[i]);
                        return;
                    }
                }
            }
 


            MessageBox.Show("Matrikelnummer oder Passwort falsch", "Fehler");
        }

        private void loginSchueler(string matrikelnummer)
        {
            
            MessageBox.Show("Schueler");
        }

        private void loginLehrer(string kuerzel)
        {
            MessageBox.Show("Lehrer");
        }

    }
}
