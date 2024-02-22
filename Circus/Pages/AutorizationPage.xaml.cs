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
using Circus.DB;

namespace Circus.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public static List<Admin> admins { get; set; }
        public static List<Worker> workers { get; set; }
        public static List<AnimalTrainer> animalTrainers { get; set; }
        public static List<Artist> artists { get; set; }
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTB.Text.Trim();
            string password = PasswordTB.Password.Trim();

            workers = new List<Worker>(DBConnection.circussEntities.Worker.ToList());
            var currentWorker = workers.FirstOrDefault(i => i.Login.Trim() == login && i.Password.Trim() == password);
            DBConnection.loginedWorker = currentWorker;

            CircussEntities2 circussEntities = DBConnection.circussEntities;
            artists = new List<Artist>(circussEntities.Artist.ToList());
            var currentArtist = artists.FirstOrDefault(i => i.Login.Trim() == login && i.Password.Trim() == password);
            DBConnection.loginedArtist = currentArtist;

            animalTrainers = new List<AnimalTrainer>(DBConnection.circussEntities.AnimalTrainer.ToList());
            var currentAnimalTrainer = animalTrainers.FirstOrDefault(i => i.Login.Trim() == login && i.Password.Trim() == password);
            DBConnection.loginedAnimalTrainer = currentAnimalTrainer;

            admins = new List<Admin>(DBConnection.circussEntities.Admin.ToList());
            var currentAdmin = admins.FirstOrDefault(i => i.Login.Trim() == login && i.Password.Trim() == password);
            DBConnection.loginedAdmin = currentAdmin;

             if (currentWorker != null)
             {
                NavigationService.Navigate(new WorkerPage());
             }

            if (currentAdmin != null)
            {
                NavigationService.Navigate(new MainPage());
            }

            if (currentAnimalTrainer != null)
            {
                NavigationService.Navigate(new MainPage());
            }

            if (currentArtist != null)
            {
                NavigationService.Navigate(new MainPage());
            }

            else

            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");
            }
        }

        private void RegistrBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
