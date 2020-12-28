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
using ClarissaJoyFlores.ArtGallery.Windows.BLL;
using ClarissaJoyFlores.ArtGallery.Windows.Models;

namespace ClarissaJoyFlores.ArtGallery.Windows.Artists
{
    /// <summary>
    /// Interaction logic for ArtistAdd.xaml
    /// </summary>
    public partial class ArtistAdd : Window
    {
        ArtistList myParentWindow = new ArtistList();
        
        public ArtistAdd(ArtistList parentWindow)

        {
            InitializeComponent();
            myParentWindow = parentWindow;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var op = Artistbll.Add(new Artist()
            {
                ArtistID = Guid.NewGuid(),
                Name = txtName.Text,
                Age = txtAge.Text,
                BirthPlace = txtAge.Text,
                StyleOfWork = txtStyleOfWork.Text,

            }); ; ;

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }

            else
            {
                MessageBox.Show("Artist is successfully added to table");
            }

            myParentWindow.showData();
            this.Close();
        }

    }
}
