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

namespace CinemaProject
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public string Email{ get; set; }
        public string Password{ get; set; }
        List<User> users = new List<User> {
        new User{Email="Ayko@gmail.com",Password="12345",Name="Ayxan",Surname="Axundov",Username="Ayxan1"},
        new User{Email="Zaur@gmail.com",Password="123456",Name="Zaur",Surname="Ceferov",Username="ZaurCfr"},
        new User{Email="Mishqa@gmail.com",Password="1234567",Name="Semi",Surname="Axundov",Username="SemiAxu"},
        new User{Email="Emin@gmail.com",Password="12345678",Name="Emin",Surname="Quluzade",Username="Emo"},
        };
        public int count = 0;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in users)
            {
                if (item.Password==PassBox.Password && item.Email== EmailTxtBox.Text)
                {
                MessageBox.Show("Succesufully log inned!");
                    break;
                }
                    count++;
                
               
            }
            if (count>users.Count)
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

            SignUpPage signUp = new SignUpPage();
            loginGrid.Visibility = Visibility.Hidden;
            signUp.Visibility = Visibility.Visible;
            signup.Navigate(signUp);


        }
    }
}
