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
using ClarissaJoyFlores.ArtGallery.Windows.Helpers;

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

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
        }

       

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            ProgramUser.Id = null;
            ProgramUser.FirstName = null;
            ProgramUser.LastName = null;
            ProgramUser.EmailAddress = null;
            ProgramUser.Roles = null;

            LoginWindow login = new LoginWindow();
            login.Show();

            this.Close();

        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
{//{
        //    Register registerWindown = new Register();
        //    registerWindown.Show();
        }
    }
}
