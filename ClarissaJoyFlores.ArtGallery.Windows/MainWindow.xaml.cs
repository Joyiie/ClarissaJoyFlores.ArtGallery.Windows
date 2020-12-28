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
using ClarissaJoyFlores.ArtGallery.Windows.DAL;



namespace ClarissaJoyFlores.ArtGallery.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            ArtGalleryDbContext context = new ArtGalleryDbContext();

            var user = context.Users.FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show(user.Email);
            }

        }

        private void btnArtist_Click(object sender, RoutedEventArgs e)
        {
            Artists.ArtistList listWindow = new Artists.ArtistList();
            listWindow.Show();
        }

        private void btnArtwork_Click(object sender, RoutedEventArgs e)
        {
            Artworks.ArtworkList listWindow = new Artworks.ArtworkList();
            listWindow.Show();
        }

        private void btnUsers1_Click(object sender, RoutedEventArgs e)
        {
            Users.UsersList listWindow = new Users.UsersList();
            listWindow.Show();
        }
    }
}
