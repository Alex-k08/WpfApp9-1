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
    /// Логика взаимодействия для ForAdministrator.xaml
    /// </summary>
    public partial class ForAdministrator : Page
    {
        private Users user;
        public ForAdministrator(Users user)
        {
            this.user = user;
            InitializeComponent();
            dannie.Content = $"Login: {user.Login} Password: {user.Password}";
        }
    }
}
