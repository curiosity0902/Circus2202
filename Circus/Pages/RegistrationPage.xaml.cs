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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public static List<Admin> admins { get; set; }
        public static List<Worker> workers { get; set; }
        public static List<AnimalTrainer> animalTrainers { get; set; }
        public static List<Artist> artists { get; set; }

        public static Worker worker = new Worker();
        public static Artist artist = new Artist();
        public static AnimalTrainer animalTrainer = new AnimalTrainer();
        public static Admin admin = new Admin();

        public RegistrationPage()
        {
            InitializeComponent();
            workers = DBConnection.circussEntities.Worker.ToList();
            artists = DBConnection.circussEntities.Artist.ToList();
            animalTrainers = DBConnection.circussEntities.AnimalTrainer.ToList();
            admins = DBConnection.circussEntities.Admin.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SurnameTB.Text) || string.IsNullOrWhiteSpace(NameTB.Text) || string.IsNullOrWhiteSpace(PatronymicTB.Text)
                    || string.IsNullOrWhiteSpace(EmailTB.Text) || string.IsNullOrWhiteSpace(PasswordTB.Text) || DateOfBirthDP.SelectedDate == null)
            {
                if (PositionCB.SelectedIndex == 0)
                {
                    admin.Surname = SurnameTB.Text.Trim();
                    admin.Name = NameTB.Text.Trim();
                    admin.Patronymic = PatronymicTB.Text.Trim();
                    admin.DateOfBirth = DateOfBirthDP.SelectedDate;
                    admin.Login = EmailTB.Text.Trim();
                    admin.Password = PasswordTB.Text.Trim();
                    var a = PositionCB.SelectedItem as Role;
                    admin.IDRole = a.IDRole;

                    DBConnection.circussEntities.Admin.Add(admin);
                    DBConnection.circussEntities.SaveChanges();
                    NavigationService.Navigate(new WorkerPage());
                }

                 if (PositionCB.SelectedIndex == 1)
                 {
                    artist.Surname = SurnameTB.Text.Trim();
                    artist.Name = NameTB.Text.Trim();
                    artist.Patronymic = PatronymicTB.Text.Trim();
                    artist.DateOfBirth = DateOfBirthDP.SelectedDate;
                    artist.Login = EmailTB.Text.Trim();
                    artist.Password = PasswordTB.Text.Trim();
                    var a = PositionCB.SelectedItem as Role;
                    artist.IDRole = a.IDRole;


                    DBConnection.circussEntities.Artist.Add(artist);
                    DBConnection.circussEntities.SaveChanges();
                    NavigationService.Navigate(new WorkerPage());
                 }

                if (PositionCB.SelectedIndex == 2)
                {
                    animalTrainer.Surname = SurnameTB.Text.Trim();
                    animalTrainer.Name = NameTB.Text.Trim();
                    animalTrainer.Patronymic = PatronymicTB.Text.Trim();
                    animalTrainer.DateOfBirth = DateOfBirthDP.SelectedDate;
                    animalTrainer.Login = EmailTB.Text.Trim();
                    animalTrainer.Password = PasswordTB.Text.Trim();
                    var a = PositionCB.SelectedItem as Role;
                    animalTrainer.IDRole = a.IDRole;


                    DBConnection.circussEntities.AnimalTrainer.Add(animalTrainer);
                    DBConnection.circussEntities.SaveChanges();
                    NavigationService.Navigate(new WorkerPage());
                }

                if (PositionCB.SelectedIndex == 3)
                {
                    worker.Surname = SurnameTB.Text.Trim();
                    worker.Name = NameTB.Text.Trim();
                    worker.Patronymic = PatronymicTB.Text.Trim();
                    worker.DateOfBirth = DateOfBirthDP.SelectedDate;
                    worker.Login = EmailTB.Text.Trim();
                    worker.Password = PasswordTB.Text.Trim();
                    var a = PositionCB.SelectedItem as Role;
                    worker.IDRole = a.IDRole;


                    DBConnection.circussEntities.Worker.Add(worker);
                    DBConnection.circussEntities.SaveChanges();
                    NavigationService.Navigate(new WorkerPage());
                }
            }
        }
    }
}
