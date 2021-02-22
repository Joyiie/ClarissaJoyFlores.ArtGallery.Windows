using ClarissaJoyFlores.ArtGallery.Windows.BLL;
using ClarissaJoyFlores.ArtGallery.Windows.DTO;
using ClarissaJoyFlores.ArtGallery.Windows.Models;
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

namespace ClarissaJoyFlores.ArtGallery.Windows.Artworks
{
    /// <summary>
    /// Interaction logic for ArtworkUpdate.xaml
    /// </summary>
    public partial class ArtworkUpdate : Window
    {
        List myParentWindow = new List();
        private ArtworkDTO artworkDTO;
        public ArtworkUpdate(List parentWindow, ArtworkDTO artwork)
        {
            InitializeComponent();


            artworkDTO = artwork;
            myParentWindow = parentWindow;

            txtTitle.Text = artwork.Title;
            txtContent.Text = artwork.Content;
            txtMedium.Text = artwork.Medium;
            txtYear.Text = artwork.Year;

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errors.Add("Title is required.");
            };

            if (string.IsNullOrEmpty(txtContent.Text))
            {
                errors.Add("Content is required.");
            };

            if (string.IsNullOrEmpty(txtMedium.Text))
            {
                errors.Add("Medium is required.");
            };

            if (string.IsNullOrEmpty(txtYear.Text))
            {
                errors.Add("Year is required.");
            };


            if (errors.Count > 0)
            {
                foreach (var error in errors)
                {
                    txtError.Text = txtError.Text + error + "\n";
                }

                return;
            }

            var op = Artworkbll.Update(new Artwork()
            {
                ArtistID = artworkDTO.ArtistID,
                Title = txtTitle.Text,
                Content = txtContent.Text,
                Year = txtYear.Text,
                Medium = txtMedium.Text,
                
            });


            if (op.Code != "200")
            {
                MessageBox.Show("Error : " + op.Message);
            }
            else
            {
                MessageBox.Show("User is successfully updated");
            }

            this.Close();
        }
    }
}
