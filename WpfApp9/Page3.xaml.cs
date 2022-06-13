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

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void voity_Click(object sender, RoutedEventArgs e)
        {
            var db = new vlad_kEntities();
            var Users = db.Users.Where ((user) => user.Login == Login.Text && user.Password == Password.Password).ToList();
            if(Users.Count > 0)
            {
                Console.WriteLine(db.UserType.Find( Users[0].Type).name);
                if(Users[0].Type == 2)
                {
                    NavigationService.Navigate(new ForAdministrator(Users[0]));
                }
                else if (Users[0].Type == 1)
                {
                    NavigationService.Navigate(new login_i_parol(Users[0]));
                }
            }
            else
            {
                MessageBox.Show("User is not found");
            }
        }
    }
}
