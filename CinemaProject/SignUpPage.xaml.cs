using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void ImageChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                User user = new User();
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                     user.ImagePath= openFileDialog.FileName;
                    ImageBrush imageBrush = new ImageBrush();
                    Uri imageUri = new Uri(user.ImagePath, UriKind.Relative);
                    BitmapImage imageBitmap = new BitmapImage(imageUri);
                    imageBrush.ImageSource = imageBitmap;
                    UserPhoto.ImageSource = imageBrush.ImageSource;
                }
            }
        }

        

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            //ver
            
        }
    }
}
