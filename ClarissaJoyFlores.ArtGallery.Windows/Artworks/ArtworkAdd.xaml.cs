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

namespace ClarissaJoyFlores.ArtGallery.Windows.Artworks
{
    /// <summary>
    /// Interaction logic for ArtworkAdd.xaml
    /// </summary>
    public partial class ArtworkAdd : Window
    {
        ArtworkList myParentWindow = new ArtworkList();
        public ArtworkAdd(ArtworkList parentWindow)
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
            var op = Artworkbll.Add(new Artwork()
            {
                ArtistID = Guid.NewGuid(),
                Title = txtTitle.Text,
                Year = txtYear.Text,
                Content = txtContent.Text,
                Medium = txtMedium.Text,

            }); ; ;

            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }

            else
            {
                MessageBox.Show("Artwork is successfully added to table");
            }

            myParentWindow.showData();
            this.Close();
        }

    }
}

